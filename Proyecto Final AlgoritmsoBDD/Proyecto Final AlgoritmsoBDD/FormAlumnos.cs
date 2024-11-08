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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class FormAlumnos : Form
    {


        private ClaseGestorAlumnos gestorAlumnos = new ClaseGestorAlumnos(); // Instancia de la clase gestora

        public FormAlumnos()
        {
            InitializeComponent();
        }

        public void Cargar_Tabla()
        {
            string consulta = "SELECT * FROM Alumnos WHERE baja = 0";
            SqlCommand command = new SqlCommand(consulta);

            try
            {
                DataTable dt = gestorAlumnos.EjecutarConsulta(command); // Usa la clase gestora para ejecutar la consulta
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Manejar excepciones, por ejemplo, mostrar un mensaje de error
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCarreraAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAlumnos_Load(object sender, EventArgs e)
        {
            Cargar_Tabla();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int matricula = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Matricula"].Value);
                    string nombre = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    string apellido = dataGridView1.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                    string direcalle = dataGridView1.Rows[e.RowIndex].Cells["direccion_calle"].Value.ToString();
                    string direnum = dataGridView1.Rows[e.RowIndex].Cells["direccion_numero"].Value.ToString();
                    string telefono = dataGridView1.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                    string documento = dataGridView1.Rows[e.RowIndex].Cells["dni"].Value.ToString();
                    string email = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    DateTime fechaNacimiento = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["fecha_nacimiento"].Value);
                    int idcarrera = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_carrera"].Value);

                    FormAlumnosModal formalumnosmodal = new FormAlumnosModal(matricula, nombre, apellido, direcalle, direnum, telefono, documento, email, fechaNacimiento, idcarrera);
                    formalumnosmodal.AlumnoEvento += ActualizarDataGridView;
                    formalumnosmodal.ShowDialog();
                }
                catch
                {
                    int matricula = 0;
                    string nombre = "";
                    string apellido = "";
                    string direcalle = "";
                    string direnum = "";
                    string telefono = "";
                    string documento = "";
                    string email = "";
                    DateTime fechaNacimiento = DateTime.Now;
                    int carrera = 0;

                    FormAlumnosModal formalumnosmodal = new FormAlumnosModal(matricula, nombre, apellido, direcalle, direnum, telefono, documento, email, fechaNacimiento, carrera);
                    formalumnosmodal.AlumnoEvento += ActualizarDataGridView;  //Me suscribo al evento para que se actualice al agregar un alumno
                    formalumnosmodal.ShowDialog();
                }


            }
        }

        private void ActualizarDataGridView()
        {
            Cargar_Tabla();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
