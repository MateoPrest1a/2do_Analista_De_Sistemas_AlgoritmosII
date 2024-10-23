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
    public partial class FormExamenes : Form
    {



        Conexionbdd conectarBDD;
        public FormExamenes()
        {
            InitializeComponent();

            conectarBDD = new Conexionbdd();
        }

        private void CargarTablaExamenes()
        {
            string consulta = @"
                                SELECT 
                                    e.id_examen,
                                    c.id_carrera, -- Esta columna se incluye pero no se mostrará
                                    c.nombre_carrera AS Carrera,
                                    m.id_materia, 
                                    m.nombre_materia AS Materia,
                                    e.fecha_examen AS Fecha,
                                    e.hora_examen AS [Hora Examen],
                                    te.id_tipoexamen,
                                    te.descripcion AS [Tipo de Examen],
                                    e.libro,
                                    e.folio
                                FROM 
                                    Examenes e
                                JOIN 
                                    Carreras c ON e.id_carrera = c.id_carrera
                                JOIN 
                                    Materias m ON e.id_materia = m.id_materia
                                JOIN 
                                    TipoExamen te ON e.tipo_examen = te.id_tipoexamen;";

            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectarBDD.conectarbdd);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Ocultar la columna de ids
                dataGridView1.Columns["id_carrera"].Visible = false; // Oculta la columna
                dataGridView1.Columns["id_materia"].Visible = false; 
                dataGridView1.Columns["id_tipoexamen"].Visible = false;
                dataGridView1.Columns["id_examen"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }

        private void FormExamenes_Load(object sender, EventArgs e)
        {
            CargarTablaExamenes();
        }


        private void Actualizar_DataGridView()
        {
            string consulta = @"
                                SELECT 
                                    e.id_examen,
                                    c.id_carrera, -- Esta columna se incluye pero no se mostrará
                                    c.nombre_carrera AS Carrera,
                                    m.id_materia, 
                                    m.nombre_materia AS Materia,
                                    e.fecha_examen AS Fecha,
                                    e.hora_examen AS [Hora Examen],
                                    te.id_tipoexamen,
                                    te.descripcion AS [Tipo de Examen],
                                    e.libro,
                                    e.folio
                                FROM 
                                    Examenes e
                                JOIN 
                                    Carreras c ON e.id_carrera = c.id_carrera
                                JOIN 
                                    Materias m ON e.id_materia = m.id_materia
                                JOIN 
                                    TipoExamen te ON e.tipo_examen = te.id_tipoexamen;";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectarBDD.conectarbdd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {

                    

                    // Obtener los valores de las celdas
                    int idExamen = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    int idCarrera = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_carrera"].Value); // Asegúrate de que el nombre es correcto
                    int idMateria = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_materia"].Value);
                    string horaExamen = dataGridView1.Rows[e.RowIndex].Cells["Hora Examen"].Value.ToString();
                    DateTime fecha = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Fecha"].Value);
                    int tipoExamen = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_tipoexamen"].Value);
                    int libro = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["libro"].Value);
                    int folio = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["folio"].Value);

                    // Crear y mostrar el formulario modal
                    FormExamenesModal formExamenModal = new FormExamenesModal(idExamen, idCarrera, idMateria, horaExamen, fecha, tipoExamen, libro, folio);
                    formExamenModal.ExamenEvento += Actualizar_DataGridView;// Suscribirse al evento
                    formExamenModal.ShowDialog(); // Mostrar como un diálogo modal
                }
                catch (Exception ex)
                {

                    FormExamenesModal formExamenModal = new FormExamenesModal(0, 0, 0, "",DateTime.Now, 0, 0, 0); // Valores por defecto
                    formExamenModal.ExamenEvento += Actualizar_DataGridView; // Suscribirse al evento
                    formExamenModal.ShowDialog(); // Mostrar el formulario modal
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
