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
    public class cd_horario_docente
    {
        // Método para agregar un nuevo horario
        public void AgregarHorario(int usuarioId, TimeSpan horaEntrada, TimeSpan horaSalida, string diaSemana)
        {
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                string query = "INSERT INTO horarios_docentes (usuarioid, horaentrada, horasalida, diasemana) " +
                               "VALUES (@usuarioId, @horaEntrada, @horaSalida, @diaSemana)";

                using (SqlCommand command = new SqlCommand(query, oconexion))
                {
                    command.Parameters.AddWithValue("@usuarioId", usuarioId);
                    command.Parameters.AddWithValue("@horaEntrada", horaEntrada);
                    command.Parameters.AddWithValue("@horaSalida", horaSalida);
                    command.Parameters.AddWithValue("@diaSemana", diaSemana);

                    oconexion.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener los horarios de un docente específico
        public DataTable ObtenerHorarios(int usuarioId)
        {
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                string query = "SELECT * FROM horarios_docentes WHERE usuarioid = @usuarioId";
                using (SqlCommand command = new SqlCommand(query, oconexion))
                {
                    command.Parameters.AddWithValue("@usuarioId", usuarioId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable horarios = new DataTable();
                    adapter.Fill(horarios);
                    return horarios;
                }
            }
        }

        //prueba
        public DataTable ObtenerHorarioPorDia(int usuarioId, string diaSemana)
        {
            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                string query = "SELECT horaentrada, horasalida FROM horarios_docentes WHERE usuarioid = @usuarioId AND diasemana LIKE '%' + @diaSemana + '%'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usuarioId", usuarioId);
                    command.Parameters.AddWithValue("@diaSemana", diaSemana);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable horarioTable = new DataTable();
                    adapter.Fill(horarioTable);
                    return horarioTable;
                }
            }
        }

        public List<horarios_docentes> ObtenerHorarioDocente(int usuarioId)
        {
            List<horarios_docentes> lista = new List<horarios_docentes>();

            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                connection.Open();

                string query = "SELECT * FROM horarios_docentes WHERE usuarioid = @usuarioId";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@usuarioId", usuarioId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new horarios_docentes
                            {
                                HoraEntrada = (TimeSpan)reader["horaentrada"],
                                HoraSalida = (TimeSpan)reader["horasalida"],
                                Materia = reader["materia"].ToString(),
                                Curso = reader["curso"].ToString(),
                                DiasSemana = reader["diasemana"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }
        public void RegistrarHorarioDocente(int usuarioId, string materia, TimeSpan horaEntrada, TimeSpan horaSalida,string diasemana)
        {
            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                connection.Open();
                    string query = "INSERT INTO horarios_docentes (usuarioid, materia, horaentrada, horasalida, diasemana) VALUES (@UsuarioId, @Materia, @horaentrada, @horasalida, @Diasemana)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                        command.Parameters.AddWithValue("@Materia", materia);
                        command.Parameters.AddWithValue("@horaentrada", horaEntrada);
                        command.Parameters.AddWithValue("@horasalida", horaSalida);
                        command.Parameters.AddWithValue("@Diasemana", diasemana);

                        command.ExecuteNonQuery();
                    }
                
            }
        }
        public void InsertarHorario(int usuarioId, string materia, TimeSpan horaEntrada, TimeSpan horaSalida, string diasSemana)
        {
            string query = "INSERT INTO horarios_docentes (usuarioid, materia, horaentrada, horasalida, diasemana) " +
                           "VALUES (@usuarioId, @materia, @horaEntrada, @horaSalida, @diasSemana)";
            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@usuarioId", usuarioId);
                command.Parameters.AddWithValue("@materia", materia);
                command.Parameters.AddWithValue("@horaEntrada", horaEntrada);
                command.Parameters.AddWithValue("@horaSalida", horaSalida);
                command.Parameters.AddWithValue("@diasSemana", diasSemana);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        /*
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
                                DiaSemana = reader["diasemana"].ToString()
                            };
                            horarios.Add(horario);
                        }
                    }
                }
            }

            return horarios;
        }
        */


    }
}
