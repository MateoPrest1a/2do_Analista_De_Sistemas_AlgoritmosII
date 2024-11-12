using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final_AlgoritmsoBDD
{
    internal class GestorEmpleados : ClaseGestorBase
    {
        // Método para eliminar un empleado
        public void EliminarEmpleado(int idEmpleado)
        {
            using (SqlCommand command = new SqlCommand("SP_EliminarEmpleado"))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id_Empleado", idEmpleado);

                try
                {
                    EjecutarComando(command);   // Utilizo metodo EjecutarComando de la ClaseGestorBase
                    MessageBox.Show("Empleado eliminado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el empleado: {ex.Message}");
                }
            }
        }

        // Método para actualizar un empleado
        public void ActualizarEmpleado(int idEmpleado, string nombre, string apellido, string direccionCalle, int direccionNumero, string telefono, string dni, string email, DateTime fechaNacimiento, int salario, int tipoPerfil)
        {
            using (SqlCommand command = new SqlCommand("SP_ModificarEmpleado"))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id_Empleado", idEmpleado);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Direccion_calle", direccionCalle);
                command.Parameters.AddWithValue("@Direccion_nro", direccionNumero);
                command.Parameters.AddWithValue("@Telefono", telefono);
                command.Parameters.AddWithValue("@DNI", dni);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Fecha_nacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@Salario", salario);
                command.Parameters.AddWithValue("@Tipo_perfil", tipoPerfil);

                try
                {
                    EjecutarComando(command);
                    MessageBox.Show("Empleado actualizado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el empleado: {ex.Message}");
                }
            }
        }

        // Método para cargar un nuevo empleado
        public void CargarEmpleado(string nombre, string apellido, string direccionCalle, int direccionNumero, string telefono, string dni, string email, DateTime fechaNacimiento, int salario, int tipoPerfil)
        {
            using (SqlCommand command = new SqlCommand("SP_AgregarEmpleado"))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Direccion_calle", direccionCalle);
                command.Parameters.AddWithValue("@Direccion_nro", direccionNumero);
                command.Parameters.AddWithValue("@Telefono", telefono);
                command.Parameters.AddWithValue("@DNI", dni);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Fecha_nacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@Salario", salario);
                command.Parameters.AddWithValue("@Tipo_perfil", tipoPerfil);

                try
                {
                    EjecutarComando(command);
                    MessageBox.Show("Empleado cargado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el empleado: {ex.Message}");
                }
            }
        }
    }
}