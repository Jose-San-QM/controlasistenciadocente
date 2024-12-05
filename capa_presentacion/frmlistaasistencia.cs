using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_negocio;
using OxyPlot.Axes;
using capa_entidad;
using System.Windows.Forms.DataVisualization.Charting;


namespace capa_presentacion
{
    public partial class frmlistaasistencia : Form
    {
        public frmlistaasistencia()
        {
            InitializeComponent();
            _negocioAsistencias = new cn_asistencia();  // Instanciar la capa de negocio

        }



        private void MostrarListaDocentesPorEstado(string estado)
        {
            // Obtener la lista de docentes para el estado especificado
            var lista = new cn_asistencia().ObtenerDocentesPorEstado(estado);

            // Limpiar el DataGridView antes de llenarlo con los nuevos datos
            dgvListaDocentes.Rows.Clear();

            // Llenar el DataGridView con los datos obtenidos
            foreach (var item in lista)
            {
                dgvListaDocentes.Rows.Add(item.NombreCompleto, item.Total);
            }

            // Mostrar el total de asistencias
            lblTotal.Text = $"Total {estado}: {lista.Sum(x => x.Total)}";
        }


        private cn_asistencia _negocioAsistencias;
        private void frmlistaasistencia_Load(object sender, EventArgs e)
        {
            MostrarGraficoTortaGlobal();
            CrearGraficoBarras3();

        }


        private void MostrarGraficoTortaGlobal()
        {
            var resumen = new cn_asistencia().ObtenerResumenGlobalAsistencias();

            var modelo = new PlotModel { Title = "Resumen Global de Asistencias" };
            var serie = new PieSeries
            {
                StrokeThickness = 1.0,
                InsideLabelPosition = 0.5,
                AngleSpan = 360,
                StartAngle = 0
            };

            var colores = new Dictionary<string, OxyColor>
    {
        { "presente", OxyColors.Green },   // Asistencias
        { "falta", OxyColors.Red },        // Faltas
        { "atrasado", OxyColors.Yellow },  // Atrasos
        { "permiso", OxyColors.Blue }      // Permisos
    };

            foreach (var estado in resumen)
            {
                if (colores.ContainsKey(estado.Key))
                {
                    serie.Slices.Add(new PieSlice(estado.Key, estado.Value)
                    {
                        IsExploded = true,
                        Fill = colores[estado.Key]
                    });
                }
            }

            modelo.Series.Add(serie);
            plotView1.Model = modelo;  
        }

        private void presente_Click(object sender, EventArgs e)
        {
            MostrarListaDocentesPorEstado("presente");
        }

        private void atrasos_Click(object sender, EventArgs e)
        {
            MostrarListaDocentesPorEstado("atrasado");
        }

        private void falta_Click(object sender, EventArgs e)
        {
            MostrarListaDocentesPorEstado("falta");
        }

        private void permisos_Click(object sender, EventArgs e)
        {
            MostrarListaDocentesPorEstado("permiso");
        }

        private void plotView2_Click(object sender, EventArgs e)
        {

        }


