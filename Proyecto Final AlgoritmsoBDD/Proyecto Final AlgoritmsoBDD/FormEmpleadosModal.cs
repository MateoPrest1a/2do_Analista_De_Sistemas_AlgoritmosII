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
            if (idprofesor != 0)
                lblEmpleado.Text = idprofesor.ToString();
            txtNombreEmpleados.Text = nombre;
            txtApellidoEmpleados.Text = apellido;
            txtDireCalleEmpleados.Text = direccioncalle;
            txtDireNumeroEmpleados.Text = Convert.ToString(direccionnumero);
            txtTelefonoEmpleados.Text = telefono;
            txtDocumentoEmpleados.Text = dni;
            txtEmailEmpleados.Text = email;
            dtpFechaNacimientoEmpleado.Value = fechanacimiento;
            txtSalarioEmpleados.Text = Convert.ToString(salario);
            cmbEspecialidadEmpleado.SelectedItem = especialidad;


        }

        private void FormEmpleadosModal_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
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
                    int idprofesor = 0;
                    string NombreEmpleado = "";
                    string ApellidoEmpleado = "";
                    string Direcalle = "";
                    int Direnum = 0;
                    string TelefonoEmpleado = "";
                    string DocumentoEmpleado = "";
                    string EmailEmpleado = "";
                    DateTime FechaNacimientoEmpleado= DateTime.Now;
                    int salario = 0;
                    int especialidad = 0;

            //NOMBRE EMPLEADO

            if (txtNombreEmpleados.Text == "")
            {
                MessageBox.Show("Ingrese un nombre");
            }
            else
            {
                NombreEmpleado= txtNombreEmpleados.Text;
            }
            //APELLIDO EMPLEADO
            if (txtApellidoEmpleados.Text == "")
            {
               MessageBox.Show("Ingrese un apellido");
            } 
            else
            {
                ApellidoEmpleado = txtApellidoEmpleados.Text;
            }

            //DIRECCION CALLE EMPLEADO

            if (txtDireCalleEmpleados.Text== "")
            {
                MessageBox.Show("Ingrese una calle");
            }
            else
            {
                Direcalle = txtDireCalleEmpleados.Text;
            }

    //NUMERO CALLE EMPLEADO
            if (txtDireNumeroEmpleados.Text == "")
            {
                MessageBox.Show("Ingrese un valor para el Numero de Direccion");
            }
            else
            {
                if (int.TryParse(txtDireNumeroEmpleados.Text, out  Direnum))
                {
                    
                }
                else
                {

                    MessageBox.Show("Por favor ingrese un número válido.");
                }
            }

        //TELEFONO EMPLEADO
        if (txtTelefonoEmpleados.Text == "")
        {
            MessageBox.Show("Ingrese un numero de telefono valido");
        }

            if (txtTelefonoEmpleados.Text == "")
            {
                MessageBox.Show("Ingrese un valor para el numero de telefono");
            }
            else
            {
                if (double.TryParse(txtTelefonoEmpleados.Text, out  double numerito))
                {
                    TelefonoEmpleado = txtTelefonoEmpleados.Text;
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un número válido.");
                }
            }
            //DOCUMENTO EMPLEADO
            if (txtDocumentoEmpleados.Text == "")
            {
                MessageBox.Show("Ingrese un numero de documento");
            }
            else 
            {
                if(double.TryParse(txtDocumentoEmpleados.Text,out double numerito)) 
                {
                    DocumentoEmpleado = txtDocumentoEmpleados.Text;
                }
            }
            //EMAIL
            if (txtEmailEmpleados.Text == "")
            {
                MessageBox.Show("Ingrese un email");
            }
            else
            {
            EmailEmpleado= txtEmailEmpleados.Text;
            }
            //FECHA DE NACIMIENTO dtpFechaNacimientoEmpleado.Value 

            if (dtpFechaNacimientoEmpleado.Value == DateTime.Now)
            {
                MessageBox.Show("Ingrese una fecha de nacimiento");
            }
            else
            {
                FechaNacimientoEmpleado = dtpFechaNacimientoEmpleado.Value;
            }
            
            //SALARIO
            if (txtSalarioEmpleados.Text == "")
            {
                MessageBox.Show("Ingrese un salario");
            }
            else
            {
                if (int.TryParse(txtSalarioEmpleados.Text,out salario))
                {

                }
                else
                {
                    MessageBox.Show("Ingrese un numero valido");
                }
            }
            //ESPECIALIDAD
            if (cmbEspecialidadEmpleado.SelectedValue is 0 )
            {
                MessageBox.Show("Seleccione un valor valido");
            }
    
                if (cmbEspecialidadEmpleado.SelectedValue is 1)


//CARGA A LA BASE DE DATOS
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
    }
}
