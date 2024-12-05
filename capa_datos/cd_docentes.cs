using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_entidad;

namespace capa_datos
{
    public class cd_docentes
    {

        public List<docente> ObtenerListaDocentes()
        {
            List<docente> listaDocentes = new List<docente>();

            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                string query = "SELECT usuarioid, nombre, apellido FROM usuarios WHERE rol = 'Docente'";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listaDocentes.Add(new docente
                    {
                        usuarioid = reader.GetInt32(0),
                        nombre = reader.GetString(1),
                        apellido = reader.GetString(2)
                    });
                }
            }

            return listaDocentes;
        }

    }
}
