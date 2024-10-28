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

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class FormCarrerasModal : Form
    {

        public event Action CarreraEvento;

        Conexionbdd conexionbdd = new Conexionbdd();

        private void CargarAño()
        {
            cmbAño.Items.Add("1");
            cmbAño.Items.Add("2");
            cmbAño.Items.Add("3");
        }
        public FormCarrerasModal(int idcarrera, string carrera, int resolucion, int añoplanestudio)
        {
            InitializeComponent();
            CargarAño();

            if (idcarrera != 0)
            {
                lblIDCarrera.Text = idcarrera.ToString();
                txtCarrera.Text = carrera;
                txtResolucion.Text = resolucion.ToString();
                cmbAño.Text = añoplanestudio.ToString();
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

            conexionbdd.CargarCarrera(txtCarrera.Text, Convert.ToInt32(txtResolucion.Text), Convert.ToInt32(cmbAño.Text));
            CarreraEvento?.Invoke();
            this.Close();
        }

        private void btnModificarCarreras_Click(object sender, EventArgs e)
        {
            conexionbdd.ModificarCarrera(Convert.ToInt32(lblIDCarrera.Text), txtCarrera.Text, Convert.ToInt32(txtResolucion.Text), Convert.ToInt32(cmbAño.Text));
            CarreraEvento?.Invoke();
            this.Close();
        }

        private void btnEliminarCarreras_Click(object sender, EventArgs e)
        {
            conexionbdd.EliminarCarrera(Convert.ToInt32(lblIDCarrera.Text));
            CarreraEvento?.Invoke();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
