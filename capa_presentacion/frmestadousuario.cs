using capa_entidad;
using capa_negocio;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using OxyPlot.WindowsForms;
using Syncfusion.WinForms.DataGrid;

namespace capa_presentacion
{
    public partial class frmestadousuario : Form
    {


        private cn_usuario usuarioNegocio = new cn_usuario();
        private int usuarioId; // Recibir este ID después del login

        public frmestadousuario(int idUsuario)
        {
            InitializeComponent();
            usuarioId = idUsuario;

            ConfigurarDataGrid();
        }

        // configurardatagrid
        private SfDataGrid dataGrid;

        private void ConfigurarDataGrid()
        {
            dataGrid = new SfDataGrid();
            dataGrid.Dock = DockStyle.Fill;

            // Configurar columnas de la tabla
            dataGrid.AutoGenerateColumns = false;
            dataGrid.Columns.Add(new GridTextColumn() { HeaderText = "Hora", MappingName = "Hora" });
            dataGrid.Columns.Add(new GridTextColumn() { HeaderText = "Lunes", MappingName = "Lunes" });
            dataGrid.Columns.Add(new GridTextColumn() { HeaderText = "Martes", MappingName = "Martes" });
            dataGrid.Columns.Add(new GridTextColumn() { HeaderText = "Miércoles", MappingName = "Miércoles" });
            dataGrid.Columns.Add(new GridTextColumn() { HeaderText = "Jueves", MappingName = "Jueves" });
            dataGrid.Columns.Add(new GridTextColumn() { HeaderText = "Viernes", MappingName = "Viernes" });
            dataGrid.Columns.Add(new GridTextColumn() { HeaderText = "Sábado", MappingName = "Sábado" });

            this.Controls.Add(dataGrid);
        }

        public void CargarHorarios(int usuarioId)
        {
            var negocioHorarios = new cn_horario(); // Capa de negocio
            var horarios = negocioHorarios.ObtenerHorarioDocente(usuarioId);
            dataGrid.DataSource = MapearHorariosATabla(horarios);
        }

        private DataTable MapearHorariosATabla(List<horarios_docentes> horarios)
        {
            DataTable tablaHorario = new DataTable();
            tablaHorario.Columns.Add("Hora");
            tablaHorario.Columns.Add("Lunes");
            tablaHorario.Columns.Add("Martes");
            tablaHorario.Columns.Add("Miércoles");
            tablaHorario.Columns.Add("Jueves");
            tablaHorario.Columns.Add("Viernes");
            tablaHorario.Columns.Add("Sábado");

            var intervalos = new[]
            {
            "08:30 - 10:00", "10:30 - 12:00", "12:30 - 14:00",
            "14:30 - 16:00", "16:30 - 18:00", "18:30 - 20:00", "20:30 - 22:00"
        };

            foreach (var intervalo in intervalos)
            {
                System.Data.DataRow fila = tablaHorario.NewRow();
                fila["Hora"] = intervalo;

                foreach (var horario in horarios)
                {
                    if ($"{horario.HoraEntrada:hh\\:mm} - {horario.HoraSalida:hh\\:mm}" == intervalo)
                    {
                        foreach (var dia in horario.DiasSemana.Split(','))
                        {
                            fila[dia.Trim()] = $"{horario.Materia} ({horario.Curso})";
                        }
                    }
                }

                tablaHorario.Rows.Add(fila);
            }

            return tablaHorario;
        } 


        //
        private void frmestadousuario_Load(object sender, EventArgs e)
        {
            CargarDatosPerfil();

            //

            MostrarGraficoTortaUnica();

            //CargarHorarios(usuarioId);
            //
        }


