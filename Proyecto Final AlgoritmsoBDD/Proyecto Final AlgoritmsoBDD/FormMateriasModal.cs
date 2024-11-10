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
using static Proyecto_Final_AlgoritmsoBDD.FormAlumnosModal;

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class FormMateriasModal : Form
    {

        public event Action MateriaEvento;

        GestorMaterias gestorMaterias = new GestorMaterias(); // Instancia de GestorMaterias
        
        SqlConnection conexion = Conexionbdd.ObtenerInstancia().ObtenerConexion();

        private void FormMateriasModal_Load(object sender, EventArgs e)
        {
            gestorMaterias = new GestorMaterias();
        }

        private void CargarAños()
        {
            cmbAñoCursada.Items.Add("1");
            cmbAñoCursada.Items.Add("2");
            cmbAñoCursada.Items.Add("3");
        }

        private void CargarCarreras()
        {
            string query = "SELECT id_carrera, nombre_carrera FROM Carreras";

            try
            {
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    // Usar la clase gestora para ejecutar la consulta
                    DataTable carrerasTable = gestorMaterias.EjecutarConsulta(command); // Asegúrate de que 'gestorMaterias' sea una instancia válida de GestorMaterias

                    // Limpia el ComboBox antes de llenarlo
                    cmbCarreras.Items.Clear();

                    foreach (DataRow row in carrerasTable.Rows)
                    {
                        // Crear un nuevo objeto para almacenar la carrera
                        var carrera = new Carrera
                        {
                            ID_Carrera = Convert.ToInt32(row["id_carrera"]), // id_carrera
                            Nombre_Carrera = row["nombre_carrera"].ToString() // nombre_carrera
                        };

                        // Agregar la carrera al ComboBox
                        cmbCarreras.Items.Add(carrera);
                    }

                    // Configura DisplayMember y ValueMember
                    cmbCarreras.DisplayMember = "nombre_carrera"; // Lo que se muestra en el ComboBox
                    cmbCarreras.ValueMember = "id_carrera"; // El valor que se utilizará
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las carreras: {ex.Message}");
            }
        }

        //Constructor
        public FormMateriasModal(int ID, int Año, string Nombre, int idcarrera)
        {
            InitializeComponent();
            CargarCarreras();
            CargarAños();

            lblMateriaID.Text = ID.ToString();
            cmbAñoCursada.SelectedItem = Año.ToString();
            txtNombreMateria.Text = Nombre;

            // Asignar la carrera seleccionada
            foreach (Carrera carrera in cmbCarreras.Items)
            {
                if (carrera.ID_Carrera == idcarrera)
                {
                    cmbCarreras.SelectedItem = carrera;
                    break;
                }
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
            int idCarrera = 0;
            int anioCursada = 0;
            string nombreMateria = "";

            if (cmbCarreras.SelectedItem == null)
            {
                error1.SetError(cmbCarreras, "Elija una carrera válida");
                cmbCarreras.Focus();
                return;
            }
            else
            {
                idCarrera = ((Carrera)cmbCarreras.SelectedItem).ID_Carrera;
            }


            if (txtNombreMateria.Text == null)
            {
                error1.SetError(txtNombreMateria, "Ingrese un nombre a la materia");
                txtNombreMateria.Focus();
                return;
            }
            else
            {
                anioCursada = Convert.ToInt32(cmbAñoCursada.SelectedItem);
            }

            if (cmbAñoCursada.SelectedItem == null)
            {
                error1.SetError(cmbAñoCursada, "Elija un año de cursada válido");
                cmbAñoCursada.Focus();
                return;
            }
            else
            {
                nombreMateria = txtNombreMateria.Text;
            }
            
            
            

            // Usar la clase GestorMaterias para agregar la materia
            gestorMaterias.CargarMateria(anioCursada, nombreMateria,idCarrera);

            // Invocar el evento y cerrar el formulario
            MateriaEvento?.Invoke();
            this.Close();
        }
        



        private void btnModificarMateria_Click(object sender, EventArgs e)
        {
            int anioCursada = 0;
            string nombreMateria = "";
            int idCarrera = 0;

            // Validaciones
            if (cmbCarreras.SelectedItem == null)
            {
                error1.SetError(cmbCarreras, "Elija una carrera válida");
                cmbCarreras.Focus();
                return;
            }
            else
            {
                idCarrera = ((Carrera)cmbCarreras.SelectedItem).ID_Carrera;
            }


            if (txtNombreMateria.Text == null)
            {
                error1.SetError(txtNombreMateria, "Ingrese un nombre a la materia");
                txtNombreMateria.Focus();
                return;
            }
            else
            {
                nombreMateria = txtNombreMateria.Text;
            }


            if (cmbAñoCursada.SelectedItem == null)
            {
                error1.SetError(cmbAñoCursada, "Elija un año válido");
                cmbAñoCursada.Focus();
                return;
            }
            else
            {
                anioCursada = Convert.ToInt32(cmbAñoCursada.SelectedItem);
            }


            int idMateria = Convert.ToInt32(lblMateriaID.Text); //no hace falta verificar ya que si no esta el boton actualizar no 

            // Usar la clase GestorMaterias para modificar la materia
            gestorMaterias.ModificarMateria(idMateria, anioCursada, nombreMateria);

            // Invocar el evento y cerrar el formulario
            MateriaEvento?.Invoke();
            this.Close();
        }


        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            int idMateria = Convert.ToInt32(lblMateriaID.Text); // Obtener ID de la materia a eliminar

            if (MessageBox.Show("¿Estás seguro de que quieres eliminar esta materia?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Usar la clase GestorMaterias para eliminar la materia
                gestorMaterias.EliminarMateria(idMateria);

                // Invocar el evento y cerrar el formulario
                MateriaEvento?.Invoke();
                this.Close();
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
