using capa_entidad;
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
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace capa_presentacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            carnet.Text = "";
            contraseña.Text = "";
            this.Show();
        }




        //script

        // Método para abrir el formulario principal según el rol del usuario
        private void AbrirFormularioPrincipal(string rol)
        {
            inicio principalForm = new inicio( rol); // Pasamos el rol al formulario principal
            principalForm.Show();
            this.Hide(); 
            principalForm.FormClosing += frm_closing;
        }

        //fin cript


        //complemento 2
        private cn_servicioqr _servicioQR = new cn_servicioqr();


        public static class SesionActual
        {
            public static int UsuarioId { get; set; }
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            //inicio script 1
            /*
            List<usuarios> test = new cn_usuario().listar();

            usuarios ousuarios = new cn_usuario().listar().FirstOrDefault(u => u.carnetidentidad.ToString() == carnet.Text && u.contraseña == contraseña.Text);

            if (ousuarios != null)
            {
               
                AbrirFormularioPrincipal(ousuarios.rol); // Llamamos al nuevo método para abrir el formulario principal
                
            }
            else
            {
                MessageBox.Show("No se encontró el usuario", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            */
            //fin script 1



            //inicio script 2

        /*
        List<usuarios> usuariosList = new cn_usuario().listar();
            usuarios usuarioActual = usuariosList.FirstOrDefault(u => u.carnetidentidad.ToString() == carnet.Text && u.contraseña == contraseña.Text);

            if (usuarioActual != null)
            {
                // Generar el código QR y enviar por correo electrónico
                string rutaQR = _servicioQR.GenerarCodigoQRConExpiracion(usuarioActual.usuarioid.ToString());
                try
                {
                    // Enviar el QR al correo electrónico del usuario
                    _servicioQR.EnviarQRPorCorreo(usuarioActual.email, rutaQR);
                    MessageBox.Show("Se ha enviado un código QR a tu correo electrónico.", "Código QR Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar el correo electrónico: " + ex.Message, "Error de envío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                AbrirFormularioPrincipal(usuarioActual.rol);
            }
            else
            {
               
                MessageBox.Show("No se encontró el usuario", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        */
            //fin script 2

            //script 3



            List<usuarios> usuariosList = new cn_usuario().listar();
            usuarios usuarioActual = usuariosList.FirstOrDefault(u => u.carnetidentidad.ToString() == carnet.Text && u.contraseña == contraseña.Text);



            if (usuarioActual != null)
            {
                if (usuarioActual.rol == "docente") // Verifica si el usuario es docente
                {
                    // Generar el código QR y enviar por correo electrónico solo si es docente
                    int usuarioId = usuarioActual.usuarioid;
                    SesionActual.UsuarioId = usuarioId;
                }
                else
                {
                    // Si es administrador o empleado, solo convalidar el inicio de sesión
                    
                }

                // Abre el formulario principal según el rol del usuario
                AbrirFormularioPrincipal(usuarioActual.rol);
            }
            else
            {
                MessageBox.Show("No se encontró el usuario", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //fin script 3

        }

        private int ObtenerUsuarioIdActual()
        {
            // Retorna el ID del usuario actual desde la clase estática
            return SesionActual.UsuarioId;
        }
        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
        private void TextBoxSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control (como la tecla de retroceso)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancela la entrada si no es un dígito o tecla de control
                e.Handled = true;
            }
        }

        private void carnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarNumeros(e, "CARNET IDENTIDAD");
            validaciones.ValidarLongitud(carnet,10,"CARNET IDENTIDAD");
        }

        private void contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarLongitud(contraseña, 15, "CONTRASEÑA");
        }
    }
}
