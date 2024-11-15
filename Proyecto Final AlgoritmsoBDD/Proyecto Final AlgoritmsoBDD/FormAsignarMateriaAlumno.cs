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
    public partial class FormAsignarMateriaAlumno : Form
    {
        GestorMaterias gestor = new GestorMaterias();
        public FormAsignarMateriaAlumno(int idalumno, int idcarrera, int año)
        {
            InitializeComponent();

            cmbEstado.Items.Add("Cursando");
            cmbEstado.Items.Add("Cursada Aprobada");
            cmbEstado.Items.Add("Cursada Desaprobada");

            CargarTablaMateriasPorCarrera(idcarrera, año);
            txtAlumno.Text = idalumno.ToString();
        }

        public void CargarTablaMateriasPorCarrera(int idCarrera, int añoAlumno)
        {
            string consulta = @"
                                SELECT 
                                    m.id_materia, 
                                    m.nombre_materia, 
                                    m.anio_cursada
                                FROM 
                                    Materias m
                                JOIN 
                                    Carreras c ON m.id_carrera = c.id_carrera
                                WHERE 
                                    c.id_carrera = @id_carrera
                                    AND m.anio_cursada = @añoAlumno;";  // Compara el año de la materia con el año del alumno

            SqlCommand command = new SqlCommand(consulta);
            command.Parameters.AddWithValue("@id_carrera", idCarrera);  // Asignar el parámetro id_carrera
            command.Parameters.AddWithValue("@añoAlumno", añoAlumno);  // Asignar el parámetro año del alumno

            try
            {
                DataTable dt = gestor.EjecutarConsulta(command); // Ejecutar la consulta
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id_materia"].Visible = false; // Ocultar la columna id_materia
            }
            catch (Exception ex)
            {
                // Manejar excepciones, por ejemplo, mostrar un mensaje de error
                MessageBox.Show("Error al cargar la tabla de materias: " + ex.Message);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si la fila seleccionada es válida (no cabecera)
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Obtener el valor del id_materia (suponiendo que está en la primera columna)
                    int idMateria = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_materia"].Value);

                    // Asignar el id_materia al TextBox
                    txtIdMateria.Text = idMateria.ToString();  // Asumiendo que tienes un TextBox llamado txtIdMateria

                    // Si necesitas realizar alguna acción adicional con el id_materia, puedes hacerlo aquí
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el id_materia: " + ex.Message);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                int matricula = Convert.ToInt32(txtAlumno.Text);
                int idMateria = Convert.ToInt32(txtIdMateria.Text);  
                string estado = cmbEstado.SelectedItem.ToString();

                if (estado.Length > 50)
                {
                    MessageBox.Show("El valor de estado es demasiado largo. Debe tener 50 caracteres o menos.");
                    return;
                }

                // Crear instancia del gestor y llamar al método
                GestorMaterias gestor = new GestorMaterias();
                gestor.AgregarMateriaAAlumno(matricula, idMateria, estado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        
        private void btnModificar_Click(object sender, EventArgs e)
        {
           
        }
        
    }
}
