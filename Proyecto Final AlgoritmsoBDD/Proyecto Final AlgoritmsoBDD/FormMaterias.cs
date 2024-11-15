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
    public partial class FormMaterias : Form
    {
        GestorMaterias GestorMaterias = new GestorMaterias();

        public FormMaterias()
        {
            InitializeComponent();
        }
        private void FormMaterias_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
                    int Año = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Año"].Value);
                    string Nombre = dataGridView1.Rows[e.RowIndex].Cells["Materia"].Value.ToString();
                    int idcarrera = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_carrera"].Value);
                    int idempleado = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID_Empleado"].Value);


                    FormMateriasModal formmateriasmodal = new FormMateriasModal(ID, Año, Nombre, idcarrera, idempleado);
                    formmateriasmodal.MateriaEvento += ActualizarDataGridView;
                    formmateriasmodal.ShowDialog();
                }
                catch
                {
                    int ID = 0;
                    int Año = 0;
                    string Nombre = "";
                    int idcarrera = 0;
                    int idprofesor = 0;

                    FormMateriasModal formmateriasmodal = new FormMateriasModal(ID, Año, Nombre, idcarrera, idprofesor);
                    formmateriasmodal.MateriaEvento += ActualizarDataGridView;
                    formmateriasmodal.ShowDialog();
                }

            }



        }

        private void CargarTabla()
        {
            string consulta = @"
                                SELECT  
                                    m.id_materia AS ID, 
                                    m.anio_cursada AS Año, 
                                    m.nombre_materia AS Materia,
                                    c.nombre_carrera AS Carrera,
                                    c.id_carrera,
                                    CONCAT(e.apellido, ', ', e.nombre) AS Profesor,
                                    e.id_empleado AS ID_Empleado
                                FROM 
                                    Materias AS m
                                JOIN 
                                    MateriasxCarrera AS mc ON m.id_materia = mc.id_materia
                                JOIN 
                                    Carreras AS c ON mc.id_carrera = c.id_carrera
                                LEFT JOIN 
                                    MateriasxProfesor AS mp ON m.id_materia = mp.id_materia --LEFT JOIN para que incluso muestre materias si no tienen profesor(no puede pasar)
                                LEFT JOIN 
                                    Empleados AS e ON mp.id_profesor = e.id_empleado;";

            SqlCommand command = new SqlCommand(consulta);

            try
            {
                // Uso la clase gestora para ejecutar la consulta
                DataTable dt = GestorMaterias.EjecutarConsulta(command);


                dataGridView1.DataSource = dt;


                dataGridView1.Columns["id_carrera"].Visible = false;
                dataGridView1.Columns["ID_Empleado"].Visible = false;

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

        private void ActualizarDataGridView()
        {
            CargarTabla();
        }
    }
}
