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
using static Proyecto_Final_AlgoritmsoBDD.FormAlumnosModal;

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class FormExamenesModal : Form
    {
        public event Action ExamenEvento; //Evento para actualizar el datagridview
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

        Conexionbdd conexionbdd = new Conexionbdd();

        public FormExamenesModal(int idexamen, int idcarrera, int idmateria, string horaexamen, DateTime fecha, int tipoexamen, int libro, int folio)
        {
            InitializeComponent();
            CargarCarreras();
            CargarMaterias();
            CargarTiposExamen();
            lblIDExamen.Text = idexamen.ToString();
            cmbIDMaterias.SelectedValue = idmateria;
            txtExamenHora.Text = horaexamen.ToString();
            dtpFechaExamen.Value = fecha;
            cmbTipoExamen.Text = tipoexamen.ToString();
            txtLibro.Text = libro.ToString();
            txtFolio.Text = folio.ToString();

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
                if (materias.Id == idmateria)
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

        private void FormExamenesModal_Load(object sender, EventArgs e)
        {

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
                    cmbIDCarrera.DisplayMember = "Nombre"; // Lo que se muestra en el ComboBox
                    cmbIDCarrera.ValueMember = "Id"; // El valor que se utilizará
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

            using (var connection = conexionbdd.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            cmbIDMaterias.Items.Clear();

                            while (reader.Read())
                            {

                                var materia = new Materia
                                {
                                    Id = reader.GetInt32(0),
                                    Nombre = reader.GetString(1)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexionbdd.CargarExamen(Convert.ToInt32(((Carrera)cmbIDCarrera.SelectedItem).ID_Carrera), Convert.ToInt32(((Materia)cmbIDMaterias.SelectedItem).Id), txtExamenHora.Text,dtpFechaExamen.Value, Convert.ToInt32(((TipoExamen)cmbTipoExamen.SelectedItem).Id), Convert.ToInt32(txtLibro.Text),Convert.ToInt32(txtFolio.Text));
            ExamenEvento?.Invoke();
            this.Close();
        }
    }
}
