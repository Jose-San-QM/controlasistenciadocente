using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidad
{
    public class horarios_docentes
    {

        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public string Materia { get; set; }
        public string Curso { get; set; }
        public string DiasSemana { get; set; } // Ejemplo: "Lunes, Miércoles, Viernes"

    }
}
