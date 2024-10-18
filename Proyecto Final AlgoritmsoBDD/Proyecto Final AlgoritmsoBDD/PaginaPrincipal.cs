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

        private FormAlumnosModal formalumnosmodal; //Para poder actualizar el combo box de carreras

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
            formalumnos.ShowDialog();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            FormEmpleados formprofesores = new FormEmpleados();
            formprofesores.ShowDialog();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            FormMaterias formmaterias = new FormMaterias();
            formmaterias.ShowDialog();
        }

        private void btnExamenes_Click(object sender, EventArgs e)
        {
            FormExamenes formexamenes = new FormExamenes();
            formexamenes.ShowDialog();
        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {
            FormCarreras formcarreras = new FormCarreras();
            formcarreras.ShowDialog();
        }
    }
}
