using Proyecto_Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class FormAlumnosModal : Form
    {
        Conexionbdd conexionbdd = new Conexionbdd();

        public event Action AlumnoEvento; //Evento para actualizar el datagridview

        private class Carrera
        {
            public int IdCarrera { get; set; }
            public string Nombre { get; set; }
        }

        private void CargarCarreras()
        {
            var carreras = new List<Carrera>
            {
                new Carrera { IdCarrera = 1, Nombre = "Analista de Sistemas" },
                new Carrera { IdCarrera = 2, Nombre = "Publicidad" }
            };

            cmbCarrerasAlumnos.DataSource = carreras;
            cmbCarrerasAlumnos.DisplayMember = "Nombre";  // Lo que se muestra en el ComboBox
            cmbCarrerasAlumnos.ValueMember = "IdCarrera"; // El valor que necesitas
        }


        private void FormAlumnosModal_Load(object sender, EventArgs e)
        {
            CargarCarreras();
        }
        public FormAlumnosModal(int matricula, string nombre, string apellido, string direcalle, string direnum, string telefono, string documento, string email, DateTime fechanacimientoalumno, int carrera)
        {
            InitializeComponent();
            if (matricula != 0)
            {
                lblMatriculaAlumno.Text = matricula.ToString();
            }
            txtNombreAlumno.Text = nombre;
            txtApellidoAlumno.Text = apellido;
            txtDireCalleAlumno.Text = direcalle;
            txtDireNumeroAlumno.Text = direnum;
            txtTelefonoAlumno.Text = telefono;
            txtDocumentoAlumno.Text = documento;
            dtpFechaNacimientoAlumno.Value = fechanacimientoalumno;
            txtEmailAlumno.Text = email;
            cmbCarrerasAlumnos.SelectedItem = carrera;
        }

        private void txtNombreAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            /*MATRICULA
            if (txtMatricula.Text = "")
            {
                MessageBox.Show("Ingrese un valor para la matricula");
            }
            else
            {
                Matricula = int.Parse(txtMatricula.Text);
            }
            */

            string NombreAlumno = "", ApellidoAlumno = "", Direccion_Calle = "", DocumentoAlumno = "", TelefonoAlumno = "", EmailAlumno = "";
            int NumeroDireccionAlumno = 0;

            //NOMBRE
            if (txtNombreAlumno.Text == "")
            {
                MessageBox.Show("Ingrese un nombre");
            }
            else
            {
                 NombreAlumno = txtNombreAlumno.Text;
            }

            //APELLIDO
            if (txtApellidoAlumno.Text == "")
            {
                MessageBox.Show("Ingrese un apellido");
            }
            else
            {
                 ApellidoAlumno = txtApellidoAlumno.Text;
            }

            //DIRECCION CALLE
            if (txtDireCalleAlumno.Text == "")
            {
                MessageBox.Show("Ingrese una direccion");
            }
            else
            {
               Direccion_Calle = txtDireCalleAlumno.Text;
            }

            //DIRECCION NUMERO

            if (txtDireNumeroAlumno.Text == "")
            {
                MessageBox.Show("Ingrese un valor para el Numero de Direccion");
            }
            else
            {
                if (int.TryParse(txtDireNumeroAlumno.Text, out  NumeroDireccionAlumno))
                {
                }
                else
                {

                    MessageBox.Show("Por favor ingrese un número válido.");
                }
            }
            //DNI
            if (txtDocumentoAlumno.Text == "")
            {
                MessageBox.Show("Ingrese un valor para el Numero de Documento");
            }
            else
            {
                 DocumentoAlumno = txtDocumentoAlumno.Text;
            }
            //Numero de telefono
            if (txtTelefonoAlumno.Text == "")
            {
                MessageBox.Show("Ingrese un valor para el Numero de Telefono");
            }
            else
            {
                 TelefonoAlumno = txtTelefonoAlumno.Text;
            }
            //EMAIL
            if (txtEmailAlumno.Text == "")
            {
                MessageBox.Show("Ingrese un valor para el email");
            }
            else
            {
                 EmailAlumno= txtEmailAlumno.Text;
            }

            conexionbdd.CargarAlumno(NombreAlumno,ApellidoAlumno,Direccion_Calle, NumeroDireccionAlumno,TelefonoAlumno,DocumentoAlumno,EmailAlumno,dtpFechaNacimientoAlumno.Value, Convert.ToInt32(cmbCarrerasAlumnos.SelectedValue));

            AlumnoEvento?.Invoke();

            this.Close();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexionbdd.ActualizarAlumno(Convert.ToInt32(lblMatriculaAlumno.Text), txtNombreAlumno.Text, txtApellidoAlumno.Text, txtDireCalleAlumno.Text, Convert.ToInt32(txtDireNumeroAlumno.Text), txtTelefonoAlumno.Text, txtDocumentoAlumno.Text, txtEmailAlumno.Text, dtpFechaNacimientoAlumno.Value, Convert.ToInt32(cmbCarrerasAlumnos.SelectedValue));
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
    }
}
