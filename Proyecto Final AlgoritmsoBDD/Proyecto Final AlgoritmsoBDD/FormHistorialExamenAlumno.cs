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
using static Proyecto_Final_AlgoritmsoBDD.FormHistorialExamenAlumno;
using static Proyecto_Final_AlgoritmsoBDD.FormExamenesModal;

namespace Proyecto_Final_AlgoritmsoBDD
{

    public partial class FormHistorialExamenAlumno : Form
    {
        GestorExamenes gestorexamenes = new GestorExamenes();

        SqlConnection conexion = Conexionbdd.ObtenerInstancia().ObtenerConexion();

        public FormHistorialExamenAlumno(int Matricla)
        {
            InitializeComponent();
            CargarTabla(Matricla);
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
                                    ExamenesXAlumno exa
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
            command.Parameters.AddWithValue("@matricula", Matricula);  // Agrego el valor del parámetro

            try
            {
                DataTable dt = gestorexamenes.EjecutarConsulta(command); // Uso la clase gestora para ejecutar la consulta
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
    

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }

}