        private void CrearGraficoBarras()
        {
            // Crear el modelo del gráfico
            var model = new PlotModel { Title = "Asistencias Semanales" };

            // Crear series de barras para cada estado
            var presenteSeries = new BarSeries { Title = "Presente", FillColor = OxyColors.Green };
            var faltaSeries = new BarSeries { Title = "Falta", FillColor = OxyColors.Red };
            var permisoSeries = new BarSeries { Title = "Permiso", FillColor = OxyColors.Blue };
            var atrasoSeries = new BarSeries { Title = "Atraso", FillColor = OxyColors.Yellow };

            // Obtener los datos de la base de datos
            var resumenAsistencias = new cn_resumenasistencias().ObtenerResumenAsistencias5();

            // Agrupar los datos por días de la semana
            var diasSemana = new[] { "lunes", "martes", "miércoles", "jueves", "viernes", "sábado" };
            foreach (var dia in diasSemana)
            {
                var asistenciasDia = resumenAsistencias.Where(x => x.DiaSemana.ToLower() == dia.ToLower());

                presenteSeries.Items.Add(new BarItem { Value = asistenciasDia.Where(x => x.Estado == "presente").Sum(x => x.Total) });
                faltaSeries.Items.Add(new BarItem { Value = asistenciasDia.Where(x => x.Estado == "falta").Sum(x => x.Total) });
                permisoSeries.Items.Add(new BarItem { Value = asistenciasDia.Where(x => x.Estado == "permiso").Sum(x => x.Total) });
                atrasoSeries.Items.Add(new BarItem { Value = asistenciasDia.Where(x => x.Estado == "atraso").Sum(x => x.Total) });
            }

            // Agregar las series al modelo
            model.Series.Add(presenteSeries);
            model.Series.Add(faltaSeries);
            model.Series.Add(permisoSeries);
            model.Series.Add(atrasoSeries);

            // Configurar el eje X
            var categoriaAxis = new OxyPlot.Axes.CategoryAxis
            {
                Position = OxyPlot.Axes.AxisPosition.Bottom,
                Key = "DiasSemanaEje",
                Title = "Días de la Semana",
                IsPanEnabled = false,
                IsZoomEnabled = false
            };

            // Agregar etiquetas al eje X
            foreach (var dia in diasSemana)
            {
                categoriaAxis.Labels.Add(dia);
            }

            model.Axes.Add(categoriaAxis);

            // Configurar el eje Y
            model.Axes.Add(new OxyPlot.Axes.LinearAxis
            {
                Position = OxyPlot.Axes.AxisPosition.Left,
                Title = "Cantidad",
                Minimum = 0
            });

            // Asignar el modelo al plotView
            plotView2.Model = model;
        }


        private void CrearGraficoBarras3()
        {
            // Crear el modelo del gráfico
            var model = new PlotModel { Title = "Asistencias Semanales" };

            // Crear las series de barras para cada estado
            var presenteSeries = new BarSeries { Title = "Presente", FillColor = OxyColors.Green };
            var atrasoSeries = new BarSeries { Title = "Atraso", FillColor = OxyColors.Yellow };
            var permisoSeries = new BarSeries { Title = "Permiso", FillColor = OxyColors.Blue };
            var faltaSeries = new BarSeries { Title = "Falta", FillColor = OxyColors.Red };

            // Ejemplo de datos para días de la semana
            var diasSemana = new[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };

            // Aquí agregamos algunos valores de ejemplo
            // Normalmente, estos datos vendrían de la base de datos
            var valoresPresente = new[] { 5, 3, 6, 2, 7, 4 };  // Ejemplo de datos
            var valoresAtraso = new[] { 1, 2, 3, 0, 1, 0 };
            var valoresPermiso = new[] { 0, 1, 1, 2, 1, 0 };
            var valoresFalta = new[] { 0, 0, 0, 1, 0, 1 };

            // Añadir los valores de cada serie
            for (int i = 0; i < diasSemana.Length; i++)
            {
                presenteSeries.Items.Add(new BarItem { Value = valoresPresente[i] });
                atrasoSeries.Items.Add(new BarItem { Value = valoresAtraso[i] });
                permisoSeries.Items.Add(new BarItem { Value = valoresPermiso[i] });
                faltaSeries.Items.Add(new BarItem { Value = valoresFalta[i] });
            }

            // Agregar las series al modelo
            model.Series.Add(presenteSeries);
            model.Series.Add(atrasoSeries);
            model.Series.Add(permisoSeries);
            model.Series.Add(faltaSeries);

            // Configurar el eje Y (Categoría de Días de la Semana)
            var categoryAxisY = new OxyPlot.Axes.CategoryAxis
            {
                Position = OxyPlot.Axes.AxisPosition.Left,
                Key = "DiasSemanaEje",
                Title = "Días de la Semana",
                IsPanEnabled = false,
                IsZoomEnabled = false
            };

            // Agregar los días de la semana a las etiquetas del eje Y
            foreach (var dia in diasSemana)
            {
                categoryAxisY.Labels.Add(dia);
            }

            // Agregar el eje Y al gráfico
            model.Axes.Add(categoryAxisY);

            // Configurar el eje X (Cantidad de registros)
            var linearAxisX = new OxyPlot.Axes.LinearAxis
            {
                Position = OxyPlot.Axes.AxisPosition.Bottom,
                Title = "Cantidad",
                Minimum = 0,
                MajorStep = 1,  // Paso entre las marcas
                MinorStep = 0.5,  // Paso menor entre las marcas
                IsPanEnabled = true,
                IsZoomEnabled = true,
            };

            // Agregar el eje X al gráfico
            model.Axes.Add(linearAxisX);

            // Asignar el modelo al plotView (suponiendo que tienes un plotView llamado plotView2)
            plotView2.Model = model;
        }

