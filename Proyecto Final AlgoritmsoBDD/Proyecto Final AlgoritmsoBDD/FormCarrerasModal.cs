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

        public FormCarrerasModal(int idcarrera, string carrera, int resolucion, int añoplanestudio)
        {
            InitializeComponent();
            if (idcarrera != 0)
            {
                lblIDCarrera.Text = idcarrera.ToString();
                txtCarrera.Text = carrera;
                txtResolucion.Text = resolucion.ToString();
                txtAñoPlanEstudio.Text = añoplanestudio.ToString();
            }
            else
            {
                lblIDCarrera.Visible = false;
                lblCarrera.Visible = false;
                txtCarrera.Clear();
                txtResolucion.Clear();
                txtAñoPlanEstudio.Clear();
            }
        }


        private void txtCarrera_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCarreras_Click(object sender, EventArgs e)
        {

            conexionbdd.CargarCarrera(txtCarrera.Text, Convert.ToInt32(txtResolucion.Text), Convert.ToInt32(txtAñoPlanEstudio.Text));
            CarreraEvento?.Invoke();
            this.Close();
        }

        private void btnModificarCarreras_Click(object sender, EventArgs e)
        {
            conexionbdd.ModificarCarrera(Convert.ToInt32(lblIDCarrera.Text), txtCarrera.Text, Convert.ToInt32(txtResolucion.Text), Convert.ToInt32(txtAñoPlanEstudio.Text));
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
