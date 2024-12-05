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
    /*public class cd_asistencias
    {
        // Método para obtener el registro de asistencia del día para el usuario especificado
        public DataTable ObtenerAsistenciaDelDia(int usuarioId, DateTime fecha)
        {
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                string query = "SELECT * FROM asistencias WHERE usuarioid = @usuarioId AND fecha = @fecha";
                using (SqlCommand command = new SqlCommand(query, oconexion))
                {
                    command.Parameters.AddWithValue("@usuarioId", usuarioId);
                    command.Parameters.AddWithValue("@fecha", fecha);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable asistencia = new DataTable();
                    adapter.Fill(asistencia);
                    return asistencia;
                }
            }
        }

        // Método para registrar la hora de entrada
        public bool RegistrarHoraEntrada(int usuarioId, DateTime fecha, TimeSpan horaEntrada, string estado)
        {
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                string query = "INSERT INTO asistencias (usuarioid, fecha, horaentrada, estado) VALUES (@usuarioid, @fecha, @horaentrada, @estado)";
                using (SqlCommand command = new SqlCommand(query, oconexion))
                {
                    command.Parameters.AddWithValue("@usuarioid", usuarioId);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@horaentrada", horaEntrada);
                    command.Parameters.AddWithValue("@estado", estado);

                    oconexion.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        // Método para registrar la hora de salida
        public bool RegistrarHoraSalida(int usuarioId, DateTime fecha, TimeSpan horaSalida)
        {
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                string query = "UPDATE asistencias SET horasalida = @horaSalida WHERE usuarioid = @usuarioId AND fecha = @fecha AND horasalida IS NULL";
                using (SqlCommand command = new SqlCommand(query, oconexion))
                {
                    command.Parameters.AddWithValue("@usuarioId", usuarioId);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@horaSalida", horaSalida);

                    oconexion.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    
    }
    */


    public class cd_asistencias
    {

        public DataTable ObtenerResumenAsistencias5()
        {
            string query = @"
            SELECT 
                DATENAME(weekday, a.fecha) AS DiaSemana, 
                a.estado, 
                COUNT(a.estado) AS Total
            FROM 
                asistencias a
            GROUP BY 
                DATENAME(weekday, a.fecha), a.estado
            ORDER BY 
                DATENAME(weekday, a.fecha), a.estado;";

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(conexion.cadena))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }
        public List<ResumenAsistencias> ObtenerResumenAsistencias()
        {
            List<ResumenAsistencias> resumen = new List<ResumenAsistencias>();

            string query = @"
            SELECT 
                DATENAME(weekday, fecha) AS DiaSemana, 
                SUM(CASE WHEN estado = 'presente' THEN 1 ELSE 0 END) AS Asistencias,
                SUM(CASE WHEN estado = 'falta' THEN 1 ELSE 0 END) AS Faltas,
                SUM(CASE WHEN estado = 'permiso' THEN 1 ELSE 0 END) AS Permisos,
                SUM(CASE WHEN estado = 'atrasado' THEN 1 ELSE 0 END) AS Atrasos
            FROM asistencias
            GROUP BY DATENAME(weekday, fecha)
            ORDER BY CASE 
                WHEN DATENAME(weekday, fecha) = 'lunes' THEN 1
                WHEN DATENAME(weekday, fecha) = 'martes' THEN 2
                WHEN DATENAME(weekday, fecha) = 'miercoles' THEN 3
                WHEN DATENAME(weekday, fecha) = 'jueves' THEN 4
                WHEN DATENAME(weekday, fecha) = 'viernes' THEN 5
                WHEN DATENAME(weekday, fecha) = 'sabado' THEN 6
                ELSE 7
            END;
        ";

            using (SqlConnection conn = new SqlConnection(conexion.cadena))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resumen.Add(new ResumenAsistencias
                        {
                            DiaSemana = reader["DiaSemana"].ToString(),
                            Asistencias = Convert.ToInt32(reader["Asistencias"]),
                            Faltas = Convert.ToInt32(reader["Faltas"]),
                            Permisos = Convert.ToInt32(reader["Permisos"]),
                            Atrasos = Convert.ToInt32(reader["Atrasos"])
                        });
                    }
                }
            }

            return resumen;
        }







        // Método para obtener el resumen de las asistencias por día de la semana
        public List<ResumenAsistencias> ObtenerResumenAsistenciasPorDia(int usuarioId)
        {
            List<ResumenAsistencias> resumen = new List<ResumenAsistencias>();


            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                connection.Open();

                // Consulta SQL para agrupar las asistencias por día de la semana
                string query = @"
                SELECT 
                    DATENAME(weekday, a.fecha) AS DiaSemana,
                    SUM(CASE WHEN a.estado = 'presente' THEN 1 ELSE 0 END) AS Asistencias,
                    SUM(CASE WHEN a.estado = 'falta' THEN 1 ELSE 0 END) AS Faltas,
                    SUM(CASE WHEN a.estado = 'permiso' THEN 1 ELSE 0 END) AS Permisos,
                    SUM(CASE WHEN a.estado = 'atrasado' THEN 1 ELSE 0 END) AS Atrasos
                FROM asistencias a
                WHERE a.usuarioid = @UsuarioId
                GROUP BY DATENAME(weekday, a.fecha)
                ORDER BY DATEPART(weekday, a.fecha);
            ";

                // Ejecutar la consulta y llenar el resultado en una lista
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId); // Parámetro para usuarioId

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var asistencia = new ResumenAsistencias
                            {
                                DiaSemana = reader["DiaSemana"].ToString(),
                                Asistencias = Convert.ToInt32(reader["Asistencias"]),
                                Faltas = Convert.ToInt32(reader["Faltas"]),
                                Permisos = Convert.ToInt32(reader["Permisos"]),
                                Atrasos = Convert.ToInt32(reader["Atrasos"])
                            };
                            resumen.Add(asistencia);
                        }
                    }
                }
            }

            return resumen;
        }





        public Dictionary<string, int> ObtenerResumenGlobalAsistencias()
        {
            Dictionary<string, int> resumen = new Dictionary<string, int>();

            using (SqlConnection conn = new SqlConnection(conexion.cadena))
            {
                conn.Open();
                string query = @"
            SELECT estado, COUNT(*) AS cantidad
            FROM asistencias
            GROUP BY estado";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            resumen.Add(dr["estado"].ToString().ToLower(), Convert.ToInt32(dr["cantidad"]));
                        }
                    }
                }
            }

            return resumen;
        }




        // Método para registrar la hora de entrada
        public bool RegistrarHoraEntrada(int usuarioId, DateTime fecha, TimeSpan horaEntrada, string estado)
        {
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                try
                {
                    string query = "INSERT INTO asistencias (usuarioid, fecha, horaentrada, estado) VALUES (@usuarioid, @fecha, @horaentrada, @estado)";
                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        command.Parameters.Add("@usuarioid", SqlDbType.Int).Value = usuarioId;
                        command.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                        command.Parameters.Add("@horaentrada", SqlDbType.Time).Value = horaEntrada;
                        command.Parameters.Add("@estado", SqlDbType.NVarChar).Value = estado;

                        oconexion.Open();
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepción
                    throw new Exception("Error al registrar la hora de entrada: " + ex.Message);
                }
            }
        }

        // Método para registrar la hora de salida
        public bool RegistrarHoraSalida(int usuarioId, DateTime fecha, TimeSpan horaSalida)
        {
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                try
                {
                    string query = "UPDATE asistencias SET horasalida = @horaSalida WHERE usuarioid = @usuarioId AND fecha = @fecha AND horasalida IS NULL";
                    using (SqlCommand command = new SqlCommand(query, oconexion))
                    {
                        command.Parameters.Add("@usuarioId", SqlDbType.Int).Value = usuarioId;
                        command.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                        command.Parameters.Add("@horaSalida", SqlDbType.Time).Value = horaSalida;

                        oconexion.Open();
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepción
                    throw new Exception("Error al registrar la hora de salida: " + ex.Message);
                }
            }
        }

        //prueba
        

        //prueba
        // Método para verificar si ya existe un registro de entrada para el usuario en el mismo día
        public bool VerificarRegistroEntrada(int usuarioId, DateTime fecha)
        {
            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                string query = @"SELECT COUNT(*) FROM asistencias 
                             WHERE usuarioid = @UsuarioId 
                             AND CAST(horaentrada AS DATE) = @Fecha 
                             AND horasalida IS NULL";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    command.Parameters.AddWithValue("@Fecha", fecha.Date);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Devuelve true si hay un registro de entrada sin salida
                }
            }
        }


        
        // Método para registrar la asistencia con estado (entrada)
        public void RegistrarAsistencia(int usuarioId, DateTime fechaRegistro, string estado)
        {
            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                string query = @"INSERT INTO asistencias (usuarioid, horaentrada,estado,fecha) 
                             VALUES (@UsuarioId, @HoraEntrada, @Estado,@fecha)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    command.Parameters.AddWithValue("@HoraEntrada", fechaRegistro);
                    command.Parameters.AddWithValue("@Estado", estado);
                    command.Parameters.AddWithValue("@Fecha", fechaRegistro.Date);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para registrar la hora de salida si el usuario ya tiene una entrada en el mismo día
        public void RegistrarSalida(int usuarioId, DateTime fechaSalida)
        {
            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                string query = @"UPDATE asistencias 
                             SET horasalida = @HoraSalida 
                             WHERE usuarioid = @UsuarioId 
                             AND CAST(horaentrada AS DATE) = @Fecha 
                             AND horasalida IS NULL";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    command.Parameters.AddWithValue("@HoraSalida", fechaSalida);
                    command.Parameters.AddWithValue("@Fecha", fechaSalida.Date);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        //prueba


        public List<asistencias> ObtenerAsistenciasDocente(int usuarioId)
        {
            List<asistencias> asistencias = new List<   asistencias>();

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


        public List<docenteasistencia> ObtenerDocentesPorEstado(string estado)
        {
            List<docenteasistencia> lista = new List<docenteasistencia>();

            using (SqlConnection conn = new SqlConnection(conexion.cadena))
            {
                conn.Open();
                string query = @"
            SELECT CONCAT(u.nombre, ' ', u.apellido) AS NombreCompleto, COUNT(a.asistenciaid) AS Total
            FROM asistencias a
            INNER JOIN usuarios u ON a.usuarioid = u.usuarioid
            WHERE a.estado = @estado
            GROUP BY u.nombre, u.apellido
            ORDER BY Total DESC"; // Ordenar de mayor a menor

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new docenteasistencia
                            {
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Total = Convert.ToInt32(dr["Total"])
                            });
                        }
                    }
                }
            }

            return lista;
        }




    }

}
