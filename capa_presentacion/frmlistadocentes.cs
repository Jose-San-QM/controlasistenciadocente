using capa_entidad;
using capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace capa_presentacion
{
    public partial class frmlistadocentes : MaterialForm
    {

        private cn_usuario negocioUsuarios = new cn_usuario();

        public frmlistadocentes()
        {
            InitializeComponent();
          
        }


        private void CargarListaDocentes()
        {
            List<docente> docentes = negocioUsuarios.ObtenerTodosLosDocentes2();
            materialListView1.Items.Clear();
            foreach (var docente in docentes)
            {
                var item = new ListViewItem(docente.usuarioid.ToString());
                item.SubItems.Add(docente.nombre);
                item.SubItems.Add(docente.apellido);
                item.SubItems.Add(docente.email);
                item.SubItems.Add(docente.numerocelular);
                materialListView1.Items.Add(item);
            }
        }

        private void frmlistadocentes_Load(object sender, EventArgs e)
        {
            CargarListaDocentes();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialListView1_DoubleClick(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count > 0)
            {
                int usuarioId = Convert.ToInt32(materialListView1.SelectedItems[0].Text);
                frmestadousuario perfil = new frmestadousuario(usuarioId);
                perfil.ShowDialog();
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
