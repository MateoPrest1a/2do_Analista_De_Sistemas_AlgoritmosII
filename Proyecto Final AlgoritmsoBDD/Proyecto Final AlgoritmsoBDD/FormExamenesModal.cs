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


        GestorExamenes Gestorexamenes = new GestorExamenes();    //Instancio la conexion

        SqlConnection conexion = Conexionbdd.ObtenerInstancia().ObtenerConexion();
        public FormExamenesModal(int idexamen, int idcarrera, int idmateria, string horaexamen, DateTime fecha, int tipoexamen, int libro, int folio)
        {
            InitializeComponent();
            CargarCarreras();
            CargarMaterias(idcarrera);
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

        private void FormExamenesModal_Load(object sender, EventArgs e)
        {
            cmbIDCarrera.SelectedIndexChanged += CmbIDCarrera_SelectedIndexChanged;

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
                    command.Parameters.AddWithValue("@idCarrera", idCarrera); // Añadir el parámetro

                    // Usar la clase gestora para ejecutar la consulta
                    DataTable materiasTable = Gestorexamenes.EjecutarConsulta(command);

                    cmbIDMaterias.Items.Clear(); // Limpia el ComboBox antes de llenarlo

                    foreach (DataRow row in materiasTable.Rows)
                    {
                        var materia = new Materia
                        {
                            ID_Materia = Convert.ToInt32(row["id_materia"]),
                            Nombre_Materia = row["Materias"].ToString()
                        };

                        // Agregar la materia al ComboBox
                        cmbIDMaterias.Items.Add(materia);
                    }

                    // Configura DisplayMember y ValueMember si es necesario
                    cmbIDMaterias.DisplayMember = "Nombre_Materia"; // Lo que se muestra en el ComboBox
                    cmbIDMaterias.ValueMember = "ID_Materia"; // El valor que se utilizará
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las materias: " + ex.Message);
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
                    DataTable tiposExamenTable = Gestorexamenes.EjecutarConsulta(command);

                    cmbTipoExamen.Items.Clear(); // Limpia el ComboBox antes de llenarlo

                    foreach (DataRow row in tiposExamenTable.Rows)
                    {
                        var tipoExamen = new TipoExamen
                        {
                            Id = Convert.ToInt32(row["id_tipoexamen"]), // id_tipoexamen
                            Descripcion = row["descripcion"].ToString() // descripcion
                        };

                        // Agregar el tipo de examen al ComboBox
                        cmbTipoExamen.Items.Add(tipoExamen);
                    }

                    // Configura DisplayMember y ValueMember
                    cmbTipoExamen.DisplayMember = "Descripcion"; // Lo que se muestra en el ComboBox
                    cmbTipoExamen.ValueMember = "Id"; // El valor que se utilizará
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los tipos de examen: {ex.Message}");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Variables para almacenar valores de los controles
            int idCarrera = Convert.ToInt32(((Carrera)cmbIDCarrera.SelectedItem).ID_Carrera);
            int idMateria = Convert.ToInt32(((Materia)cmbIDMaterias.SelectedItem).ID_Materia);
            string horaExamen = txtExamenHora.Text;
            DateTime fechaExamen = dtpFechaExamen.Value;
            int tipoExamen = Convert.ToInt32(((TipoExamen)cmbTipoExamen.SelectedItem).Id);
            int libro = Convert.ToInt32(txtLibro.Text);
            int folio = Convert.ToInt32(txtFolio.Text);

            // Llama al método para agregar un examen
            Gestorexamenes.CargarExamen(idCarrera, idMateria, horaExamen, fechaExamen, tipoExamen, libro, folio);

            ExamenEvento?.Invoke();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Asegúrate de que tienes el ID del examen a modificar
            int idExamen = Convert.ToInt32(lblIDExamen);

            // Variables para almacenar valores de los controles
            int idCarrera = Convert.ToInt32(((Carrera)cmbIDCarrera.SelectedItem).ID_Carrera);
            int idMateria = Convert.ToInt32(((Materia)cmbIDMaterias.SelectedItem).ID_Materia);
            string horaExamen = txtExamenHora.Text;
            DateTime fechaExamen = dtpFechaExamen.Value;
            int tipoExamen = Convert.ToInt32(((TipoExamen)cmbTipoExamen.SelectedItem).Id);
            int libro = Convert.ToInt32(txtLibro.Text);
            int folio = Convert.ToInt32(txtFolio.Text);

            // Llama al método para actualizar el examen
            Gestorexamenes.ActualizarExamen(idExamen, idCarrera, idMateria, horaExamen, fechaExamen, tipoExamen, libro, folio);

            ExamenEvento?.Invoke();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Asegúrate de que tienes el ID del examen a eliminar
            int idExamen = Convert.ToInt32(lblIDExamen);

            // Llama al método para eliminar el examen
            Gestorexamenes.EliminarExamen(idExamen);

            ExamenEvento?.Invoke();
            this.Close();
        }
    }
}
