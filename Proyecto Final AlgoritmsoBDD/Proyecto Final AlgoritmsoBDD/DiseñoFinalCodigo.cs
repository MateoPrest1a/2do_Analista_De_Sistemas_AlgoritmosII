using Microsoft.VisualBasic.ApplicationServices;
using Proyecto_Final;
using Proyecto_Final_AlgoritmsoBDD;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Windows.Forms;

namespace DiseñoFinal
{
    public partial class DiseñoFinalCodigo : Form
    {
        Conexionbdd conectar;
        SqlConnection conexion = Conexionbdd.ObtenerInstancia().ObtenerConexion();

        int Id_Persona = 0;
        string Perfil;
        string cadenaUrl = "https://github.com/MateoPrest1a/2do_Analista_De_Sistemas_AlgoritmosII/blob/main/Imagenes/";

        private List<string> imgs;
        private int indiceImagen = 0;
        MetodosConexionBDD mcb = new MetodosConexionBDD();

        public DiseñoFinalCodigo(string nombre, string apellido, string perfil, int idPerfil)
        {
            InitializeComponent();
            imgs = new List<string>()
            {
                /*
                @"C:\Users\hilet.HILET\Documents\GitHub\2do_Analista_De_Sistemas_AlgoritmosII\Imagenes\foto1.jpg",
                @"C:\Users\hilet.HILET\Documents\GitHub\2do_Analista_De_Sistemas_AlgoritmosII\Imagenes\foto2.jpg",  Fotos Hilet
                @"C:\Users\hilet.HILET\Documents\GitHub\2do_Analista_De_Sistemas_AlgoritmosII\Imagenes\foto3.jpg",
                @"C:\Users\hilet.HILET\Documents\GitHub\2do_Analista_De_Sistemas_AlgoritmosII\Imagenes\foto3.jpg"
                */
                @"D:\GitHub\2do_Analista_De_Sistemas_AlgoritmosII\Imagenes\foto1.jpg",
                @"D:\GitHub\2do_Analista_De_Sistemas_AlgoritmosII\Imagenes\foto2.jpg",  // Fotos Renzo
                @"D:\GitHub\2do_Analista_De_Sistemas_AlgoritmosII\Imagenes\foto3.jpg",
                @"D:\GitHub\2do_Analista_De_Sistemas_AlgoritmosII\Imagenes\foto4.jpg",

            };

            timer1.Interval = 3000;
            timer1.Start();

            lblUsuario.Text = nombre + " " + apellido;
            lblPerfil.Text = perfil;


            //Cargo datos pantalla principal
            lblUsuario.Text = nombre + " " + apellido;
            lblPerfil.Text = perfil;

            Id_Persona = idPerfil;
            Perfil = perfil; //Cargo el perfil de la persona

            //Cargo datos alumno
            lblUsuarioAlumno.Text = nombre + " " + apellido;
            lblPerfilAlumno.Text = perfil;

            //Cargo datos profesores
            lblUsuarioEmpleado.Text = nombre + " " + apellido;
            lblPerfilEmpleado.Text = perfil;

            AjustarVisibilidadPerfil(perfil);


            //Tab Page Alumnos
            Cargar_Tabla_Alumnos();
            Cargar_Filtros_Alumnos();
            CargarCarreras(); //Carga las carreras al combobox en Alumnos

            //Tab Page Materias
            Cargar_Tabla_Materias();
        }

        private void AjustarVisibilidadPerfil(string perfil)
        {

            if (perfil == "Alumno")
            {
                btnExamenesAlumnos.Visible = true;
                btnDatosAlumnos.Visible = true;
                tabControl1.TabPages.RemoveAt(0); //Borro la primer tabpage ya que es solo para administradores o profesores
                tabControl1.TabPages.RemoveAt(1); //Borro la tercer tabpage que es la de los profesores

            }
            else if (perfil == "Profesor")
            {
               // tabControl1.TabPages.RemoveAt(0);
               // tabControl1.TabPages.RemoveAt(0);
            }
            else if (perfil == "Personal Administrativo")
            {
                tabControl1.TabPages.RemoveAt(1);
            }
            else if (perfil == "Administrador")
            {
                tabControl1.TabPages.RemoveAt(1);
            }
        }


        private void BtnABMAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void btnABMEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados formempleados = new FormEmpleados(Perfil);
            formempleados.ShowDialog();
        }

