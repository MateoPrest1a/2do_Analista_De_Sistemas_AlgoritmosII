using System;
using System.Data;
using System.Data.SqlClient;
using static Proyecto_Final_AlgoritmsoBDD.FormAlumnosModal;
using static Proyecto_Final_AlgoritmsoBDD.FormExamenesModal;

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
    }
}