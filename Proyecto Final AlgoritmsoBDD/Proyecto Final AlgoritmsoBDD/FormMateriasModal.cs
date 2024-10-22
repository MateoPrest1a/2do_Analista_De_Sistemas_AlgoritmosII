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
    public partial class FormMateriasModal : Form
    {

        public event Action MateriaEvento;

        Conexionbdd conexionbdd = new Conexionbdd();

        private void FormMateriasModal_Load(object sender, EventArgs e)
        {
            cmbAñoCursada.Items.Add("1");
            cmbAñoCursada.Items.Add("2");
            cmbAñoCursada.Items.Add("3");
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

        public FormMateriasModal(int ID, int Año, string Nombre)
        {
            InitializeComponent();
            CargarCarreras();
            if (ID == 0)
            {
                lblMateria.Visible = false;
                lblMateriaID.Visible = false;
            }
            else
            {
                lblMateriaID.Text = ID.ToString();
                cmbAñoCursada.SelectedText = Año.ToString();
                txtNombreMateria.Text = Nombre;
            }

        }


        private void cmbProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            conexionbdd.CargarMateria(Convert.ToInt32(cmbAñoCursada.SelectedText), txtNombreMateria.Text);
            MateriaEvento?.Invoke();
            this.Close();
        }

        private void btnModificarMateria_Click(object sender, EventArgs e)
        {
            conexionbdd.ModificarMateria(Convert.ToInt32(lblMateriaID.Text), Convert.ToInt32(cmbAñoCursada.SelectedText), txtNombreMateria.Text);
            MateriaEvento?.Invoke();
            this.Close();
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            conexionbdd.EliminarMateria(Convert.ToInt32(lblMateriaID.Text));
            MateriaEvento?.Invoke();
            this.Close();
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
