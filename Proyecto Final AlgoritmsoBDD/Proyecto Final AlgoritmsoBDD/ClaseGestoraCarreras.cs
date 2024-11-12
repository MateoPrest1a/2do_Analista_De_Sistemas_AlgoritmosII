using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final_AlgoritmsoBDD
{
    internal class GestorCarreras : ClaseGestorBase
    {
        // Método para cargar una nueva carrera
        public void CargarCarrera(string nombreCarrera, int numResolucion, int anioPlanEstudio)
        {
            using (SqlCommand command = new SqlCommand("SP_AgregarCarrera"))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                command.Parameters.AddWithValue("@nombre_carrera", nombreCarrera);
                command.Parameters.AddWithValue("@num_resolucion", numResolucion);
                command.Parameters.AddWithValue("@anio_plan_estudio", anioPlanEstudio);

                try
                {
                    EjecutarComando(command); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Carrera cargada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la carrera: {ex.Message}");
                }
            }
        }

        // Método para modificar una carrera existente
        public void ModificarCarrera(int idCarrera, string nombreCarrera, int numResolucion, int anioPlanEstudio)
        {
            using (SqlCommand command = new SqlCommand("SP_ModificarCarrera"))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                command.Parameters.AddWithValue("@id_carrera", idCarrera);
                command.Parameters.AddWithValue("@nombre_carrera", nombreCarrera);
                command.Parameters.AddWithValue("@num_resolucion", numResolucion);
                command.Parameters.AddWithValue("@anio_plan_estudio", anioPlanEstudio);

                try
                {
                    EjecutarComando(command); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Carrera modificada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar la carrera: {ex.Message}");
                }
            }
        }

        // Método para eliminar una carrera
        public void EliminarCarrera(int idCarrera)
        {
            using (SqlCommand command = new SqlCommand("SP_EliminarCarrera"))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar el parámetro
                command.Parameters.AddWithValue("@id_carrera", idCarrera);

                try
                {
                    EjecutarComando(command); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Carrera eliminada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la carrera: {ex.Message}");
                }
            }
        }
    }
}