using capa_datos;
using capa_entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class cn_docente
    {

      

        private readonly datosdocentedata datosDocenteData;

        public cn_docente(string connectionString)
        {
            datosDocenteData = new datosdocentedata();
        }

        public datosdocente ObtenerDatosDocente(int usuarioId)
        {
            return datosDocenteData.ObtenerDatosDocente(usuarioId);
        }

        //
        public List<docente> ObtenerDocentes()
        {
            cd_docentes datos = new cd_docentes();
            return datos.ObtenerListaDocentes();
        }

    }
}
