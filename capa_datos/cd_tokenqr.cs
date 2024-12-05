using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class cd_tokenqr
    {


        public void GuardarToken(string usuarioId, string token, DateTime expiracion)
        {
            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                string query = "INSERT INTO tokens_qr (usuarioid, token, fecha_generacion, expiraen) VALUES (@UsuarioId, @Token, @FechaGeneracion, @ExpiraEn)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    command.Parameters.AddWithValue("@Token", token);
                    command.Parameters.AddWithValue("@FechaGeneracion", DateTime.Now);
                    command.Parameters.AddWithValue("@ExpiraEn", expiracion);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarTokenExpirado(string usuarioId)
        {
            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                string query = "DELETE FROM tokens_qr WHERE usuarioid = @UsuarioId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool EsTokenValido(string usuarioId, string token)
        {
            using (SqlConnection connection = new SqlConnection(conexion.cadena))
            {
                string query = "SELECT COUNT(1) FROM tokens_qr WHERE usuarioid = @UsuarioId AND token = @Token AND expiraen > @Ahora";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    command.Parameters.AddWithValue("@Token", token);
                    command.Parameters.AddWithValue("@Ahora", DateTime.Now);

                    connection.Open();
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

    }
}
