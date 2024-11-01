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

        Conexionbdd conexionbdd = new Conexionbdd();
        public FormExamenesRendidosModal(int idexamenxalumno, string nombre, int idexamen, int idmateria, int idcarrera, int año, DateTime fecha, decimal calificacion)
        {
            InitializeComponent();
            CargarCarreras();
            CargarTiposExamen();
            cmbIDCarrera.SelectedIndexChanged += CmbIDCarrera_SelectedIndexChanged;
            CargarMaterias(idcarrera);

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

            using (var connection = conexionbdd.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Limpia el ComboBox antes de llenarlo
                            cmbIDCarrera.Items.Clear();

                            while (reader.Read())
                            {
                                // Crear un nuevo objeto para almacenar la carrera
                                var carrera = new Carrera
                                {
                                    ID_Carrera = reader.GetInt32(0), // id_carrera
                                    Nombre_Carrera = reader.GetString(1) // nombre_carrera
                                };

                                // Agregar la carrera al ComboBox
                                cmbIDCarrera.Items.Add(carrera);
                            }
                        }
                    }

                    // Configura DisplayMember y ValueMember
                    cmbIDCarrera.DisplayMember = "Nombre_Carrera"; // Lo que se muestra en el ComboBox
                    cmbIDCarrera.ValueMember = "ID_Carrera"; // El valor que se utilizará
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar las carreras: {ex.Message}");
                }
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
            using (var connection = conexionbdd.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idCarrera", idCarrera); // Añadir el parámetro

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            cmbIDMaterias.Items.Clear(); // Limpia el ComboBox antes de llenarlo

                            while (reader.Read())
                            {
                                var materia = new Materia
                                {
                                    ID_Materia = reader.GetInt32(0),
                                    Nombre_Materia = reader.GetString(1)
                                };

                                // Agregar la materia al ComboBox
                                cmbIDMaterias.Items.Add(materia);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las materias: " + ex.Message);
                }
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

            using (var connection = conexionbdd.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            cmbTipoExamen.Items.Clear(); // Limpia el ComboBox antes de llenarlo

                            while (reader.Read())
                            {
                                var tipoExamen = new TipoExamen
                                {
                                    Id = reader.GetInt32(0), // id_tipoexamen
                                    Descripcion = reader.GetString(1) // descripcion
                                };

                                // Agregar el tipo de examen al ComboBox
                                cmbTipoExamen.Items.Add(tipoExamen);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los tipos de examen: " + ex.Message);
                }
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
    }
}
