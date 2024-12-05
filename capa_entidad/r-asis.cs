using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidad
{
    public class r_asis
    {
        public string Estado { get; set; }  // Estado: Presente, Falta, Permiso, Atraso
        public int Total { get; set; }      // Total de registros para ese estado
    }
}
