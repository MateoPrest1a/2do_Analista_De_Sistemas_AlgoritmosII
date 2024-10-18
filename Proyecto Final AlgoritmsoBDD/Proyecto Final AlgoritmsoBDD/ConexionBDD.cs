using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Final
{
    public class Conexionbdd
    {
        //string cadena = @"Data Source= DESKTOP-D5URBLB\SQLEXPRESS01; Initial Catalog= Proyecto_Hilet; Integrated Security=True;"; //Cadena Casa


        string cadena = "Data Source=192.168.0.100,1433; Initial Catalog=u11; User Id=u11; Password=u11";


        public SqlConnection conectarbdd = new SqlConnection();

        public Conexionbdd()
        {
            conectarbdd.ConnectionString = cadena;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(cadena);
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
            using (SqlCommand command = new SqlCommand("SP_AgregarAlumno", conectarbdd))
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
                command.Parameters.AddWithValue("@id_carrera", 2);

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

        public void CargarCarrera(string nombreCarrera, int numResolucion, int anioPlanEstudio)
        {
            using (SqlCommand command = new SqlCommand("SP_AgregarCarrera", conectarbdd))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                command.Parameters.AddWithValue("@nombre_carrera", nombreCarrera);
                command.Parameters.AddWithValue("@num_resolucion", numResolucion);
                command.Parameters.AddWithValue("@anio_plan_estudio", anioPlanEstudio);

                try
                {
                    abrir(); // Abre la conexión a la base de datos
                    command.ExecuteNonQuery(); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Carrera cargada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la carrera: {ex.Message}");
                }
                finally
                {
                    cerrar(); // Cierra la conexión
                }
            }
        }

        public void ModificarCarrera(int idCarrera, string nombreCarrera, int numResolucion, int anioPlanEstudio)
        {
            using (SqlCommand command = new SqlCommand("SP_ModificarCarrera", conectarbdd))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                command.Parameters.AddWithValue("@id_carrera", idCarrera);
                command.Parameters.AddWithValue("@nombre_carrera", nombreCarrera);
                command.Parameters.AddWithValue("@num_resolucion", numResolucion);
                command.Parameters.AddWithValue("@anio_plan_estudio", anioPlanEstudio);

                try
                {
                    abrir(); // Abre la conexión a la base de datos
                    command.ExecuteNonQuery(); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Carrera modificada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar la carrera: {ex.Message}");
                }
                finally
                {
                    cerrar(); // Cierra la conexión
                }
            }
        }

        public void EliminarCarrera(int idCarrera)
        {
            using (SqlCommand command = new SqlCommand("SP_EliminarCarrera", conectarbdd))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar el parámetro
                command.Parameters.AddWithValue("@id_carrera", idCarrera);

                try
                {
                    abrir(); // Abre la conexión a la base de datos
                    command.ExecuteNonQuery(); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Carrera eliminada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la carrera: {ex.Message}");
                }
                finally
                {
                    cerrar(); // Cierra la conexión
                }
            }
        }


        //Cargar Materias
        public void CargarMateria(int anioCursada, string nombreMateria)
        {
            using (SqlCommand command = new SqlCommand("SP_AgregarMateria", conectarbdd))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                command.Parameters.AddWithValue("@anio_cursada", anioCursada);
                command.Parameters.AddWithValue("@nombre_materia", nombreMateria);

                try
                {
                    abrir(); // Abre la conexión a la base de datos
                    command.ExecuteNonQuery(); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Materia cargada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la materia: {ex.Message}");
                }
                finally
                {
                    cerrar(); // Cierra la conexión
                }
            }
        }

        //Modificar carreras
        public void ModificarMateria(int idMateria, int anioCursada, string nombreMateria)
        {
            using (SqlCommand command = new SqlCommand("SP_ActualizarMateria", conectarbdd))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros
                command.Parameters.AddWithValue("@id_materia", idMateria);
                command.Parameters.AddWithValue("@anio_cursada", anioCursada);
                command.Parameters.AddWithValue("@nombre_materia", nombreMateria);

                try
                {
                    abrir(); // Abre la conexión a la base de datos
                    command.ExecuteNonQuery(); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Materia modificada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar la materia: {ex.Message}");
                }
                finally
                {
                    cerrar(); // Cierra la conexión
                }
            }
        }


        //Eliminar Carreras

        public void EliminarMateria(int idMateria)
        {
            using (SqlCommand command = new SqlCommand("SP_EliminarMateria", conectarbdd))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Agregar el parámetro
                command.Parameters.AddWithValue("@id_materia", idMateria);

                try
                {
                    abrir(); // Abre la conexión a la base de datos
                    command.ExecuteNonQuery(); // Ejecuta el procedimiento almacenado
                    MessageBox.Show("Materia eliminada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar la materia: {ex.Message}");
                }
                finally
                {
                    cerrar(); // Cierra la conexión
                }
            }
        }


        //Cargar Examenes
        public void CargarExamen(int idCarrera, int idMateria, string horaExamen, DateTime fechaExamen, int tipoExamen, int libro, int folio)
        {
            using (SqlCommand command = new SqlCommand("SP_AgregarExamen", conectarbdd))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id_carrera", idCarrera);
                command.Parameters.AddWithValue("@id_materia", idMateria);
                command.Parameters.AddWithValue("@hora_examen", horaExamen);
                command.Parameters.AddWithValue("@fecha_examen", fechaExamen);
                command.Parameters.AddWithValue("@tipo_examen", tipoExamen);
                command.Parameters.AddWithValue("@libro", libro);
                command.Parameters.AddWithValue("@folio", folio);

                try
                {
                    abrir();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Examen cargado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el examen: {ex.Message}");
                }
                finally
                {
                    cerrar();
                }
            }
        }


        //Eliminar Examenes
        public void EliminarExamen(int idExamen)
        {
            using (SqlCommand command = new SqlCommand("SP_EliminarExamen", conectarbdd))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id_examen", idExamen);
                try
                {
                    abrir();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Examen eliminado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el examen: {ex.Message}");
                }
                finally
                {
                    cerrar();
                }
            }
        }


        //Modificar Examenes

        public void ActualizarExamen(int idExamen, int idCarrera, int idMateria, string horaExamen, DateTime fechaExamen, int tipoExamen, int libro, int folio)
        {
            using (SqlCommand command = new SqlCommand("SP_ActualizarExamen", conectarbdd))
            {
                command.CommandType = CommandType.StoredProcedure;

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
                    abrir();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Examen actualizado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el examen: {ex.Message}");
                }
                finally
                {
                    cerrar();
                }
            }
        }



        public void cerrar()
        {
            conectarbdd.Close();
        }
    }
}