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
using static Proyecto_Final_AlgoritmsoBDD.FormAlumnosModal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class FormEmpleadosModal : Form
    {
        private GestorEmpleados gestorEmpleados = new GestorEmpleados();

        public event Action EmpleadoEvento; //Evento para actualizar el datagridview

        SqlConnection conexion = Conexionbdd.ObtenerInstancia().ObtenerConexion();

        private void CargarEspecialidades()
        {
            var especialidades = new List<Especialidad>
            {
                new Especialidad { IdEspecialidad = 1, especialidad = "Personal Administrativo" },
                new Especialidad { IdEspecialidad = 2, especialidad = "Profesor" }
            };

            cmbEspecialidadEmpleado.DataSource = especialidades;
            cmbEspecialidadEmpleado.DisplayMember = "Especialidad";  // Lo que se muestra en el ComboBox
            cmbEspecialidadEmpleado.ValueMember = "IdEspecialidad"; // El valor que necesitas
        }

        public FormEmpleadosModal(int idprofesor, string nombre, string apellido, string direccioncalle, string direccionnumero, string telefono, string dni, string email, DateTime fechanacimiento, decimal salario, int especialidad)
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

        


        private void ValidarCampo(TextBox textBox, string mensaje)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                error1.SetError(textBox, mensaje);
                textBox.Focus();
                return;
            }
            error1.Clear();

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

            ValidarCampo(txtNombreEmpleados, "Nombre Invalido");
            NombreEmpleado = txtNombreEmpleados.Text;

            //APELLIDO EMPLEADO

            ValidarCampo(txtApellidoEmpleados, "Apellido Invalido");
            ApellidoEmpleado = txtApellidoEmpleados.Text;

            //DIRECCION CALLE EMPLEADO

            ValidarCampo(txtDireCalleEmpleados, "Calle Invalida");
            Direcalle = txtDireCalleEmpleados.Text;


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

            ValidarCampo(txtEmailEmpleados, "Email Invalido");
            EmailEmpleado = txtEmailEmpleados.Text;

            //FECHA DE NACIMIENTO 

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

            // CARGA A LA BASE DE DATOS
            gestorEmpleados.CargarEmpleado(NombreEmpleado, ApellidoEmpleado, Direcalle, Direnum, TelefonoEmpleado, DocumentoEmpleado, EmailEmpleado, FechaNacimientoEmpleado, salario, especialidad);
            EmpleadoEvento?.Invoke();
            this.Close();
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            int idempleado = Convert.ToInt32(lblEmpleado.Text);
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

            ValidarCampo(txtNombreEmpleados, "Nombre Invalido");
            NombreEmpleado = txtNombreEmpleados.Text;

            //APELLIDO EMPLEADO

            ValidarCampo(txtApellidoEmpleados, "Apellido Invalido");
            ApellidoEmpleado = txtApellidoEmpleados.Text;

            //DIRECCION CALLE EMPLEADO

            ValidarCampo(txtDireCalleEmpleados, "Calle Invalida");
            Direcalle = txtDireCalleEmpleados.Text;


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

            ValidarCampo(txtEmailEmpleados, "Email Invalido");
            EmailEmpleado = txtEmailEmpleados.Text;

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

            // CARGO A LA BDD
            gestorEmpleados.ActualizarEmpleado(idempleado, NombreEmpleado, ApellidoEmpleado, Direcalle, Direnum, TelefonoEmpleado, DocumentoEmpleado, EmailEmpleado, FechaNacimientoEmpleado, salario, especialidad);
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
                gestorEmpleados.EliminarEmpleado(idempleado); // Uso la clase GestorEmpleados
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
