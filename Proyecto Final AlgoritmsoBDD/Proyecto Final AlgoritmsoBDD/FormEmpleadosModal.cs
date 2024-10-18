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
    public partial class FormEmpleadosModal : Form
    {
        Conexionbdd conexionbdd = new Conexionbdd();

        public event Action EmpleadoEvento; //Evento para actualizar el datagridview
        private class Especialidad
        {
            public int IdEspecialidad { get; set; }
            public string especialidad { get; set; }
        }

        private void CargarEspecialidades()
        {
            var especialidades = new List<Especialidad>
            {
                new Especialidad { IdEspecialidad = 1, especialidad = "Profesor" },
                new Especialidad { IdEspecialidad = 2, especialidad = "Personal Administrativo" }
            };

            cmbEspecialidadEmpleado.DataSource = especialidades;
            cmbEspecialidadEmpleado.DisplayMember = "Especialidad";  // Lo que se muestra en el ComboBox
            cmbEspecialidadEmpleado.ValueMember = "IdEspecialidad"; // El valor que necesitas
        }

        public FormEmpleadosModal(int idprofesor, string nombre, string apellido, string direccioncalle, int direccionnumero, string telefono, string dni, string email, DateTime fechanacimiento, decimal salario, int especialidad)
        {
            InitializeComponent();

            CargarEspecialidades();

            if (idprofesor != 0)
                lblEmpleado.Text = idprofesor.ToString();
            else
                lblEmpleado2.Visible = false;
            txtNombreEmpleados.Text = nombre;
            txtApellidoEmpleados.Text = apellido;
            txtDireCalleEmpleados.Text = direccioncalle;
            txtDireNumeroEmpleados.Text = Convert.ToString(direccionnumero);
            txtTelefonoEmpleados.Text = telefono;
            txtDocumentoEmpleados.Text = dni;
            txtEmailEmpleados.Text = email;
            dtpFechaNacimientoEmpleado.Value = fechanacimiento;
            txtSalarioEmpleados.Text = Convert.ToString(salario);
            cmbEspecialidadEmpleado.SelectedValue = especialidad;
        }

        private void FormEmpleadosModal_Load(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }





        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            conexionbdd.CargarEmpleado(txtNombreEmpleados.Text, txtApellidoEmpleados.Text, txtDireCalleEmpleados.Text, Convert.ToInt32(txtDireNumeroEmpleados.Text), txtTelefonoEmpleados.Text, txtDocumentoEmpleados.Text, txtEmailEmpleados.Text, dtpFechaNacimientoEmpleado.Value, Convert.ToInt32(txtSalarioEmpleados.Text), Convert.ToInt32(cmbEspecialidadEmpleado.SelectedValue));
            EmpleadoEvento?.Invoke();
            this.Close();
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            conexionbdd.ModificarEmpleado(Convert.ToInt32(lblEmpleado.Text), txtNombreEmpleados.Text, txtApellidoEmpleados.Text, txtDireCalleEmpleados.Text, Convert.ToInt32(txtDireNumeroEmpleados.Text), txtTelefonoEmpleados.Text, txtDocumentoEmpleados.Text, txtEmailEmpleados.Text, dtpFechaNacimientoEmpleado.Value, Convert.ToInt32(txtSalarioEmpleados.Text), Convert.ToInt32(cmbEspecialidadEmpleado.SelectedValue));
            EmpleadoEvento?.Invoke();
            this.Close();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            int idempleado = Convert.ToInt32(lblEmpleado.Text);


            DialogResult result = MessageBox.Show(
            "¿Está seguro de que desea eliminar este Profesor?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                conexionbdd.EliminarEmpleado(idempleado);
                EmpleadoEvento?.Invoke();

            }
            else
            {
                MessageBox.Show("La eliminación ha sido cancelada.");

            }
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
