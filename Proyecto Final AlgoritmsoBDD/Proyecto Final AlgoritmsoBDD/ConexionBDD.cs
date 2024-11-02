using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public class Conexionbdd
    {
        private static Conexionbdd _instancia;
        private SqlConnection _conexion;

        //private string cadena = Cadena facultad falta

        private string cadena = @"Data Source=DESKTOP-D5URBLB\SQLEXPRESS01; Initial Catalog=Proyecto_Hilet; Integrated Security=True;"; // Cadena de conexión

        private Conexionbdd()
        {
            _conexion = new SqlConnection(cadena);
        }

        public static Conexionbdd ObtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Conexionbdd();
            }
            return _instancia;
        }

        public SqlConnection ObtenerConexion()
        {
            return _conexion;
        }

        public void Abrir()
        {
            try
            {
                if (_conexion.State == ConnectionState.Closed)
                {
                    _conexion.Open();
                    Console.WriteLine("Conexión exitosa");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
            }
        }

        public void Cerrar()
        {
            if (_conexion != null && _conexion.State == ConnectionState.Open)
            {
                _conexion.Close();
                Console.WriteLine("Conexión cerrada");
            }
        }
    }
}