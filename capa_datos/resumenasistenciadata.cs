using capa_entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class resumenasistenciadata
    {


        public List<ResumenAsistencias> ObtenerResumenAsistencias5()
        {
            var resumen = new List<ResumenAsistencias>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conexion.cadena))
                {
                    connection.Open();

                    string query = @"
                    SELECT 
                        DATENAME(dw, a.fecha) AS DiaSemana,
                        a.estado AS Estado,
                        COUNT(*) AS Total
                    FROM asistencias a
                    GROUP BY DATENAME(dw, a.fecha), a.estado
                    ORDER BY 
                        CASE DATENAME(dw, a.fecha)
                            WHEN 'lunes' THEN 1
                            WHEN 'martes' THEN 2
                            WHEN 'miércoles' THEN 3
                            WHEN 'jueves' THEN 4
                            WHEN 'viernes' THEN 5
                            WHEN 'sábado' THEN 6
                            ELSE 7 -- domingo, si existe
                        END;";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                resumen.Add(new ResumenAsistencias
                                {
                                    DiaSemana = reader["DiaSemana"].ToString(),
                                    Estado = reader["Estado"].ToString(),
                                    Total = Convert.ToInt32(reader["Total"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el resumen de asistencias: " + ex.Message);
            }

            return resumen;
        }



        public List<r_asis> ObtenerResumenPorDocente(int idDocente)
        {
            var resumen = new List<r_asis>();

            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Estado, COUNT(*) AS Total FROM asistencias WHERE usuarioid = @IdDocente GROUP BY Estado", con))
                {
                    cmd.Parameters.AddWithValue("@IdDocente", idDocente);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            resumen.Add(new r_asis
                            {
                                Estado = dr["Estado"].ToString(),
                                Total = Convert.ToInt32(dr["Total"])
                            });
                        }
                    }
                }
            }

            return resumen;
        }

        public Dictionary<string, int> ObtenerResumenAsistenciasPorEstado(int usuarioId)
        {
            Dictionary<string, int> resumen = new Dictionary<string, int>();

            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                string query = @"
            SELECT estado, COUNT(*) AS cantidad
            FROM asistencias
            WHERE usuarioid = @UsuarioId
            GROUP BY estado";

                using (SqlCommand comando = new SqlCommand(query, oconexion))
                {
                    comando.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    oconexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string estado = reader["estado"].ToString();
                            int cantidad = Convert.ToInt32(reader["cantidad"]);
                            resumen[estado] = cantidad;
                        }
                    }
                }
            }

            // Asegurarse de que todos los estados estén presentes, aunque sean 0.
            foreach (var estado in new[] { "presente", "falta", "atrasado", "permiso" })
            {
                if (!resumen.ContainsKey(estado))
                {
                    resumen[estado] = 0;
                }
            }

            return resumen;
        }

    }
}
