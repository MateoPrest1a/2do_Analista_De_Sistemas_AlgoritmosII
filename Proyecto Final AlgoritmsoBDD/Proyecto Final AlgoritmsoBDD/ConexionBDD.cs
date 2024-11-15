using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public class Conexionbdd
    {
        private static Conexionbdd _instancia; //Instancia unica para garantizar una unica conexion y no instanciar la clase en cada formulario (patron Singleton).
        private SqlConnection _conexion;

        //private string cadena = "Data Source=192.168.0.100; Database=u11; User Id=u11; Password=u11";

        private string cadena = @"Data Source=DESKTOP-D5URBLB\SQLEXPRESS01; Initial Catalog=Proyecto_Hilet; Integrated Security=True;"; // Cadena de conexión

        private Conexionbdd()   //Constructor privado para evitar instancias de la clase.
        {
            _conexion = new SqlConnection(cadena);
        }

        public static Conexionbdd ObtenerInstancia()
        {
            if (_instancia == null) //Si la instancia no existe la crea y si existe utiliza la ya creada
            {
                _instancia = new Conexionbdd();
            }
            return _instancia;
        }

        public SqlConnection ObtenerConexion()  //Metodo para obtener la conexion desde cualquier parte del programa y poder realizar consultas
        {
            return _conexion;
        }

        public void Abrir()
        {
            try
            {
                if (_conexion.State == ConnectionState.Closed)  //Verifico que este cerrada antes de abrirla
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
            if (_conexion != null && _conexion.State == ConnectionState.Open)   //Verifico que este abierta antes de cerrarla.
            {
                _conexion.Close();
                Console.WriteLine("Conexión cerrada");
            }
        }
    }
}