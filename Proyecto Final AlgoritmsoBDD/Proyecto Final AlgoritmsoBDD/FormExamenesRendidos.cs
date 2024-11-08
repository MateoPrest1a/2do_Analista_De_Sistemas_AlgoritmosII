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
    public partial class FormExamenesRendidos : Form
    {
        GestorExamenes Gestorexamenes = new GestorExamenes();

        public int Matricula;
        public FormExamenesRendidos(int idmatricula)
        {
            InitializeComponent();
            Matricula = idmatricula;
            CargarTabla(Matricula);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void CargarTabla(int Matricula)
        {
            
            string consulta = @"
                                SELECT 
                                    exa.id_examenxalumno, 
                                    a.matricula, 
                                    a.nombre AS Alumno,
                                    ex.id_examen,
                                    ex.fecha_examen AS Fecha,
                                    m.id_materia,
                                    m.nombre_materia AS Materia,
                                    c.id_carrera, 
                                    c.nombre_carrera AS Carrera,
                                    m.anio_cursada AS Año,
                                    te.descripcion AS TipoExamen,  -- Agregamos el tipo de examen
                                    exa.calificacion 
                                FROM 
                                    ExamenxAlumno exa
                                INNER JOIN 
                                    Alumnos a ON exa.matricula = a.matricula
                                INNER JOIN 
                                    Examenes ex ON exa.id_examen = ex.id_examen
                                INNER JOIN 
                                    Materias m ON ex.id_materia = m.id_materia
                                INNER JOIN 
                                    Carreras c ON ex.id_carrera = c.id_carrera
                                INNER JOIN 
                                    tipoexamen te ON ex.tipo_examen = te.id_tipoexamen  -- Join para obtener el tipo de examen
                                WHERE 
                                    exa.matricula = @matricula";

            SqlCommand command = new SqlCommand(consulta);
            command.Parameters.AddWithValue("@matricula", Matricula); // Agrego el valor del parámetro

            try
            {
                DataTable dt = Gestorexamenes.EjecutarConsulta(command); // Uso la clase gestora para ejecutar la consulta
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id_carrera"].Visible = false;
                dataGridView1.Columns["id_materia"].Visible = false;
                dataGridView1.Columns["id_examenxalumno"].Visible = false;
                dataGridView1.Columns["id_examen"].Visible = false;
                dataGridView1.Columns["matricula"].Visible = false;  // Oculto las columnas que no quiero mostrar

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }
        


        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int idexamenxalumno = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_examenxalumno"].Value);
                    string nombre = dataGridView1.Rows[e.RowIndex].Cells["Alumno"].Value.ToString();
                    int idexamen = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_examen"].Value);
                    DateTime fechaexamen = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Fecha"].Value);
                    int idmateria = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_materia"].Value);
                    int idcarrera = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_carrera"].Value);
                    int año = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Año"].Value);
                    decimal calificacion = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["calificacion"].Value);


                    FormExamenesRendidosModal formExamenesRendidosModal = new FormExamenesRendidosModal(idexamenxalumno, nombre, idexamen, idmateria, idcarrera, año, fechaexamen, calificacion);
                    formExamenesRendidosModal.ShowDialog();
                }
                catch 
                {
                    int idexamenxalumno = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_examenxalumno"].Value);
                    string nombre = dataGridView1.Rows[e.RowIndex].Cells["Alumno"].Value.ToString();
                    int idexamen = 0;
                    DateTime fechaexamen = DateTime.Now;
                    int idmateria = 0;
                    int idcarrera = 0;
                    int año = 0;
                    decimal calificacion = 0;


                    FormExamenesRendidosModal formExamenesRendidosModal = new FormExamenesRendidosModal(idexamenxalumno, nombre, idexamen, idmateria, idcarrera, año, fechaexamen, calificacion);
                    formExamenesRendidosModal.ShowDialog();
                }
            }
        }
    }
}
