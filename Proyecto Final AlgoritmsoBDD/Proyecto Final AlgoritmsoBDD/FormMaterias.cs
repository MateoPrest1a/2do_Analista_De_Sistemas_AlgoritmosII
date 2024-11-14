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

                    FormMateriasModal formmateriasmodal = new FormMateriasModal(ID, Año, Nombre, idcarrera);
                    formmateriasmodal.MateriaEvento += ActualizarDataGridView;
                    formmateriasmodal.ShowDialog();
                }
                catch
                {
                    int ID = 0;
                    int Año = 0;
                    string Nombre = "";
                    int idcarrera = 0;

                    FormMateriasModal formmateriasmodal = new FormMateriasModal(ID, Año, Nombre, idcarrera);
                    formmateriasmodal.MateriaEvento += ActualizarDataGridView;
                    formmateriasmodal.ShowDialog();
                }

            }



        }

        private void CargarTabla()
        {
            string consulta = @"SELECT  
                                    m.id_materia as ID, 
                                    m.anio_cursada as Año, 
                                    m.nombre_materia as Materia,
                                    c.nombre_carrera AS Carrera,
                                    c.id_carrera
                                FROM 
                                    Materias as m
                                JOIN MateriasxCarrera as mc ON m.id_materia = mc.id_materia
                                JOIN Carreras as c ON mc.id_carrera = c.id_carrera;";

            SqlCommand command = new SqlCommand(consulta);

            try
            {
                DataTable dt = GestorMaterias.EjecutarConsulta(command); // Usa la clase gestora para ejecutar la consulta
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id_carrera"].Visible = false;
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
