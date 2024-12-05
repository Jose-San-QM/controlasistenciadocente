using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_presentacion
{
    public partial class frmagregartexto : Form
    {


        public string TextoIngresado { get; private set; } = null;
        public frmagregartexto(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
            titulo1.Text = titulo;
        }

        private void frmagregartexto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(agregartexto.Text))
            {
                MessageBox.Show("Por favor, ingresa un texto válido.");
                return;
            }

            // Guardar el texto ingresado
            TextoIngresado = agregartexto.Text.Trim();

            // Cerrar el formulario con resultado OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario sin realizar ninguna acción
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
