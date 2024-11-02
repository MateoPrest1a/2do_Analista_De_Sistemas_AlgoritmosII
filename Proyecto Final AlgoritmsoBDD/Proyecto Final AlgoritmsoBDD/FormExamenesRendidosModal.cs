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
    public partial class FormExamenesRendidosModal : Form
    {
        GestorExamenes Gestorexamenes = new GestorExamenes();

        SqlConnection conexion = Conexionbdd.ObtenerInstancia().ObtenerConexion();
        public FormExamenesRendidosModal(int idexamenxalumno, string nombre, int idexamen, int idmateria, int idcarrera, int año, DateTime fecha, decimal calificacion)
        {
            InitializeComponent();
            CargarCarreras();
            CargarTiposExamen();
            CargarMaterias(idcarrera);
            cmbIDCarrera.SelectedIndexChanged += CmbIDCarrera_SelectedIndexChanged;

            lblIDExamen.Text = idexamenxalumno.ToString();
            lblAlumno.Text = nombre;
            dtpFechaExamen.Value = fecha;


            foreach (Carrera carrera in cmbIDCarrera.Items)
            {
                if (carrera.ID_Carrera == idcarrera)
                {
                    cmbIDCarrera.SelectedItem = carrera;
                    break;
                }
            }

            foreach (Materia materias in cmbIDMaterias.Items)
            {
                if (materias.ID_Materia == idmateria)
                {
                    cmbIDMaterias.SelectedItem = materias;
                    break;
                }
            }

            foreach (TipoExamen tipoexamenes in cmbTipoExamen.Items)
            {
                if (tipoexamenes.Id == idexamen)
                {
                    cmbTipoExamen.SelectedItem = tipoexamenes;
                    break;
                }
            }
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
                    DataTable carrerasTable = Gestorexamenes.EjecutarConsulta(command);

                    // Limpia el ComboBox antes de llenarlo
                    cmbIDCarrera.Items.Clear();

                    foreach (DataRow row in carrerasTable.Rows)
                    {
                        // Crear un nuevo objeto para almacenar la carrera
                        var carrera = new Carrera
                        {
                            ID_Carrera = Convert.ToInt32(row["id_carrera"]), // id_carrera
                            Nombre_Carrera = row["nombre_carrera"].ToString() // nombre_carrera
                        };

                        // Agregar la carrera al ComboBox
                        cmbIDCarrera.Items.Add(carrera);
                    }

                    // Configura DisplayMember y ValueMember
                    cmbIDCarrera.DisplayMember = "Nombre"; // Lo que se muestra en el ComboBox
                    cmbIDCarrera.ValueMember = "Id"; // El valor que se utilizará
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las carreras: {ex.Message}");
            }
        }


        private void CargarMaterias(int idCarrera)
        {
            string query = @"SELECT 
                         m.id_materia, 
                         m.nombre_materia AS Materias 
                     FROM 
                         Materias as M
                     INNER JOIN 
                        MateriasxCarrera mc ON mc.id_materia = m.id_materia
                    INNER JOIN 
                        Carreras c ON mc.id_carrera = c.id_carrera
                    WHERE 
                        c.id_carrera = @idCarrera";
            try
            {
                // Crear el comando SQL
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    // Usar la clase gestora para ejecutar la consulta
                    DataTable carrerasTable = Gestorexamenes.EjecutarConsulta(command);

                    // Limpia el ComboBox antes de llenarlo
                    cmbIDMaterias.Items.Clear();

                    foreach (DataRow row in carrerasTable.Rows)
                    {
                        // Crear un nuevo objeto para almacenar la carrera
                        var materia = new Materia
                        {
                            ID_Materia = Convert.ToInt32(row["id_materia"]), // id_carrera
                            Nombre_Materia= row["nombre_materia"].ToString() // nombre_carrera
                        };

                        // Agregar la carrera al ComboBox
                        cmbIDCarrera.Items.Add(materia);
                    }

                    // Configura DisplayMember y ValueMember
                    cmbIDCarrera.DisplayMember = "Nombre"; // Lo que se muestra en el ComboBox
                    cmbIDCarrera.ValueMember = "Id"; // El valor que se utilizará
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las carreras: {ex.Message}");
            }
        }


        private void CmbIDCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIDCarrera.SelectedItem is Carrera carrera)
            {
                CargarMaterias(carrera.ID_Carrera); // Llama a CargarMaterias con el ID de la carrera seleccionada
            }
        }


        private void CargarTiposExamen()
        {
            string query = "SELECT id_tipoexamen, descripcion FROM tipoexamen";
            try
            {
                // Crear el comando SQL
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    // Usar la clase gestora para ejecutar la consulta
                    DataTable carrerasTable = Gestorexamenes.EjecutarConsulta(command);

                    // Limpia el ComboBox antes de llenarlo
                    cmbTipoExamen.Items.Clear();

                    foreach (DataRow row in carrerasTable.Rows)
                    {
                        // Crear un nuevo objeto para almacenar la carrera
                        var tipoExamen = new TipoExamen
                        {
                            Id = Convert.ToInt32(row["id_tipoexamen"]), // id_carrera
                            Descripcion = row["descripcion"].ToString() // nombre_carrera
                        };

                        // Agregar la carrera al ComboBox
                        cmbIDCarrera.Items.Add(tipoExamen);
                    }

                    // Configura DisplayMember y ValueMember
                    cmbIDCarrera.DisplayMember = "Nombre"; // Lo que se muestra en el ComboBox
                    cmbIDCarrera.ValueMember = "Id"; // El valor que se utilizará
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las carreras: {ex.Message}");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormExamenesRendidosModal_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
