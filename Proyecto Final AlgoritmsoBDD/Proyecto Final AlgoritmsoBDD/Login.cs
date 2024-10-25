using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private string ObtenerNombreUsuario(string usuario)
        {
            string nombre = txtUsuario.Text;
            string connectionString = ""; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT nombre_usuario FROM PerfilxAlumno WHERE nombre_usuario = @Usuario";
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    
                    if (result != null)
                    {
                        nombre = "Not Found";
                    }
                }
            }

            return nombre;
        }

        private string ObtenerPerfilDeUsuario(string usuario, string contrasena)
        {
            string perfil = string.Empty;
            string connectionString = "tu_cadena_de_conexion"; // Reemplaza con tu cadena de conexión

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT p.tipo FROM Perfiles as p WHERE Nombre = @Usuario AND Contrasena = @Contrasena"; // Ajusta según tu tabla

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);

                    connection.Open();
                    object result = command.ExecuteScalar(); // Ejecuta la consulta

                    if (result != null)
                    {
                        perfil = result.ToString(); // Obtiene el perfil del usuario
                    }
                }
            }

            return perfil; // Devuelve el perfil o una cadena vacía si no se encontró
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            //string NameUser = ObtenerNombreUsuario(txtUsuario.Text);

            DiseñoFinal.DiseñoFinalCodigo frm2 = new DiseñoFinal.DiseñoFinalCodigo();
            frm2.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
