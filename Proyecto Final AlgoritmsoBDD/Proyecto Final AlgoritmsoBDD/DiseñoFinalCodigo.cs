using Proyecto_Final;
using Proyecto_Final_AlgoritmsoBDD;
using System.Data.SqlClient;

namespace DiseñoFinal
{
    public partial class DiseñoFinalCodigo : Form
    {
        Conexionbdd conectar;

        int Id_Persona = 0;

        public DiseñoFinalCodigo(string nombre, string apellido, string perfil, int idPerfil)
        {
            InitializeComponent();
            lblUsuario.Text = nombre + " " + apellido;
            lblPerfil.Text = perfil;
            Id_Persona = idPerfil;
            lblUsuarioAlumno.Text = nombre + " " + apellido;
            lblPerfilAlumno.Text = perfil;


            AjustarVisibilidadPerfil(perfil);
        }

        private void AjustarVisibilidadPerfil(string perfil)
        {

            if (perfil == "Alumno")
            {
                btnExamenesAlumnos.Visible = true;
                btnDatosAlumnos.Visible = true;
                tabControl1.TabPages.RemoveAt(0); //Borro la primer tabpage ya que es solo para administradores o profesores
                tabControl1.TabPages.RemoveAt(1); //Borro la tercer tabpage que es la de los profesores

            }
            else if (perfil == "Profesor")
            {
                tabControl1.TabPages.RemoveAt(1);
            }
            else if (perfil == "Personal Administrativo")
            {
                tabControl1.TabPages.RemoveAt(1);
            }
        }


        private void BtnABMAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void btnABMEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados formempleados = new FormEmpleados();
            formempleados.ShowDialog();
        }

        private void btnABMPermisos_Click(object sender, EventArgs e)
        {

        }

        private void btnABMProfesores_Click(object sender, EventArgs e)
        {

        }

        private void btnABMMaterias_Click(object sender, EventArgs e)
        {
            FormMaterias formmaterias = new FormMaterias();
            formmaterias.ShowDialog();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnABMAlumnos_Click_1(object sender, EventArgs e)
        {
            FormAlumnos formalumnos = new FormAlumnos();
            formalumnos.ShowDialog();
        }



        private void btnExamenesProfesor_Click(object sender, EventArgs e)
        {
            FormExamenes formexamenes = new FormExamenes();
            formexamenes.ShowDialog();
        }

        private void btnCarrerasProfesor_Click(object sender, EventArgs e)
        {
            FormCarreras formcarreras = new FormCarreras();
            formcarreras.ShowDialog();
        }

        //Botones para el Alumno

        //Funcion Buscar Alumno
        public void CargarDatosAlumno(int matricula)
        {
            ClaseGestorAlumnos gestorAlumnos = new ClaseGestorAlumnos();
            var result = gestorAlumnos.ObtenerDatosAlumno(matricula);

            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                string nombre = row["nombre"].ToString();
                string apellido = row["apellido"].ToString();
                string direcalle = row["direccion_calle"].ToString();
                string direnum = row["direccion_numero"].ToString();
                string telefono = row["telefono"].ToString();
                string documento = row["dni"].ToString();
                string email = row["email"].ToString();
                DateTime fechanacimientoalumno = Convert.ToDateTime(row["fecha_nacimiento"]);
                int idcarrera = Convert.ToInt32(row["id_carrera"]);
                int año = Convert.ToInt32(row["año"]);

                // Llama al método para abrir el formulario con los datos del alumno
                FormAlumnosModal formulario = new FormAlumnosModal(matricula, nombre, apellido, direcalle, direnum, telefono, documento, email, fechanacimientoalumno, idcarrera, año);
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Alumno no encontrado");
            }
        }

        private void btnDatosAlumnos_Click(object sender, EventArgs e)
        {
            CargarDatosAlumno(Id_Persona);
        }

        private void btnExamenesAlumnos_Click(object sender, EventArgs e)
        {
            FormHistorialExamenAlumno formHistorial = new FormHistorialExamenAlumno(Id_Persona);
            formHistorial.ShowDialog();
        }

        //Materias en las que el alumno esta anotado
        private void btnMateriasAlumnos_Click(object sender, EventArgs e)
        {
            FormMateriasXAlumno formMateriasXAlumno = new FormMateriasXAlumno(Id_Persona);
            formMateriasXAlumno.ShowDialog();
        }
    }
}