        private void btnabmCarreras_Click(object sender, EventArgs e)
        {
            FormCarreras formcarreras = new FormCarreras();
            formcarreras.ShowDialog();
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
            FormAlumnos formalumnos = new FormAlumnos(Perfil, Id_Persona);
            formalumnos.ShowDialog();
        }



        private void btnExamenesProfesor_Click(object sender, EventArgs e)
        {
            FormExamenes formexamenes = new FormExamenes();
            formexamenes.ShowDialog();
        }

        //Botones para el Alumno

        //Funcion Buscar Alumno
        public void CargarDatosAlumno(int matricula)
        {
            ClaseGestorAlumnos gestorAlumnos = new ClaseGestorAlumnos();
            var result = gestorAlumnos.ObtenerDatosAlumno(matricula);

            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                string nombre = row["nombre"].ToString();
                string apellido = row["apellido"].ToString();
                string direcalle = row["direccion_calle"].ToString();
                string direnum = row["direccion_numero"].ToString();
                string telefono = row["telefono"].ToString();
                string documento = row["dni"].ToString();
                string email = row["email"].ToString();
                DateTime fechanacimientoalumno = Convert.ToDateTime(row["fecha_nacimiento"]);
                int idcarrera = Convert.ToInt32(row["id_carrera"]);
                int año = Convert.ToInt32(row["año"]);

                // Llama al método para abrir el formulario con los datos del alumno
                FormAlumnosModal formulario = new FormAlumnosModal(matricula, nombre, apellido, direcalle, direnum, telefono, documento, email, fechanacimientoalumno, idcarrera, año, Perfil);
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Alumno no encontrado");
            }
        }

        private void btnDatosAlumnos_Click(object sender, EventArgs e)
        {
            CargarDatosAlumno(Id_Persona);
        }

        private void btnExamenesAlumnos_Click(object sender, EventArgs e)
        {
            FormHistorialExamenAlumno formHistorial = new FormHistorialExamenAlumno(Id_Persona);
            formHistorial.ShowDialog();
        }

        //Materias en las que el alumno esta anotado
        private void btnMateriasAlumnos_Click(object sender, EventArgs e)
        {
            FormMateriasXAlumno formMateriasXAlumno = new FormMateriasXAlumno(Id_Persona);
            formMateriasXAlumno.ShowDialog();
        }


        //Carga de fotos
        private void CargarImagen()
        {
            if (imgs.Count > 0 && indiceImagen >= 0 && indiceImagen < imgs.Count)
            {
                AlumnoImagenes.Image = Image.FromFile(imgs[indiceImagen]);
                ImagenesProfes.Image = Image.FromFile(imgs[indiceImagen]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (indiceImagen > imgs.Count)
            {
                indiceImagen = 0;
            }
            else
            {
                indiceImagen++;
            }

            CargarImagen();
        }





        // Botones Empleados



        /*
        private void btnCarrerasProfesor_Click(object sender, EventArgs e)
        {
            CargarDatosEmpleado(Id_Persona);
        }

        private void btnMateriasProfesor_Click(object sender, EventArgs e)
        {
            FormAlumnos formalumnos = new FormAlumnos(Perfil,Id_Persona);
            formalumnos.ShowDialog();
        }
        */


        public void CargarDatosEmpleado(int idEmpleado)
        {
            GestorEmpleados gestorEmpleados = new GestorEmpleados();
            var result = gestorEmpleados.ObtenerDatosEmpleado(idEmpleado);

            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                string nombre = row["nombre"].ToString();
                string apellido = row["apellido"].ToString();
                string direcalle = row["direccion_calle"].ToString();
                string direnum = row["direccion_nro"].ToString();
                string telefono = row["telefono"].ToString();
                string documento = row["dni"].ToString();
                string email = row["email"].ToString();
                DateTime fechaNacimientoEmpleado = Convert.ToDateTime(row["fecha_nacimiento"]);
                int salario = Convert.ToInt32(row["salario"]);
                int tipoPerfil = Convert.ToInt32(row["tipo_perfil"]);

                // Llama al formulario con los datos del empleado
                FormEmpleadosModal formulario = new FormEmpleadosModal(idEmpleado, nombre, apellido, direcalle, direnum, telefono, documento, email, fechaNacimientoEmpleado, salario, tipoPerfil, Perfil);
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
            }
        }

        private void btnCarrerasProfesor_Click(object sender, EventArgs e)
        {
            CargarDatosEmpleado(Id_Persona);
        }

        private void btnMateriasProfesor_Click(object sender, EventArgs e)
        {

        }

        //Tab Page Alumnos


        ClaseGestorAlumnos gestoralumnos = new ClaseGestorAlumnos();

        private void Cargar_Filtros_Alumnos()
        {
            cmbFiltrosAlumnos.Items.Clear();
            cmbFiltrosAlumnos.Items.Add("Nombre y Apellido");
            cmbFiltrosAlumnos.Items.Add("Carrera");
            cmbFiltrosAlumnos.Items.Add("Año");


            cmbAñoAlumno.Items.Clear();
            cmbAñoAlumno.Items.Add("1");
            cmbAñoAlumno.Items.Add("2");
            cmbAñoAlumno.Items.Add("3");
        }

        private void cmbFiltrosAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreApellidoAlumno.Visible = false;
            cmbAñoAlumno.Visible = false;
            cmbCarreraAlumno.Visible = false;

            // Muestra el control correspondiente según la selección.
            switch (cmbFiltrosAlumnos.SelectedItem.ToString())
            {
                case "Nombre y Apellido":
                    txtNombreApellidoAlumno.Visible = true;
                    break;
                case "Año":
                    cmbAñoAlumno.Visible = true;
                    break;
                case "Carrera":
                    cmbCarreraAlumno.Visible = true;
                    break;
            }
        }

        private void Cargar_Tabla_Alumnos()
        {
            string consulta = @"SELECT 
                                    matricula, 
                                    nombre, 
                                    apellido, 
                                    direccion_calle, 
                                    direccion_numero, 
                                    telefono, 
                                    dni, 
                                    email, 
                                    fecha_nacimiento, 
                                    id_carrera, 
                                    año 
                                FROM 
                                    Alumnos 
                                WHERE 
                                    baja = 0;";
            SqlCommand command = new SqlCommand(consulta);

            try
            {
                DataTable dt = gestoralumnos.EjecutarConsulta(command); // Usa la clase gestora para ejecutar la consulta
                dataGridViewAlumnos.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Manejar excepciones, por ejemplo, mostrar un mensaje de error
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }

        private void btnRecargarTablaAlumnos_Click(object sender, EventArgs e)
        {
            Cargar_Tabla_Alumnos();
        }


        //Cargo Combo box Carreras Alumnos
        private void CargarCarreras()
        {
            string query = "SELECT id_carrera, nombre_carrera FROM Carreras";

            try
            {
                // Crear el comando SQL
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    // Usar la clase gestora para ejecutar la consulta
                    DataTable cmbCarrerasTabla = gestoralumnos.EjecutarConsulta(command);

                    // Limpia el ComboBox antes de llenarlo
                    cmbCarreraAlumno.Items.Clear();

                    foreach (DataRow row in cmbCarrerasTabla.Rows)
                    {
                        // Crear un nuevo objeto para almacenar la carrera
                        var carrera = new Carrera
                        {
                            ID_Carrera = Convert.ToInt32(row["id_carrera"]), // id_carrera
                            Nombre_Carrera = row["nombre_carrera"].ToString() // nombre_carrera
                        };

                        // Agregar la carrera al ComboBox
                        cmbCarreraAlumno.Items.Add(carrera);
                    }

                    // Configura DisplayMember y ValueMember
                    cmbCarreraAlumno.DisplayMember = "Nombre_Carrera"; // Lo que se muestra en el ComboBox
                    cmbCarreraAlumno.ValueMember = "ID_Carrera"; // El valor que se utilizará
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las carreras: {ex.Message}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Verifica si el campo Nombre y Apellido está visible
            if (txtNombreApellidoAlumno.Visible)
            {
                // Llama al método BuscarAlumno pasándole el texto de txtNombreApellido
                string nombreApellido = txtNombreApellidoAlumno.Text;

                if (!string.IsNullOrEmpty(nombreApellido))
                {
                    // Llamar al método de búsqueda
                    ClaseGestorAlumnos gestorAlumnos = new ClaseGestorAlumnos();
                    DataTable resultados = gestorAlumnos.BuscarAlumno(nombreApellido);

                    if (resultados != null && resultados.Rows.Count > 0)
                    {
                        // Si se encuentran resultados, mostrar en un DataGridView
                        dataGridViewAlumnos.DataSource = resultados;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron alumnos con ese nombre y apellido.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un nombre y apellido.");
                }
            }
            else if (cmbAñoAlumno.Visible)
            {
                // Obtiene el valor seleccionado en el ComboBox de Año
                int añoSeleccionado = Convert.ToInt32(cmbAñoAlumno.SelectedItem);

                // Verifica que el valor del año seleccionado sea válido
                if (añoSeleccionado > 0)
                {
                    // Llama al método de búsqueda con solo el filtro de Año
                    ClaseGestorAlumnos gestorAlumnos = new ClaseGestorAlumnos();
                    DataTable resultados = gestorAlumnos.CargarAlumnosPorAño(añoSeleccionado);

                    if (resultados != null && resultados.Rows.Count > 0)
                    {
                        // Si se encuentran resultados, mostrar en un DataGridView
                        dataGridViewAlumnos.DataSource = resultados;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron alumnos para el año seleccionado.");
                    }
                }

            }
            else if (cmbCarreraAlumno.Visible)
            {
                // Obtiene el objeto Carrera seleccionado en el ComboBox
                Carrera carreraSeleccionada = (Carrera)cmbCarreraAlumno.SelectedItem;

                // Verifica que la carrera seleccionada no sea nula
                if (carreraSeleccionada != null && carreraSeleccionada.ID_Carrera > 0)
                {
                    // Llama al método de búsqueda con el filtro de carrera
                    ClaseGestorAlumnos gestorAlumnos = new ClaseGestorAlumnos();
                    DataTable resultados = gestorAlumnos.CargarAlumnosPorCarrera(carreraSeleccionada.ID_Carrera);

                    if (resultados != null && resultados.Rows.Count > 0)
                    {
                        // Si se encuentran resultados, mostrar en un DataGridView
                        dataGridViewAlumnos.DataSource = resultados;
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron alumnos para la carrera seleccionada.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una carrera válida.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un filtro de carrera válido para buscar.");
            }
        }


        // Tab Page Materias

        GestorMaterias gestormaterias = new GestorMaterias();
        private void Cargar_Tabla_Materias()
        {
            string consulta = @"
                                SELECT  
                                    m.id_materia AS ID, 
                                    m.anio_cursada AS Año, 
                                    m.nombre_materia AS Materia,
                                    c.nombre_carrera AS Carrera,
                                    c.id_carrera,
                                    CONCAT(e.apellido, ', ', e.nombre) AS Profesor,
                                    e.id_empleado AS ID_Empleado
                                FROM 
                                    Materias AS m
                                JOIN 
                                    MateriasxCarrera AS mc ON m.id_materia = mc.id_materia
                                JOIN 
                                    Carreras AS c ON mc.id_carrera = c.id_carrera
                                LEFT JOIN 
                                    MateriasxProfesor AS mp ON m.id_materia = mp.id_materia --LEFT JOIN para que incluso muestre materias si no tienen profesor(no puede pasar)
                                LEFT JOIN 
                                    Empleados AS e ON mp.id_profesor = e.id_empleado;";

            SqlCommand command = new SqlCommand(consulta);

            try
            {
                // Uso la clase gestora para ejecutar la consulta
                DataTable dt = gestormaterias.EjecutarConsulta(command);


                dataGridViewMaterias.DataSource = dt;


                dataGridViewMaterias.Columns["id_carrera"].Visible = false;
                dataGridViewMaterias.Columns["ID_Empleado"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }

        private void dataGridViewMaterias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int ID = Convert.ToInt32(dataGridViewMaterias.Rows[e.RowIndex].Cells["ID"].Value);
                    int Año = Convert.ToInt32(dataGridViewMaterias.Rows[e.RowIndex].Cells["Año"].Value);
                    string Nombre = dataGridViewMaterias.Rows[e.RowIndex].Cells["Materia"].Value.ToString();
                    int idcarrera = Convert.ToInt32(dataGridViewMaterias.Rows[e.RowIndex].Cells["id_carrera"].Value);
                    int idempleado = Convert.ToInt32(dataGridViewMaterias.Rows[e.RowIndex].Cells["ID_Empleado"].Value);


                    FormMateriasModal formmateriasmodal = new FormMateriasModal(ID, Año, Nombre, idcarrera, idempleado);
                    formmateriasmodal.MateriaEvento += ActualizarDataGridView;
                    formmateriasmodal.ShowDialog();
                }
                catch
                {
                    int ID = 0;
                    int Año = 0;
                    string Nombre = "";
                    int idcarrera = 0;
                    int idprofesor = 0;

                    FormMateriasModal formmateriasmodal = new FormMateriasModal(ID, Año, Nombre, idcarrera, idprofesor);
                    formmateriasmodal.MateriaEvento += ActualizarDataGridView;
                    formmateriasmodal.ShowDialog();
                }
            }
        }
        private void ActualizarDataGridView()
        {
            Cargar_Tabla_Materias();
        }
    }
}