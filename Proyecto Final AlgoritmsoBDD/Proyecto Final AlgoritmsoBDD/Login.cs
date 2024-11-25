using DiseñoFinal;
using Proyecto_Final;
using System;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class Login : Form
    {
        private ClaseGestorBase gestor = new ClaseGestorBase();


        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            
            Conexionbdd.ObtenerInstancia().Abrir(); // Abre la conexión al iniciar el formulario
        }

        private void AbrirFormularioModal(string nombre, string apellido, string perfil, int idPerfil)
        {
            // Crea una instancia del formulario modal y le pasa los datos
            DiseñoFinalCodigo formulario = new DiseñoFinalCodigo(nombre, apellido, perfil, idPerfil);

            // Muestra el formulario modal
            formulario.ShowDialog();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = checkBox1.Checked ? '\0' : '*';    // Oculta Contraseña
        }


        private string ObtenerPerfilDeUsuario(string usuario, string contrasena)
        {
            try
            {
                string nombre = string.Empty;
                string apellido = string.Empty;
                string perfil = string.Empty;
                int idPerfil = -1;  // Usaremos este valor para el ID de perfil

                string query = @" 
                                -- Caso especial para el administrador
                                SELECT 
                                    'Administrador' AS tipo,
                                    'Admin' AS nombre,
                                    '' AS apellido,
                                    0 AS id_perfil  -- Uso 0 como ID ficticio para el administrador
                                WHERE
                                    @Usuario = 'admin' AND @Contrasena = 'admin'

                                UNION ALL

                                -- Para obtener el perfil de un empleado (profesor, administrativo, etc.)
                                SELECT 
                                    p.tipo,  -- Tipo de perfil (Profesor, Personal Administrativo)
                                    e.nombre,
                                    e.apellido,
                                    e.id_empleado AS id_perfil  -- Devolvemos el id_empleado para el personal
                                FROM 
                                    Perfiles AS p
                                JOIN 
                                    PerfilxPersona AS pp ON pp.nombre_usuario = @Usuario AND pp.contrasenia = @Contrasena
                                JOIN 
                                    Empleados AS e ON e.id_empleado = pp.id_empleado
                                WHERE 
                                    pp.nombre_usuario = @Usuario AND pp.contrasenia = @Contrasena
                                    AND p.id_perfil = e.tipo_perfil  -- Relación entre el tipo de perfil en Empleados y Perfiles

                                UNION ALL

                                -- Para obtener el perfil de un alumno
                                SELECT 
                                    'Alumno' AS tipo,
                                    a.nombre,
                                    a.apellido,
                                    pa.matricula AS id_perfil-- Devolvemos la matricula como id_perfil desde PerfilxAlumno
                                FROM
                                    Perfiles AS p
                                JOIN
                                    PerfilxAlumno AS pa ON pa.nombre_usuario = @Usuario AND pa.contrasenia = @Contrasena
                                JOIN
                                    Alumnos AS a ON a.matricula = pa.matricula
                                WHERE
                                    pa.nombre_usuario = @Usuario AND pa.contrasenia = @Contrasena";


                using (SqlCommand command = new SqlCommand(query))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);

                    // Ejecutamos la consulta
                    var result = gestor.EjecutarConsulta(command);

                    if (result.Rows.Count > 0)
                    {
                        // Obtén los datos de la primera fila
                        perfil = result.Rows[0]["tipo"].ToString();
                        nombre = result.Rows[0]["nombre"].ToString();
                        apellido = result.Rows[0]["apellido"].ToString();
                        idPerfil = Convert.ToInt32(result.Rows[0]["id_perfil"]);

                        AbrirFormularioModal(nombre,apellido,perfil,idPerfil);
                    }
                    else
                    {
                        // Si no hay resultados, significa que no hay coincidencias
                        MessageBox.Show("Usuario o Contraseña incorrectos");
                        return string.Empty; // No hay perfil encontrado
                    }
                }

                return perfil;
            }
            catch (Exception ex)
            {
                // Captura cualquier error y muestra un mensaje
                MessageBox.Show($"Error: {ex.Message}");
                return string.Empty; // En caso de error
            }
        }



        private void btnAcceder_Click(object sender, EventArgs e)
        {           
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;

            // Validar el usuario y la contraseña
            ObtenerPerfilDeUsuario(usuario, contrasena);

        }



        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conexionbdd.ObtenerInstancia().Cerrar(); // Cerrar conexión al cerrar el formulario
        }
    }
}
