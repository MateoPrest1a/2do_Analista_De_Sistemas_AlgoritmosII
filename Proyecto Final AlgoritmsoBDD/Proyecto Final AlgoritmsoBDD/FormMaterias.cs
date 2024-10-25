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
        Conexionbdd conectarBDD;

        public FormMaterias()
        {
            InitializeComponent();
            conectarBDD = new Conexionbdd();
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

                    FormMateriasModal formmateriasmodal = new FormMateriasModal(ID, Año, Nombre);
                    formmateriasmodal.MateriaEvento += ActualizarDataGridView;
                    formmateriasmodal.ShowDialog();
                }
                catch
                {
                    int ID = 0;
                    int Año = 0;
                    string Nombre = "";

                    FormMateriasModal formmateriasmodal = new FormMateriasModal(ID, Año, Nombre);
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
                                    mc.id_carrera AS Carrera
                                FROM 
                                    Materias as m
                                JOIN MateriasxCarrera as mc ON m.id_materia = mc.id_materia;";

            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectarBDD.conectarbdd);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Manejar excepciones, por ejemplo, mostrar un mensaje de error
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
            finally
            {
                conectarBDD.cerrar(); // Cerrar la conexión después de usarla
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarDataGridView()
        {
            string consulta = "SELECT id_materia as ID, anio_cursada as Año, nombre_materia as Materia FROM Materias";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conectarBDD.conectarbdd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
