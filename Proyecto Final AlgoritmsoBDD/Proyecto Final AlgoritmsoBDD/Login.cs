using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final_AlgoritmsoBDD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            PaginaPrincipal frm2 = new PaginaPrincipal();
            DialogResult resultado = frm2.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Estudiante cargado Correctamente.");
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Cancelado.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
