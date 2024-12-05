using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion
{
    public static class validaciones
    {
        // Validar longitud máxima de caracteres
        public static void ValidarLongitud(TextBox textBox, int longitudMaxima, string nombreCampo)
        {
            if (textBox.Text.Length > longitudMaxima)
            {
                MessageBox.Show($"El campo '{nombreCampo}' admite un máximo de {longitudMaxima} caracteres.", "Validación de longitud");
                textBox.Text = textBox.Text.Substring(0, longitudMaxima); // Truncar texto
                textBox.SelectionStart = textBox.Text.Length; // Posicionar cursor al final
            }
        }


        // Validar solo letras

        public static void ValidarSoloLetras(TextBox textBox, string nombreCampo)
        {
            // Expresión regular para permitir solo letras y espacios
            string soloLetrasPattern = @"^[a-zA-Z\s]*$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, soloLetrasPattern))
            {
                MessageBox.Show($"El campo '{nombreCampo}' solo permite letras y espacios.", "Validación de entrada");

                // Remover caracteres no válidos
                textBox.Text = new string(textBox.Text.Where(char.IsLetterOrDigit).ToArray());

                // Posicionar cursor al final
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        // Validar solo números
        public static void ValidarNumeros(KeyPressEventArgs e, string nombreCampo)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show($"El campo '{nombreCampo}' solo admite números.", "Validación de números");
                e.Handled = true; // Cancelar entrada de teclas
            }
        }

        // Validar formato de correo electrónico
        public static void ValidarCorreo(TextBox textBox)
        {
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(textBox.Text, patronCorreo))
            {
                MessageBox.Show("Por favor, ingresa un correo electrónico válido.", "Validación de correo");
                textBox.Focus(); // Enfocar nuevamente el TextBox
            }
        }
    }
}
