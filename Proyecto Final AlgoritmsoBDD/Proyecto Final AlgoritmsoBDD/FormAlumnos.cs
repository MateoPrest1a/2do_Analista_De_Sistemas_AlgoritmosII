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

        SqlConnection conexion = Conexionbdd.ObtenerInstancia().ObtenerConexion();

        private ClaseGestorAlumnos gestorAlumnos = new ClaseGestorAlumnos(); // Instancia de la clase gestora

        string Perfil; //Para determinar que podra ver dependiendo cada perfil
        public FormAlumnos(string perfil,int idpersona)
        {
            InitializeComponent();
            Cargar_Filtros();
            CargarCarreras();

            Perfil = perfil;
        }

        private void CargarCarreras()
        {
            string query = "SELECT id_carrera, nombre_carrera FROM Carreras";

            try
            {
                // Crear el comando SQL
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    // Usar la clase gestora para ejecutar la consulta
                    DataTable cmbCarrerasTabla = gestorAlumnos.EjecutarConsulta(command);

                    // Limpia el ComboBox antes de llenarlo
                    cmbCarrera.Items.Clear();

                    foreach (DataRow row in cmbCarrerasTabla.Rows)
                    {
                        // Crear un nuevo objeto para almacenar la carrera
                        var carrera = new Carrera
                        {
                            ID_Carrera = Convert.ToInt32(row["id_carrera"]), // id_carrera
                            Nombre_Carrera = row["nombre_carrera"].ToString() // nombre_carrera
                        };

                        // Agregar la carrera al ComboBox
                        cmbCarrera.Items.Add(carrera);
                    }

                    // Configura DisplayMember y ValueMember
                    cmbCarrera.DisplayMember = "Nombre_Carrera"; // Lo que se muestra en el ComboBox
                    cmbCarrera.ValueMember = "ID_Carrera"; // El valor que se utilizará
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las carreras: {ex.Message}");
            }
        }


        //Cargo los filtros y todas sus opciones
        private void Cargar_Filtros()
        {
            cmbFiltros.Items.Clear();
            cmbFiltros.Items.Add("Nombre y Apellido");
            cmbFiltros.Items.Add("Año");
            cmbFiltros.Items.Add("Carrera");
            cmbFiltros.Items.Add("Dni");

            cmbAño.Items.Clear();
            cmbAño.Items.Add("1");
            cmbAño.Items.Add("2");
            cmbAño.Items.Add("3");
        }

        public void Cargar_Tabla()
        {
            string consulta = @"SELECT 
                                    matricula, 
                                    nombre, 
                                    apellido, 
                                    direccion_calle, 
                                    direccion_numero, 
                                    telefono, 
                                    dni, 
                                    email, 
                                    fecha_nacimiento, 
                                    id_carrera, 
                                    año 
                                FROM 
                                    Alumnos 
                                WHERE 
                                    baja = 0;";
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
                    int año = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["año"].Value);

                    FormAlumnosModal formalumnosmodal = new FormAlumnosModal(matricula, nombre, apellido, direcalle, direnum, telefono, documento, email, fechaNacimiento, idcarrera, año, Perfil);
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
                    int año = 0;

                    FormAlumnosModal formalumnosmodal = new FormAlumnosModal(matricula, nombre, apellido, direcalle, direnum, telefono, documento, email, fechaNacimiento, carrera, año, Perfil);
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



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreApellido.Visible = false;
            cmbAño.Visible = false;
            cmbCarrera.Visible = false;
            txtDni.Visible = false;

            // Muestra el control correspondiente según la selección.
            switch (cmbFiltros.SelectedItem.ToString())
            {
                case "Nombre y Apellido":
                    txtNombreApellido.Visible = true;
                    break;
                case "Año":
                    cmbAño.Visible = true;
                    break;
                case "Carrera":
                    cmbCarrera.Visible = true;
                    break;
                case "Dni":
                    txtDni.Visible = true;
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Verifica si el campo Nombre y Apellido está visible
            if (txtNombreApellido.Visible)
            {
                // Llama al método BuscarAlumno pasándole el texto de txtNombreApellido
                string nombreApellido = txtNombreApellido.Text;

                if (!string.IsNullOrEmpty(nombreApellido))
                {
                    // Llamar al método de búsqueda
                    ClaseGestorAlumnos gestorAlumnos = new ClaseGestorAlumnos();
                    DataTable resultados = gestorAlumnos.BuscarAlumno(nombreApellido);

                    if (resultados != null && resultados.Rows.Count > 0)
                    {
                        // Si se encuentran resultados, mostrar en un DataGridView
                        dataGridView1.DataSource = resultados;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron alumnos con ese nombre y apellido.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un nombre y apellido.");
                }
            }
            else
            {
                // Si no se está usando el filtro de nombre y apellido, podrías manejar los otros casos
                MessageBox.Show("Seleccione un filtro válido para buscar.");
            }
        }

        private void btnRecargarTabla_Click(object sender, EventArgs e)
        {
            Cargar_Tabla();
        }
    }
}
