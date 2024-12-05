using capa_entidad;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static capa_presentacion.login;

namespace capa_presentacion
{
    public partial class inicio : Form
    {

        
        public inicio(string rol)
        {
            InitializeComponent();
            this.rol = rol;
            ConfigurarMenuPorRol(rol); // Llama al método para ajustar el menú
        }

       //inicio script

        private string rol;  // Variable para almacenar el rol del usuario

        // Método para configurar los ítems del menú según el rol
        private void ConfigurarMenuPorRol(string rol)
        {
            // Ocultar todos los ítems del menú por defecto
            usuarios.Visible = false;
            marcarasistencia.Visible = false;
            reportes.Visible = false;
            informacion.Visible = false;
            estadousuario.Visible = false;

            // Mostrar los ítems del menú según el rol
            switch (rol)
            {
                case "administrador":
                    usuarios.Visible = true;
                    reportes.Visible = true;
                    informacion.Visible = true;
                    break;

                case "docente":
                    marcarasistencia.Visible = true;
                    informacion.Visible = true;
                    estadousuario.Visible = true;
                    break;

                case "empleado":
                    reportes.Visible = true;
                    listadocentes.Visible = true;
                    listaasistencias.Visible = true;
                    informacion.Visible = true;
                    break;

                default:
                    MessageBox.Show("Rol desconocido. No se pueden mostrar los menús.");
                    break;
            }
        }

        //fin script
        private void frmadmin_Load(object sender, EventArgs e)
        {

        }

        private static IconMenuItem menuactivo = null;
        private static Form formularioactivo = null;

        private  void abrirformulario(IconMenuItem menu, Form formulario)
        {
            if (menuactivo != null)
            {
                menuactivo.BackColor = Color.White;

            }
            menu.BackColor = Color.Silver;
            menuactivo = menu;
            if (formularioactivo != null)
            {
                formularioactivo.Close();

            }
            formularioactivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

          

            contenedor.Controls.Add(formulario);
            formulario.Show();
            

        }
        
        private void marcarasistencia_Click(object sender, EventArgs e)
        {
            abrirformulario((IconMenuItem) sender,new frmmarcarasistencia());
        }

        private void admindocentes_Click(object sender, EventArgs e)
        {
        }

        private void adminempleados_Click(object sender, EventArgs e)
        {
            //abrirformulario(usuarios, new frmadminempleados());
        }

        private void listaasistencias_Click(object sender, EventArgs e)
        {
            abrirformulario(reportes, new frmlistaasistencia());
        }

        private void listadocentes_Click(object sender, EventArgs e)
        {
            abrirformulario(reportes, new frmlistadocentes());
        }

        private void listaempleados_Click(object sender, EventArgs e)
        {
            abrirformulario(reportes, new frmlistaempleados());
        }

        private void informacion_Click(object sender, EventArgs e)
        {
            abrirformulario(informacion, new frminformacion());
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

            // Crear instancia del formulario
            frmagregarusuarios agregarUsuariosForm = new frmagregarusuarios();

            // Cambiar el texto del Label
            agregarUsuariosForm.CambiarTextoLabel("DOCENTE");

            // Abrir el formulario
            abrirformulario(usuarios, agregarUsuariosForm);

            //abrirformulario(usuarios, new frmagregarusuarios());
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {


            // Crear instancia del formulario
            frmeliminarusuarios eliminarusuario = new frmeliminarusuarios();

            // Cambiar el texto del Label
            eliminarusuario.CambiarTextoLabel("DOCENTE");

            // Abrir el formulario
            abrirformulario(usuarios, eliminarusuario);

            //abrirformulario(usuarios, new frmeliminarusuarios());
        }

        private void agregarempleado_Click(object sender, EventArgs e)
        {

            // Crear instancia del formulario
            frmagregarusuarios agregarUsuariosForm = new frmagregarusuarios();

            // Cambiar el texto del Label
            agregarUsuariosForm.CambiarTextoLabel("EMPLEADO");

            // Abrir el formulario
            abrirformulario(usuarios, agregarUsuariosForm);

            //abrirformulario(usuarios, new frmagregarusuarios());
        }

        private void eliminarempleado_Click(object sender, EventArgs e)
        {

            // Crear instancia del formulario
            frmeliminarusuarios eliminarusuario = new frmeliminarusuarios();

            // Cambiar el texto del Label
            eliminarusuario.CambiarTextoLabel("EMPLEADO");

            // Abrir el formulario
            abrirformulario(usuarios, eliminarusuario);

            //abrirformulario(usuarios, new frmeliminarusuarios());
        }


        private int ObtenerUsuarioIdActual()
        {
            // Retorna el ID del usuario actual desde la clase estática
            return SesionActual.UsuarioId;
        }

        private void estadousuario_Click(object sender, EventArgs e)
        {

            int usuarioId = ObtenerUsuarioIdActual();  // Obtenemos el ID del usuario actual
                                                                       // Método para obtener el ID del usuario logueado
            abrirformulario((IconMenuItem)sender, new frmestadousuario(usuarioId));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
 

