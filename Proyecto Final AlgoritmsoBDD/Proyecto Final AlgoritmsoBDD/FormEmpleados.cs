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
        private GestorEmpleados gestorEmpleados = new GestorEmpleados(); // Instancia de la clase gestora
        public FormEmpleados()
        {
            InitializeComponent();
            CargarEspecialidades();
            Cargar_Filtros();
        }
        private void Cargar_Filtros()
        {
            cmbFiltros.Items.Clear();
            cmbFiltros.Items.Add("Nombre y Apellido");
            cmbFiltros.Items.Add("Especialidad");
            cmbFiltros.Items.Add("Carrera");
            cmbFiltros.Items.Add("Dni");
        }
        private void CargarEspecialidades()
        {
            var especialidades = new List<Especialidad>
            {
                new Especialidad { IdEspecialidad = 1, especialidad = "Profesor" },
                new Especialidad { IdEspecialidad = 2, especialidad = "Personal Administrativo" }
            };

            cmbEspecialidad.DataSource = especialidades;
            cmbEspecialidad.DisplayMember = "Especialidad";  // Lo que se muestra en el ComboBox
            cmbEspecialidad.ValueMember = "IdEspecialidad"; // El valor que necesitas
        }
        public void Cargar_Tabla()
        {
            string consulta = "SELECT * FROM Empleados";
            SqlCommand command = new SqlCommand(consulta);

            try
            {
                DataTable dt = gestorEmpleados.EjecutarConsulta(command); // Usa la clase gestora para ejecutar la consulta
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
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
            Cargar_Tabla();
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

        private void cmbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreApellido.Visible = false;
            cmbCarrera.Visible = false;
            txtDni.Visible = false;
            cmbEspecialidad.Visible = false;

            // Muestra el control correspondiente según la selección.
            switch (cmbFiltros.SelectedItem.ToString())
            {
                case "Nombre y Apellido":
                    txtNombreApellido.Visible = true;
                    break;
                case "Carrera":
                    cmbCarrera.Visible = true;
                    break;
                case "Especialidad":
                    cmbEspecialidad.Visible = true;
                    break;
                case "Dni":
                    txtDni.Visible = true;
                    break;
            }
        }
        private void Filtrar_tablaEspecialidad()
        {

            string consulta = "SELECT * FROM Empleados";
            SqlCommand command = new SqlCommand(consulta);

            try
            {
                DataTable dt = gestorEmpleados.EjecutarConsulta(command); // Usa la clase gestora para ejecutar la consulta
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }
    }
}
