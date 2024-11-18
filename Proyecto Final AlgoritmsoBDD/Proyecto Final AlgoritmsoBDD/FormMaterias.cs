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
    public partial class FormMaterias : Form
    {
        GestorMaterias GestorMaterias = new GestorMaterias();

        SqlConnection conexion = Conexionbdd.ObtenerInstancia().ObtenerConexion();

        public FormMaterias()
        {
            InitializeComponent();
        }
        private void FormMaterias_Load(object sender, EventArgs e)
        {
            CargarTabla();
            cmbFiltros.Items.Add("Carreras");
            cmbFiltros.Items.Add("Año");

            CargarCarreras();

            cmbAño.Items.Clear();
            cmbAño.Items.Add("1");
            cmbAño.Items.Add("2");
            cmbAño.Items.Add("3");
        }

        //Cargo Carreras
        private void CargarCarreras()
        {
            string query = "SELECT id_carrera, nombre_carrera FROM Carreras";

            try
            {
                // Crear el comando SQL
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    // Usar la clase gestora para ejecutar la consulta
                    DataTable cmbCarrerasTabla = GestorMaterias.EjecutarConsulta(command);

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Obtener los valores de las celdas de la fila seleccionada
                    int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                    int Año = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Año"].Value);
                    string Nombre = dataGridView1.Rows[e.RowIndex].Cells["Materia"].Value.ToString();
                    int idcarrera = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_carrera"].Value);
                    int idempleado = 0;

                    // Verificar si el profesor está asignado o no
                    var idEmpleadoCell = dataGridView1.Rows[e.RowIndex].Cells["ID_Empleado"].Value;
                    if (idEmpleadoCell != DBNull.Value)
                    {
                        idempleado = Convert.ToInt32(idEmpleadoCell);
                    }

                    // Abrir el formulario de MateriasModal con los datos correctos
                    FormMateriasModal formmateriasmodal = new FormMateriasModal(ID, Año, Nombre, idcarrera, idempleado);
                    formmateriasmodal.MateriaEvento += ActualizarDataGridView;
                    formmateriasmodal.ShowDialog();
                }
                catch
                {
                    FormMateriasModal formmateriasmodal = new FormMateriasModal(0, 0, string.Empty, 0, null);
                    formmateriasmodal.MateriaEvento += ActualizarDataGridView;
                    formmateriasmodal.ShowDialog();
                }

            }



        }

        private void CargarTabla()
        {
            string consulta = @"
                                SELECT  
                                    m.id_materia AS ID, 
                                    m.anio_cursada AS Año, 
                                    m.nombre_materia AS Materia,
                                    c.nombre_carrera AS Carrera,
                                    m.id_carrera,
                                    c.nombre_carrera,
                                    CONCAT(e.apellido, ' ', e.nombre) AS Profesor,
                                    m.id_empleado AS ID_Empleado
                                FROM 
                                    Materias AS m
                                JOIN 
                                    Carreras AS c ON m.id_carrera = c.id_carrera
                                LEFT JOIN                                               --LEFT ya que devuelve todas las materias aunque no tengan profesor
                                    Empleados AS e ON e.id_empleado = m.id_empleado";

            SqlCommand command = new SqlCommand(consulta);

            try
            {
                // Uso la clase gestora para ejecutar la consulta
                DataTable dt = GestorMaterias.EjecutarConsulta(command);


                dataGridView1.DataSource = dt;


                dataGridView1.Columns["id_carrera"].Visible = false;
                dataGridView1.Columns["ID_Empleado"].Visible = false;

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

        private void ActualizarDataGridView()
        {
            CargarTabla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Filtrar solo por Año
            if (cmbAño.Visible)
            {
                // Obtiene el valor seleccionado en el ComboBox de Año
                int añoSeleccionado = Convert.ToInt32(cmbAño.SelectedItem);

                // Verifica que el valor del año seleccionado sea válido
                if (añoSeleccionado > 0)
                {
                    // Llama al método de búsqueda con solo el filtro de Año
                    GestorMaterias gestorMaterias = new GestorMaterias();
                    DataTable resultados = gestorMaterias.FiltrarPorAño(añoSeleccionado);

                    // Verifica si se encontraron resultados
                    if (resultados != null && resultados.Rows.Count > 0)
                    {
                        // Si se encuentran resultados, mostrar en un DataGridView
                        dataGridView1.DataSource = resultados;
                        dataGridView1.Columns["id_carrera"].Visible = false;
                        dataGridView1.Columns["ID_Empleado"].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron materias para el año seleccionado.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un año válido.");
                }
            }
            // Filtrar solo por Carrera
            else if (cmbCarrera.Visible)
            {
                
                Carrera carreraSeleccionada = (Carrera)cmbCarrera.SelectedItem;

               
                if (carreraSeleccionada != null && carreraSeleccionada.ID_Carrera > 0)
                {
                    
                    GestorMaterias gestormat = new GestorMaterias();
                    DataTable resultados = gestormat.FiltrarPorCarrera(carreraSeleccionada.ID_Carrera);

                    if (resultados != null && resultados.Rows.Count > 0)
                    {
                        
                        dataGridView1.DataSource = resultados;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron alumnos para la carrera seleccionada.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una carrera válida.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un filtro válido para buscar.");
            }
        }

        private void cmbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbCarrera.Visible = false;
            cmbAño.Visible = false;
            
            switch (cmbFiltros.SelectedItem.ToString())
            {
                case "Año":
                    cmbAño.Visible = true;
                    break;
                case "Carreras":
                    cmbCarrera.Visible = true;
                    break;
            }


        }
    }
}
