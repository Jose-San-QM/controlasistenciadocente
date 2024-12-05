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
    public class datosdocentedata
    {

        public datosdocente ObtenerDatosDocente(int usuarioId)
        {
            datosdocente datosDocente = new datosdocente();

            using (SqlConnection conn = new SqlConnection(conexion.cadena))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ObtenerDatosDocente", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        datosDocente.Asistencias = reader.GetInt32(reader.GetOrdinal("Asistencias"));
                        datosDocente.Faltas = reader.GetInt32(reader.GetOrdinal("Faltas"));
                        datosDocente.Atrasos = reader.GetInt32(reader.GetOrdinal("Atrasos"));
                        datosDocente.Permisos = reader.GetInt32(reader.GetOrdinal("Permisos"));
                    }
                }
            }

            return datosDocente;
        }

    }
}
