namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class FormAlumnosModal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumnosModal));
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            btnSalir = new Button();
            panel3 = new Panel();
            lblMatriculaAlumno = new Label();
            lblMatricula = new Label();
            btnHistorialExamenes = new Button();
            btnAsignarMaterias = new Button();
            btnExamenesRendidos = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            cmbAñoAlumno = new ComboBox();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            cmbCarrerasAlumnos = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dtpFechaNacimientoAlumno = new DateTimePicker();
            txtEmailAlumno = new TextBox();
            txtDocumentoAlumno = new TextBox();
            txtDireNumeroAlumno = new TextBox();
            txtTelefonoAlumno = new TextBox();
            txtDireCalleAlumno = new TextBox();
            txtApellidoAlumno = new TextBox();
            txtNombreAlumno = new TextBox();
            error1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 63, 96);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(744, 69);
            panel2.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(218, 55);
            label2.TabIndex = 1;
            label2.Text = "Alumnos";
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(673, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(59, 44);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblMatriculaAlumno);
            panel3.Controls.Add(lblMatricula);
            panel3.Controls.Add(btnHistorialExamenes);
            panel3.Controls.Add(btnAsignarMaterias);
            panel3.Controls.Add(btnExamenesRendidos);
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnModificar);
            panel3.Controls.Add(btnAgregar);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cmbAñoAlumno);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(cmbCarrerasAlumnos);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dtpFechaNacimientoAlumno);
            panel3.Controls.Add(txtEmailAlumno);
            panel3.Controls.Add(txtDocumentoAlumno);
            panel3.Controls.Add(txtDireNumeroAlumno);
            panel3.Controls.Add(txtTelefonoAlumno);
            panel3.Controls.Add(txtDireCalleAlumno);
            panel3.Controls.Add(txtApellidoAlumno);
            panel3.Controls.Add(txtNombreAlumno);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(744, 450);
            panel3.TabIndex = 6;
            // 
            // lblMatriculaAlumno
            // 
            lblMatriculaAlumno.AutoSize = true;
            lblMatriculaAlumno.Font = new Font("Microsoft Sans Serif", 12F);
            lblMatriculaAlumno.Location = new Point(153, 109);
            lblMatriculaAlumno.Name = "lblMatriculaAlumno";
            lblMatriculaAlumno.Size = new Size(0, 20);
            lblMatriculaAlumno.TabIndex = 46;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatricula.ImageAlign = ContentAlignment.BottomLeft;
            lblMatricula.Location = new Point(63, 109);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(81, 20);
            lblMatricula.TabIndex = 45;
            lblMatricula.Text = "Matricula :";
            lblMatricula.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHistorialExamenes
            // 
            btnHistorialExamenes.Location = new Point(475, 331);
            btnHistorialExamenes.Name = "btnHistorialExamenes";
            btnHistorialExamenes.Size = new Size(92, 40);
            btnHistorialExamenes.TabIndex = 44;
            btnHistorialExamenes.Text = "Historial Examenes";
            btnHistorialExamenes.UseVisualStyleBackColor = true;
            btnHistorialExamenes.Click += btnHistorialExamenes_Click;
            // 
            // btnAsignarMaterias
            // 
            btnAsignarMaterias.Location = new Point(475, 280);
            btnAsignarMaterias.Name = "btnAsignarMaterias";
            btnAsignarMaterias.Size = new Size(92, 40);
            btnAsignarMaterias.TabIndex = 43;
            btnAsignarMaterias.Text = "Asignar Materias";
            btnAsignarMaterias.UseVisualStyleBackColor = true;
            btnAsignarMaterias.Click += btnAsignarMaterias_Click_1;
            // 
            // btnExamenesRendidos
            // 
            btnExamenesRendidos.Location = new Point(475, 380);
            btnExamenesRendidos.Name = "btnExamenesRendidos";
            btnExamenesRendidos.Size = new Size(92, 40);
            btnExamenesRendidos.TabIndex = 42;
            btnExamenesRendidos.Text = "Examenes Rendidos";
            btnExamenesRendidos.UseVisualStyleBackColor = true;
            btnExamenesRendidos.Click += btnExamenesRendidos_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = (Image)resources.GetObject("btnEliminar.BackgroundImage");
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(624, 261);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 69);
            btnEliminar.TabIndex = 41;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.BackgroundImage = (Image)resources.GetObject("btnModificar.BackgroundImage");
            btnModificar.BackgroundImageLayout = ImageLayout.Stretch;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(624, 176);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 69);
            btnModificar.TabIndex = 40;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackgroundImage = (Image)resources.GetObject("btnAgregar.BackgroundImage");
            btnAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(624, 92);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 66);
            btnAgregar.TabIndex = 39;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(300, 380);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 38;
            label1.Text = "Año :";
            // 
            // cmbAñoAlumno
            // 
            cmbAñoAlumno.FormattingEnabled = true;
            cmbAñoAlumno.Location = new Point(348, 378);
            cmbAñoAlumno.Name = "cmbAñoAlumno";
            cmbAñoAlumno.Size = new Size(47, 23);
            cmbAñoAlumno.TabIndex = 37;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(309, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F);
            label11.Location = new Point(74, 377);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 33;
            label11.Text = "Carrera :";
            // 
            // cmbCarrerasAlumnos
            // 
            cmbCarrerasAlumnos.FormattingEnabled = true;
            cmbCarrerasAlumnos.Location = new Point(149, 377);
            cmbCarrerasAlumnos.Name = "cmbCarrerasAlumnos";
            cmbCarrerasAlumnos.Size = new Size(145, 23);
            cmbCarrerasAlumnos.TabIndex = 32;
            cmbCarrerasAlumnos.SelectedIndexChanged += cmbCarrerasAlumnos_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F);
            label10.Location = new Point(3, 351);
            label10.Name = "label10";
            label10.Size = new Size(145, 20);
            label10.TabIndex = 31;
            label10.Text = "Fecha Nacimiento :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(87, 319);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 30;
            label9.Text = "Email :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(47, 290);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 29;
            label8.Text = "Documento :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(67, 261);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 28;
            label7.Text = "Telefono :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(74, 225);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 27;
            label6.Text = "Numero :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(25, 196);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 26;
            label5.Text = "Dirección Calle :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(73, 167);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 25;
            label4.Text = "Apellido :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.BottomLeft;
            label3.Location = new Point(73, 138);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 24;
            label3.Text = "Nombre :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpFechaNacimientoAlumno
            // 
            dtpFechaNacimientoAlumno.Location = new Point(151, 348);
            dtpFechaNacimientoAlumno.Name = "dtpFechaNacimientoAlumno";
            dtpFechaNacimientoAlumno.Size = new Size(244, 23);
            dtpFechaNacimientoAlumno.TabIndex = 22;
            // 
            // txtEmailAlumno
            // 
            txtEmailAlumno.Location = new Point(151, 319);
            txtEmailAlumno.Name = "txtEmailAlumno";
            txtEmailAlumno.Size = new Size(145, 23);
            txtEmailAlumno.TabIndex = 20;
            // 
            // txtDocumentoAlumno
            // 
            txtDocumentoAlumno.Location = new Point(151, 290);
            txtDocumentoAlumno.Name = "txtDocumentoAlumno";
            txtDocumentoAlumno.Size = new Size(123, 23);
            txtDocumentoAlumno.TabIndex = 19;
            // 
            // txtDireNumeroAlumno
            // 
            txtDireNumeroAlumno.Location = new Point(152, 225);
            txtDireNumeroAlumno.Name = "txtDireNumeroAlumno";
            txtDireNumeroAlumno.Size = new Size(100, 23);
            txtDireNumeroAlumno.TabIndex = 18;
            // 
            // txtTelefonoAlumno
            // 
            txtTelefonoAlumno.Location = new Point(151, 261);
            txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            txtTelefonoAlumno.Size = new Size(123, 23);
            txtTelefonoAlumno.TabIndex = 17;
            // 
            // txtDireCalleAlumno
            // 
            txtDireCalleAlumno.Location = new Point(152, 196);
            txtDireCalleAlumno.Name = "txtDireCalleAlumno";
            txtDireCalleAlumno.Size = new Size(123, 23);
            txtDireCalleAlumno.TabIndex = 16;
            // 
            // txtApellidoAlumno
            // 
            txtApellidoAlumno.Location = new Point(152, 167);
            txtApellidoAlumno.Name = "txtApellidoAlumno";
            txtApellidoAlumno.Size = new Size(123, 23);
            txtApellidoAlumno.TabIndex = 15;
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(152, 138);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(123, 23);
            txtNombreAlumno.TabIndex = 14;
            txtNombreAlumno.TextChanged += txtNombreAlumno_TextChanged_1;
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // FormAlumnosModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 450);
            Controls.Add(panel1);
            Name = "FormAlumnosModal";
            Text = "FormAlumnosModal";
            Load += FormAlumnosModal_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label11;
        private ComboBox cmbCarrerasAlumnos;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpFechaNacimientoAlumno;
        private TextBox txtEmailAlumno;
        private TextBox txtDocumentoAlumno;
        private TextBox txtDireNumeroAlumno;
        private TextBox txtTelefonoAlumno;
        private TextBox txtDireCalleAlumno;
        private TextBox txtApellidoAlumno;
        private TextBox txtNombreAlumno;
        private Panel panel2;
        private Label label2;
        private Button btnSalir;
        private ErrorProvider error1;
        private Label label1;
        private ComboBox cmbAñoAlumno;
        private Button btnHistorialExamenes;
        private Button btnAsignarMaterias;
        private Button btnExamenesRendidos;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label lblMatriculaAlumno;
        private Label lblMatricula;
    }
}