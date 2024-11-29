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

        int Matricula;
        public FormHistorialExamenAlumno(int matricla)
        {
            InitializeComponent();
            CargarTabla(matricla);
            CargarMateriasPorAlumno(matricla);
            cmbFiltrosExamenxAlumno.Items.Add("Materias");
            Matricula = matricla;
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


        //cargo combo box

        private void CargarMateriasPorAlumno(int matricula)
        {
            try
            {
                // Obtengo el ID de la carrera del alumno
                string queryCarrera = "SELECT id_carrera FROM Alumnos WHERE matricula = @matricula";
                int idCarrera;

                using (SqlCommand command = new SqlCommand(queryCarrera, conexion))
                {
                    command.Parameters.AddWithValue("@matricula", matricula);

                    // Ejecutar la consulta y obtener el resultado
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        idCarrera = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un alumno con esa matrícula.");
                        return;
                    }
                }

                // Llamo al método CargarMaterias con el idCarrera obtenido
                CargarMaterias(idCarrera);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las materias: " + ex.Message);
            }
        }
        private void CargarMaterias(int idCarrera)
        {
            string query = @"SELECT 
                         m.id_materia, 
                         m.nombre_materia 
                     FROM 
                         Materias as M
                    INNER JOIN 
                        Carreras c ON m.id_carrera = c.id_carrera
                    WHERE 
                        c.id_carrera = @idCarrera";
            try
            {
                // Crear el comando SQL
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idCarrera", idCarrera); // Añadir el parámetro

                    // Usar la clase gestora para ejecutar la consulta
                    DataTable materiasTable = gestorexamenes.EjecutarConsulta(command);

                    cmbMateriasExamenAlumno.Items.Clear(); // Limpia el ComboBox antes de llenarlo

                    foreach (DataRow row in materiasTable.Rows)
                    {
                        var materia = new Materia
                        {
                            ID_Materia = Convert.ToInt32(row["id_materia"]),
                            Nombre_Materia = row["nombre_materia"].ToString()
                        };

                        // Agregar la materia al ComboBox
                        cmbMateriasExamenAlumno.Items.Add(materia);
                    }

                    // Configura DisplayMember y ValueMember si es necesario
                    cmbMateriasExamenAlumno.DisplayMember = "nombre_materia"; // Lo que se muestra en el ComboBox
                    cmbMateriasExamenAlumno.ValueMember = "id_materia"; // El valor que se utilizará
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las materias: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbFiltrosExamenxAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Generar reporte en txt
        private void GenerarReporteTXT()
        {
            try
            {
                // Usar el SaveFileDialog para elegir dónde guardar el archivo TXT
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files|*.txt";
                    saveFileDialog.Title = "Guardar reporte como";
                    saveFileDialog.FileName = "reporte_alumnos.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaArchivo = saveFileDialog.FileName;

                        // Crear el archivo TXT y escribir en él
                        using (StreamWriter writer = new StreamWriter(rutaArchivo))
                        {
                            writer.WriteLine("Reporte General de Alumnos");
                            writer.WriteLine();

                            // Escribir los encabezados de las columnas
                            foreach (DataGridViewColumn col in dataGridView1.Columns)
                            {
                                writer.Write(col.HeaderText + "\t"); // Usamos tabulador para separar las columnas
                            }
                            writer.WriteLine();  // Salto de línea después de los encabezados

                            // Escribir los datos de las filas
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                // Solo procesamos filas no vacías (filas de datos)
                                if (!row.IsNewRow)
                                {
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        string cellValue = cell.Value?.ToString() ?? "";
                                        writer.Write(cellValue + "\t");  // Usamos tabulador para separar las celdas
                                    }
                                    writer.WriteLine();  // Salto de línea después de cada fila
                                }
                            }

                            MessageBox.Show("Reporte generado exitosamente en: " + rutaArchivo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                MessageBox.Show("Error al generar el reporte: " + ex.Message);
            }
        }

        private void btnReporteAlumnoExamenes_Click(object sender, EventArgs e)
        {
            GenerarReporteTXT();
        }


        // Filtrar por Materias
        private void CargarTablaxMaterias(int matricula, int idMateria)
        {
            try
            {
          
                SqlCommand command = new SqlCommand("sp_ObtenerExamenesPorAlumnoYMateria", conexion);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Matricula", matricula);
                command.Parameters.AddWithValue("@IdMateria", idMateria);


                DataTable dt = gestorexamenes.EjecutarConsulta(command);

      
                dataGridView1.DataSource = dt;

                // Ocultar columnas no necesarias
                dataGridView1.Columns["id_carrera"].Visible = false;
                dataGridView1.Columns["id_materia"].Visible = false;
                dataGridView1.Columns["id_examenxalumno"].Visible = false;
                dataGridView1.Columns["id_examen"].Visible = false;
                dataGridView1.Columns["matricula"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }

        private void btnFiltrarExamenxAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMateriasExamenAlumno.SelectedItem is Materia materiaSeleccionada) 
                {
                    int idMateria = materiaSeleccionada.ID_Materia; 
                    int matricula = Matricula; 

                    if (matricula > 0)
                    {
                        CargarTablaxMaterias(matricula, idMateria);
                    }
                    else
                    {
                        MessageBox.Show("Por favor selecciona un alumno válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor selecciona una materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al filtrar los exámenes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRecargarTablaAlumnos_Click(object sender, EventArgs e)
        {
            CargarTabla(Matricula);
        }
    }

}
