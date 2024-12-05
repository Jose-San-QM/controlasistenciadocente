using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidad
{
    public class docenteasistencia
    {
        public string NombreCompleto { get; set; }  // Nombre completo del docente
        public int Total { get; set; }              // Total de asistencias del docente en el estado seleccionado
    }
}
