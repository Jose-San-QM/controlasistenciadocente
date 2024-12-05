using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidad
{
    public class docente
    {
        public int usuarioid { get; set; }        // ID único del docente
        public string nombre { get; set; }        // Nombre del docente
        public string apellido { get; set; }      // Apellido del docente
        public string carnetidentidad { get; set; }  // Carnet de identidad
        public string email { get; set; }         // Correo electrónico
        public string numerocelular { get; set; } // Número de celular
        public string rol { get; set; }           // Rol del usuario (en este caso "Docente")
        public string foto { get; set; }          // Ruta o URL de la foto de perfil

    }
}
