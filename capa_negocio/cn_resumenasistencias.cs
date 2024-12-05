using capa_datos;
using capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class cn_resumenasistencias
    {
        private resumenasistenciadata datos = new resumenasistenciadata();

        public List<ResumenAsistencias> ObtenerResumenAsistencias5()
        {
            return datos.ObtenerResumenAsistencias5();
        }

        public Dictionary<string, int> ObtenerResumenAsistenciasPorDocente(int idDocente)
        {
            var datos = new resumenasistenciadata().ObtenerResumenPorDocente(idDocente);

            // Procesar y devolver en formato Dictionary
            return datos.GroupBy(x => x.Estado)
                        .ToDictionary(g => g.Key, g => g.Sum(x => x.Total));
        }
    }
}
