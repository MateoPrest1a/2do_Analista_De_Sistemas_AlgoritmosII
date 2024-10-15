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
    public partial class FormEmpleados : Form
    {
        Conexionbdd conectarBDD;
        public FormEmpleados()
        {
            InitializeComponent();
            conectarBDD = new Conexionbdd();
        }

        public void Cargar_Tabla()
        {
            string consulta = "SELECT * FROM Empleados";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectarBDD.conectarbdd);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
            finally
            {
                conectarBDD.cerrar();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            Cargar_Tabla();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int idprofesor = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_empleado"].Value);
                    string nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                    string apellido = dataGridView1.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
                    string direcalle = dataGridView1.Rows[e.RowIndex].Cells["direccion_calle"].Value.ToString();
                    int direnum = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["direccion_nro"].Value);
                    string telefono = dataGridView1.Rows[e.RowIndex].Cells["Telefono"].Value?.ToString();
                    string documento = dataGridView1.Rows[e.RowIndex].Cells["dni"].Value?.ToString();
                    string email = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value?.ToString();
                    DateTime fechaNacimiento = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["fecha_nacimiento"].Value);
                    int salario = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Salario"].Value);
                    int especialidad = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Tipo_Perfil"].Value);



                    FormEmpleadosModal formempleadosmodal = new FormEmpleadosModal(idprofesor, nombre, apellido, direcalle, direnum, telefono, documento, email, fechaNacimiento, salario, especialidad);
                    formempleadosmodal.EmpleadoEvento += FormAgregar_EmpleadoEvento;
                    formempleadosmodal.ShowDialog();
                }
                catch
                {
                    int idprofesor = 0;
                    string nombre = "";
                    string apellido = "";
                    string direcalle = "";
                    int direnum = 0;
                    string telefono = "";
                    string documento = "";
                    string email = "";
                    DateTime fechaNacimiento = DateTime.Now;
                    int salario = 0;
                    int especialidad = 1;

                    FormEmpleadosModal formempleadosmodal = new FormEmpleadosModal(idprofesor, nombre, apellido, direcalle, direnum, telefono, documento, email, fechaNacimiento, salario, especialidad);
                    formempleadosmodal.EmpleadoEvento += FormAgregar_EmpleadoEvento;
                    formempleadosmodal.ShowDialog();
                }

            }
        }

        private void FormAgregar_EmpleadoEvento()
        {
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {

            string consulta = "SELECT * FROM Empleados";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectarBDD.conectarbdd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FormAgregar_EmpleadoAgregado()
        {
            ActualizarDataGridView(); // Actualizar el DataGridView
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
