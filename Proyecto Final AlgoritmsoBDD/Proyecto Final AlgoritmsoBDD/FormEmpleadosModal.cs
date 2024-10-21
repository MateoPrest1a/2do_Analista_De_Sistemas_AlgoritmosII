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
            if (idprofesor != 0)
            {
                lblEmpleado.Text = idprofesor.ToString();
            }
            else
            {
                lblEmpleado2.Visible = false;
                lblEmpleado.Visible = false;
                txtDireNumeroEmpleados.Clear();
                txtSalarioEmpleados.Clear();
            }
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
            string NombreEmpleado = "";
            string ApellidoEmpleado = "";
            string Direcalle = "";
            int Direnum = 0;
            string TelefonoEmpleado = "";
            string DocumentoEmpleado = "";
            string EmailEmpleado = "";
            DateTime FechaNacimientoEmpleado = DateTime.Now;
            int salario = 0;
            int especialidad = 0;

            //NOMBRE EMPLEADO

            if (txtNombreEmpleados.Text == "")
            {
                error1.SetError(txtNombreEmpleados, "Nombre Invalido");
                txtNombreEmpleados.Focus();
                return;
            }
            else
            {
                NombreEmpleado = txtNombreEmpleados.Text;
                error1.Clear();
            }

            //APELLIDO EMPLEADO
            if (txtApellidoEmpleados.Text == "")
            {
                error1.SetError(txtApellidoEmpleados, "Apellido Invalido");
                txtApellidoEmpleados.Focus();
                return;
            }
            else
            {
                ApellidoEmpleado = txtApellidoEmpleados.Text;
            }

            //DIRECCION CALLE EMPLEADO

            if (txtDireCalleEmpleados.Text == "")
            {
                error1.SetError(txtDireCalleEmpleados, "Calle Invalida");
                txtDireCalleEmpleados.Focus();
                return;
            }
            else
            {
                Direcalle = txtDireCalleEmpleados.Text;
            }

            //NUMERO CALLE EMPLEADO
            if (txtDireNumeroEmpleados.Text == "")
            {
                error1.SetError(txtDireNumeroEmpleados, "Calle Invalida");
                txtDireNumeroEmpleados.Focus();
                return;
            }
            else
            {
                if (int.TryParse(txtDireNumeroEmpleados.Text, out Direnum))
                {
                    error1.Clear();
                }
                else
                {
                    error1.SetError(txtDireNumeroEmpleados, "Calle Invalida");
                    txtDireNumeroEmpleados.Focus();
                    return;
                }
            }

            //TELEFONO EMPLEADO
            if (txtTelefonoEmpleados.Text == "")
            {
                error1.SetError(txtTelefonoEmpleados, "Telefono Invalido");
                txtTelefonoEmpleados.Focus();
                return;
            }
            else
            {
                if (double.TryParse(txtTelefonoEmpleados.Text, out double numerito))
                {
                    TelefonoEmpleado = txtTelefonoEmpleados.Text;
                    error1.Clear();
                }
                else
                {
                    error1.SetError(txtTelefonoEmpleados, "Ingrese un numero valido");
                    txtTelefonoEmpleados.Focus();
                    return;
                }
            }
            //DOCUMENTO EMPLEADO
            if (txtDocumentoEmpleados.Text == "")
            {
                error1.SetError(txtDocumentoEmpleados, "Documento Invalido");
                txtDocumentoEmpleados.Focus();
                return;
            }
            else
            {
                if (double.TryParse(txtDocumentoEmpleados.Text, out double numerito))
                {
                    DocumentoEmpleado = txtDocumentoEmpleados.Text;
                    error1.Clear();
                }
            }
            //EMAIL
            if (txtEmailEmpleados.Text == "")
            {
                error1.SetError(txtEmailEmpleados, "Email Invalido");
                txtEmailEmpleados.Focus();
                return;
            }
            else
            {
                EmailEmpleado = txtEmailEmpleados.Text;
            }
            //FECHA DE NACIMIENTO dtpFechaNacimientoEmpleado.Value 

            if (dtpFechaNacimientoEmpleado.Value == DateTime.Now)
            {
                error1.SetError(dtpFechaNacimientoEmpleado, "Fecha Nacimiento Invalida");
                dtpFechaNacimientoEmpleado.Focus();
                return;
            }
            else
            {
                FechaNacimientoEmpleado = dtpFechaNacimientoEmpleado.Value;
                error1.Clear();
            }

            //SALARIO
            if (txtSalarioEmpleados.Text == "")
            {
                error1.SetError(txtSalarioEmpleados, "Salario Invalido");
                txtSalarioEmpleados.Focus();
                return;
            }
            else
            {
                if (int.TryParse(txtSalarioEmpleados.Text, out salario))
                {
                    error1.Clear();
                }
                else
                {
                    MessageBox.Show("Ingrese un numero valido");
                }
            }
            //ESPECIALIDAD
            if (cmbEspecialidadEmpleado.SelectedValue is 0)
            {
                error1.SetError(cmbEspecialidadEmpleado, "Especialidad Invalida");
                cmbEspecialidadEmpleado.Focus();
                return;
            }
            else
            {
                especialidad = Convert.ToInt32(cmbEspecialidadEmpleado.SelectedValue);
                error1.Clear();
            }

             //CARGA A LA BASE DE DATOS
            conexionbdd.CargarEmpleado(NombreEmpleado, ApellidoEmpleado, Direcalle, Direnum, TelefonoEmpleado, DocumentoEmpleado, EmailEmpleado, FechaNacimientoEmpleado, salario, especialidad);
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
