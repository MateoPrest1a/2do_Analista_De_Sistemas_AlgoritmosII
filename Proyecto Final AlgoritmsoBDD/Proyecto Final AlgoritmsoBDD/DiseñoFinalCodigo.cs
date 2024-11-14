using Proyecto_Final;
using Proyecto_Final_AlgoritmsoBDD;
using System.Data.SqlClient;

namespace DiseñoFinal
{
    public partial class DiseñoFinalCodigo : Form
    {
        Conexionbdd conectar;
        private List<string> imagenes;
        private int indiceImagenActual;


        public DiseñoFinalCodigo(string nombre, string apellido, string perfil, int idPerfil)
        {
            InitializeComponent();
            lblUsuario.Text = nombre + " " + apellido;
            lblPerfil.Text = perfil;

            imagenes = new List<string>
        {
            @"C:\Ruta\A\Imagen1.jpg",  
            @"C:\Ruta\A\Imagen2.jpg",
            @"C:\Ruta\A\Imagen3.jpg",
            @"C:\Ruta\A\Imagen4.jpg"
        };

            indiceImagenActual = 0;          
                    
            timerFotos.Interval = 15000;  // Cambiar cada 2 segundos (2000 ms)            
            timerFotos.Start();
            
            CargarImagen();
        }

        private void CargarLabel()
        {
            string connectionString = "";
        }


        private void BtnABMAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void btnABMEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados formempleados = new FormEmpleados();
            formempleados.ShowDialog();
        }

        private void btnABMPermisos_Click(object sender, EventArgs e)
        {

        }

        private void btnABMProfesores_Click(object sender, EventArgs e)
        {

        }

        private void btnABMMaterias_Click(object sender, EventArgs e)
        {
            FormMaterias formmaterias = new FormMaterias();
            formmaterias.ShowDialog();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnABMAlumnos_Click_1(object sender, EventArgs e)
        {
            FormAlumnos formalumnos = new FormAlumnos();
            formalumnos.ShowDialog();
        }

        private void btnExamenesAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void btnExamenesProfesor_Click(object sender, EventArgs e)
        {
            FormExamenes formexamenes = new FormExamenes();
            formexamenes.ShowDialog();
        }

        private void btnCarrerasProfesor_Click(object sender, EventArgs e)
        {
            FormCarreras formcarreras = new FormCarreras();
            formcarreras.ShowDialog();
        }

        private void CargarImagen()
        {
            if (imagenes.Count > 0 && indiceImagenActual >= 0 && indiceImagenActual < imagenes.Count)
            {
                pictureBox1.Image = Image.FromFile(imagenes[indiceImagenActual]);
            }
        }

        private void timerFotos_Tick(object sender, EventArgs e)
        {
            indiceImagenActual++;

            // Si hemos llegado al final de la lista, reiniciar el índice
            if (indiceImagenActual >= imagenes.Count)
            {
                indiceImagenActual = 0;  // Reiniciar a la primera imagen
            }

            // Cargar la nueva imagen en el PictureBox
            CargarImagen();
        }
    }
}
