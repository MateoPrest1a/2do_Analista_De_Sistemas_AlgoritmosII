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
        ClaseGestoraExamenXAlumnos Gestorexamenesalumnos = new ClaseGestoraExamenXAlumnos();

        public int Matricula;
        public int IdCarrera;
        public FormExamenesRendidos(int idmatricula, string nombre, int idcarrera)
        {
            InitializeComponent();
            Matricula = idmatricula;
            txtAlumno.Text = nombre;
            IdCarrera = idcarrera;
            CargarTablaExamenes(IdCarrera, Matricula);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable CargarTablaExamenes(int idCarrera, int matricula)
        {
            string consulta = @"
                        SELECT 
                            e.id_examen,
                            c.id_carrera, 
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
                            c.id_carrera = @idCarrera
                        AND 
                            NOT EXISTS (
                                SELECT 1
                                FROM ExamenesXAlumno exa
                                WHERE exa.matricula = @matricula
                                AND exa.id_examen = e.id_examen
                            );";

            try
            {
                SqlCommand comando = new SqlCommand(consulta);
                comando.Parameters.AddWithValue("@idCarrera", idCarrera); // Agrega el parámetro de carrera
                comando.Parameters.AddWithValue("@matricula", matricula);
                DataTable dt = Gestorexamenesalumnos.EjecutarConsulta(comando); // Usa la clase gestora para ejecutar la consulta
                dataGridView1.DataSource = dt;

                // Ocultar la columna de ids
                dataGridView1.Columns["id_carrera"].Visible = false; // Oculta la columna
                dataGridView1.Columns["id_materia"].Visible = false;
                dataGridView1.Columns["id_tipoexamen"].Visible = false;
                dataGridView1.Columns["id_examen"].Visible = false;

                // Verificar si el DataTable está vacío
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("El alumno ya rindió todos los examenes posibles para esta carrera.");
                }

                

                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
                return new DataTable();
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


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
               
                int idExamen = Convert.ToInt32(txtIdExamen.Text);  
                decimal calificacion = Convert.ToDecimal(txtCalificacion.Text);  

                Gestorexamenesalumnos.InsertarExamenXAlumno(Matricula, idExamen, calificacion);

                // Actualiza el DataGridView
                DataTable dt = CargarTablaExamenes(IdCarrera, Matricula);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar examen: {ex.Message}");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del examen asignado y la nueva calificación
                int idExamenXAlumno = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_examenxalumno"].Value);  
                int idExamen = Convert.ToInt32(txtIdExamen.Text);  
                decimal calificacion = Convert.ToDecimal(txtCalificacion.Text);  

                Gestorexamenesalumnos.ActualizarExamenXAlumno(idExamenXAlumno, idExamen, calificacion);

                // Actualizo la grilla
                CargarTablaExamenes(IdCarrera, Matricula); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar examen: {ex.Message}");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
