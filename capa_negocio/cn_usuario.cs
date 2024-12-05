using capa_datos;
using capa_entidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace capa_negocio
{
    public class cn_usuario
    {

        private cd_usuario datos = new cd_usuario();

        public List<docente> ObtenerTodosLosDocentes2()
        {
            return datos.ListarDocentes();
        }




        //

        private cd_usuario usuarioDatos = new cd_usuario();

        public usuarios ObtenerUsuario(int usuarioId)
        {
            return usuarioDatos.ObtenerUsuarioPorId(usuarioId);
        }

        public List<horarios_docentes> ObtenerHorarios(int usuarioId)
        {
            return usuarioDatos.ObtenerHorariosDocente(usuarioId);
        }

        public List<asistencias> ObtenerAsistencias(int usuarioId)
        {
            return usuarioDatos.ObtenerAsistenciasDocente(usuarioId);
        }


        //

        private cd_usuario objCD_Usuario = new cd_usuario();

        public List<usuarios> listar()
        {
            return objCD_Usuario.listar();
        }

        public void agregarusuario(string nombre, string apellido, string contraseña, int carnetIdentidad, string rol, string email, byte[] foto, int numerocelular)
        {
            cd_usuario datosUsuario = new cd_usuario();
            datosUsuario.InsertarUsuario(nombre, apellido, contraseña, carnetIdentidad, rol, email, foto, numerocelular);
        }

        
        // Método para agregar un usuario a la base de datos
        public void agregardocente(string nombre, string apellido, string contraseña, int carnet, string rol, string email)
        {
            // Cadena de conexión a la base de datos
            //using (SqlConnection oconexion = new SqlConnection(conexion.cadena))

            // Insertar el usuario en la base de datos
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    string query = "INSERT INTO usuarios (nombre,apellido, contraseña, carnetidentidad, rol,email) " +
                                   "VALUES (@nombre,@apellido, @contraseña, @carnet, @rol, @email)";

                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        // Asignar los parámetros
                        command.Parameters.AddWithValue("@carnet", carnet);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@contraseña", contraseña);
                        command.Parameters.AddWithValue("@rol", rol);
                        command.Parameters.AddWithValue("@email", email);

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción (puedes lanzar una excepción personalizada si es necesario)
                    throw new Exception("Error al agregar el usuario: " + ex.Message);
                }
            }
        }

        //

        public int ObtenerUsuarioIdPorCarnet(int carnetIdentidad)
        {
            // Instancia de la capa de datos para consultar en la base de datos
            cd_usuario datosUsuario = new cd_usuario();
            return datosUsuario.ObtenerUsuarioIdPorCarnet(carnetIdentidad);
        }
        //
        public int ObtenerUsuarioId(int carnetIdentidad)
        {
            string query = "SELECT usuarioid FROM usuarios WHERE carnetidentidad = @carnetIdentidad";
            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@carnetIdentidad", carnetIdentidad);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
        }
        //

        public void agregarempleado(string nombre, string apellido, string contraseña, int carnet, string rol, string email)
        {
            // Cadena de conexión a la base de datos
            //using (SqlConnection oconexion = new SqlConnection(conexion.cadena))

            // Insertar el usuario en la base de datos
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    string query = "INSERT INTO usuarios (nombre,apellido, contraseña, carnetidentidad, rol,email) " +
                                   "VALUES (@nombre,@apellido, @contraseña, @carnet, @rol, @email)";

                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        // Asignar los parámetros
                        command.Parameters.AddWithValue("@carnet", carnet);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@contraseña", contraseña);
                        command.Parameters.AddWithValue("@rol", rol);
                        command.Parameters.AddWithValue("@email", email);

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción (puedes lanzar una excepción personalizada si es necesario)
                    throw new Exception("Error al agregar el usuario: " + ex.Message);
                }
            }
        }

        //


       

        //
        private cd_usuario data = new cd_usuario(); // La clase que maneja las consultas SQL

        public bool EliminarUsuario(int usuarioId)
        {
            return data.EliminarUsuario(usuarioId); // Llama al método de la capa de datos
        }
        //

        public class UsuarioService
        {
            private cd_usuario usuarioDatos = new cd_usuario();

            public List<usuarios> ListarUsuarios()
            {
                return usuarioDatos.listar();
            }
        }

        //




        public List<usuarios> ObtenerTodosLosDocentes()
        {
            List<usuarios> listaDocentes = new List<usuarios>();

            // Cadena de conexión a la base de datos
            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                string query = "SELECT nombre, apellido, carnetidentidad, email FROM usuarios WHERE rol = 'docente'"; // O cualquier otro criterio que defina a los docentes
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        usuarios docente = new usuarios
                        {
                            //usuarioId = Convert.ToInt32(reader["usuarioId"]),
                            nombre = reader["nombre"].ToString(),
                            apellido = reader["apellido"].ToString(),
                            email = reader["email"].ToString(),
                            carnetidentidad = Convert.ToInt32(reader["carnetidentidad"])
                            // Otras propiedades necesarias
                        };
                        listaDocentes.Add(docente);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener los docentes: " + ex.Message);
                }
            }

            return listaDocentes;
        }
    }



}

    



