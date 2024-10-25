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
using static Proyecto_Final_AlgoritmsoBDD.FormAgregarExamenAlumno;
using static Proyecto_Final_AlgoritmsoBDD.FormExamenesModal;

namespace Proyecto_Final_AlgoritmsoBDD
{

    public partial class FormAgregarExamenAlumno : Form
    {
        Conexionbdd conectarBDD = new Conexionbdd();


        public class Materia
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return Nombre; // Esto es importante para que el ComboBox muestre el nombre
            }
        }

        public class TipoExamen
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }

            public override string ToString() => Descripcion; // Para que se muestre correctamente en el ComboBox
        }

        public FormAgregarExamenAlumno(string nombre, int materia, decimal calificacion, int carrera, int tipocarrera, DateTime fecha)
        {
            InitializeComponent();
            CargarCarreras();
            CargarMaterias();
            CargarTiposExamen();
            txtAlumno.Text = nombre;
            cmbMateria.SelectedValue = materia;
            txtCalificacion.Text = calificacion.ToString();
            cmbCarreras.SelectedValue = carrera;
            cmbTipoExamen.SelectedValue = tipocarrera;
            dtpFechaExamenAlumno.Value = fecha;


        }
        private void CargarCarreras()
        {
            string query = "SELECT id_carrera, nombre_carrera FROM Carreras";

            using (var connection = conectarBDD.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Limpia el ComboBox antes de llenarlo
                            cmbCarreras.Items.Clear();

                            while (reader.Read())
                            {
                                // Crear un nuevo objeto para almacenar la carrera
                                var carrera = new Carrera
                                {
                                    ID_Carrera = reader.GetInt32(0), // id_carrera
                                    Nombre_Carrera = reader.GetString(1) // nombre_carrera
                                };

                                // Agregar la carrera al ComboBox
                                cmbCarreras.Items.Add(carrera);
                            }
                        }
                    }

                    // Configura DisplayMember y ValueMember
                    cmbCarreras.DisplayMember = "Nombre"; // Lo que se muestra en el ComboBox
                    cmbCarreras.ValueMember = "Id"; // El valor que se utilizará
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar las carreras: {ex.Message}");
                }
            }
        }


        private void CargarMaterias()
        {
            string query = @"SELECT 
                               id_materia, 
                               nombre_materia AS Materias 
                             FROM 
                               Materias";

            using (var connection = conectarBDD.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            cmbMateria.Items.Clear();

                            while (reader.Read())
                            {

                                var materia = new Materia
                                {
                                    Id = reader.GetInt32(0),
                                    Nombre = reader.GetString(1)
                                };

                                // Agregar la materia al ComboBox
                                cmbMateria.Items.Add(materia);
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

        private void CargarTiposExamen()
        {
            string query = "SELECT id_tipoexamen, descripcion FROM tipoexamen";

            using (var connection = conectarBDD.GetConnection())
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

        
    }
}
