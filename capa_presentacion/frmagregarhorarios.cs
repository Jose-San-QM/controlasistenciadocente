using capa_entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion
{
    public partial class frmagregarhorarios : Form
    {



        private int usuarioId;

        public frmagregarhorarios(int idUsuario)
        {
            InitializeComponent();
            usuarioId = idUsuario;
        }

        private void frmagregarhorarios_Load(object sender, EventArgs e)
        {

            // Configura el ComboBox 'horainicio' con los horarios específicos
            {
                horainicio.Items.Add("8:30");
                horainicio.Items.Add("10:30");
                horainicio.Items.Add("12:30");
                horainicio.Items.Add("14:30");
                horainicio.Items.Add("16:30");
                horainicio.Items.Add("18:30");
                horainicio.Items.Add("20:30");
            

            // Opcionalmente, puedes seleccionar el primer horario como predeterminado
            horainicio.SelectedIndex = 0;  // Selecciona "8:30" por defecto
            }

            // Configura el ComboBox 'horafin' con los horarios específicos

            {
                horafin.Items.Add("10:00");
                horafin.Items.Add("12:00");
                horafin.Items.Add("14:00");
                horafin.Items.Add("16:00");
                horafin.Items.Add("18:00");
                horafin.Items.Add("20:00");
                horafin.Items.Add("22:00");

                // Opcionalmente, puedes seleccionar el primer horario como predeterminado
                horafin.SelectedIndex = 0;  // Selecciona "10:00" por defecto
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        List<materia> materiasTemporales = new List<materia>();
        public static List<horarios_docentes> HorariosDocente { get; set; } = new List<horarios_docentes>();
        private void agregarhorario_Click(object sender, EventArgs e)
        {
            // Validar que se hayan llenado todos los campos
            
            if (materianom.SelectedItem == null ||
                (cursoscarrera.SelectedItem == null && laboratoriox.SelectedItem == null) ||
                 (cursoscarrera.SelectedItem != null && laboratoriox.SelectedItem != null) ||
                 horainicio.SelectedItem == null ||
                 horafin.SelectedItem == null ||
                 diassemana.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor, completa todos los campos antes de agregar la materia. Solo puedes seleccionar un curso o un laboratorio, pero no ambos.");
                return;
            }
            
            MessageBox.Show("Horario agregado correctamente.");


            // Determinar si se seleccionó un curso o un laboratorio
            string cursoOLab = cursoscarrera.SelectedItem != null
                ? cursoscarrera.SelectedItem.ToString()
                : laboratoriox.SelectedItem.ToString();

            // Crear un objeto Horario
            horarios_docentes nuevoHorario = new horarios_docentes
            {
                Materia = materianom.SelectedItem.ToString(),
                DiasSemana = string.Join(", ", diassemana.CheckedItems.OfType<string>()),
                HoraEntrada = TimeSpan.Parse(horainicio.SelectedItem.ToString()),
                HoraSalida = TimeSpan.Parse(horafin.SelectedItem.ToString())
            };

            // Agregar a la lista de horarios
            HorariosDocente.Add(nuevoHorario);

            // Actualizar la lista visual en el ListView
            var item = new ListViewItem(nuevoHorario.Materia); // Primera columna: Materia
            item.SubItems.Add(cursoOLab);                     // Segunda columna: Curso/Laboratorio
            item.SubItems.Add(nuevoHorario.HoraEntrada.ToString(@"hh\:mm")); // Tercera columna: Hora Inicio
            item.SubItems.Add(nuevoHorario.HoraSalida.ToString(@"hh\:mm"));  // Cuarta columna: Hora Fin

            listamaterias.Items.Add(item);
            // Limpiar los controles
            materianom.SelectedIndex = -1;
            foreach (int i in diassemana.CheckedIndices)
            diassemana.SetItemCheckState(i, CheckState.Unchecked);
            horafin.SelectedIndex = -1;
            horainicio.SelectedIndex = -1;
            cursoscarrera.SelectedIndex = -1;
            laboratoriox.SelectedIndex = -1;
            

        }

        public List<string> horarios_docentes { get; private set; } = new List<string>();

        private void finalizar_Click(object sender, EventArgs e)
        {
            // Crear una lista con los horarios registrados
            List<horarios_docentes> listaHorarios = new List<horarios_docentes>();

            // Agregar los horarios a la lista (aquí se asume que tienes los horarios en una lista llamada HorariosDocente)
            foreach (var horario in HorariosDocente)
            {
                listaHorarios.Add(horario);
            }

            // Obtener una referencia al formulario de agregar usuario (suponiendo que es un formulario principal o instanciado anteriormente)
            frmagregarusuarios formularioAgregarUsuarios = Application.OpenForms.OfType<frmagregarusuarios>().FirstOrDefault();

            // Si el formulario de agregar usuario está abierto
            if (formularioAgregarUsuarios != null)
            {
                // Llamar al método de recibir los horarios
                formularioAgregarUsuarios.RecibirHorarios(listaHorarios);
            }

            // Cerrar el formulario actual
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmagregartexto agregarTexto = new frmagregartexto("Agregar Materia");
            if (agregarTexto.ShowDialog() == DialogResult.OK)
            {
                string nuevaMateria = agregarTexto.TextoIngresado;

                if (!materianom.Items.Contains(nuevaMateria))
                {
                    materianom.Items.Add(nuevaMateria);
                    MessageBox.Show("Materia agregada exitosamente.");
                }
                else
                {
                    MessageBox.Show("La materia ya existe en la lista.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmagregartexto agregarTexto = new frmagregartexto("Agregar Curso");
            if (agregarTexto.ShowDialog() == DialogResult.OK)
            {
                string nuevoCurso = agregarTexto.TextoIngresado;

                if (!cursoscarrera.Items.Contains(nuevoCurso))
                {
                    cursoscarrera.Items.Add(nuevoCurso);
                    MessageBox.Show("Curso agregado exitosamente.");
                }
                else
                {
                    MessageBox.Show("El curso ya existe en la lista.");
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmagregartexto agregarTexto = new frmagregartexto("Agregar Laboratorio");
            if (agregarTexto.ShowDialog() == DialogResult.OK)
            {
                string nuevoLaboratorio = agregarTexto.TextoIngresado;

                if (!laboratoriox.Items.Contains(nuevoLaboratorio))
                {
                    laboratoriox.Items.Add(nuevoLaboratorio);
                    MessageBox.Show("Laboratorio agregado exitosamente.");
                }
                else
                {
                    MessageBox.Show("El laboratorio ya existe en la lista.");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado en el ListView
            if (listamaterias.SelectedItems.Count > 0)
            {
                // Confirmar eliminación
                var confirmResult = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este horario?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Eliminar el elemento seleccionado
                    listamaterias.Items.Remove(listamaterias.SelectedItems[0]);

                    // Mostrar mensaje de confirmación
                    MessageBox.Show("Horario eliminado correctamente.", "Eliminación exitosa");
                }
            }
            else
            {
                // Mostrar mensaje si no hay ningún elemento seleccionado
                MessageBox.Show("Por favor, selecciona un horario de la lista para eliminarlo.", "Error");
            }
        }

        private void listamaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listamaterias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listamaterias.View = View.Details;
            listamaterias.Columns.Add("Materia", 150);
            listamaterias.Columns.Add("Curso/Laboratorio", 150);
            listamaterias.Columns.Add("Hora Inicio", 100);
            listamaterias.Columns.Add("Hora Fin", 100);
        }

        private void horainicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
        private void listamaterias_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            
            listamaterias.View = View.Details;
            listamaterias.Columns.Add("Materia", 100);
            listamaterias.Columns.Add("Curso/Laboratorio", 100);
            listamaterias.Columns.Add("Hora Inicio", 60);
            listamaterias.Columns.Add("Hora Fin", 60);
        
            
            }
    }
}
