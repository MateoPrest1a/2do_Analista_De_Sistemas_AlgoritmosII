using Proyecto_Final;
using System.Data.SqlClient;
using System.Data;


// clase base para los gestores específicos como ClaseGestorAlumnos
// y utiliza la conexión proporcionada por Conexionbdd.
public class ClaseGestorBase
{
    protected SqlConnection conexion;

    public ClaseGestorBase()
    {
        conexion = Conexionbdd.ObtenerInstancia().ObtenerConexion();
    }

    public void CerrarConexion()
    {
        // Cerrar conexión solo en el login
        // No es necesario cerrar aquí
    }

    public DataTable EjecutarConsulta(SqlCommand command)
    {
        DataTable dt = new DataTable();
        try
        {
            command.Connection = conexion; // Asignar la conexión al comando
            using (SqlDataReader reader = command.ExecuteReader())
            {
                dt.Load(reader);
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error al ejecutar la consulta: {ex.Message}");
        }
        return dt; // Dejo la conexión abierta para más operaciones
    }

    public void EjecutarComando(SqlCommand command)
    {
        try
        {
            command.Connection = conexion; // Asignar la conexión al comando
            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error al ejecutar el comando: {ex.Message}");
        }
            // Dejo la conexión abierta para más operaciones
        }
    }