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
        Conexionbdd conectarBDD = new Conexionbdd();

        public FormExamenesRendidos(int idmatricula)
        {
            InitializeComponent();
            CargarTabla(idmatricula);
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
                                    ex.fecha_examen,
                                    m.id_materia,
                                    m.nombre_materia AS Materia,
                                    c.id_carrera, 
                                    c.nombre_carrera AS Carrera,
                                    --m.anio_cursada AS Año,
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

            using (SqlCommand command = new SqlCommand(consulta, conectarBDD.conectarbdd))
            {
                command.Parameters.AddWithValue("@matricula", Matricula);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                try
                {
                    conectarBDD.abrir();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Ocultar la columna 'id_examenxalumno
                    dataGridView1.Columns["id_examenxalumno"].Visible = false;
                    dataGridView1.Columns["id_examen"].Visible = false;
                    dataGridView1.Columns["id_materia"].Visible = false;
                    dataGridView1.Columns["id_carrera"].Visible = false;
                    //dataGridView1.Columns["anio_cursada"].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la tabla de exámenes: " + ex.Message);
                }
                finally
                {
                    conectarBDD.cerrar(); // Asegúrate de cerrar la conexión en caso de que ocurra un error
                }
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idexamenxalumno = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_examenxalumno"].Value);
                string nombre = dataGridView1.Rows[e.RowIndex].Cells["Alumno"].Value.ToString();
                int idexamen = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_examen"].Value);
                int idmateria = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_carrera"].Value);
                DateTime fechaexamen = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["fecha_examen"].Value);
                int idcarrera = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_carrera"].Value);
                //int año = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["anio_cursada"].Value);
                decimal calificacion = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["calificacion"].Value);

                FormExamenesRendidosModal formExamenesRendidosModal = new FormExamenesRendidosModal(idexamenxalumno, nombre, idexamen, idmateria, idcarrera, 2, fechaexamen, calificacion);
                formExamenesRendidosModal.ShowDialog();
            }
        }
    }
}
