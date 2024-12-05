using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidad
{
    public class usuarios
    {

        public int usuarioid { get; set; }
        public int carnetidentidad { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string rol { get; set; }
        public string email { get; set; }

        public byte[] Foto { get; set; }
        public int numerocelular { get; set; }



        public List<horarios_docentes> Horarios { get; set; } = new List<horarios_docentes>();

        public List<asistencias> Asistencias { get; set; }
        public int PermisosRestantes { get; set; }
        public int Faltas { get; set; }

    }
}
