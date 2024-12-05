using capa_entidad;
using capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace capa_presentacion
{
    public partial class frmagregarusuarios : Form
    {


        public frmagregarusuarios( )
        {
 
            InitializeComponent();
        }


        // Método público para actualizar el texto del Label
        public void CambiarTextoLabel(string texto)
        {
            user.Text = texto;  // 'user' es el nombre del Label
            user2.Text = texto;
        }

        private void generarqr_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ConfigurarInterfazPorRol(string rol)

        {

            // Controles específicos para empleados
            var controlesEmpleado = new List<Control>
            {
                añadirhorario,
                listahorarios,
                label6,
                
            };

            // Mostrar/ocultar controles según el rol
            if (rol.ToLower() == "docente")
            {
                foreach (var control in controlesEmpleado)
                    control.Visible = true;
            }
            else if (rol.ToLower() == "empleado")
            {
            
                foreach (var control in controlesEmpleado)
                    control.Visible = false;
            }
            else
            {
                // En caso de roles desconocidos, oculta ambos conjuntos
                

                foreach (var control in controlesEmpleado)
                    control.Visible = false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            //prueba 22
            // Obtener los datos de los controles
            string nombred = nombre.Text;
            string apellidod = apellido.Text;
            string contraseñad = carnetidentidad.Text + "SISinf";
            string carnett = carnetidentidad.Text;
            string email = correo.Text;
            string rol = user.Text.ToLower();
            string numerocel = numerocelular.Text;

            // Validación de campos básicos
            if (string.IsNullOrWhiteSpace(nombred) || string.IsNullOrWhiteSpace(apellidod) ||
                string.IsNullOrWhiteSpace(contraseñad) || string.IsNullOrWhiteSpace(carnett) ||
                string.IsNullOrWhiteSpace(email) || fotousuario.Image == null || string.IsNullOrWhiteSpace(numerocel))
            {
                MessageBox.Show("Por favor, completa todos los campos y selecciona una foto.");
                return;
            }

            // Validar el formato de email
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Por favor, ingresa un email válido.");
                return;
            }

            // Convertir la foto a un arreglo de bytes
            byte[] fotoUsuario = null;
            using (MemoryStream ms = new MemoryStream())
            {
                fotousuario.Image.Save(ms, fotousuario.Image.RawFormat);
                fotoUsuario = ms.ToArray();
            }

            try
            {
                // Agregar el usuario a la base de datos
                cn_usuario agregar = new cn_usuario();
                agregar.agregarusuario(nombred, apellidod, contraseñad, Convert.ToInt32(carnett), rol, email, fotoUsuario, Convert.ToInt32(numerocel));

                // Mostrar mensaje de éxito
                MessageBox.Show(rol + " registrado exitosamente.");

                // Si el rol es "docente", registrar también los horarios seleccionados
                if (rol == "docente" && frmagregarhorarios.HorariosDocente != null)
                {
                    cn_horario servicioHorario = new cn_horario();
                    foreach (var horario in frmagregarhorarios.HorariosDocente)
                    {
                        servicioHorario.AgregarHorarioDocente(agregar.ObtenerUsuarioIdPorCarnet(Convert.ToInt32(carnett)),
                                                              horario.Materia, horario.HoraEntrada, horario.HoraSalida, horario.DiasSemana);
                    }
                    MessageBox.Show("Horarios registrados exitosamente.");
                }

                // Limpiar los controles
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message);
            }
            //prueba 22

        }
        

        private void LimpiarCampos()
        {
            nombre.Clear();
            apellido.Clear();
            contraseña.Clear();
            carnetidentidad.Clear();
            numerocelular.Clear();
            correo.Clear();
            listahorarios.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }



     
        private void user_Click(object sender, EventArgs e)
        {
        }


        public List<materia> MateriasRegistradas { get; set; }

        private void frmagregarusuarios_Load(object sender, EventArgs e)
        {

            string rol = user.Text.ToLower();
            ConfigurarInterfazPorRol(rol);
            

        }

        private void contraseña_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
           
        }

        private void diasemana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarSoloLetras(apellido, "Apellido");
        }
       

        private void carnetidentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarNumeros(e, "Carnet de Identidad");

        }

        private void contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void materia_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Obtener el usuarioId del docente recién registrado
            if (string.IsNullOrEmpty(carnetidentidad.Text))
            {
                MessageBox.Show("Primero debe registrar al docente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int usuarioId = int.Parse(carnetidentidad.Text);

            // Crear una instancia del formulario para agregar horarios
            frmagregarhorarios frmHorarios = new frmagregarhorarios(usuarioId);

            // Mostrar el formulario como un cuadro de diálogo (ventana emergente)
            frmHorarios.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fotousuario.Image = Image.FromFile(openFileDialog.FileName);
                }
            }

        }


        public void RecibirHorarios(List<horarios_docentes> listaHorarios)
        {
            // Limpiar el ListView antes de agregar los nuevos elementos
            listahorarios.Items.Clear();

            // Llenar el ListView con los horarios pasados
            foreach (var horario in listaHorarios)
            {
                // Crear un nuevo ListViewItem para la fila
                ListViewItem item = new ListViewItem(horario.Materia);  // Primer columna: Materia

                // Agregar subelementos al ListViewItem
                item.SubItems.Add(horario.Curso); // Segunda columna: Curso
                item.SubItems.Add(horario.DiasSemana); // Tercera columna: Días de la semana
                item.SubItems.Add(horario.HoraEntrada.ToString(@"hh\:mm")); // Cuarta columna: Hora de entrada
                item.SubItems.Add(horario.HoraSalida.ToString(@"hh\:mm")); // Quinta columna: Hora de salida

                // Agregar el item al ListView
                listahorarios.Items.Add(item);
            }
        }


        private void listamaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listahorarios_SelectedIndexChanged(object sender, EventArgs e)
        {

            listahorarios.View = View.Details;
            listahorarios.Columns.Add("Materia", 100);
            listahorarios.Columns.Add("Curso/Laboratorio", 100);
            listahorarios.Columns.Add("Hora Inicio", 60);
            listahorarios.Columns.Add("Hora Fin", 60);

        }

      

        private void nombre_TextChanged(object sender, EventArgs e)
        {

            validaciones.ValidarLongitud(nombre, 50, "Nombre");
            validaciones.ValidarSoloLetras(nombre, "Nombre");

        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {
            validaciones.ValidarLongitud(apellido, 50, "Apellido");
            validaciones.ValidarSoloLetras(apellido, "Apellido");
        }

        private void carnetidentidad_TextChanged(object sender, EventArgs e)
        {
            validaciones.ValidarLongitud(carnetidentidad, 10, "CARNET DE IDENTIDAD");

        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {
            validaciones.ValidarLongitud(contraseña, 20, "CONTRASEÑA");

        }

        private void numerocelular_TextChanged(object sender, EventArgs e)
        {
            validaciones.ValidarLongitud(numerocelular, 10, "NUMERO DE CELULAR");

        }

        private void correo_Leave(object sender, EventArgs e)
        {
            validaciones.ValidarCorreo(correo);
        }

        private void numerocelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarNumeros(e,"Numero de Celular");

        }

        private void correo_TextChanged(object sender, EventArgs e)
        {
            validaciones.ValidarLongitud(correo, 50, "CORREO ELECTRONICO");

        }
    }
}

