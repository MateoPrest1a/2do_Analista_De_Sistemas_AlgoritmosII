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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Final_AlgoritmsoBDD.FormAlumnosModal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class FormAlumnosModal : Form
    {
        ClaseGestorAlumnos gestorAlumnos = new ClaseGestorAlumnos(); // Instancia de la clase gestora

        public event Action AlumnoEvento; //Evento para actualizar el datagridview

        SqlConnection conexion = Conexionbdd.ObtenerInstancia().ObtenerConexion();

        int Matricula; // Declaro variable Matricula para asignarle la matricula del alumno

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

        public FormAlumnosModal(int matricula, string nombre, string apellido, string direcalle, string direnum, string telefono, string documento, string email, DateTime fechanacimientoalumno, int idcarrera, int año, string perfil) //perfil para mostrar que puede hacer dependiendo el perfil del usuario
        {
            InitializeComponent();

            //Cargo los combobox al iniciar cada formulario
            CargarCarreras();
            CargarAños();

            Matricula = matricula;

            if (matricula != 0)
            {
                lblMatriculaAlumno.Text = matricula.ToString();
                btnAgregar.Visible = false;
            }
            else
            {
                lblMatriculaAlumno.Visible = false;
                lblMatricula.Visible = false; //Hacemos invisible para que al agregar alumno nuevo no se vea el label "Matricula :"
                btnExamenesRendidos.Visible = false;
                btnEliminar.Visible = false;
                btnModificar.Visible = false;
                btnAsignarMaterias.Visible = false;
                btnHistorialExamenes.Visible = false;
            }
            txtNombreAlumno.Text = nombre;
            txtApellidoAlumno.Text = apellido;
            txtDireCalleAlumno.Text = direcalle;
            txtDireNumeroAlumno.Text = direnum;
            txtTelefonoAlumno.Text = telefono;
            txtDocumentoAlumno.Text = documento;
            dtpFechaNacimientoAlumno.Value = fechanacimientoalumno;
            txtEmailAlumno.Text = email;
            cmbAñoAlumno.SelectedItem = año.ToString();
            foreach (Carrera carrera in cmbCarrerasAlumnos.Items)
            {
                if (carrera.Id == idcarrera)
                {
                    cmbCarrerasAlumnos.SelectedItem = carrera;
                    break;
                }
            }

            //Perfiles
            AjustarVisibilidadPerfil(perfil);
        }
        private void CargarAños()
        {
            cmbAñoAlumno.Items.Clear();
            cmbAñoAlumno.Items.Add("1");
            cmbAñoAlumno.Items.Add("2");
            cmbAñoAlumno.Items.Add("3");
        }

        private void CargarCarreras()
        {
            string query = "SELECT id_carrera, nombre_carrera FROM Carreras";

            try
            {
                // Crear el comando SQL
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    // Usar la clase gestora para ejecutar la consulta
                    DataTable cmbCarrerasTabla = gestorAlumnos.EjecutarConsulta(command);

                    // Limpia el ComboBox antes de llenarlo
                    cmbCarrerasAlumnos.Items.Clear();

                    foreach (DataRow row in cmbCarrerasTabla.Rows)
                    {
                        // Crear un nuevo objeto para almacenar la carrera
                        var carrera = new Carrera
                        {
                            Id = Convert.ToInt32(row["id_carrera"]), // id_carrera
                            Nombre = row["nombre_carrera"].ToString() // nombre_carrera
                        };

                        // Agregar la carrera al ComboBox
                        cmbCarrerasAlumnos.Items.Add(carrera);
                    }

                    // Configura DisplayMember y ValueMember
                    cmbCarrerasAlumnos.DisplayMember = "Nombre"; // Lo que se muestra en el ComboBox
                    cmbCarrerasAlumnos.ValueMember = "Id"; // El valor que se utilizará
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las carreras: {ex.Message}");
            }
        }


        private void FormAlumnosModal_Load(object sender, EventArgs e)
        {

        }



        private void AjustarVisibilidadPerfil(string perfil)
        {

            if (perfil == "Alumno")
            {
                //Oculto Botones
                btnAgregar.Visible = false;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
                btnAsignarMaterias.Visible = false;
                btnExamenesRendidos.Visible = false;

                //Deshabilito edicion de atributos
                txtNombreAlumno.Enabled = false;
                txtApellidoAlumno.Enabled = false;
                txtDireCalleAlumno.Enabled = false;
                txtDireNumeroAlumno.Enabled = false;
                txtEmailAlumno.Enabled = false;
                txtDocumentoAlumno.Enabled = false;
                cmbAñoAlumno.Enabled = false;
                cmbCarrerasAlumnos.Enabled = false;
                txtTelefonoAlumno.Enabled = false;
                dtpFechaNacimientoAlumno.Enabled = false;
            }
            else if (perfil == "Profesor")
            {
                btnAgregar.Visible = false;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
                btnAsignarMaterias.Visible = false;
                btnExamenesRendidos.Visible = false;

            }
            else if (perfil == "Personal Administrativo")
            {

            }
        }

        //Validar si el Mail es valido
        private bool ValidarMail(string email)
        {
            Regex regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(email);
        }

        //Validar si el salario es valido, y que no sea negativo
        private bool ValidarSalario(string sal)
        {
            if (decimal.TryParse(sal, out decimal salario))
            {
                return salario >= 1;
            }
            return false;
        }


        private void txtNombreAlumno_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnExamenesRendidos_Click(object sender, EventArgs e)
        {
            //No hace falta validar que sea un numero ya que si no hay numero cargado este boton no aparece
            int matricula;
            string NombreAlumno;
            int idcarrera;
            if (int.TryParse(lblMatriculaAlumno.Text, out matricula))
            {
                // devuelve matricula en caso de que este bien
            }
            else
            {
                MessageBox.Show("El valor de matrícula no es válido.");
            }

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

            // CARRERA 
            if (cmbCarrerasAlumnos.SelectedItem == null)
            {
                error1.SetError(cmbCarrerasAlumnos, "Carrera Inválida");
                cmbCarrerasAlumnos.Focus();
                return;
            }
            else
            {
                idcarrera = ((Carrera)cmbCarrerasAlumnos.SelectedItem).Id;
                error1.Clear();
            }


            FormExamenesRendidos formexamenesrendidos = new FormExamenesRendidos(matricula, NombreAlumno, idcarrera);
            formexamenesrendidos.ShowDialog();

        }

        private void cmbCarrerasAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsignarMaterias_Click(object sender, EventArgs e)
        {
            int idcarrera;
            int año;
            int matricula;

            //Matricula
            if (int.TryParse(lblMatriculaAlumno.Text, out matricula))
            {
                // devuelve matricula en caso de que este bien
            }
            else
            {
                MessageBox.Show("El valor de matrícula no es válido.");
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
                idcarrera = ((Carrera)cmbCarrerasAlumnos.SelectedItem).Id;
                error1.Clear();
            }

            // AÑO
            if (cmbAñoAlumno.SelectedItem == null)
            {
                error1.SetError(cmbAñoAlumno, "Seleccione un año valido");
                cmbAñoAlumno.Focus();
                return;
            }
            else
            {
                año = Convert.ToInt32(cmbAñoAlumno.SelectedItem);
            }

            FormAsignarMateriaAlumno formulario = new FormAsignarMateriaAlumno(matricula, idcarrera, año);
            formulario.ShowDialog();
        }

        private void btnHistorialExamenes_Click(object sender, EventArgs e)
        {
            FormHistorialExamenAlumno formulario = new FormHistorialExamenAlumno(Matricula);
            formulario.ShowDialog();
        }

        private void btnExamenesRendidos_Click_1(object sender, EventArgs e)
        {
            string NombreAlumno;
            int idcarrera;

            // Nombre Alumno
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

            // CARRERA 
            if (cmbCarrerasAlumnos.SelectedItem == null)
            {
                error1.SetError(cmbCarrerasAlumnos, "Carrera Inválida");
                cmbCarrerasAlumnos.Focus();
                return;
            }
            else
            {
                idcarrera = ((Carrera)cmbCarrerasAlumnos.SelectedItem).Id;
                error1.Clear();
            }

            FormExamenesRendidos formexamenes = new FormExamenesRendidos(Matricula, NombreAlumno, idcarrera);
            formexamenes.ShowDialog();
        }

        private void btnAsignarMaterias_Click_1(object sender, EventArgs e)
        {
            int idcarrera;
            int año;

            // CARRERA 
            if (cmbCarrerasAlumnos.SelectedItem == null)
            {
                error1.SetError(cmbCarrerasAlumnos, "Carrera Inválida");
                cmbCarrerasAlumnos.Focus();
                return;
            }
            else
            {
                idcarrera = ((Carrera)cmbCarrerasAlumnos.SelectedItem).Id;
                error1.Clear();
            }

            // AÑO
            if (cmbAñoAlumno.SelectedItem == null)
            {
                error1.SetError(cmbAñoAlumno, "Seleccione un año valido");
                cmbAñoAlumno.Focus();
                return;
            }
            else
            {
                año = Convert.ToInt32(cmbAñoAlumno.SelectedItem);
            }

            FormAsignarMateriaAlumno formmaterias = new FormAsignarMateriaAlumno(Matricula, idcarrera, año);
            formmaterias.ShowDialog();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
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
            int año = 0;

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
                error1.SetError(txtEmailAlumno, "Nombre Inválido");
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

            // AÑO
            if (cmbAñoAlumno.SelectedItem == null)
            {
                error1.SetError(cmbAñoAlumno, "Seleccione un año valido");
                cmbAñoAlumno.Focus();
                return;
            }
            else
            {
                año = Convert.ToInt32(cmbAñoAlumno.SelectedItem);
            }


            // Llamada a la clase gestora para agregar un alumno
            gestorAlumnos.CargarAlumno(NombreAlumno, ApellidoAlumno, Direcalle, Direnum, TelefonoAlumno, DocumentoAlumno, EmailAlumno, FechaNacimientoAlumno, carreraId, año);

            // EVENTO Y CIERRE
            AlumnoEvento?.Invoke();
            this.Close();

        }


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

            int matricula = Convert.ToInt32(lblMatriculaAlumno.Text);

            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea eliminar este alumno?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Llamada a la clase gestora para eliminar un alumno
                gestorAlumnos.EliminarAlumno(matricula);

                // Actualizar la vista si es necesario
                AlumnoEvento?.Invoke();
            }
            else
            {
                MessageBox.Show("La eliminación ha sido cancelada.");
            }

            this.Close();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            int matricula = Convert.ToInt32(lblMatriculaAlumno.Text);
            string NombreAlumno = "";
            string ApellidoAlumno = "";
            string Direcalle = "";
            int Direnum = 0;
            string TelefonoAlumno = "";
            string DocumentoAlumno = "";
            string EmailAlumno = "";
            DateTime FechaNacimientoAlumno = DateTime.Now;
            int carreraId = 0;
            int año = 0;

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
                error1.SetError(txtEmailAlumno, "Nombre Inválido");
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

            // AÑO
            if (cmbAñoAlumno.SelectedItem == null)
            {
                error1.SetError(cmbAñoAlumno, "Seleccione un año valido");
                cmbAñoAlumno.Focus();
                return;
            }
            else
            {
                año = Convert.ToInt32(cmbAñoAlumno.SelectedItem);
            }

            gestorAlumnos.ActualizarAlumno(matricula, NombreAlumno, ApellidoAlumno, Direcalle, Direnum, TelefonoAlumno, DocumentoAlumno, EmailAlumno, FechaNacimientoAlumno, carreraId, año); AlumnoEvento?.Invoke();
            this.Close();
        }
    }
}
