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
    public partial class FormMateriasModal : Form
    {
        string consulta = "SELECT nombre FROM Empleados";
        public FormMateriasModal()
        {
            InitializeComponent();
        }
        private void CargarProfesores()
        {
            using (SqlConnection connection = new SqlConnection(consulta))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Nombre FROM Profesores", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbProfesores.Items.Add(reader["Nombre"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar profesores: " + ex.Message);
                }
            }
        }

        private void cmbProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
