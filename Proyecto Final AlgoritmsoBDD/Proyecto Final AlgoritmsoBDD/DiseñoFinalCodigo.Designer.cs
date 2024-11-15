
namespace DiseñoFinal
{
    partial class DiseñoFinalCodigo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiseñoFinalCodigo));
            tabControl1 = new TabControl();
            tabMenuPrincipal = new TabPage();
            panel8 = new Panel();
            lblUsuario = new Label();
            lblPerfil = new Label();
            label14 = new Label();
            label13 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            btnABMAlumnos = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnABMMaterias = new Button();
            btnABMProfesores = new Button();
            btnABMCarreras = new Button();
            btnABMEmpleados = new Button();
            tabPerfilAlumno = new TabPage();
            panel10 = new Panel();
            AlumnoImagenes = new PictureBox();
            panel12 = new Panel();
            lblUsuarioAlumno = new Label();
            lblPerfilAlumno = new Label();
            label33 = new Label();
            label34 = new Label();
            panel11 = new Panel();
            pictureBox2 = new PictureBox();
            btnExamenesAlumnos = new Button();
            btnDatosAlumnos = new Button();
            btnMateriasAlumnos = new Button();
            tabPerfilProfesores = new TabPage();
            panel13 = new Panel();
            lblUsuarioEmpleado = new Label();
            lblPerfilEmpleado = new Label();
            label36 = new Label();
            label37 = new Label();
            panel9 = new Panel();
            pictureBox3 = new PictureBox();
            btnExamenesProfesor = new Button();
            btnCarrerasProfesor = new Button();
            btnMateriasProfesor = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabMenuPrincipal.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPerfilAlumno.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AlumnoImagenes).BeginInit();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPerfilProfesores.SuspendLayout();
            panel13.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMenuPrincipal);
            tabControl1.Controls.Add(tabPerfilAlumno);
            tabControl1.Controls.Add(tabPerfilProfesores);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1216, 601);
            tabControl1.TabIndex = 0;
            // 
            // tabMenuPrincipal
            // 
            tabMenuPrincipal.Controls.Add(panel8);
            tabMenuPrincipal.Controls.Add(panel7);
            tabMenuPrincipal.Controls.Add(panel6);
            tabMenuPrincipal.Controls.Add(panel5);
            tabMenuPrincipal.Controls.Add(panel4);
            tabMenuPrincipal.Controls.Add(panel3);
            tabMenuPrincipal.Controls.Add(panel1);
            tabMenuPrincipal.Location = new Point(4, 24);
            tabMenuPrincipal.Name = "tabMenuPrincipal";
            tabMenuPrincipal.Padding = new Padding(3);
            tabMenuPrincipal.Size = new Size(1208, 573);
            tabMenuPrincipal.TabIndex = 0;
            tabMenuPrincipal.Text = "Menu Principal";
            tabMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(lblUsuario);
            panel8.Controls.Add(lblPerfil);
            panel8.Controls.Add(label14);
            panel8.Controls.Add(label13);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(197, 534);
            panel8.Name = "panel8";
            panel8.Size = new Size(1008, 43);
            panel8.TabIndex = 6;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(51, 13);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(69, 21);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerfil.Location = new Point(841, 13);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(135, 21);
            lblPerfil.TabIndex = 2;
            lblPerfil.Text = "(Aca va el perfil)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(757, 13);
            label14.Name = "label14";
            label14.Size = new Size(78, 21);
            label14.TabIndex = 1;
            label14.Text = "Usted es:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(6, 13);
            label13.Name = "label13";
            label13.Size = new Size(54, 21);
            label13.TabIndex = 0;
            label13.Text = "Hola, ";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Gainsboro;
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(197, 423);
            panel7.Name = "panel7";
            panel7.Size = new Size(1008, 111);
            panel7.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(197, 318);
            panel6.Name = "panel6";
            panel6.Size = new Size(1008, 105);
            panel6.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(197, 213);
            panel5.Name = "panel5";
            panel5.Size = new Size(1008, 105);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(197, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(1008, 105);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(197, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1008, 105);
            panel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnABMAlumnos);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnABMMaterias);
            panel1.Controls.Add(btnABMProfesores);
            panel1.Controls.Add(btnABMCarreras);
            panel1.Controls.Add(btnABMEmpleados);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 567);
            panel1.TabIndex = 0;
            // 
            // btnABMAlumnos
            // 
            btnABMAlumnos.BackColor = Color.FromArgb(33, 63, 96);
            btnABMAlumnos.BackgroundImageLayout = ImageLayout.None;
            btnABMAlumnos.Cursor = Cursors.Hand;
            btnABMAlumnos.Dock = DockStyle.Top;
            btnABMAlumnos.FlatAppearance.BorderSize = 0;
            btnABMAlumnos.FlatStyle = FlatStyle.Flat;
            btnABMAlumnos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnABMAlumnos.ForeColor = Color.White;
            btnABMAlumnos.Location = new Point(0, 420);
            btnABMAlumnos.Name = "btnABMAlumnos";
            btnABMAlumnos.Size = new Size(194, 111);
            btnABMAlumnos.TabIndex = 6;
            btnABMAlumnos.Text = "ALUMNOS";
            btnABMAlumnos.UseVisualStyleBackColor = false;
            btnABMAlumnos.Click += btnABMAlumnos_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 531);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 36);
            panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Proyecto_Final_AlgoritmsoBDD.Properties.Resources.logo_hilet_azul_grande;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnABMMaterias
            // 
            btnABMMaterias.BackColor = Color.FromArgb(33, 63, 96);
            btnABMMaterias.BackgroundImageLayout = ImageLayout.None;
            btnABMMaterias.Cursor = Cursors.Hand;
            btnABMMaterias.Dock = DockStyle.Top;
            btnABMMaterias.FlatAppearance.BorderSize = 0;
            btnABMMaterias.FlatStyle = FlatStyle.Flat;
            btnABMMaterias.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnABMMaterias.ForeColor = Color.White;
            btnABMMaterias.Location = new Point(0, 315);
            btnABMMaterias.Name = "btnABMMaterias";
            btnABMMaterias.Size = new Size(194, 105);
            btnABMMaterias.TabIndex = 4;
            btnABMMaterias.Text = "MATERIAS";
            btnABMMaterias.UseVisualStyleBackColor = false;
            btnABMMaterias.Click += btnABMMaterias_Click;
            // 
            // btnABMProfesores
            // 
            btnABMProfesores.BackColor = Color.FromArgb(33, 63, 96);
            btnABMProfesores.BackgroundImageLayout = ImageLayout.None;
            btnABMProfesores.Cursor = Cursors.Hand;
            btnABMProfesores.Dock = DockStyle.Top;
            btnABMProfesores.FlatAppearance.BorderSize = 0;
            btnABMProfesores.FlatStyle = FlatStyle.Flat;
            btnABMProfesores.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnABMProfesores.ForeColor = Color.White;
            btnABMProfesores.Location = new Point(0, 210);
            btnABMProfesores.Name = "btnABMProfesores";
            btnABMProfesores.Size = new Size(194, 105);
            btnABMProfesores.TabIndex = 3;
            btnABMProfesores.Text = "PROFESORES";
            btnABMProfesores.UseVisualStyleBackColor = false;
            btnABMProfesores.Click += btnABMProfesores_Click;
            // 
            // btnABMCarreras
            // 
            btnABMCarreras.BackColor = Color.FromArgb(33, 63, 96);
            btnABMCarreras.BackgroundImageLayout = ImageLayout.None;
            btnABMCarreras.Cursor = Cursors.Hand;
            btnABMCarreras.Dock = DockStyle.Top;
            btnABMCarreras.FlatAppearance.BorderSize = 0;
            btnABMCarreras.FlatStyle = FlatStyle.Flat;
            btnABMCarreras.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnABMCarreras.ForeColor = Color.White;
            btnABMCarreras.Location = new Point(0, 105);
            btnABMCarreras.Name = "btnABMCarreras";
            btnABMCarreras.Size = new Size(194, 105);
            btnABMCarreras.TabIndex = 2;
            btnABMCarreras.Text = "CARRERAS";
            btnABMCarreras.UseVisualStyleBackColor = false;
            btnABMCarreras.Click += btnabmCarreras_Click;
            // 
            // btnABMEmpleados
            // 
            btnABMEmpleados.BackColor = Color.FromArgb(33, 63, 96);
            btnABMEmpleados.BackgroundImageLayout = ImageLayout.None;
            btnABMEmpleados.Cursor = Cursors.Hand;
            btnABMEmpleados.Dock = DockStyle.Top;
            btnABMEmpleados.FlatAppearance.BorderSize = 0;
            btnABMEmpleados.FlatStyle = FlatStyle.Flat;
            btnABMEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnABMEmpleados.ForeColor = Color.White;
            btnABMEmpleados.Location = new Point(0, 0);
            btnABMEmpleados.Name = "btnABMEmpleados";
            btnABMEmpleados.Size = new Size(194, 105);
            btnABMEmpleados.TabIndex = 1;
            btnABMEmpleados.Text = "EMPLEADOS";
            btnABMEmpleados.UseVisualStyleBackColor = false;
            btnABMEmpleados.Click += btnABMEmpleados_Click;
            // 
            // tabPerfilAlumno
            // 
            tabPerfilAlumno.Controls.Add(panel10);
            tabPerfilAlumno.Location = new Point(4, 24);
            tabPerfilAlumno.Name = "tabPerfilAlumno";
            tabPerfilAlumno.Size = new Size(1208, 573);
            tabPerfilAlumno.TabIndex = 2;
            tabPerfilAlumno.Text = "Mi Perfil";
            tabPerfilAlumno.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            panel10.Controls.Add(AlumnoImagenes);
            panel10.Controls.Add(panel12);
            panel10.Controls.Add(panel11);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1208, 573);
            panel10.TabIndex = 0;
            // 
            // AlumnoImagenes
            // 
            AlumnoImagenes.Dock = DockStyle.Fill;
            AlumnoImagenes.Image = (Image)resources.GetObject("AlumnoImagenes.Image");
            AlumnoImagenes.Location = new Point(195, 0);
            AlumnoImagenes.Name = "AlumnoImagenes";
            AlumnoImagenes.Size = new Size(1013, 524);
            AlumnoImagenes.SizeMode = PictureBoxSizeMode.StretchImage;
            AlumnoImagenes.TabIndex = 8;
            AlumnoImagenes.TabStop = false;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Transparent;
            panel12.Controls.Add(lblUsuarioAlumno);
            panel12.Controls.Add(lblPerfilAlumno);
            panel12.Controls.Add(label33);
            panel12.Controls.Add(label34);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(195, 524);
            panel12.Name = "panel12";
            panel12.Size = new Size(1013, 49);
            panel12.TabIndex = 7;
            // 
            // lblUsuarioAlumno
            // 
            lblUsuarioAlumno.AutoSize = true;
            lblUsuarioAlumno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioAlumno.Location = new Point(51, 13);
            lblUsuarioAlumno.Name = "lblUsuarioAlumno";
            lblUsuarioAlumno.Size = new Size(69, 21);
            lblUsuarioAlumno.TabIndex = 3;
            lblUsuarioAlumno.Text = "Usuario";
            // 
            // lblPerfilAlumno
            // 
            lblPerfilAlumno.AutoSize = true;
            lblPerfilAlumno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerfilAlumno.Location = new Point(841, 13);
            lblPerfilAlumno.Name = "lblPerfilAlumno";
            lblPerfilAlumno.Size = new Size(135, 21);
            lblPerfilAlumno.TabIndex = 2;
            lblPerfilAlumno.Text = "(Aca va el perfil)";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.Location = new Point(757, 13);
            label33.Name = "label33";
            label33.Size = new Size(78, 21);
            label33.TabIndex = 1;
            label33.Text = "Usted es:";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.Location = new Point(6, 13);
            label34.Name = "label34";
            label34.Size = new Size(54, 21);
            label34.TabIndex = 0;
            label34.Text = "Hola, ";
            // 
            // panel11
            // 
            panel11.Controls.Add(pictureBox2);
            panel11.Controls.Add(btnExamenesAlumnos);
            panel11.Controls.Add(btnDatosAlumnos);
            panel11.Controls.Add(btnMateriasAlumnos);
            panel11.Dock = DockStyle.Left;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(195, 573);
            panel11.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Proyecto_Final_AlgoritmsoBDD.Properties.Resources.logo_hilet_azul_grande;
            pictureBox2.Location = new Point(0, 524);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(195, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnExamenesAlumnos
            // 
            btnExamenesAlumnos.BackColor = Color.FromArgb(33, 63, 96);
            btnExamenesAlumnos.BackgroundImageLayout = ImageLayout.None;
            btnExamenesAlumnos.Dock = DockStyle.Top;
            btnExamenesAlumnos.FlatAppearance.BorderSize = 0;
            btnExamenesAlumnos.FlatStyle = FlatStyle.Flat;
            btnExamenesAlumnos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExamenesAlumnos.ForeColor = SystemColors.ButtonHighlight;
            btnExamenesAlumnos.Location = new Point(0, 380);
            btnExamenesAlumnos.Name = "btnExamenesAlumnos";
            btnExamenesAlumnos.Size = new Size(195, 144);
            btnExamenesAlumnos.TabIndex = 3;
            btnExamenesAlumnos.Text = "EXAMENES RENDIDOS";
            btnExamenesAlumnos.UseVisualStyleBackColor = false;
            btnExamenesAlumnos.Click += btnExamenesAlumnos_Click;
            // 
            // btnDatosAlumnos
            // 
            btnDatosAlumnos.BackColor = Color.FromArgb(33, 63, 96);
            btnDatosAlumnos.BackgroundImageLayout = ImageLayout.None;
            btnDatosAlumnos.Dock = DockStyle.Top;
            btnDatosAlumnos.FlatAppearance.BorderSize = 0;
            btnDatosAlumnos.FlatStyle = FlatStyle.Flat;
            btnDatosAlumnos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatosAlumnos.ForeColor = SystemColors.ButtonHighlight;
            btnDatosAlumnos.Location = new Point(0, 193);
            btnDatosAlumnos.Name = "btnDatosAlumnos";
            btnDatosAlumnos.Size = new Size(195, 187);
            btnDatosAlumnos.TabIndex = 2;
            btnDatosAlumnos.Text = "MIS DATOS";
            btnDatosAlumnos.UseVisualStyleBackColor = false;
            btnDatosAlumnos.Click += btnDatosAlumnos_Click;
            // 
            // btnMateriasAlumnos
            // 
            btnMateriasAlumnos.BackColor = Color.FromArgb(33, 63, 96);
            btnMateriasAlumnos.BackgroundImageLayout = ImageLayout.None;
            btnMateriasAlumnos.Dock = DockStyle.Top;
            btnMateriasAlumnos.FlatAppearance.BorderSize = 0;
            btnMateriasAlumnos.FlatStyle = FlatStyle.Flat;
            btnMateriasAlumnos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMateriasAlumnos.ForeColor = SystemColors.ButtonHighlight;
            btnMateriasAlumnos.Location = new Point(0, 0);
            btnMateriasAlumnos.Name = "btnMateriasAlumnos";
            btnMateriasAlumnos.Size = new Size(195, 193);
            btnMateriasAlumnos.TabIndex = 1;
            btnMateriasAlumnos.Text = "MATERIAS";
            btnMateriasAlumnos.UseVisualStyleBackColor = false;
            btnMateriasAlumnos.Click += btnMateriasAlumnos_Click;
            // 
            // tabPerfilProfesores
            // 
            tabPerfilProfesores.Controls.Add(panel13);
            tabPerfilProfesores.Controls.Add(panel9);
            tabPerfilProfesores.Location = new Point(4, 24);
            tabPerfilProfesores.Name = "tabPerfilProfesores";
            tabPerfilProfesores.Padding = new Padding(3);
            tabPerfilProfesores.Size = new Size(1208, 573);
            tabPerfilProfesores.TabIndex = 1;
            tabPerfilProfesores.Text = "Mi Perfil";
            tabPerfilProfesores.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Transparent;
            panel13.Controls.Add(lblUsuarioEmpleado);
            panel13.Controls.Add(lblPerfilEmpleado);
            panel13.Controls.Add(label36);
            panel13.Controls.Add(label37);
            panel13.Dock = DockStyle.Bottom;
            panel13.Location = new Point(198, 521);
            panel13.Name = "panel13";
            panel13.Size = new Size(1007, 49);
            panel13.TabIndex = 8;
            // 
            // lblUsuarioEmpleado
            // 
            lblUsuarioEmpleado.AutoSize = true;
            lblUsuarioEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioEmpleado.Location = new Point(51, 13);
            lblUsuarioEmpleado.Name = "lblUsuarioEmpleado";
            lblUsuarioEmpleado.Size = new Size(69, 21);
            lblUsuarioEmpleado.TabIndex = 3;
            lblUsuarioEmpleado.Text = "Usuario";
            // 
            // lblPerfilEmpleado
            // 
            lblPerfilEmpleado.AutoSize = true;
            lblPerfilEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerfilEmpleado.Location = new Point(841, 13);
            lblPerfilEmpleado.Name = "lblPerfilEmpleado";
            lblPerfilEmpleado.Size = new Size(135, 21);
            lblPerfilEmpleado.TabIndex = 2;
            lblPerfilEmpleado.Text = "(Aca va el perfil)";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.Location = new Point(757, 13);
            label36.Name = "label36";
            label36.Size = new Size(78, 21);
            label36.TabIndex = 1;
            label36.Text = "Usted es:";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label37.Location = new Point(6, 13);
            label37.Name = "label37";
            label37.Size = new Size(54, 21);
            label37.TabIndex = 0;
            label37.Text = "Hola, ";
            // 
            // panel9
            // 
            panel9.Controls.Add(pictureBox3);
            panel9.Controls.Add(btnExamenesProfesor);
            panel9.Controls.Add(btnCarrerasProfesor);
            panel9.Controls.Add(btnMateriasProfesor);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(195, 567);
            panel9.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Proyecto_Final_AlgoritmsoBDD.Properties.Resources.logo_hilet_azul_grande;
            pictureBox3.Location = new Point(0, 520);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(195, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // btnExamenesProfesor
            // 
            btnExamenesProfesor.BackColor = Color.FromArgb(33, 63, 96);
            btnExamenesProfesor.BackgroundImageLayout = ImageLayout.None;
            btnExamenesProfesor.Dock = DockStyle.Top;
            btnExamenesProfesor.FlatAppearance.BorderSize = 0;
            btnExamenesProfesor.FlatStyle = FlatStyle.Flat;
            btnExamenesProfesor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExamenesProfesor.ForeColor = SystemColors.ButtonHighlight;
            btnExamenesProfesor.Location = new Point(0, 372);
            btnExamenesProfesor.Name = "btnExamenesProfesor";
            btnExamenesProfesor.Size = new Size(195, 148);
            btnExamenesProfesor.TabIndex = 3;
            btnExamenesProfesor.Text = "EXAMENES";
            btnExamenesProfesor.UseVisualStyleBackColor = false;
            btnExamenesProfesor.Click += btnExamenesProfesor_Click;
            // 
            // btnCarrerasProfesor
            // 
            btnCarrerasProfesor.BackColor = Color.FromArgb(33, 63, 96);
            btnCarrerasProfesor.BackgroundImageLayout = ImageLayout.None;
            btnCarrerasProfesor.Dock = DockStyle.Top;
            btnCarrerasProfesor.FlatAppearance.BorderSize = 0;
            btnCarrerasProfesor.FlatStyle = FlatStyle.Flat;
            btnCarrerasProfesor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarrerasProfesor.ForeColor = SystemColors.ButtonHighlight;
            btnCarrerasProfesor.Location = new Point(0, 193);
            btnCarrerasProfesor.Name = "btnCarrerasProfesor";
            btnCarrerasProfesor.Size = new Size(195, 179);
            btnCarrerasProfesor.TabIndex = 2;
            btnCarrerasProfesor.Text = "MIS DATOS";
            btnCarrerasProfesor.UseVisualStyleBackColor = false;
            // 
            // btnMateriasProfesor
            // 
            btnMateriasProfesor.BackColor = Color.FromArgb(33, 63, 96);
            btnMateriasProfesor.BackgroundImageLayout = ImageLayout.None;
            btnMateriasProfesor.Dock = DockStyle.Top;
            btnMateriasProfesor.FlatAppearance.BorderSize = 0;
            btnMateriasProfesor.FlatStyle = FlatStyle.Flat;
            btnMateriasProfesor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMateriasProfesor.ForeColor = SystemColors.ButtonHighlight;
            btnMateriasProfesor.Location = new Point(0, 0);
            btnMateriasProfesor.Name = "btnMateriasProfesor";
            btnMateriasProfesor.Size = new Size(195, 193);
            btnMateriasProfesor.TabIndex = 1;
            btnMateriasProfesor.Text = "ALUMNOS";
            btnMateriasProfesor.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // DiseñoFinalCodigo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 601);
            Controls.Add(tabControl1);
            Name = "DiseñoFinalCodigo";
            Text = "HILET";
            tabControl1.ResumeLayout(false);
            tabMenuPrincipal.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPerfilAlumno.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AlumnoImagenes).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPerfilProfesores.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        private void btnABMAlumnos_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabMenuPrincipal;
        private Panel panel1;
        private TabPage tabPerfilProfesores;
        private Button btnABMMaterias;
        private Button btnABMProfesores;
        private Button btnABMCarreras;
        private Button btnABMEmpleados;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel9;
        private Button btnExamenesProfesor;
        private Button btnCarrerasProfesor;
        private Button btnMateriasProfesor;
        private Label lblUsuario;
        private Label lblPerfil;
        private Label label14;
        private Label label13;
        private TabPage tabPerfilAlumno;
        private Button btnABMAlumnos;
        private Panel panel10;
        private Panel panel11;
        private Button btnExamenesAlumnos;
        private Button btnMateriasAlumnos;
        private Button button1;
        private Button btnDatosAlumnos;
        private Panel panel12;
        private Label lblUsuarioAlumno;
        private Label lblPerfilAlumno;
        private Label label33;
        private Label label34;
        private PictureBox pictureBox2;
        private PictureBox AlumnoImagenes;
        private System.Windows.Forms.Timer timer1;
        private Panel panel13;
        private Label lblUsuarioEmpleado;
        private Label lblPerfilEmpleado;
        private Label label36;
        private Label label37;
        private PictureBox pictureBox3;
    }
}
