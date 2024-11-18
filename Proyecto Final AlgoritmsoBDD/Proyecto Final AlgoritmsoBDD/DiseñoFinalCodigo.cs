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

            Id_Persona = idPerfil; //Guardo el id Persona para utilizarlo despues
            Perfil = perfil; //Cargo el perfil de la persona

            //Cargo datos alumno
            lblUsuarioAlumno.Text = nombre + " " + apellido;
            lblPerfilAlumno.Text = perfil;

            //Cargo datos profesores
            lblUsuarioEmpleado.Text = nombre + " " + apellido;
            lblPerfilEmpleado.Text = perfil;

            


            //Tab Page Alumnos
            Cargar_Tabla_Alumnos();
            Cargar_Filtros_Alumnos();
            CargarCarreras(); //Carga las carreras al combobox en Alumnos
            CargarProfesores();

            //Tab Page Materias
            Cargar_Tabla_Materias();

            AjustarVisibilidadPerfil(perfil); //Por ultimo ajusto los formularios dependiendo el perfil
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
                Cargar_Tabla_AlumnosPorProfesor(Id_Persona);
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
            cmbFiltrosAlumnos.Items.Add("Profesores");


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
            cmbProfesoresAlumno.Visible = false;

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
                case "Profesores":
                    cmbProfesoresAlumno.Visible = true;
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


        //Filtro alumnos por profesores
        private void Cargar_Tabla_AlumnosPorProfesor(int idEmpleado)
        {
            // Consulta SQL con el parámetro @id_empleado
            string consulta = @"
                                SELECT 
                                    a.matricula,
                                    a.nombre AS Nombre_Alumno,
                                    a.apellido AS Apellido_Alumno,
                                    a.direccion_calle,
                                    a.direccion_numero,
                                    a.telefono,
                                    a.dni,
                                    a.email,
                                    a.fecha_nacimiento,
                                    a.id_carrera,
                                    a.año,
                                    m.nombre_materia AS Materia,
                                    ma.estado AS Estado_Alumno
                                FROM 
                                    Alumnos a
                                JOIN 
                                    MateriasxAlumno ma ON a.matricula = ma.matricula
                                JOIN 
                                    Materias m ON ma.id_materia = m.id_materia
                                WHERE 
                                    m.id_empleado = @id_empleado AND a.baja = 0;";  // solo alumnos activos

            SqlCommand command = new SqlCommand(consulta);
            command.Parameters.AddWithValue("@id_empleado", idEmpleado);

            try
            {
                // Ejecutar la consulta y llenar el DataTable
                DataTable dt = gestoralumnos.EjecutarConsulta(command);

                // Asignar el DataTable al DataGridView
                dataGridViewAlumnos.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Manejar excepciones, por ejemplo, mostrar un mensaje de error
                MessageBox.Show("Error al cargar la tabla de alumnos: " + ex.Message);
            }
        }

        //Cargo Combo Box Profesores Alumnos
        private void CargarProfesores()
        {
            string query = "SELECT id_empleado, nombre, apellido FROM Empleados WHERE tipo_perfil = 2"; // Filtramos por tipo_perfil = 2 para obtener solo profesores

            try
            {
                // Crear el comando SQL
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    // Usar la clase gestora para ejecutar la consulta
                    DataTable cmbProfesoresTabla = gestoralumnos.EjecutarConsulta(command);

                    // Limpiar el ComboBox antes de llenarlo
                    cmbProfesoresAlumno.Items.Clear();

                    foreach (DataRow row in cmbProfesoresTabla.Rows)
                    {
                        // Crear un nuevo objeto para almacenar el profesor
                        var profesor = new Empleado
                        {
                            ID_Empleado = Convert.ToInt32(row["id_empleado"]), // id_empleado
                            Nombre = row["nombre"].ToString(), // nombre
                            Apellido = row["apellido"].ToString() // apellido
                        };

                        // Agregar el profesor al ComboBox
                        cmbProfesoresAlumno.Items.Add(profesor);
                    }

                    // Configura DisplayMember y ValueMember
                    cmbProfesoresAlumno.DisplayMember = "NombreCompleto"; // Lo que se muestra en el ComboBox
                    cmbProfesoresAlumno.ValueMember = "ID_Empleado"; // El valor que se utilizará
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los profesores: {ex.Message}");
            }
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
                Carrera carreraSeleccionada = (Carrera)cmbCarreraAlumno.SelectedItem;

                // Verifico que la carrera seleccionada no sea nula
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
            else if (cmbProfesoresAlumno.Visible)
            {
                Empleado profesorSeleccionado = (Empleado)cmbProfesoresAlumno.SelectedItem;

                // Verifico que el profesor seleccionado no sea nulo
                if (profesorSeleccionado != null)
                {
                    // Llamo al método de búsqueda de alumnos para ese profesor
                    ClaseGestorAlumnos gestorAlumnos = new ClaseGestorAlumnos();
                    DataTable resultados = gestorAlumnos.CargarAlumnosPorProfesor(profesorSeleccionado.ID_Empleado);

                    // Mostrar los resultados en el DataGridView
                    dataGridViewAlumnos.DataSource = resultados;

                    // Si no hay resultados, mostrar un mensaje
                    if (resultados.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron alumnos para el profesor seleccionado.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un profesor.");
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
                                    m.id_carrera,
                                    c.nombre_carrera,
                                    CONCAT(e.apellido, ' ', e.nombre) AS Profesor,
                                    m.id_empleado AS ID_Empleado
                                FROM 
                                    Materias AS m
                                JOIN 
                                    Carreras AS c ON m.id_carrera = c.id_carrera
                                LEFT JOIN                                               --LEFT ya que devuelve todas las materias aunque no tengan profesor
                                    Empleados AS e ON e.id_empleado = m.id_empleado";


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