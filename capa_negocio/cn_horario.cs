using capa_datos;
using capa_entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public  class cn_horario
    {

        private cd_horario_docente dataHorario = new cd_horario_docente();

        // Método para agregar el horario del docente
        /*public void AgregarHorarioDocente(int usuarioId, string materia, TimeSpan horaInicio, TimeSpan horaFin, string diasSeleccionados)
        {
            

            // Llamar al método de la capa de datos para registrar el horario del docente
            dataHorario.RegistrarHorarioDocente(usuarioId, materia, horaInicio, horaFin, diasSeleccionados);
        }*/


        // Método para eliminar todos los horarios de un docente
        public bool EliminarHorariosPorDocente(int usuarioId)
        {
            bool resultado = false;

            // Conexión a la base de datos
            using (SqlConnection con = new SqlConnection(conexion.cadena))
            {
                // La consulta SQL para eliminar los horarios del docente
                string query = "DELETE FROM horarios WHERE usuarioId = @usuarioId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@usuarioId", usuarioId); // Pasamos el usuarioId a la consulta

                try
                {
                    // Abrimos la conexión y ejecutamos la consulta
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();  // Ejecutamos la consulta de eliminación
                    resultado = rowsAffected > 0; // Si se afectaron filas, la eliminación fue exitosa
                }
                catch (Exception ex)
                {
                    // Manejo de errores en caso de que falle la consulta
                    Console.WriteLine("Error al eliminar horarios: " + ex.Message);
                }
            }

            return resultado; // Retornamos si la eliminación fue exitosa o no
        }



        public void AgregarHorarioDocente(int usuarioId, string materia, TimeSpan horaEntrada, TimeSpan horaSalida, string diasSemana)
        {
            cd_horario_docente datosHorario = new cd_horario_docente();
            datosHorario.InsertarHorario(usuarioId, materia, horaEntrada, horaSalida, diasSemana);
        }




        private cd_horario_docente datosHorarios = new cd_horario_docente();

        public List<horarios_docentes> ObtenerHorarioDocente(int usuarioId)
        {
            return datosHorarios.ObtenerHorarioDocente(usuarioId);
        }

        //

        public DataTable ObtenerHorarioTabla(int usuarioId)
        {
            cd_horario_docente datosHorarios = new cd_horario_docente();
            List<horarios_docentes> horarios = datosHorarios.ObtenerHorarioDocente(usuarioId);

            DataTable tablaHorario = new DataTable();
            tablaHorario.Columns.Add("Hora");
            tablaHorario.Columns.Add("Lunes");
            tablaHorario.Columns.Add("Martes");
            tablaHorario.Columns.Add("Miércoles");
            tablaHorario.Columns.Add("Jueves");
            tablaHorario.Columns.Add("Viernes");
            tablaHorario.Columns.Add("Sábado");

            // Inicializar filas con horas base
            var horasBase = new List<string>
    {
        "8:30 - 10:00", "10:30 - 12:00", "12:30 - 14:00",
        "14:30 - 16:00", "16:30 - 18:00", "18:30 - 20:00", "20:30 - 22:00"
    };

            foreach (var hora in horasBase)
            {
                DataRow fila = tablaHorario.NewRow();
                fila["Hora"] = hora;
                tablaHorario.Rows.Add(fila);
            }

            // Mapear horarios a la tabla
            foreach (var horario in horarios)
            {
                string intervalo = $"{horario.HoraEntrada:hh\\:mm} - {horario.HoraSalida:hh\\:mm}";

                foreach (var dia in horario.DiasSemana)
                {
                    foreach (DataRow fila in tablaHorario.Rows)
                    {
                        if (fila["Hora"].ToString() == intervalo)
                        {
                            fila[dia] = $"{horario.Materia} ({horario.Curso})";
                        }
                    }
                }
            }

            return tablaHorario;
        }

        //

    }



    

    
}
