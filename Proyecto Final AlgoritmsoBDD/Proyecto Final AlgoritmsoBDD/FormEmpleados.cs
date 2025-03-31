using Proyecto_Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

        string Perfil; //Para determinar que podra ver dependiendo cada perfil
        public FormEmpleados(string perfil)
        {
            InitializeComponent();
            CargarEspecialidades();
            Cargar_Filtros();
            Perfil = perfil;
        }
        private void Cargar_Filtros()
        {
            cmbFiltros.Items.Clear();
            cmbFiltros.Items.Add("Nombre"); //no se llego :(

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
                    string direnum = dataGridView1.Rows[e.RowIndex].Cells["direccion_nro"].ToString();
                    string telefono = dataGridView1.Rows[e.RowIndex].Cells["Telefono"].Value?.ToString();
                    string documento = dataGridView1.Rows[e.RowIndex].Cells["dni"].Value?.ToString();
                    string email = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value?.ToString();
                    DateTime fechaNacimiento = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["fecha_nacimiento"].Value);
                    int salario = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Salario"].Value);
                    int especialidad = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Tipo_Perfil"].Value);



                    FormEmpleadosModal formempleadosmodal = new FormEmpleadosModal(idprofesor, nombre, apellido, direcalle, direnum, telefono, documento, email, fechaNacimiento, salario, especialidad, Perfil);
                    formempleadosmodal.EmpleadoEvento += FormAgregar_EmpleadoEvento;
                    formempleadosmodal.ShowDialog();
                }
                catch
                {
                    int idprofesor = 0;
                    string nombre = "";
                    string apellido = "";
                    string direcalle = "";
                    string direnum = "";
                    string telefono = "";
                    string documento = "";
                    string email = "";
                    DateTime fechaNacimiento = DateTime.Now;
                    int salario = 0;
                    int especialidad = 1;

                    FormEmpleadosModal formempleadosmodal = new FormEmpleadosModal(idprofesor, nombre, apellido, direcalle, direnum, telefono, documento, email, fechaNacimiento, salario, especialidad, Perfil);
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


        public void Cargar_Tabla_PorNombre(string nombre)
        {

            string consulta = "SELECT * FROM Empleados WHERE nombre = @nombre";
            SqlCommand command = new SqlCommand(consulta);
            command.Parameters.AddWithValue("@nombre", nombre);
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

        private void cmbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreApellido.Visible = false;
            

            // Muestra el control correspondiente según la selección.
            switch (cmbFiltros.SelectedItem.ToString())
            {
                case "Nombre":
                    txtNombreApellido.Visible = true;
                    break;                     
            }
        }
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtNombreApellido.Visible)
            {
                string nombre = txtNombreApellido.Text;
                Cargar_Tabla_PorNombre(nombre);
            }
        }
    }
}
