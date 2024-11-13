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
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class FormExamenesRendidos : Form
    {
        GestorExamenes Gestorexamenes = new GestorExamenes();

        public int Matricula;
        public FormExamenesRendidos(int idmatricula, string nombre, int idcarrera)
        {
            InitializeComponent();
            Matricula = idmatricula;
            txtAlumno.Text = nombre;
            CargarTablaExamenes(idcarrera);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarTablaExamenes(int idCarrera)
        {
            string consulta = @"
                        SELECT 
                            e.id_examen,
                            c.id_carrera, -- Esta columna se incluye pero no se mostrará
                            c.nombre_carrera AS Carrera,
                            m.id_materia, 
                            m.nombre_materia AS Materia,
                            m.anio_cursada AS Año, 
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
                            TipoExamen te ON e.tipo_examen = te.id_tipoexamen
                        WHERE 
                            c.id_carrera = @idCarrera;";

            try
            {
                SqlCommand comando = new SqlCommand(consulta);
                comando.Parameters.AddWithValue("@idCarrera", idCarrera); // Agrega el parámetro de carrera
                DataTable dt = Gestorexamenes.EjecutarConsulta(comando); // Usa la clase gestora para ejecutar la consulta
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




        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {

                        string valor = dataGridView1.Rows[e.RowIndex].Cells["id_examen"].Value.ToString();

                        txtIdExamen.Text = valor;
                    }
                }
                catch
                {

                }
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorialExamenAlumno formulario = new FormHistorialExamenAlumno(Matricula);
            formulario.ShowDialog();
        }
    }
}
