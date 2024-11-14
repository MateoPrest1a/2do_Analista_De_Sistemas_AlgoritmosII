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
    public partial class FormMateriasXAlumno : Form
    {
        GestorMaterias gestormaterias = new GestorMaterias();
        public FormMateriasXAlumno(int Matricula)
        {
            InitializeComponent();

            CargarMateriasAlumno(Matricula);

        }

        public void CargarMateriasAlumno(int matricula)
        {
            try
            {
                string consulta = @"
                                    SELECT
                                        m.nombre_materia AS Materia, 
                                        m.id_materia, 
                                        m.anio_cursada AS Año, 
                                        c.nombre_carrera AS Carrera,
                                        m.id_carrera
                                    FROM 
                                        MateriasxAlumno AS ma
                                    JOIN 
                                        Materias AS m ON m.id_materia = ma.id_materia
                                    JOIN 
                                        Carreras AS c ON c.id_carrera = m.id_carrera
                                    WHERE 
                                        ma.matricula = @Matricula";


                SqlCommand comando = new SqlCommand(consulta);
                comando.Parameters.AddWithValue("@Matricula", matricula);

                // Ejecuto la consulta usando la clase gestora
                DataTable dt = gestormaterias.EjecutarConsulta(comando); 
                
                
                dataGridView1.DataSource = dt;

                
                dataGridView1.Columns["id_materia"].Visible = false;
                dataGridView1.Columns["id_carrera"].Visible = false; // Oculta la columna
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
    }
}
