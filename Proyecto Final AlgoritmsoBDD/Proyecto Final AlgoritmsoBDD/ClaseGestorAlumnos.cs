using System;
using System.Data;
using System.Data.SqlClient;
using System.Numerics;
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

        //Buscar el alumno por matricula
        public DataTable ObtenerDatosAlumno(int matricula)
        {
            string query = @"
                            SELECT 
                                a.nombre, 
                                a.apellido, 
                                a.direccion_calle, 
                                a.direccion_numero, 
                                a.telefono, 
                                a.dni, 
                                a.email, 
                                a.fecha_nacimiento, 
                                a.id_carrera, 
                                a.año
                            FROM 
                                Alumnos AS a
                            WHERE 
                                a.matricula = @Matricula";

            using (SqlCommand command = new SqlCommand(query))
            {
                command.Parameters.AddWithValue("@Matricula", matricula);
                return EjecutarConsulta(command);
            }
        }



        // Filtros

        //Metodo para buscar por nombre y apellido
        public DataTable BuscarAlumno(string nombreApellido)
        {
            using (SqlCommand command = new SqlCommand("SP_BuscarAlumnoPorNombreApellido"))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@NombreApellido", nombreApellido);

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


        //Metodo Buscar por año
        public DataTable CargarAlumnosPorAño(int año)
        {
            string consulta = "SP_FiltrarAlumnosPorAño";

            SqlCommand command = new SqlCommand(consulta);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Año", año);

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


        public DataTable CargarAlumnosPorCarrera(int idCarrera)
        {
            string consulta = "SP_FiltrarAlumnosPorCarrera";

            SqlCommand command = new SqlCommand(consulta);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@IdCarrera", idCarrera);

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

        // Filtro profesores
        public DataTable CargarAlumnosPorProfesor(int idEmpleado)
        {
            string consulta = @"
                                SELECT 
                                    a.matricula, a.nombre, a.apellido
                                FROM 
                                    Alumnos a
                                INNER JOIN 
                                    MateriasxAlumno ma ON a.matricula = ma.matricula
                                INNER JOIN 
                                    Materias m ON ma.id_materia = m.id_materia
                                WHERE m.id_empleado = @idEmpleado";

            SqlCommand command = new SqlCommand(consulta);
            command.Parameters.AddWithValue("@idEmpleado", idEmpleado);

            return EjecutarConsulta(command); // Método para ejecutar la consulta
        }
    }
}