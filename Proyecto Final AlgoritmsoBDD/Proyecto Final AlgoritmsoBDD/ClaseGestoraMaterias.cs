using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final_AlgoritmsoBDD
{
    internal class GestorMaterias : ClaseGestorBase
    {
        // Método para cargar una nueva materia
        public void CargarMateria(int anioCursada, string nombreMateria, int idCarrera)
        {
            using (SqlCommand command = new SqlCommand("SP_AgregarMateria"))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                command.Parameters.AddWithValue("@anio_cursada", anioCursada);
                command.Parameters.AddWithValue("@nombre_materia", nombreMateria);
                command.Parameters.AddWithValue("@id_carrera", idCarrera);
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
        public void ModificarMateria(int idMateria, int anioCursada, string nombreMateria)
        {
            using (SqlCommand command = new SqlCommand("SP_ActualizarMateria"))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                command.Parameters.AddWithValue("@id_materia", idMateria);
                command.Parameters.AddWithValue("@anio_cursada", anioCursada);
                command.Parameters.AddWithValue("@nombre_materia", nombreMateria);

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

        // Método para cargar la relación Materia-Carrera
        public void CargarMatxCarr(int idCarrera, int idMateria)
        {
            using (SqlCommand command = new SqlCommand("SP_AgregarMatxCarrera"))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                command.Parameters.AddWithValue("@id_carrera", idCarrera);
                command.Parameters.AddWithValue("@id_materia", idMateria);

                try
                {
                    EjecutarComando(command); // Ejecuta el procedimiento almacenado
                    
                }
                catch 
                {
      
                }
            }
        }
    }
}
