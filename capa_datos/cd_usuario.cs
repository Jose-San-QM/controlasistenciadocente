using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_entidad;
namespace capa_datos
{
    public class cd_usuario
    {
        public bool EliminarUsuario(int usuarioId)
        {
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                try
                {
                    string query = "DELETE FROM usuarios WHERE usuarioid = @usuarioId";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    // Manejar excepción o registrar el error
                    return false;
                }
            }
        }


        public int ObtenerUsuarioIdPorCarnet(int carnetIdentidad)
        {
            int usuarioId = 0;
            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                string query = "SELECT usuarioid FROM usuarios WHERE carnetidentidad = @carnetIdentidad";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@carnetIdentidad", carnetIdentidad);
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        usuarioId = Convert.ToInt32(result);
                    }
                }
            }
            return usuarioId;
        }



        public List<usuarios> listar()
        {
            List<usuarios> lista = new List<usuarios>();
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                try
                {
                    string query = "select usuarioid, carnetidentidad, contraseña, nombre, apellido, rol, email from usuarios ";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new usuarios()
                            {
                                usuarioid = Convert.ToInt32(dr["usuarioid"]),
                                carnetidentidad = Convert.ToInt32(dr["carnetidentidad"]),
                                contraseña = dr["contraseña"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                rol = dr["rol"].ToString(),
                                email = dr["email"].ToString()


                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    lista = new List<usuarios>();

                }

            }
            return lista;

        }

        public void InsertarUsuario(string nombre, string apellido, string contraseña, int carnetIdentidad, string rol, string email, byte[] foto, int numerocelular)
        {
            string query = "INSERT INTO usuarios (nombre, apellido, contraseña, carnetidentidad, rol, email, foto, numerocelular) " +
                           "VALUES (@nombre, @apellido, @contraseña, @carnetIdentidad, @rol, @email, @foto, @numerocelular)";
            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@contraseña", contraseña);
                command.Parameters.AddWithValue("@carnetIdentidad", carnetIdentidad);
                command.Parameters.AddWithValue("@rol", rol);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@foto", foto ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@numerocelular", numerocelular);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //sacar perfil

        public usuarios ObtenerUsuarioPorId(int usuarioId)
        {
            usuarios usuario = null;

            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                connection.Open();

                string query = @"SELECT nombre, apellido, carnetidentidad, email, numerocelular, foto 
                         FROM usuarios WHERE usuarioid = @UsuarioId";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new usuarios
                            {
                                nombre = reader["nombre"].ToString(),
                                apellido = reader["apellido"].ToString(),
                                carnetidentidad = Convert.ToInt32(reader["carnetidentidad"]),
                                email = reader["email"].ToString(),
                                numerocelular = Convert.ToInt32(reader["numerocelular"]),
                                Foto = reader["foto"] as byte[] // Puede ser nulo
                            };
                        }
                    }
                }
            }

            return usuario;
        }


        public List<horarios_docentes> ObtenerHorariosDocente(int usuarioId)
        {
            List<horarios_docentes> horarios = new List<horarios_docentes>();

            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                connection.Open();

                string query = @"SELECT horaentrada, horasalida, materia, curso, diasemana 
                         FROM horarios_docentes 
                         WHERE usuarioid = @UsuarioId";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            horarios_docentes horario = new horarios_docentes
                            {
                                HoraEntrada = TimeSpan.Parse(reader["horaentrada"].ToString()),
                                HoraSalida = TimeSpan.Parse(reader["horasalida"].ToString()),
                                Materia = reader["materia"].ToString(),
                                Curso = reader["curso"].ToString(),
                                DiasSemana = reader["diasemana"].ToString()
                            };
                            horarios.Add(horario);
                        }
                    }
                }
            }

            return horarios;
        }

        public List<asistencias> ObtenerAsistenciasDocente(int usuarioId)
        {
            List<asistencias> asistencias = new List<asistencias>();

            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                connection.Open();

                string query = @"SELECT fecha, horaentrada, horasalida, estado, codigoregistro 
                         FROM asistencias 
                         WHERE usuarioid = @UsuarioId 
                         ORDER BY fecha DESC";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            asistencias asistencia = new asistencias
                            {
                                Fecha = Convert.ToDateTime(reader["fecha"]),
                                HoraEntrada = TimeSpan.Parse(reader["horaentrada"].ToString()),
                                HoraSalida = reader["horasalida"] != DBNull.Value ? TimeSpan.Parse(reader["horasalida"].ToString()) : (TimeSpan?)null,
                                Estado = reader["estado"].ToString(),
                            };
                            asistencias.Add(asistencia);
                        }
                    }
                }
            }

            return asistencias;
        }

        //



        public List<docente> ListarDocentes()
        {
            List<docente> lista = new List<docente>();
            using (SqlConnection conn = new SqlConnection(conexion.cadena))
            {
                conn.Open();
                string query = "SELECT usuarioid, nombre, apellido, email, numerocelular FROM usuarios WHERE rol = 'Docente'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new docente
                            {
                                usuarioid = Convert.ToInt32(dr["usuarioid"]),
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
                                email = dr["email"].ToString(),
                                numerocelular = dr["numerocelular"].ToString()
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
