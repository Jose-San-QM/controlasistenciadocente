using capa_datos;
using capa_entidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class cn_asistencia
    {

        private readonly cd_asistencias _datosAsistencias;

        public cn_asistencia()
        {
            _datosAsistencias = new cd_asistencias();  // Capa de datos
        }

        // Función para obtener el resumen de las asistencias
        public List<ResumenAsistencias> ObtenerResumenAsistencias()
        {
            return _datosAsistencias.ObtenerResumenAsistencias();
        }
    




    public List<docenteasistencia> ObtenerDocentesPorEstado(string estado)
        {
            cd_asistencias datos = new cd_asistencias();
            return datos.ObtenerDocentesPorEstado(estado);
        }

        public Dictionary<string, int> ObtenerResumenGlobalAsistencias()
        {
            cd_asistencias datos = new cd_asistencias();
            return datos.ObtenerResumenGlobalAsistencias();
        }

        //inicio script 1
        /*
        public void RegistrarAsistencia(int usuarioId, DateTime fecha, TimeSpan horaEntrada, string estado)
        {
            using (SqlConnection oconexion = new SqlConnection(conexion.cadena))
            {
                string query = "INSERT INTO asistencias (usuarioid, fecha, horaentrada, estado) VALUES (@usuarioid, @fecha, @horaentrada, @estado)";

                using (SqlCommand command = new SqlCommand(query, oconexion))
                {
                    command.Parameters.AddWithValue("@usuarioid", usuarioId);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@horaentrada", horaEntrada);
                    command.Parameters.AddWithValue("@estado", estado);

                    oconexion.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        */
        //fin script 1


        //inicio script 2
        /*
        private cd_asistencias _dataAccessAsistencia = new cd_asistencias();
        private cd_horario_docente _dataAccessHorarios = new cd_horario_docente();

        // Método para registrar la asistencia del docente según el QR escaneado
        public bool RegistrarAsistencia(int usuarioId)
        {
            DateTime fechaActual = DateTime.Now.Date;
            TimeSpan horaActual = DateTime.Now.TimeOfDay;

            // Consultar si el usuario ya tiene un registro de entrada en la fecha actual
            DataTable asistenciaExistente = _dataAccessAsistencia.ObtenerAsistenciaDelDia(usuarioId, fechaActual);

            if (asistenciaExistente.Rows.Count > 0)
            {
                // Si ya hay un registro de entrada, actualizar la salida
                return _dataAccessAsistencia.RegistrarHoraSalida(usuarioId, fechaActual, horaActual);
            }
            else
            {
                // Si no hay registro de entrada, registrar como nueva entrada
                string estado = DeterminarEstadoAsistencia(horaActual, usuarioId);
                return _dataAccessAsistencia.RegistrarHoraEntrada(usuarioId, fechaActual, horaActual, estado);
            }
        }

        // Método auxiliar para determinar el estado de asistencia (presente, atrasado, etc.)
        private string DeterminarEstadoAsistencia(TimeSpan horaActual, int usuarioId)
        {
            // Obtener el horario del usuario
            DataTable horario = _dataAccessHorarios.ObtenerHorarios(usuarioId);
            if (horario.Rows.Count > 0)
            {
                foreach (DataRow row in horario.Rows)
                {
                    TimeSpan horaEntradaProgramada = (TimeSpan)row["horaentrada"];
                    TimeSpan tolerancia = TimeSpan.FromMinutes(5); // Tolerancia de 5 minutos

                    // Determina el estado según la hora de entrada programada
                    if (horaActual <= horaEntradaProgramada + tolerancia)
                    {
                        return "presente";
                    }
                    else
                    {
                        return "atrasado";
                    }
                }
            }
            return "sin horario"; // Si no hay un horario asignado
        }
        */
        //fin scriopt 2



        //inicio script 3
        private cd_horario_docente horarioData = new cd_horario_docente();
        private cd_asistencias asistenciaData = new cd_asistencias();

        public string RegistrarAsistencia(int usuarioId, DateTime fechaRegistro)
        {
            // Obtener el horario del docente en el día y hora de la asistencia
            DataTable horarioDocente = horarioData.ObtenerHorarioPorDia(usuarioId, fechaRegistro.DayOfWeek.ToString());

            if (horarioDocente.Rows.Count == 0)
            {
                // Caso: fuera de horario (no tiene clases programadas para este día)
                asistenciaData.RegistrarAsistencia(usuarioId, fechaRegistro, "Fuera de horario");
                return "Fuera de horario";
            }
            else
            {
                // Extraer la hora de entrada y salida del horario del docente
                TimeSpan horaEntrada = (TimeSpan)horarioDocente.Rows[0]["horaentrada"];
                TimeSpan horaSalida = (TimeSpan)horarioDocente.Rows[0]["horasalida"];

                // Comparar la hora de registro con el horario de entrada
                TimeSpan horaRegistro = fechaRegistro.TimeOfDay;
                string estado;

                // Verificar si el usuario ya tiene un registro de entrada y está dentro del horario de clase
                if (asistenciaData.VerificarRegistroEntrada(usuarioId, fechaRegistro.Date))
                {
                    // Caso: registrar salida si ya se registró una entrada previamente en el mismo día
                    asistenciaData.RegistrarSalida(usuarioId, fechaRegistro);
                    return "Salida registrada";
                }
                else
                {
                    // Registrar asistencia de entrada
                    if (horaRegistro <= horaEntrada)
                    {
                        // Caso: llegó a tiempo
                        estado = "A tiempo";
                    }
                    else if (horaRegistro > horaEntrada && horaRegistro < horaSalida)
                    {
                        // Caso: llegó tarde
                        estado = "Atrasado";
                    }
                    else
                    {
                        // Caso: fuera del horario de clase
                        estado = "Fuera de horario";
                    }

                    // Registrar la asistencia de entrada con el estado determinado
                    asistenciaData.RegistrarAsistencia(usuarioId, fechaRegistro, estado);
                    return estado;
                }
            }
        }
        //fin script 3
       
    } 
}
