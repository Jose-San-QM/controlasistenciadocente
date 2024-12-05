using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidad
{
    public class asistencias
    {
        public int AsistenciaId { get; set; }    // Identificador de la asistencia
        public int UsuarioId { get; set; }       // ID del docente
        public DateTime Fecha { get; set; }      // Fecha de la asistencia
        public TimeSpan HoraEntrada { get; set; } // Hora de entrada registrada
        public TimeSpan? HoraSalida { get; set; } // Hora de salida registrada, puede ser null
        public string Estado { get; set; }       // Estado de la asistencia (presente, atrasado, etc.)

    }
   
}
