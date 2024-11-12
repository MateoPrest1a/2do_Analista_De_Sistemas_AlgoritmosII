using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final_AlgoritmsoBDD                  //Heredo la clase gestora base ya que tengo
{                                                       //los metodos de conexion y para ejecutar comandos SQL
    internal class ClaseGestorAlumnos : ClaseGestorBase 
    {
        // Método para eliminar un alumno
        public void EliminarAlumno(int matricula)
        {
            using (SqlCommand command = new SqlCommand("SP_EliminarAlumno"))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@matricula", matricula);

                try
                {
                    EjecutarComando(command);   // Utilizo metodo EjecutarComando de la ClaseGestorBase
                    MessageBox.Show("Alumno Eliminado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al Eliminar el alumno: {ex.Message}");
                }
            }
        }

        // Método para actualizar un alumno
        public void ActualizarAlumno(int matricula, string nombre, string apellido, string direccionCalle, int direccionNumero, string telefono, string dni, string email, DateTime fechaNacimiento, int idCarrera, int año)
        {
            using (SqlCommand command = new SqlCommand("SP_ActualizarAlumno"))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@matricula", matricula);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@apellido", apellido);
                command.Parameters.AddWithValue("@direccion_calle", direccionCalle);
                command.Parameters.AddWithValue("@direccion_numero", direccionNumero);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@id_carrera", idCarrera);
                command.Parameters.AddWithValue("@año", año);

                try
                {
                    EjecutarComando(command);
                    MessageBox.Show("Alumno Actualizado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al Actualizar el alumno: {ex.Message}");
                }
            }
        }

        // Método para cargar un nuevo alumno
        public void CargarAlumno(string nombre, string apellido, string direccionCalle, int direccionNumero, string telefono, string dni, string email, DateTime fechaNacimiento, int idCarrera, int año)
        {
            using (SqlCommand command = new SqlCommand("SP_AgregarAlumno"))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@direccion_calle", direccionCalle);
                command.Parameters.AddWithValue("@direccion_numero", direccionNumero);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@id_carrera", idCarrera); // Cambia 2 por el idCarrera correspondiente
                command.Parameters.AddWithValue("@año", año);

                try
                {
                    EjecutarComando(command);
                    MessageBox.Show("Alumno cargado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el alumno: {ex.Message}");
                }
            }
        }
    }
}