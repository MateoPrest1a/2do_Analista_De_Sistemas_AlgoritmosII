using Proyecto_Final;
using Proyecto_Final_AlgoritmsoBDD;
using System.Data.SqlClient;

namespace DiseñoFinal
{
    public partial class DiseñoFinalCodigo : Form
    {
        Conexionbdd conectar;


        public DiseñoFinalCodigo()
        {
            InitializeComponent();
            conectar = new Conexionbdd();
        }

        private void CargarLabel()
        {
            string connectionString = "";
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

        private void btnExamenesAlumnos_Click(object sender, EventArgs e)
        {

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
    }
}
