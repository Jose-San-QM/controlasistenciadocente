using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_entidad;
using capa_negocio;
using static capa_negocio.cn_usuario;

namespace capa_presentacion
{
    public partial class frmeliminarusuarios : Form
    {
        public frmeliminarusuarios()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
        }


        // Método público para actualizar el texto del Label
        public void CambiarTextoLabel(string texto)
        {
            user.Text = texto;  // 'user' es el nombre del Label
        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        //inicio script combobox
        private UsuarioService usuarioService;


        // Método para cargar los usuarios en el ComboBox
        private void CargarUsuariosEnComboBox()
        {
            List<usuarios> listaUsuarios = usuarioService.ListarUsuarios();

            // Agregar los usuarios al ComboBox con un display adecuado (nombre + apellido)
            foreach (var usuario in listaUsuarios)
            {
                if (usuario.rol == user.Text.ToLower())
                {

                    nombrecombox.Items.Add(new KeyValuePair<int, string>(usuario.usuarioid, $"{usuario.nombre} {usuario.apellido}"));
           
                
                }
            }
            // Configurar para que muestre el nombre completo y use el ID de usuario como valor
            nombrecombox.DisplayMember = "Value"; // Visualizar el nombre completo en el ComboBox
            nombrecombox.ValueMember = "Key";    // Usar el ID del usuario internamente
        }

        //fin script combobox
        private void frmeliminarusuarios_Load(object sender, EventArgs e)
        {
            string rol = user.Text.ToLower();
            ConfigurarInterfazPorRol(rol);
            CargarUsuariosEnComboBox();
        }


        private void ConfigurarInterfazPorRol(string rol)

        {

            // Controles específicos para empleados
            var controlesEmpleado = new List<Control>
            {
                modificarhorario,
                listView1,
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

        private void eliminar_Click(object sender, EventArgs e)
        {
            //eliminar usuario 1
            /*
            // Obtén el usuario seleccionado en el ComboBox
            var usuarioSeleccionado = (KeyValuePair<int, string>)nombrecombox.SelectedItem;
            int usuarioId = usuarioSeleccionado.Key;

            // Llamada a la capa de negocio para eliminar
            cn_usuario servicioUsuario = new cn_usuario();
            bool resultado = servicioUsuario.EliminarUsuario(usuarioId);

            if (resultado)
            {
                MessageBox.Show("Usuario eliminado correctamente");
                // Recargar los datos en el ComboBox u otros controles si es necesario
            }
            else
            {
                MessageBox.Show("Error al eliminar el usuario");
            } 
            */



            //eliminar usuario 2

            // Verificar si se ha seleccionado un valor en el ComboBox
            if (nombrecombox.SelectedItem == null)
            {
                MessageBox.Show("Se debe seleccionar un usuario");
                return;
            }

            // Obtén el usuario seleccionado en el ComboBox
            var usuarioSeleccionado = (KeyValuePair<int, string>)nombrecombox.SelectedItem;
            int usuarioId = usuarioSeleccionado.Key;

            // Crear la instancia de la capa de negocio para obtener el rol del usuario
            cn_usuario servicioUsuario = new cn_usuario();

            // Obtener el rol del usuario
            string rol = user.Text.ToLower();
            // Eliminar el usuario
            bool resultado = servicioUsuario.EliminarUsuario(usuarioId);

            if (resultado)
            {
                // Si es docente, eliminar los horarios
                if (rol.ToLower() == "docente")
                {
                    // Llamada a la capa de negocio para eliminar los horarios del docente
                    cn_horario servicioHorario = new cn_horario();
                    bool resultadoHorarios = servicioHorario.EliminarHorariosPorDocente(usuarioId);

                    if (resultadoHorarios)
                    {
                        MessageBox.Show("Usuario y sus horarios eliminados correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Usuario eliminado, pero no se pudieron eliminar los horarios.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario eliminado correctamente.");
                }

                // Recargar los datos en el ComboBox u otros controles si es necesario
            }
            else
            {
                MessageBox.Show("Error al eliminar el usuario");
            }
            

            
        }

       

        private void nombrecombox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (nombrecombox.SelectedItem != null)
            {
                var usuarioSeleccionado = (KeyValuePair<int, string>)nombrecombox.SelectedItem;
                int usuarioId = usuarioSeleccionado.Key;

                // Buscar los datos del usuario seleccionado en la lista y mostrar en los TextBox
                usuarios usuario = usuarioService.ListarUsuarios().Find(u => u.usuarioid == usuarioId);

                if (usuario != null)
                {
                    //ComboBox.Text = usuario.nombre;
                    apellido.Text = usuario.apellido;
                    carnetidentidad.Text = usuario.carnetidentidad.ToString();
                    contraseña.Text = usuario.contraseña;
                }
            }
        }
    }
}
