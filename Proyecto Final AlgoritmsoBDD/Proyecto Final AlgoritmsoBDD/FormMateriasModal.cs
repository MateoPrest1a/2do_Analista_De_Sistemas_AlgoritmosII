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
using static Proyecto_Final_AlgoritmsoBDD.FormAlumnosModal;

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class FormMateriasModal : Form
    {

        public event Action MateriaEvento;

        Conexionbdd conexionbdd = new Conexionbdd();

        private void FormMateriasModal_Load(object sender, EventArgs e)
        {
            
        }

        private void CargarAños()
        {
            cmbAñoCursada.Items.Add("1");
            cmbAñoCursada.Items.Add("2");
            cmbAñoCursada.Items.Add("3");
        }

        private void CargarCarreras()
        {
            string query = @"SELECT 
                                id_carrera, 
                                nombre_carrera 
                             FROM 
                                Carreras";

            using (var connection = conexionbdd.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

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

                    cmbCarreras.DisplayMember = "nombre_carrera"; // Lo que se muestra en el ComboBox
                    cmbCarreras.ValueMember = "id_carrera"; // El valor que se utilizará
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar las carreras: {ex.Message}");
                }
            }
        }

        public FormMateriasModal(int ID, int Año, string Nombre, int idcarrera)
        {
            InitializeComponent();
            CargarCarreras();
            CargarAños();

            lblMateriaID.Text = ID.ToString();
            cmbAñoCursada.SelectedItem = Año.ToString();
            txtNombreMateria.Text = Nombre;

            // Asignar la carrera seleccionada
            if (cmbCarreras.Items.Count > 0)
            {
                cmbCarreras.SelectedItem = cmbCarreras.Items.Cast<Carrera>().FirstOrDefault(c => c.ID_Carrera == idcarrera); // La función Cast<Carrera>() convierte esos elementos al tipo Carrera FirstOrDefault(c => c.ID_Carrera == idcarrera) : Esta parte busca el primer elemento en la colección que cumpla con la condición especificada en la expresión lambda c => c.ID_Carrera == idcarrera.
            }

            if (ID == 0)
            {
                lblMateria.Visible = false;
                lblMateriaID.Visible = false;
                btnModificarMateria.Visible = false;
                btnEliminarMateria.Visible = false;
            }
            else
            {
                btnAgregarMateria.Visible = false;
            }

        }


        private void cmbProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {

            if (cmbCarreras.SelectedItem == null)
            {
                error1.SetError(cmbCarreras, "Elija una carrera válida");
                cmbCarreras.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreMateria.Text))
            {
                error1.SetError(txtNombreMateria, "Ingrese un nombre a la materia");
                txtNombreMateria.Focus();
                return;
            }

            if (cmbAñoCursada.SelectedItem == null)
            {
                error1.SetError(cmbAñoCursada, "Elija un año de cursada válido");
                cmbAñoCursada.Focus();
                return;
            }

            // Obtener valores
            int idCarrera = ((Carrera)cmbCarreras.SelectedItem).ID_Carrera; // Obtener el ID de la carrera seleccionada
            int anioCursada = Convert.ToInt32(cmbAñoCursada.SelectedItem); // Año cursada
            string nombreMateria = txtNombreMateria.Text; // Obtener el nombre de la materia del TextBox

            using (var connection = conexionbdd.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_AgregarMateria", connection)) // Asegúrate de que el nombre sea correcto
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Pasar los parámetros al stored procedure
                        cmd.Parameters.AddWithValue("@anio_cursada", anioCursada);
                        cmd.Parameters.AddWithValue("@nombre_materia", nombreMateria);
                        cmd.Parameters.AddWithValue("@id_carrera", idCarrera); // Se pasa el ID de la carrera

                        // Ejecutar el stored procedure
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Materia guardada correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar la materia: {ex.Message}");
                }

                // Invocar el evento y cerrar el formulario
                MateriaEvento?.Invoke();
                this.Close();
            }
        }



        private void btnModificarMateria_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (cmbCarreras.SelectedItem == null)
            {
                error1.SetError(cmbCarreras, "Elija una carrera válida");
                cmbCarreras.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreMateria.Text))
            {
                error1.SetError(txtNombreMateria, "Ingrese un nombre a la materia");
                txtNombreMateria.Focus();
                return;
            }

            if (cmbAñoCursada.SelectedItem == null)
            {
                error1.SetError(cmbAñoCursada, "Elija un año válido");
                cmbAñoCursada.Focus();
                return;
            }

            // Obtener valores
            int idMateria = Convert.ToInt32(lblMateriaID.Text); // Obtener el ID de la materia
            int anioCursada = Convert.ToInt32(cmbAñoCursada.SelectedItem); // Año cursada
            string nombreMateria = txtNombreMateria.Text; // Obtener el nombre de la materia
            int idCarrera = ((Carrera)cmbCarreras.SelectedItem).ID_Carrera; // Obtener el ID de la carrera

            using (var connection = conexionbdd.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_ModificarMateria", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Pasar los parámetros al stored procedure
                        cmd.Parameters.AddWithValue("@id_materia", idMateria);
                        cmd.Parameters.AddWithValue("@anio_cursada", anioCursada);
                        cmd.Parameters.AddWithValue("@nombre_materia", nombreMateria);
                        cmd.Parameters.AddWithValue("@id_carrera", idCarrera); // Pasar el ID de la carrera

                        // Ejecutar el stored procedure
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Materia modificada correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar la materia: {ex.Message}");
                }

                // Invocar el evento y cerrar el formulario
                MateriaEvento?.Invoke();
                this.Close();
            }
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            int idMateria = Convert.ToInt32(lblMateriaID.Text); // Obtener ID de la materia a eliminar

            if (MessageBox.Show("¿Estás seguro de que quieres eliminar esta materia?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var connection = conexionbdd.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand("SP_EliminarMateria", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@id_materia", idMateria);

                            // Ejecutar el stored procedure
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Materia eliminada correctamente.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar la materia: {ex.Message}");
                    }

                    MateriaEvento?.Invoke();
                    this.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
