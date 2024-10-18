using Proyecto_Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Final_AlgoritmsoBDD.FormAlumnosModal;

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class FormAlumnosModal : Form
    {
        Conexionbdd conexionbdd = new Conexionbdd();

        public event Action AlumnoEvento; //Evento para actualizar el datagridview


        public class Carrera
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            // Esto es lo que se mostrará en el ComboBox
            public override string ToString()
            {
                return Nombre;
            }
        }

        private void CargarCarreras()
        {
            string query = "SELECT id_carrera, nombre_carrera FROM Carreras";

            using (var connection = conexionbdd.GetConnection())
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Limpia el ComboBox antes de llenarlo
                            cmbCarrerasAlumnos.Items.Clear();

                            while (reader.Read())
                            {
                                // Crear un nuevo objeto para almacenar la carrera
                                var carrera = new Carrera
                                {
                                    Id = reader.GetInt32(0), // id_carrera
                                    Nombre = reader.GetString(1) // nombre_carrera
                                };

                                // Agregar la carrera al ComboBox
                                cmbCarrerasAlumnos.Items.Add(carrera);
                            }
                        }
                    }

                    // Configura DisplayMember y ValueMember
                    cmbCarrerasAlumnos.DisplayMember = "Nombre"; // Lo que se muestra en el ComboBox
                    cmbCarrerasAlumnos.ValueMember = "Id"; // El valor que se utilizará
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar las carreras: {ex.Message}");
                }
            }
        }


        private void FormAlumnosModal_Load(object sender, EventArgs e)
        {
            CargarCarreras();
        }

        public FormAlumnosModal(int matricula, string nombre, string apellido, string direcalle, string direnum, string telefono, string documento, string email, DateTime fechanacimientoalumno, int idcarrera)
        {
            InitializeComponent();

            CargarCarreras();

            if (matricula != 0)
            {
                lblMatriculaAlumno.Text = matricula.ToString();
                btnAgregar.Visible = false;
            }
            else
            {
                lblMatriculaAlumno.Visible = false;
                lblMatricula.Visible = false; //Hacemos invisible para que al agregar alumno nuevo no se vea el label "Matricula :"
            }
            txtNombreAlumno.Text = nombre;
            txtApellidoAlumno.Text = apellido;
            txtDireCalleAlumno.Text = direcalle;
            txtDireNumeroAlumno.Text = direnum;
            txtTelefonoAlumno.Text = telefono;
            txtDocumentoAlumno.Text = documento;
            dtpFechaNacimientoAlumno.Value = fechanacimientoalumno;
            txtEmailAlumno.Text = email;

            foreach (Carrera carrera in cmbCarrerasAlumnos.Items)
            {
                if (carrera.Id == idcarrera)
                {
                    cmbCarrerasAlumnos.SelectedItem = carrera;
                    break;
                }
            }

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexionbdd.CargarAlumno(txtNombreAlumno.Text, txtApellidoAlumno.Text, txtDireCalleAlumno.Text, Convert.ToInt32(txtDireNumeroAlumno.Text), txtTelefonoAlumno.Text, txtDocumentoAlumno.Text, txtEmailAlumno.Text, dtpFechaNacimientoAlumno.Value, Convert.ToInt32(((Carrera)cmbCarrerasAlumnos.SelectedItem).Id));

            AlumnoEvento?.Invoke();

            this.Close();

        }


        //Resuelto para cargar el id de la carrera y no se rompa
        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexionbdd.ActualizarAlumno(Convert.ToInt32(lblMatriculaAlumno.Text), txtNombreAlumno.Text, txtApellidoAlumno.Text, txtDireCalleAlumno.Text, Convert.ToInt32(txtDireNumeroAlumno.Text), txtTelefonoAlumno.Text, txtDocumentoAlumno.Text, txtEmailAlumno.Text, dtpFechaNacimientoAlumno.Value, Convert.ToInt32(((Carrera)cmbCarrerasAlumnos.SelectedItem).Id));
            AlumnoEvento?.Invoke();
            this.Close();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int matricula = Convert.ToInt32(lblMatriculaAlumno.Text);


            DialogResult result = MessageBox.Show(
            "¿Está seguro de que desea eliminar este alumno?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                conexionbdd.EliminarAlumno(matricula);
                AlumnoEvento?.Invoke();

            }
            else
            {
                MessageBox.Show("La eliminación ha sido cancelada.");

            }
            this.Close();
        }

        private void txtNombreAlumno_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnExamenesRendidos_Click(object sender, EventArgs e)
        {
            FormExamenesRendidos formexamenesrendidos = new FormExamenesRendidos(Convert.ToInt32(lblMatriculaAlumno.Text));


        }

        private void cmbCarrerasAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
