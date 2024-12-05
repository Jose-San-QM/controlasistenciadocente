using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

using System.Data;
using System.Data.SqlClient;

namespace capa_datos
{
    public class conexion
    {

        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();


    }
}
