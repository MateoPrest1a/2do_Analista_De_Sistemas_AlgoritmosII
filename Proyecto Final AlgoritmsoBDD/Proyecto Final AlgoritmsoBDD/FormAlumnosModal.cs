﻿using Proyecto_Final;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public void Validacion(string n)
        {

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
            string NombreAlumno = "";
            string ApellidoAlumno = "";
            string Direcalle = "";
            int Direnum = 0;
            string TelefonoAlumno = "";
            string DocumentoAlumno = "";
            string EmailAlumno = "";
            DateTime FechaNacimientoAlumno = DateTime.Now;
            int carreraId = 0;

            // NOMBRE ALUMNO
            if (txtNombreAlumno.Text == "")
            {
                error1.SetError(txtNombreAlumno, "Nombre Inválido");
                txtNombreAlumno.Focus();
                return;
            }
            else
            {
                NombreAlumno = txtNombreAlumno.Text;
                error1.Clear();
            }

            // APELLIDO ALUMNO
            if (txtApellidoAlumno.Text == "")
            {
                error1.SetError(txtApellidoAlumno, "Apellido Inválido");
                txtApellidoAlumno.Focus();
                return;
            }
            else
            {
                ApellidoAlumno = txtApellidoAlumno.Text;
                error1.Clear();
            }

            // DIRECCIÓN CALLE
            if (txtDireCalleAlumno.Text == "")
            {
                error1.SetError(txtDireCalleAlumno, "Calle Inválida");
                txtDireCalleAlumno.Focus();
                return;
            }
            else
            {
                Direcalle = txtDireCalleAlumno.Text;
                error1.Clear();
            }

            // NÚMERO CALLE
            if (txtDireNumeroAlumno.Text == "")
            {
                error1.SetError(txtDireNumeroAlumno, "Número Inválido");
                txtDireNumeroAlumno.Focus();
                return;
            }
            else
            {
                if (int.TryParse(txtDireNumeroAlumno.Text, out Direnum))
                {
                    error1.Clear();
                }
                else
                {
                    error1.SetError(txtDireNumeroAlumno, "Número Inválido");
                    txtDireNumeroAlumno.Focus();
                    return;
                }
            }

            // TELÉFONO ALUMNO
            if (txtTelefonoAlumno.Text == "")
            {
                error1.SetError(txtTelefonoAlumno, "Teléfono Inválido");
                txtTelefonoAlumno.Focus();
                return;
            }
            else
            {
                if (double.TryParse(txtTelefonoAlumno.Text, out double numerito))
                {
                    TelefonoAlumno = txtTelefonoAlumno.Text;
                    error1.Clear();
                }
                else
                {
                    error1.SetError(txtTelefonoAlumno, "Ingrese un número válido");
                    txtTelefonoAlumno.Focus();
                    return;
                }
            }

            // DOCUMENTO ALUMNO
            if (txtDocumentoAlumno.Text == "")
            {
                error1.SetError(txtDocumentoAlumno, "Documento Inválido");
                txtDocumentoAlumno.Focus();
                return;
            }
            else
            {
                if (double.TryParse(txtDocumentoAlumno.Text, out double numerito))
                {
                    DocumentoAlumno = txtDocumentoAlumno.Text;
                    error1.Clear();
                }
            }

            // EMAIL ALUMNO
            if (txtEmailAlumno.Text == "")
            {
                error1.SetError(txtEmailAlumno, "Email Inválido");
                txtEmailAlumno.Focus();
                return;
            }
            else
            {
                EmailAlumno = txtEmailAlumno.Text;
                error1.Clear();
            }

            // FECHA DE NACIMIENTO
            if (dtpFechaNacimientoAlumno.Value == DateTime.Now)
            {
                error1.SetError(dtpFechaNacimientoAlumno, "Fecha de Nacimiento Inválida");
                dtpFechaNacimientoAlumno.Focus();
                return;
            }
            else
            {
                FechaNacimientoAlumno = dtpFechaNacimientoAlumno.Value;
                error1.Clear();
            }

            // CARRERA
            if (cmbCarrerasAlumnos.SelectedItem == null || !(cmbCarrerasAlumnos.SelectedItem is Carrera))
            {
                error1.SetError(cmbCarrerasAlumnos, "Carrera Inválida");
                cmbCarrerasAlumnos.Focus();
                return;
            }
            else
            {
                carreraId = ((Carrera)cmbCarrerasAlumnos.SelectedItem).Id;
                error1.Clear();
            }

            // LLAMADA A BASE DE DATOS
            conexionbdd.CargarAlumno(NombreAlumno, ApellidoAlumno, Direcalle, Direnum, TelefonoAlumno, DocumentoAlumno, EmailAlumno, FechaNacimientoAlumno, carreraId);

            // EVENTO Y CIERRE
            AlumnoEvento?.Invoke();
            this.Close();

        }


        //Resuelto para cargar el id de la carrera y no se rompa
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string NombreAlumno = "";
            string ApellidoAlumno = "";
            string Direcalle = "";
            int Direnum = 0;
            string TelefonoAlumno = "";
            string DocumentoAlumno = "";
            string EmailAlumno = "";
            DateTime FechaNacimientoAlumno = DateTime.Now;
            int carreraId = 0;

            // NOMBRE ALUMNO
            if (txtNombreAlumno.Text == "")
            {
                error1.SetError(txtNombreAlumno, "Nombre Inválido");
                txtNombreAlumno.Focus();
                return;
            }
            else
            {
                NombreAlumno = txtNombreAlumno.Text;
                error1.Clear();
            }

            // APELLIDO ALUMNO
            if (txtApellidoAlumno.Text == "")
            {
                error1.SetError(txtApellidoAlumno, "Apellido Inválido");
                txtApellidoAlumno.Focus();
                return;
            }
            else
            {
                ApellidoAlumno = txtApellidoAlumno.Text;
                error1.Clear();
            }

            // DIRECCIÓN CALLE
            if (txtDireCalleAlumno.Text == "")
            {
                error1.SetError(txtDireCalleAlumno, "Calle Inválida");
                txtDireCalleAlumno.Focus();
                return;
            }
            else
            {
                Direcalle = txtDireCalleAlumno.Text;
                error1.Clear();
            }

            // NÚMERO CALLE
            if (txtDireNumeroAlumno.Text == "")
            {
                error1.SetError(txtDireNumeroAlumno, "Número Inválido");
                txtDireNumeroAlumno.Focus();
                return;
            }
            else
            {
                if (int.TryParse(txtDireNumeroAlumno.Text, out Direnum))
                {
                    error1.Clear();
                }
                else
                {
                    error1.SetError(txtDireNumeroAlumno, "Número Inválido");
                    txtDireNumeroAlumno.Focus();
                    return;
                }
            }

            // TELÉFONO ALUMNO
            if (txtTelefonoAlumno.Text == "")
            {
                error1.SetError(txtTelefonoAlumno, "Teléfono Inválido");
                txtTelefonoAlumno.Focus();
                return;
            }
            else
            {
                if (double.TryParse(txtTelefonoAlumno.Text, out double numerito))
                {
                    TelefonoAlumno = txtTelefonoAlumno.Text;
                    error1.Clear();
                }
                else
                {
                    error1.SetError(txtTelefonoAlumno, "Ingrese un número válido");
                    txtTelefonoAlumno.Focus();
                    return;
                }
            }

            // DOCUMENTO ALUMNO
            if (txtDocumentoAlumno.Text == "")
            {
                error1.SetError(txtDocumentoAlumno, "Documento Inválido");
                txtDocumentoAlumno.Focus();
                return;
            }
            else
            {
                if (double.TryParse(txtDocumentoAlumno.Text, out double numerito))
                {
                    DocumentoAlumno = txtDocumentoAlumno.Text;
                    error1.Clear();
                }
            }

            // EMAIL ALUMNO
            if (txtEmailAlumno.Text == "")
            {
                error1.SetError(txtEmailAlumno, "Email Inválido");
                txtEmailAlumno.Focus();
                return;
            }
            else
            {
                EmailAlumno = txtEmailAlumno.Text;
                error1.Clear();
            }

            // FECHA DE NACIMIENTO
            if (dtpFechaNacimientoAlumno.Value == DateTime.Now)
            {
                error1.SetError(dtpFechaNacimientoAlumno, "Fecha de Nacimiento Inválida");
                dtpFechaNacimientoAlumno.Focus();
                return;
            }
            else
            {
                FechaNacimientoAlumno = dtpFechaNacimientoAlumno.Value;
                error1.Clear();
            }

            // CARRERA 
            if (cmbCarrerasAlumnos.SelectedItem == null)
            {
                error1.SetError(cmbCarrerasAlumnos, "Carrera Inválida");
                cmbCarrerasAlumnos.Focus();
                return;
            }
            else
            {
                carreraId = ((Carrera)cmbCarrerasAlumnos.SelectedItem).Id;
                error1.Clear();
            }

            conexionbdd.ActualizarAlumno(Convert.ToInt32(lblMatriculaAlumno.Text), NombreAlumno, ApellidoAlumno, Direcalle, Direnum, TelefonoAlumno, DocumentoAlumno, EmailAlumno, FechaNacimientoAlumno, carreraId);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
