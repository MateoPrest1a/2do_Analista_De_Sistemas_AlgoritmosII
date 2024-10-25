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

        }

        private void btnABMCarreras_Click(object sender, EventArgs e)
        {

        }

        private void btnABMMaterias_Click(object sender, EventArgs e)
        {

        }

        private void btnABMPerfiles_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
