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

        //Arreglar todo esto

        private void CargarTabla(int Matricula)
        {
            string consulta = @"
                                SELECT 
                                    e.id_examenxalumno,
                                    e.fecha,
                                    e.calificacion,
                                    a.nombre AS Alumno,
                                    m.nombre_materia AS Materia,
                                    c.nombre_carrera AS Carrera,
                                    ex.tipo_examen AS [Tipo Examen]
                                FROM 
                                    ExamenxAlumno AS e
                                JOIN 
                                    Alumnos AS a ON a.matricula = e.id_alumno
                                JOIN 
                                    Materias AS m ON m.id_materia = e.id_materia
                                JOIN 
                                    Carreras AS c ON c.id_carrera = e.id_carrera
                                JOIN 
                                    Examenes AS ex ON ex.id_examen = e.id_examen
                                WHERE 
                                    e.id_alumno = @matricula;";

            using (SqlCommand command = new SqlCommand(consulta, conectarBDD.conectarbdd))
            {
                command.Parameters.AddWithValue("@matricula", Matricula); // Reemplaza con el valor correcto

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();


                try
                {
                    conectarBDD.abrir();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["id_examenxalumno"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la tabla de exámenes: " + ex.Message);
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
                string nombre = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                int materia; 


            }
        }
    }
}
