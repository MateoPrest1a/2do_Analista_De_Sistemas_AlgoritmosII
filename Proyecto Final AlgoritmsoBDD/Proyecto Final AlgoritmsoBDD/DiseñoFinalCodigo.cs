using Microsoft.VisualBasic.ApplicationServices;
using Proyecto_Final;
using Proyecto_Final_AlgoritmsoBDD;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Numerics;
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



            //Tab Page Empleados
            CargarEspecialidades();
            Cargar_Tabla_Empleados();
            Cargar_Filtros_Empleados();

            //Tab Page Alumnos
            Cargar_Tabla_Alumnos();
            Cargar_Filtros_Alumnos();
            CargarCarreras(); //Carga las carreras al combobox
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
                CargarDatosEnControles(Id_Persona);
                Cargar_Tabla_MateriasxProfesor(Id_Persona);
            }
            else if (perfil == "Personal Administrativo")
            {
                tabControl1.TabPages.RemoveAt(1);
                CargarDatosEnControles(Id_Persona);
            }
            else if (perfil == "Administrador")
            {
                //tabControl1.TabPages.RemoveAt(1);
            }
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

        }



        private void btnExamenesProfesor_Click(object sender, EventArgs e)
        {
            FormExamenes formexamenes = new FormExamenes();
            formexamenes.ShowDialog();
        }



        //Carga de fotos
        private void CargarImagen()
        {
            if (imgs.Count > 0 && indiceImagen >= 0 && indiceImagen < imgs.Count)
            {
                AlumnoImagenes.Image = Image.FromFile(imgs[indiceImagen]);
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


        //Tab Page Empleados

        GestorEmpleados gestorempleados = new GestorEmpleados();

        public void Cargar_Tabla_Empleados()
        {
            string consulta = "SELECT * FROM Empleados";
            SqlCommand command = new SqlCommand(consulta);

            try
            {
                DataTable dt = gestorempleados.EjecutarConsulta(command); // Usa la clase gestora para ejecutar la consulta
                dataGridViewEmpleados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }
        private DataTable ObtenerDatosEmpleado(int idEmpleado)
        {
            string query = @"SELECT 
                        id_empleado, 
                        nombre, 
                        apellido, 
                        direccion_calle, 
                        direccion_nro, 
                        telefono, 
                        dni, 
                        email, 
                        fecha_nacimiento, 
                        salario, 
                        tipo_perfil 
                    FROM Empleados
                    WHERE id_empleado = @id_empleado";

            using (SqlCommand command = new SqlCommand(query))
            {
                command.Parameters.AddWithValue("@id_empleado", idEmpleado);


                return gestorempleados.EjecutarConsulta(command);
            }
        }

        private void CargarDatosEnControles(int idEmpleado)
        {
            DataTable datosEmpleado = ObtenerDatosEmpleado(idEmpleado);

            if (datosEmpleado.Rows.Count > 0)
            {
                DataRow fila = datosEmpleado.Rows[0];

                lblEmpleado.Text = idEmpleado.ToString();

                txtNombreEmpleados.Text = fila["nombre"].ToString();


                txtApellidoEmpleados.Text = fila["apellido"].ToString();
                txtDireCalleEmpleados.Text = fila["direccion_calle"].ToString();
                txtDireNumeroEmpleados.Text = fila["direccion_nro"].ToString();
                txtTelefonoEmpleados.Text = fila["telefono"].ToString();
                txtDocumentoEmpleados.Text = fila["dni"].ToString();
                txtEmailEmpleados.Text = fila["email"].ToString();
                dtpFechaNacimientoEmpleado.Text = Convert.ToDateTime(fila["fecha_nacimiento"]).ToString("yyyy-MM-dd");
                txtSalarioEmpleados.Text = fila["salario"].ToString();

                // Si querés cargar un ComboBox con el tipo de perfil
                cmbEspecialidadEmpleado.SelectedValue = fila["tipo_perfil"];


                txtNombreEmpleados.Enabled = false;
                txtApellidoEmpleados.Enabled = false;
                txtDireCalleEmpleados.Enabled = false;
                txtDireNumeroEmpleados.Enabled = false;
                txtTelefonoEmpleados.Enabled = false;
                txtDocumentoEmpleados.Enabled = false;
                txtEmailEmpleados.Enabled = false;
                dtpFechaNacimientoEmpleado.Enabled = false;
                txtSalarioEmpleados.Enabled = false;
                cmbEspecialidadEmpleado.Enabled = false;
            }
            else
            {
                MessageBox.Show("No se encontró el empleado con el ID especificado.");
            }
        }

        //Cargo Combo Box Especialidades
        private void CargarEspecialidades()
        {
            var especialidades = new List<Especialidad>
            {
                new Especialidad { IdEspecialidad = 1, especialidad = "Personal Administrativo" },
                new Especialidad { IdEspecialidad = 2, especialidad = "Profesor" }
            };

            cmbEspecialidadEmpleado.DataSource = especialidades;
            cmbEspecialidadEmpleado.DisplayMember = "Especialidad";  // Lo que se muestra en el ComboBox
            cmbEspecialidadEmpleado.ValueMember = "IdEspecialidad"; // El valor que necesitas

            cmbEspecialidadEmpleados.DataSource = especialidades;
            cmbEspecialidadEmpleados.DisplayMember = "Especialidad";
            cmbEspecialidadEmpleados.ValueMember = "IdEspecialidad";
        }


        //Cargo la tabla alumnos para ese profesor
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

        // Cargo la tabla materias con las materias de ese profesor
        private void Cargar_Tabla_MateriasxProfesor(int idEmpleado)
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
                         JOIN                                               
                             Empleados AS e ON e.id_empleado = m.id_empleado
                         WHERE 
                             m.id_empleado = @idEmpleado";  // Filtro por id_empleado

            SqlCommand command = new SqlCommand(consulta);
            command.Parameters.AddWithValue("@idEmpleado", idEmpleado);

            try
            {
                DataTable dt = gestormaterias.EjecutarConsulta(command);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewMaterias.DataSource = dt;

                    dataGridViewMaterias.Columns["id_carrera"].Visible = false;
                    dataGridViewMaterias.Columns["ID_Empleado"].Visible = false;
                }
                else
                {
                    DataTable dtTemporal = new DataTable();
                    dtTemporal.Columns.Add("Mensaje");  // Columna personalizada
                    DataRow fila = dtTemporal.NewRow();
                    fila["Mensaje"] = "Sin materias asignadas";
                    dtTemporal.Rows.Add(fila);

                    dataGridViewMaterias.DataSource = null;

                    // Cargo el DataTable temporal en el DataGridView
                    dataGridViewMaterias.DataSource = dtTemporal;

                    // Solo muestro la columna del mensaje
                    dataGridViewMaterias.Columns[0].HeaderText = "Información";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }


        //Filtros Empleados

        private void Cargar_Filtros_Empleados()
        {
            cmbFiltrosEmpleados.Items.Clear();
            cmbFiltrosEmpleados.Items.Add("Nombre y Apellido");
            cmbFiltrosEmpleados.Items.Add("Carrera");
            cmbFiltrosEmpleados.Items.Add("Especialidad");

        }
        private void cmbFiltrosEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEspecialidadEmpleados.Visible = false;
            cmbCarreraEmpleados.Visible = false;
            txtNombreApellidoEmpleado.Visible = false;

            // Muestra el control correspondiente según la selección.
            switch (cmbFiltrosEmpleados.SelectedItem.ToString())
            {
                case "Nombre y Apellido":
                    txtNombreApellidoEmpleado.Visible = true;
                    break;
                case "Carrera":
                    cmbCarreraEmpleados.Visible = true;
                    break;
                case "Especialidad":
                    cmbEspecialidadEmpleados.Visible = true;
                    break;
            }
        }


        //Tab Page Alumnos

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

        // Boton mis datos alumno
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


        //Cargo Combo Box Profesores Alumnos
        private void CargarProfesores()
        {
            string query = "SELECT id_empleado, nombre, apellido FROM Empleados WHERE tipo_perfil = 2"; // Filtramos por tipo_perfil = 2 para obtener solo profesores

            try
            {

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    // Uso la clase gestora para ejecutar la consulta
                    DataTable cmbProfesoresTabla = gestoralumnos.EjecutarConsulta(command);


                    cmbProfesoresAlumno.Items.Clear();

                    foreach (DataRow row in cmbProfesoresTabla.Rows)
                    {
                        // Creo un nuevo objeto para almacenar el profesor
                        var profesor = new Empleado
                        {
                            ID_Empleado = Convert.ToInt32(row["id_empleado"]), // id_empleado
                            Nombre = row["nombre"].ToString(), // nombre
                            Apellido = row["apellido"].ToString() // apellido
                        };

                        // Agrego el profesor al ComboBox
                        cmbProfesoresAlumno.Items.Add(profesor);
                    }


                    cmbProfesoresAlumno.DisplayMember = "NombreCompleto"; // Lo que se muestra
                    cmbProfesoresAlumno.ValueMember = "ID_Empleado"; // El valor 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los profesores: {ex.Message}");
            }
        }

        //Cargo Combo box Carreras 
        private void CargarCarreras()
        {
            string query = "SELECT id_carrera, nombre_carrera FROM Carreras";

            try
            {

                using (SqlCommand command = new SqlCommand(query, conexion))
                {

                    DataTable cmbCarrerasTabla = gestoralumnos.EjecutarConsulta(command);


                    cmbCarreraAlumno.Items.Clear();

                    foreach (DataRow row in cmbCarrerasTabla.Rows)
                    {
                        // Creo objeto para cada carrera
                        var carrera = new Carrera
                        {
                            ID_Carrera = Convert.ToInt32(row["id_carrera"]), // id_carrera
                            Nombre_Carrera = row["nombre_carrera"].ToString() // nombre_carrera
                        };

                        // Agregar la carrera al ComboBox
                        cmbCarreraAlumno.Items.Add(carrera);
                    }


                    cmbCarreraAlumno.DisplayMember = "Nombre_Carrera"; // Lo que se muestra 
                    cmbCarreraAlumno.ValueMember = "ID_Carrera"; // El valor

                    cmbCarreraEmpleados.DisplayMember = "Nombre_Carrera";
                    cmbCarreraEmpleados.ValueMember = "ID_Carrera";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las carreras: {ex.Message}");
            }
        }

        private void btnFiltrarAlumnos_Click(object sender, EventArgs e)
        {
            // Verifico que campo esta visible
            if (txtNombreApellidoAlumno.Visible)
            {
                // Llama al método BuscarAlumno pasándole el texto de txtNombreApellido
                string nombreApellido = txtNombreApellidoAlumno.Text;

                if (!string.IsNullOrEmpty(nombreApellido))
                {
                    // Llamo al método de búsqueda
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
                int añoSeleccionado = Convert.ToInt32(cmbAñoAlumno.SelectedItem);

                // Verifico que el valor del año seleccionado sea válido
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

                    // Si no hay resultados
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


        private void dataGridViewAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Evento donble click usuarios
        private void dataGridViewAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int matricula = Convert.ToInt32(dataGridViewAlumnos.Rows[e.RowIndex].Cells["Matricula"].Value);
                    string nombre = dataGridViewAlumnos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    string apellido = dataGridViewAlumnos.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                    string direcalle = dataGridViewAlumnos.Rows[e.RowIndex].Cells["direccion_calle"].Value.ToString();
                    string direnum = dataGridViewAlumnos.Rows[e.RowIndex].Cells["direccion_numero"].Value.ToString();
                    string telefono = dataGridViewAlumnos.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                    string documento = dataGridViewAlumnos.Rows[e.RowIndex].Cells["dni"].Value.ToString();
                    string email = dataGridViewAlumnos.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    DateTime fechaNacimiento = Convert.ToDateTime(dataGridViewAlumnos.Rows[e.RowIndex].Cells["fecha_nacimiento"].Value);
                    int idcarrera = Convert.ToInt32(dataGridViewAlumnos.Rows[e.RowIndex].Cells["id_carrera"].Value);
                    int año = Convert.ToInt32(dataGridViewAlumnos.Rows[e.RowIndex].Cells["año"].Value);

                    FormAlumnosModal formalumnosmodal = new FormAlumnosModal(matricula, nombre, apellido, direcalle, direnum, telefono, documento, email, fechaNacimiento, idcarrera, año, Perfil);
                    formalumnosmodal.AlumnoEvento += ActualizarDataGridViewAlumnos;
                    formalumnosmodal.ShowDialog();
                }
                catch
                {
                    int matricula = 0;
                    string nombre = "";
                    string apellido = "";
                    string direcalle = "";
                    string direnum = "";
                    string telefono = "";
                    string documento = "";
                    string email = "";
                    DateTime fechaNacimiento = DateTime.Now;
                    int carrera = 0;
                    int año = 0;

                    FormAlumnosModal formalumnosmodal = new FormAlumnosModal(matricula, nombre, apellido, direcalle, direnum, telefono, documento, email, fechaNacimiento, carrera, año, Perfil);
                    formalumnosmodal.AlumnoEvento += ActualizarDataGridViewAlumnos;  //Me suscribo al evento para que se actualice al agregar un alumno
                    formalumnosmodal.ShowDialog();
                }

            }
        }
        private void ActualizarDataGridViewAlumnos()
        {
            Cargar_Tabla_Alumnos();
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

        private void dataGridViewEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}