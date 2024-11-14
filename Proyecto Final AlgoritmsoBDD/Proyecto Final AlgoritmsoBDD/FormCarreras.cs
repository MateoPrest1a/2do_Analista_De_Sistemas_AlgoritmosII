using Proyecto_Final;
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

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class FormCarreras : Form
    {

        public event Action<string> CarreraAgregada;

        private GestorCarreras gestorCarreras = new GestorCarreras(); // Instancia de la clase gestora


        public FormCarreras()
        {
            InitializeComponent();
        }

        public void Cargar_Tabla()
        {
            string consulta = "SELECT * FROM Carreras";
            SqlCommand command = new SqlCommand(consulta);

            try
            {
                DataTable dt = gestorCarreras.EjecutarConsulta(command); // Usa la clase gestora para ejecutar la consulta
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Manejar excepciones, por ejemplo, mostrar un mensaje de error
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }

        private void FormCarreras_Load(object sender, EventArgs e)
        {
            Cargar_Tabla();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int idcarrera = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_carrera"].Value);
                    string carrera = dataGridView1.Rows[e.RowIndex].Cells["nombre_carrera"].Value.ToString();
                    int resolucion = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["num_resolucion"].Value);
                    int añoplan = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["anio_plan_estudio"].Value);

                    FormCarrerasModal formcarrerasmodal = new FormCarrerasModal(idcarrera, carrera, resolucion, añoplan);
                    formcarrerasmodal.CarreraEvento += ActualizarDataGridView;
                    formcarrerasmodal.ShowDialog();
                }
                catch
                {
                    int idcarrera = 0;
                    string carrera = "";
                    int resolucion = 0;
                    int añoplan = 0;

                    FormCarrerasModal formcarrerasmodal = new FormCarrerasModal(idcarrera, carrera, resolucion, añoplan);
                    formcarrerasmodal.CarreraEvento += ActualizarDataGridView;
                    formcarrerasmodal.ShowDialog();
                }
            }
        }

        private void ActualizarDataGridView()
        {
            Cargar_Tabla();
        }
    }
}
