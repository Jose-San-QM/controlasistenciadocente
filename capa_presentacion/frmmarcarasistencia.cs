using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using capa_negocio;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using capa_entidad;



namespace capa_presentacion
{
   /* public partial class frmmarcarasistencia : Form
    {

        //inico script
        private FilterInfoCollection dispositivos; // Para almacenar la lista de dispositivos de video
        private VideoCaptureDevice camara; // Para manejar la cámara
        private HashSet<string> processedIds = new HashSet<string>(); // Para evitar procesar el mismo ID varias veces
        private DateTime lastProcessedTime = DateTime.MinValue; // Para controlar el tiempo entre lecturas

            public frmmarcarasistencia()
            {
                InitializeComponent();
            }



            private void camara_NewFrame(object sender, NewFrameEventArgs eventArgs)
            {
            // Mostrar la imagen de la cámara en un PictureBox
            leerqr1.Image = (Bitmap)eventArgs.Frame.Clone();

            // Llama al método para leer el QR
            string usuarioId = LeerCodigoQR((Bitmap)eventArgs.Frame.Clone());

            // Si se ha leído un QR y no ha sido procesado recientemente, registrar asistencia
            if (!string.IsNullOrEmpty(usuarioId) && !processedIds.Contains(usuarioId) && (DateTime.Now - lastProcessedTime).TotalSeconds > 5)
            {
                RegistrarAsistencia(usuarioId);
                processedIds.Add(usuarioId); // Marca el ID como procesado
                lastProcessedTime = DateTime.Now; // Actualiza el tiempo de la última lectura
            }
             }
        private void RegistrarAsistencia(string usuarioId)
        {

            //ptueba 1
            // Convertir el usuarioId a entero
            /*
            int usuarioIdInt;
            if (int.TryParse(usuarioId, out usuarioIdInt))
            {
                // Crear una instancia de la capa de negocio
                cn_asistencia servicioAsistencia = new cn_asistencia();

                // Registrar la asistencia con el estado "presente"
                servicioAsistencia.RegistrarAsistencia(usuarioIdInt);

                // Mostrar un mensaje de éxito
                MessageBox.Show($"Asistencia marcada para el usuario: {usuarioId}", "Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El ID de usuario no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } //fin prueba 1

            //prueba 2
            // Convertir el usuarioId a entero
                int usuarioIdInt;
                if (int.TryParse(usuarioId, out usuarioIdInt))
                {
                    // Crear una instancia de la capa de negocio
                    cn_asistencia servicioAsistencia = new cn_asistencia();

                    // Registrar la asistencia con el estado "presente"
                    servicioAsistencia.RegistrarAsistencia(usuarioIdInt,);

                    // Mostrar un mensaje de éxito
                    MessageBox.Show($"Asistencia marcada para el usuario: {usuarioId}", "Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El ID de usuario no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
          
            //fin prueba 2
        }
        //fin script

        private void marcarasistencia_Click(object sender, EventArgs e)
        {
        }


            //inicio script

            private void frmmarcarasistencia_FormClosing(object sender, FormClosingEventArgs e)
            {
            // Detener y liberar la cámara al cerrar el formulario
            if (camara != null && camara.IsRunning)
            {
                camara.SignalToStop(); // Indicar que la cámara debe detenerse
                camara.WaitForStop(); // Esperar a que la cámara se detenga
            }
            }

            private string LeerCodigoQR(Bitmap frame)
            {

            // Configura ZXing para leer el código QR
            var reader = new BarcodeReader();

            // Decodifica el código QR
            var result = reader.Decode(frame);
            return result?.Text; // Retorna el texto del QR (usuarioId) o null si no se detecta

            }


            private void frmmarcarasistencia_Load(object sender, EventArgs e)
            {
            // Configurar la cámara al cargar el formulario
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (dispositivos.Count > 0)
            {
                camara = new VideoCaptureDevice(dispositivos[0].MonikerString);
                camara.NewFrame += new NewFrameEventHandler(camara_NewFrame);
                camara.Start();
            }
            else
            {
                MessageBox.Show("No se encontró ninguna cámara.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

        private void leerqr1_Click(object sender, EventArgs e)
        {

        }

        //fin script



    }
*/


    public partial class frmmarcarasistencia : Form {

        // Variables para manejo de la cámara y QR
        private FilterInfoCollection dispositivos;
        private VideoCaptureDevice camara;
        private HashSet<string> processedIds = new HashSet<string>();
        private DateTime lastProcessedTime = DateTime.MinValue;
        private cn_servicioqr servicioTokenQR = new cn_servicioqr();
        public frmmarcarasistencia()
        {
            InitializeComponent();
        }

        private void camara_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            leerqr1.Image = (Bitmap)eventArgs.Frame.Clone();
            string usuarioId = LeerCodigoQR((Bitmap)eventArgs.Frame.Clone());

            if (!string.IsNullOrEmpty(usuarioId) && !processedIds.Contains(usuarioId) && (DateTime.Now - lastProcessedTime).TotalSeconds > 5)
            {
                RegistrarAsistencia(usuarioId);
                processedIds.Add(usuarioId);
                lastProcessedTime = DateTime.Now;
            }
        }

        
         private void RegistrarAsistencia(string usuarioId)
         {
             // Convertir el usuarioId a entero
             if (int.TryParse(usuarioId, out int usuarioIdInt))
             {
                 // Crear una instancia de la capa de negocio
                 cn_asistencia servicioAsistencia = new cn_asistencia();

                 // Registrar la asistencia y obtener el estado
                 DateTime fechaRegistro = DateTime.Now;
                 string estadoAsistencia = servicioAsistencia.RegistrarAsistencia(usuarioIdInt, fechaRegistro);

                 // Verificar si se recibió un estado de asistencia válido
                 if (!string.IsNullOrEmpty(estadoAsistencia))
                 {
                     // Mostrar el estado de asistencia registrado
                     MessageBox.Show($"Asistencia registrada para el usuario: {usuarioId}\nEstado: {estadoAsistencia}", "Asistencia",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 else
                 {
                     MessageBox.Show("No se pudo registrar la asistencia. Inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
             else
             {
                 MessageBox.Show("El ID de usuario no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

        


        private void frmmarcarasistencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camara != null && camara.IsRunning)
            {
                camara.SignalToStop();
                camara.WaitForStop();
            }
        }

        private string LeerCodigoQR(Bitmap frame)
        {
            var reader = new BarcodeReader();
            var result = reader.Decode(frame);
            return result?.Text;

        }


       


        private void frmmarcarasistencia_Load(object sender, EventArgs e)
        {
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (dispositivos.Count > 0)
            {
                camara = new VideoCaptureDevice(dispositivos[0].MonikerString);
                camara.NewFrame += new NewFrameEventHandler(camara_NewFrame);
                camara.Start();
            }
            else
            {
                MessageBox.Show("No se encontró ninguna cámara.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private cn_servicioqr _servicioQR = new cn_servicioqr();

        private void qrdenuevo_Click(object sender, EventArgs e)
        {

            List<usuarios> usuariosList = new cn_usuario().listar();
            usuarios usuarioActual = usuariosList.FirstOrDefault(u => u.rol == "docente"); // Filtrar solo docentes

            if (usuarioActual != null)
            {
                // Generar el código QR y enviar por correo electrónico solo si el usuario es docente
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
            }
            else
            {
                MessageBox.Show("No se encontró un docente con ese identificador.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
    }

