using Proyecto_Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Final_AlgoritmsoBDD.FormAlumnosModal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class FormCarrerasModal : Form
    {

        public event Action CarreraEvento;

        private GestorCarreras gestorCarreras = new GestorCarreras(); // Instancia de la clase gestora

        public FormCarrerasModal(int idcarrera, string carrera, int resolucion, int añoplanestudio)
        {
            InitializeComponent();

            if (idcarrera != 0)
            {
                lblIDCarrera.Text = idcarrera.ToString();
                txtCarrera.Text = carrera;
                txtResolucion.Text = resolucion.ToString();
                txtAñoPlan.Text = añoplanestudio.ToString();
                btnAgregarCarreras.Visible = false;
            }
            else
            {
                lblIDCarrera.Visible = false;
                lblCarrera.Visible = false;
                txtCarrera.Clear();
                txtResolucion.Clear();
                btnModificarCarreras.Visible = false;
                btnEliminarCarreras.Visible = false;
            }
        }


        private void txtCarrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCarreras_Click(object sender, EventArgs e)
        {

            // Validaciones antes de cargar la carrera
            if (string.IsNullOrWhiteSpace(txtCarrera.Text))
            {
                error1.SetError(txtCarrera, "Nombre de carrera inválido");
                txtCarrera.Focus();
                return;
            }
            error1.Clear();

            if (string.IsNullOrWhiteSpace(txtResolucion.Text))
            {
                error1.SetError(txtResolucion, "Número de resolución inválido");
                txtResolucion.Focus();
                return;
            }
            else if (!int.TryParse(txtResolucion.Text, out _))
            {
                error1.SetError(txtResolucion, "Ingrese un número válido");
                txtResolucion.Focus();
                return;
            }
            error1.Clear();

            if (txtAñoPlan.Text == null)
            {
                error1.SetError(txtAñoPlan, "Año de plan de estudio inválido");
                txtAñoPlan.Focus();
                return;
            }
            error1.Clear();

            // Si todas las validaciones son correctas, carga la carrera
            gestorCarreras.CargarCarrera(txtCarrera.Text, Convert.ToInt32(txtResolucion.Text), Convert.ToInt32(txtAñoPlan.Text));
            CarreraEvento?.Invoke();
            this.Close();
        }

        private void btnModificarCarreras_Click(object sender, EventArgs e)
        {
            // Validaciones antes de modificar la carrera

            // Verifica que el ID de carrera sea válido
            if (string.IsNullOrWhiteSpace(lblIDCarrera.Text) || lblIDCarrera.Text == "0")
            {
                error1.SetError(lblIDCarrera, "ID de carrera no válido. No se puede modificar.");
                return;
            }
            error1.Clear();

            if (string.IsNullOrWhiteSpace(txtCarrera.Text))
            {
                error1.SetError(txtCarrera, "Nombre de carrera inválido");
                txtCarrera.Focus();
                return;
            }
            error1.Clear();

            if (string.IsNullOrWhiteSpace(txtResolucion.Text))
            {
                error1.SetError(txtResolucion, "Número de resolución inválido");
                txtResolucion.Focus();
                return;
            }
            else if (!int.TryParse(txtResolucion.Text, out _))
            {
                error1.SetError(txtResolucion, "Ingrese un número válido");
                txtResolucion.Focus();
                return;
            }
            error1.Clear();

            if (txtAñoPlan.Text == null)
            {
                error1.SetError(txtAñoPlan, "Año de plan de estudio inválido");
                txtAñoPlan.Focus();
                return;
            }
            else if(!int.TryParse(txtAñoPlan.Text, out _))
            {
                error1.SetError(txtAñoPlan, "Ingrese un año válido");
                txtAñoPlan.Focus();
                return;
            }
            error1.Clear();

        }

        private void btnEliminarCarreras_Click(object sender, EventArgs e)
        {
            // Verifica que el ID de carrera sea válido
            if (string.IsNullOrWhiteSpace(lblIDCarrera.Text) || lblIDCarrera.Text == "0")
            {
                error1.SetError(lblIDCarrera, "ID de carrera no válido. No se puede modificar.");
                return;
            }
            error1.Clear();

            // Pregunta al usuario si está seguro de que quiere eliminar la carrera
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta carrera?",
                                                 "Confirmar Eliminación",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Si el usuario confirma, se procede a eliminar la carrera
                gestorCarreras.EliminarCarrera(Convert.ToInt32(lblIDCarrera.Text));
                CarreraEvento?.Invoke();
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
