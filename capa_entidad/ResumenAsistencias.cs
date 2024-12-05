using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidad
{
    public class ResumenAsistencias
    {
        public string DiaSemana { get; set; } // Lunes, Martes, etc.
        public int Asistencias { get; set; }
        public int Faltas { get; set; }
        public int Permisos { get; set; }
        public int Atrasos { get; set; }
        public string Estado { get; set; }     // Ej: "presente", "falta"
        public int Total { get; set; }         // Cantidad de registros para este día y estado

    }
}
