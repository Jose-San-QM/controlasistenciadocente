using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ZXing;
using ZXing.QrCode;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using capa_datos;



namespace capa_negocio
{
    public class cn_servicioqr
    {


        /*
        //inico script

        // Método para generar y guardar el código QR basado en el usuarioid
        public void GenerarYGuardarCodigoQR(string usuarioId, string ruta)
        {
            // Generar el código QR
            var qrOptions = new QrCodeEncodingOptions
            {
                Height = 300,
                Width = 300,
                Margin = 1,
                CharacterSet = "UTF-8"
            };

            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = qrOptions
            };

            // Generar la imagen QR
            Bitmap qrImage = barcodeWriter.Write(usuarioId);

            // Guardar la imagen QR en la ruta especificada
            qrImage.Save(ruta, ImageFormat.Png);
        }

        */
        //fin script


        //inicio script 2 


        /*
        // Método para generar el código QR con una vida útil de 5 minutos
        public string GenerarCodigoQRConExpiracion(string usuarioId)
        {
            // Crear el token único para este usuario
            string token = usuarioId;

            // Generar el código QR usando el token
            var qrOptions = new QrCodeEncodingOptions
            {
                Height = 300,
                Width = 300,
                Margin = 1,
                CharacterSet = "UTF-8"
            };

            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = qrOptions
            };

            // Generar la imagen QR
            Bitmap qrImage = barcodeWriter.Write(token);

            // Guardar el QR temporalmente
            string ruta = Path.Combine(Path.GetTempPath(), $"{usuarioId}_QR.png");
            qrImage.Save(ruta, ImageFormat.Png);

            // Guardar el token y su expiración en la base de datos
            GuardarTokenEnBaseDatos(usuarioId, token, DateTime.Now.AddMinutes(5));

            return ruta; // Devolver la ruta de la imagen QR
        } */

        //prueba

        public cd_tokenqr dataTokenQR = new cd_tokenqr();

        public string GenerarCodigoQRConExpiracion(string usuarioId)
        {
            // Crear un nuevo token único para el usuario
            //string nuevoToken = usuarioId + "_" + Guid.NewGuid().ToString();

            // Crear un nuevo token único para el usuario
            string nuevoToken = usuarioId.ToString();

            // Eliminar cualquier token expirado anterior
            dataTokenQR.EliminarTokenExpirado(usuarioId);

            // Generar la imagen del QR usando el nuevo token
            var qrOptions = new QrCodeEncodingOptions
            {
                Height = 300,
                Width = 300,
                Margin = 1,
                CharacterSet = "UTF-8"
            };

            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = qrOptions
            };

            // Generar el QR y guardarlo como imagen
            Bitmap qrImage = barcodeWriter.Write(nuevoToken);
            string ruta = Path.Combine(Path.GetTempPath(), $"{usuarioId}_QR.png");
            qrImage.Save(ruta, ImageFormat.Png);

            // Guardar el token y su expiración en la base de datos
            dataTokenQR.GuardarToken(usuarioId, nuevoToken, DateTime.Now.AddMinutes(5));

            return ruta;
        }

        public bool EsCodigoQRValido(string usuarioId, string token)
        {
            // Llama a la capa de datos para validar el token y su expiración
            return dataTokenQR.EsTokenValido(usuarioId, token);
        }

        //fin prueba

        // Método para guardar el token y la expiración en la base de datos
        private void GuardarTokenEnBaseDatos(string usuarioId, string token, DateTime expiracion)
        {
            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                string query = "INSERT INTO tokens_qr (usuarioid, token, fecha_generacion, expiraen) VALUES (@UsuarioId, @Token, @FechaGeneracion, @ExpiraEn)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    command.Parameters.AddWithValue("@Token", token);
                    command.Parameters.AddWithValue("@FechaGeneracion", DateTime.Now);
                    command.Parameters.AddWithValue("@ExpiraEn", expiracion);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para enviar el QR por correo electrónico
        public void EnviarQRPorCorreo(string email, string rutaQR)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("Control.Asistencia.Docentes@gmail.com");
            mail.To.Add(email);
            mail.Subject = "Código QR para Marcar Asistencia";
            mail.Body = "Escanea el siguiente código QR para marcar tu asistencia. El código es válido por 5 minutos.";

            // Adjuntar el QR
            mail.Attachments.Add(new Attachment(rutaQR));

            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new NetworkCredential("Control.Asistencia.Docentes@gmail.com", "rguz ykdo skra cgrb");
            client.EnableSsl = true;

            client.Send(mail);
        }



        //fin script 2


      

    }
}
