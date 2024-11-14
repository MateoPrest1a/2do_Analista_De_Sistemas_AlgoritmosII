using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_AlgoritmsoBDD
{
    internal class ClaseGestoraExamenXAlumnos : ClaseGestorBase
    {
        // Método para insertar un nuevo registro en ExamenesXAlumno
        public void InsertarExamenXAlumno(int matricula, int idExamen, decimal calificacion)
        {
            using (SqlCommand command = new SqlCommand("SP_AgregarExamenXAlumno"))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@matricula", matricula);
                command.Parameters.AddWithValue("@id_examen", idExamen);
                command.Parameters.AddWithValue("@calificacion", calificacion);

                try
                {
                    EjecutarComando(command);  // Utiliza el método EjecutarComando de ClaseGestorBase
                    MessageBox.Show("Examen cargado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el examen: {ex.Message}");
                }
            }
        }

        // Método para actualizar un examen de un alumno
        public void ActualizarExamenXAlumno(int idExamenXAlumno, int idExamen, decimal calificacion)
        {
            using (SqlCommand command = new SqlCommand("SP_ActualizarExamenXAlumno"))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_examenxalumno", idExamenXAlumno);
                command.Parameters.AddWithValue("@id_examen", idExamen);
                command.Parameters.AddWithValue("@calificacion", calificacion);

                try
                {
                    EjecutarComando(command);
                    MessageBox.Show("Examen actualizado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el examen: {ex.Message}");
                }
            }
        }

        // Método para eliminar un examen de un alumno
        public void EliminarExamenXAlumno(int idExamenXAlumno)
        {
            using (SqlCommand command = new SqlCommand("SP_EliminarExamenXAlumno"))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id_examenxalumno", idExamenXAlumno);

                try
                {
                    EjecutarComando(command);
                    MessageBox.Show("Examen eliminado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el examen: {ex.Message}");
                }
            }
        }


    }
}
