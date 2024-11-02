using Proyecto_Final;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class Login : Form
    {
        private ClaseGestorBase gestor;

        public Login()
        {
            InitializeComponent();
            gestor = new ClaseGestorBase();
            Conexionbdd.ObtenerInstancia().Abrir(); // Abre la conexión al iniciar el formulario
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = checkBox1.Checked ? '\0' : '*';    // Oculta Contraseña
        }

        private string ObtenerNombreUsuario(string usuario)
        {
            string nombre = string.Empty;
            string query = @"SELECT 
                                nombre_usuario 
                             FROM
                                PerfilxAlumno 
                            WHERE 
                                nombre_usuario = @Usuario";

            using (SqlCommand command = new SqlCommand(query))
            {
                command.Parameters.AddWithValue("@Usuario", usuario);
                nombre = gestor.EjecutarConsulta(command).Rows.Count > 0 ? usuario : "Not Found";
            }

            return nombre;
        }

        private string ObtenerPerfilDeUsuario(string usuario, string contrasena)
        {
            string perfil = string.Empty;
            string query = @"SELECT 
                                p.tipo 
                            FROM 
                                Perfiles as p 
                            WHERE 
                                Nombre = @Usuario AND Contrasena = @Contrasena"; 

            using (SqlCommand command = new SqlCommand(query))
            {
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contrasena", contrasena);

                var result = gestor.EjecutarConsulta(command);
                if (result.Rows.Count > 0)
                {
                    perfil = result.Rows[0]["tipo"].ToString(); // Obtiene el tipo de perfil del usuario
                }
            }

            return perfil;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string perfil = "kjsadkjas";
            /*
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;

            // Validar el usuario y la contraseña
            string perfil = ObtenerPerfilDeUsuario(usuario, contrasena);

            */
            if (!string.IsNullOrEmpty(perfil))
            {
                // Abre el siguiente formulario
                DiseñoFinal.DiseñoFinalCodigo frm2 = new DiseñoFinal.DiseñoFinalCodigo();
                frm2.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Conexionbdd.ObtenerInstancia().Cerrar(); // Cerrar conexión al cerrar el formulario
        }
    }
}
