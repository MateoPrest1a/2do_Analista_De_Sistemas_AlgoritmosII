using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final_AlgoritmsoBDD
{
    internal class GestorExamenes : ClaseGestorBase
    {
        // Método para cargar un nuevo examen
        public void CargarExamen(int idCarrera, int idMateria, string horaExamen, DateTime fechaExamen, int tipoExamen, int libro, int folio)
        {
            using (SqlCommand command = new SqlCommand("SP_AgregarExamen"))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                command.Parameters.AddWithValue("@id_carrera", idCarrera);
                command.Parameters.AddWithValue("@id_materia", idMateria);
                command.Parameters.AddWithValue("@hora_examen", horaExamen);
                command.Parameters.AddWithValue("@fecha_examen", fechaExamen);
                command.Parameters.AddWithValue("@tipo_examen", tipoExamen);
                command.Parameters.AddWithValue("@libro", libro);
                command.Parameters.AddWithValue("@folio", folio);

                try
                {
                    EjecutarComando(command); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Examen cargado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el examen: {ex.Message}");
                }
            }
        }

        // Método para eliminar un examen
        public void EliminarExamen(int idExamen)
        {
            using (SqlCommand command = new SqlCommand("SP_EliminarExamen"))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar el parámetro
                command.Parameters.AddWithValue("@id_examen", idExamen);

                try
                {
                    EjecutarComando(command); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Examen eliminado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el examen: {ex.Message}");
                }
            }
        }

        // Método para actualizar un examen
        public void ActualizarExamen(int idExamen, int idCarrera, int idMateria, string horaExamen, DateTime fechaExamen, int tipoExamen, int libro, int folio)
        {
            using (SqlCommand command = new SqlCommand("SP_ActualizarExamen"))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                command.Parameters.AddWithValue("@id_examen", idExamen);
                command.Parameters.AddWithValue("@id_carrera", idCarrera);
                command.Parameters.AddWithValue("@id_materia", idMateria);
                command.Parameters.AddWithValue("@hora_examen", horaExamen);
                command.Parameters.AddWithValue("@fecha_examen", fechaExamen);
                command.Parameters.AddWithValue("@tipo_examen", tipoExamen);
                command.Parameters.AddWithValue("@libro", libro);
                command.Parameters.AddWithValue("@folio", folio);

                try
                {
                    EjecutarComando(command); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Examen actualizado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el examen: {ex.Message}");
                }
            }
        }
    }
}