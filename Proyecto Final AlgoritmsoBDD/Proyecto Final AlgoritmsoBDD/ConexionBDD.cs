using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Final
{
    public class Conexionbdd
    {
        string cadena = "Data Source = 192.168.0.100; Database=u11; User Id = u11; Password=u11";

        public SqlConnection conectarbdd = new SqlConnection();

        public Conexionbdd()
        {
            conectarbdd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarbdd.Open();
                Console.WriteLine("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar con la BDD: {ex.Message}");
            }
        }
        public void EliminarAlumno(int matricula) 
        {
            using (SqlCommand command = new SqlCommand("SP_EliminarAlumno", conectarbdd))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@matricula", matricula);
                try
                {
                    abrir();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Alumno Eliminado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al Eliminar el alumno: {ex.Message}");
                }
                finally
                {
                    cerrar();
                }
            }
        }
        public void ActualizarAlumno(int matricula, string nombre, string apellido, string direccionCalle, int direccionNumero, string telefono, string dni, string email, DateTime fechaNacimiento, int idCarrera)
        {
            using (SqlCommand command = new SqlCommand("SP_ActualizarAlumno", conectarbdd))
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

                try
                {
                    abrir();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Alumno Actualizado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al Actualizar el alumno: {ex.Message}");
                }
                finally
                {
                    cerrar();
                }
            }
        }

        public void CargarAlumno(string nombre, string apellido, string direccionCalle, int direccionNumero, string telefono, string dni, string email, DateTime fechaNacimiento, int idCarrera)
        {
            using (SqlCommand command = new SqlCommand("SP_CargarAlumno", conectarbdd))
            {
                command.CommandType = CommandType.StoredProcedure;

               
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@DireccionCalle", direccionCalle);
                command.Parameters.AddWithValue("@DireccionNumero", direccionNumero);
                command.Parameters.AddWithValue("@Telefono", telefono);
                command.Parameters.AddWithValue("@DNI", dni);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                command.Parameters.AddWithValue("@IdCarrera", idCarrera);

                try
                {
                    abrir(); 
                    command.ExecuteNonQuery();
                    MessageBox.Show("Alumno cargado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el alumno: {ex.Message}");
                }
                finally
                {
                    cerrar(); 
                }
            }
        }

        public void CargarEmpleado(string nombre, string apellido, string direccionCalle, int direccionNumero, string telefono, string dni, string email, DateTime fechaNacimiento, int salario, int tipoPerfil)
        {
            using (SqlCommand command = new SqlCommand("SP_AgregarEmpleado", conectarbdd))
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
                    abrir();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Empleado cargado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el empleado: {ex.Message}");
                }
                finally
                {
                    cerrar();
                }
            }
        }

        public void ModificarEmpleado(int idEmpleado, string nombre, string apellido, string direccionCalle, int direccionNumero, string telefono, string dni, string email, DateTime fechaNacimiento, int salario, int tipoPerfil)
        {
            using (SqlCommand command = new SqlCommand("SP_ModificarEmpleado", conectarbdd))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Añadir parámetros al comando
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
                    abrir(); // Abre la conexión
                    command.ExecuteNonQuery(); // Ejecuta el comando
                    MessageBox.Show("Empleado modificado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar el empleado: {ex.Message}"); // Manejo de errores
                }
                finally
                {
                    cerrar(); // Cierra la conexión
                }
            }
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            using (SqlCommand command = new SqlCommand("SP_EliminarEmpleado", conectarbdd))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Añadir el parámetro al comando
                command.Parameters.AddWithValue("@Id_Empleado", idEmpleado);

                try
                {
                    abrir(); // Abre la conexión
                    command.ExecuteNonQuery(); // Ejecuta el comando
                    MessageBox.Show("Empleado eliminado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el empleado: {ex.Message}"); // Manejo de errores
                }
                finally
                {
                    cerrar(); // Cierra la conexión
                }
            }
        }


        public void cerrar()
        {
            conectarbdd.Close();
        }
    }
}