        //mostragrafico pastel 1
        /*
        private void MostrarGraficoTortaUnica()
        {
            int usuId = usuarioId;
            var resumen = new cn_resumenasistencias().ObtenerResumenAsistencias(usuId);

            var modelo = new PlotModel { Title = "Resumen de Asistencias" };
            var serie = new PieSeries
            {
                StrokeThickness = 1.0,
                InsideLabelPosition = 0.5,
                AngleSpan = 360,
                StartAngle = 0
            };


       

            // Colores definidos para cada estado
            
            var colores = new Dictionary<string, OxyColor>
    {
        { "presente", OxyColors.Green },   // Asistencias
        { "falta", OxyColors.Red },        // Faltas
        { "atrasado", OxyColors.Yellow },  // Atrasos
        { "permiso", OxyColors.Blue }      // Permisos
    }; 

            // Agregar las categorías a la torta
            foreach (var estado in resumen)
            {
                serie.Slices.Add(new PieSlice(estado.Key, estado.Value)
                {
                    IsExploded = true,
                    Fill = colores[estado.Key.ToLower()]
                });
            }

            modelo.Series.Add(serie);
            plotView1.Model = modelo;  
        }
        */
        //

        //grafico pastel 2
        private void MostrarGraficoTortaUnica()
        {
            int usuId = usuarioId;  // Asumimos que 'usuarioId' es un valor ya asignado previamente.

            // Obtener los datos de resumen de asistencias
            var resumen = new cn_resumenasistencias().ObtenerResumenAsistenciasPorDocente(usuId);

            // Crear el modelo del gráfico
            var modelo = new PlotModel { Title = "Resumen de Asistencias" };

            // Crear la serie de torta
            var serie = new PieSeries
            {
                StrokeThickness = 1.0,
                InsideLabelPosition = 0.5,
                AngleSpan = 360,
                StartAngle = 0
            };

            // Colores definidos para cada estado
            var colores = new Dictionary<string, OxyColor>
    {
        { "presente", OxyColors.Green },   // Asistencias
        { "falta", OxyColors.Red },        // Faltas
        { "atrasado", OxyColors.Yellow },  // Atrasos
        { "permiso", OxyColors.Blue }      // Permisos
    };

            // Agregar las categorías a la torta
            foreach (var estado in resumen)
            {
                // Asegurarnos de que la clave existe en el diccionario
                string estadoKey = estado.Key.ToLower();  // Convertir a minúsculas para coincidir con las claves

                // Comprobar si la clave existe en el diccionario antes de agregarla
                if (colores.ContainsKey(estadoKey))
                {
                    serie.Slices.Add(new PieSlice(estado.Key, estado.Value)
                    {
                        IsExploded = true,
                        Fill = colores[estadoKey]  // Usar el color correspondiente
                    });
                }
                else
                {
                    // Si no existe la clave, podemos optar por usar un color predeterminado o ignorar
                    // En este caso, elijo usar un color gris predeterminado para las claves no encontradas
                    serie.Slices.Add(new PieSlice(estado.Key, estado.Value)
                    {
                        IsExploded = true,
                        Fill = OxyColors.Gray  // Color predeterminado
                    });
                }
            }

            // Añadir la serie al modelo y actualizar el gráfico
            modelo.Series.Add(serie);
            plotView1.Model = modelo;
        }

        private void CargarDatosPerfil()
        {
            usuarios usuario = usuarioNegocio.ObtenerUsuario(usuarioId);

            if (usuario.Foto != null)
            {
                using (var ms = new MemoryStream(usuario.Foto))
                {
                    fotoperfil.Image = Image.FromStream(ms);
                }
            }

            nombreusuario.Text = $"{usuario.nombre} {usuario.apellido}";
            numerodelular.Text = $"{usuario.numerocelular}";
            correo.Text = $"{usuario.email}";
            carnet.Text = $"{usuario.carnetidentidad}";

            CargarAsistencias(usuario.Asistencias);
        }
        

        private void CargarAsistencias(List<asistencias> asistencias)
        {
        }

        private void asistenciasdtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void plotView1_Click(object sender, EventArgs e)
        {

        }

        private void dgvHorario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void datagrid1_Navigate(object sender, NavigateEventArgs ne)
        {

        }
    }
}
