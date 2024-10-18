using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            FormAlumnos formalumnos = new FormAlumnos();
            DialogResult resultado = formalumnos.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Completado Exitosamente.");
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Cancelado.");
            }
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            FormEmpleados formprofesores = new FormEmpleados();
            DialogResult resultado = formprofesores.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Completado Exitosamente.");
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Cancelado.");
            }
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {

        }
    }
}
