using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final_AlgoritmsoBDD
{
    internal class GestorMaterias : ClaseGestorBase
    {
        // Método para cargar una nueva materia
        public void CargarMateria(int anioCursada, string nombreMateria, int idCarrera, int idEmpleado)
        {
            using (SqlCommand command = new SqlCommand("SP_AgregarMateria"))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                command.Parameters.AddWithValue("@anio_cursada", anioCursada);
                command.Parameters.AddWithValue("@nombre_materia", nombreMateria);
                command.Parameters.AddWithValue("@id_carrera", idCarrera);
                command.Parameters.AddWithValue("@id_empleado", idEmpleado);  // Parámetro para el profesor

                try
                {
                    EjecutarComando(command); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Materia cargada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la materia: {ex.Message}");
                }
            }
        }

        // Método para modificar una materia existente
        public void ModificarMateria(int idMateria, int anioCursada, string nombreMateria, int idCarrera, int idEmpleado)
        {
            using (SqlCommand command = new SqlCommand("SP_ActualizarMateria"))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                command.Parameters.AddWithValue("@id_materia", idMateria);
                command.Parameters.AddWithValue("@anio_cursada", anioCursada);
                command.Parameters.AddWithValue("@nombre_materia", nombreMateria);
                command.Parameters.AddWithValue("@id_carrera", idCarrera);  // Actualiza la carrera
                command.Parameters.AddWithValue("@id_empleado", idEmpleado);  // Actualiza el profesor

                try
                {
                    EjecutarComando(command); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Materia modificada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar la materia: {ex.Message}");
                }
            }
        }

        // Método para eliminar una materia
        public void EliminarMateria(int idMateria)
        {
            using (SqlCommand command = new SqlCommand("SP_EliminarMateria"))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar el parámetro
                command.Parameters.AddWithValue("@id_materia", idMateria);

                try
                {
                    EjecutarComando(command); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Materia eliminada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la materia: {ex.Message}");
                }
            }
        }

        // Método para agregar una materia a un alumno
        public void AgregarMateriaAAlumno(int matricula, int idMateria, string estado)
        {
            using (SqlCommand command = new SqlCommand("SP_AgregarMateriasxAlumno"))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                command.Parameters.AddWithValue("@matricula", matricula);
                command.Parameters.AddWithValue("@id_materia", idMateria);
                command.Parameters.AddWithValue("@estado", estado);

                try
                {
                    EjecutarComando(command); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Materia asignada al alumno con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al asignar la materia al alumno: {ex.Message}");
                }
            }
        }

        //Filtros Materias
        public DataTable FiltrarPorAño(int año)
        {
            SqlCommand command = new SqlCommand("SP_FiltrarMateriasPorAño");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@año", año);

            try
            {
                return EjecutarConsulta(command);  // EjecutarConsulta es el método de ClaseGestorBase que devuelve un DataTable
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el alumno: {ex.Message}");
                return null;  // Devuelve null en caso de error
            }
        }

        public DataTable FiltrarPorCarrera(int idCarrera)
        {
            SqlCommand command = new SqlCommand("SP_FiltrarMateriasPorCarrera");
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_carrera", idCarrera);

            try
            {
                return EjecutarConsulta(command);  // EjecutarConsulta es el método de ClaseGestorBase que devuelve un DataTable
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el alumno: {ex.Message}");
                return null;  // Devuelve null en caso de error
            }
        }

    }
}