        private void CrearGraficoBarras2()
        {
            // Crear el modelo del gráfico
            var model = new PlotModel { Title = "Asistencias Semanales" };

            // Crear las series de barras para cada estado
            var presenteSeries = new BarSeries { Title = "Presente", FillColor = OxyColors.Green };
            var atrasoSeries = new BarSeries { Title = "Atraso", FillColor = OxyColors.Yellow };
            var permisoSeries = new BarSeries { Title = "Permiso", FillColor = OxyColors.Blue };
            var faltaSeries = new BarSeries { Title = "Falta", FillColor = OxyColors.Red };

            // Ejemplo de datos para días de la semana
            var diasSemana = new[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };

            // Aquí agregamos algunos valores de ejemplo
            // Normalmente, estos datos vendrían de la base de datos
            var valoresPresente = new[] { 5, 3, 6, 2, 7, 4 };  // Ejemplo de datos
            var valoresAtraso = new[] { 1, 2, 3, 0, 1, 0 };
            var valoresPermiso = new[] { 0, 1, 1, 2, 1, 0 };
            var valoresFalta = new[] { 0, 0, 0, 1, 0, 1 };

            // Añadir los valores de cada serie
            for (int i = 0; i < diasSemana.Length; i++)
            {
                presenteSeries.Items.Add(new BarItem { Value = valoresPresente[i] });
                atrasoSeries.Items.Add(new BarItem { Value = valoresAtraso[i] });
                permisoSeries.Items.Add(new BarItem { Value = valoresPermiso[i] });
                faltaSeries.Items.Add(new BarItem { Value = valoresFalta[i] });
            }

            // Agregar las series al modelo
            model.Series.Add(presenteSeries);
            model.Series.Add(atrasoSeries);
            model.Series.Add(permisoSeries);
            model.Series.Add(faltaSeries);

            // Configurar el eje X (Días de la semana)
            var categoryAxis = new OxyPlot.Axes.CategoryAxis
            {
                Position = OxyPlot.Axes.AxisPosition.Bottom,
                Key = "DiasSemanaEje",
                Title = "Días de la Semana",
                IsPanEnabled = false,
                IsZoomEnabled = false
            };

            // Agregar los días de la semana a las etiquetas del eje X
            foreach (var dia in diasSemana)
            {
                categoryAxis.Labels.Add(dia);
            }

            // Agregar el eje X al gráfico
            model.Axes.Add(categoryAxis);

            // Configurar el eje Y (Cantidad de registros)
            model.Axes.Add(new OxyPlot.Axes.LinearAxis
            {
                Position = OxyPlot.Axes.AxisPosition.Left,
                Title = "Cantidad",
                Minimum = 0,
                MajorStep = 1,  // Paso entre las marcas
                MinorStep = 0.5,  // Paso menor entre las marcas
                IsPanEnabled = true,
                IsZoomEnabled = true,
            });

            // Asignar el modelo al plotView (suponiendo que tienes un plotView llamado plotView2)
            plotView2.Model = model;
        }


        private void plotView1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
