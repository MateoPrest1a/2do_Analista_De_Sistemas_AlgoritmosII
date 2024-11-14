using Proyecto_Final;
using System.Data.SqlClient;
using System.Data;


// clase base para los gestores específicos como ClaseGestorAlumnos
// y utiliza la conexión proporcionada por Conexionbdd.
public class ClaseGestorBase
{
    // Variable protegida para obtener la conexion con la base de datos.
    protected SqlConnection conexion;

    public ClaseGestorBase()
    {
        conexion = Conexionbdd.ObtenerInstancia().ObtenerConexion();
    }


    public DataTable EjecutarConsulta(SqlCommand command) // Método para ejecutar una consulta SQL y devolver los resultados en un DataTable para pasarlo al DataGridvView.
    {
        DataTable dt = new DataTable();
        try
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open(); // Asegurarse de que la conexión esté abierta.
            }

            command.Connection = conexion; // Asignar la conexión al comando.
            using (SqlDataReader reader = command.ExecuteReader())
            {
                dt.Load(reader);
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error al ejecutar la consulta: {ex.Message}");
        }
        return dt; // Dejo la conexión abierta para más operaciones.
    }

    public void EjecutarComando(SqlCommand command) // Método para ejecutar un comando SQL que no devuelve resultados (INSERT, UPDATE, DELETE).
    {
        try
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open(); // Asegurarse de que la conexión esté abierta.
            }

            command.Connection = conexion; // Asignar la conexión al comando.
            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error al ejecutar el comando: {ex.Message}");
        }
        // Dejo la conexión abierta para más operaciones.
    }
}