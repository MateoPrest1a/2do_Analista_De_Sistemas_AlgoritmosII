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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumnosModal));
            panel1 = new Panel();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            panel3 = new Panel();
            lblMatriculaAlumno = new Label();
            label1 = new Label();
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
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(622, 203);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(622, 148);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(622, 98);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(lblMatriculaAlumno);
            panel3.Controls.Add(label1);
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
            panel3.Location = new Point(21, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(499, 322);
            panel3.TabIndex = 6;
            // 
            // lblMatriculaAlumno
            // 
            lblMatriculaAlumno.AutoSize = true;
            lblMatriculaAlumno.Font = new Font("Schadow BT", 12F);
            lblMatriculaAlumno.Location = new Point(152, 40);
            lblMatriculaAlumno.Name = "lblMatriculaAlumno";
            lblMatriculaAlumno.Size = new Size(0, 19);
            lblMatriculaAlumno.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Schadow BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(62, 40);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 35;
            label1.Text = "Matricula :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(373, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Schadow BT", 12F);
            label11.Location = new Point(75, 270);
            label11.Name = "label11";
            label11.Size = new Size(69, 19);
            label11.TabIndex = 33;
            label11.Text = "Carrera :";
            // 
            // cmbCarrerasAlumnos
            // 
            cmbCarrerasAlumnos.FormattingEnabled = true;
            cmbCarrerasAlumnos.Location = new Point(150, 270);
            cmbCarrerasAlumnos.Name = "cmbCarrerasAlumnos";
            cmbCarrerasAlumnos.Size = new Size(145, 23);
            cmbCarrerasAlumnos.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Schadow BT", 12F);
            label10.Location = new Point(4, 244);
            label10.Name = "label10";
            label10.Size = new Size(140, 19);
            label10.TabIndex = 31;
            label10.Text = "Fecha Nacimiento :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Schadow BT", 12F);
            label9.Location = new Point(88, 212);
            label9.Name = "label9";
            label9.Size = new Size(56, 19);
            label9.TabIndex = 30;
            label9.Text = "Email :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Schadow BT", 12F);
            label8.Location = new Point(48, 183);
            label8.Name = "label8";
            label8.Size = new Size(96, 19);
            label8.TabIndex = 29;
            label8.Text = "Documento :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Schadow BT", 12F);
            label7.Location = new Point(68, 154);
            label7.Name = "label7";
            label7.Size = new Size(76, 19);
            label7.TabIndex = 28;
            label7.Text = "Telefono :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Schadow BT", 12F);
            label6.Location = new Point(281, 125);
            label6.Name = "label6";
            label6.Size = new Size(72, 19);
            label6.TabIndex = 27;
            label6.Text = "Numero :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Schadow BT", 12F);
            label5.Location = new Point(25, 125);
            label5.Name = "label5";
            label5.Size = new Size(121, 19);
            label5.TabIndex = 26;
            label5.Text = "Dirección Calle :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Schadow BT", 12F);
            label4.Location = new Point(73, 96);
            label4.Name = "label4";
            label4.Size = new Size(73, 19);
            label4.TabIndex = 25;
            label4.Text = "Apellido :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Schadow BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.BottomLeft;
            label3.Location = new Point(73, 67);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 24;
            label3.Text = "Nombre :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpFechaNacimientoAlumno
            // 
            dtpFechaNacimientoAlumno.Location = new Point(152, 241);
            dtpFechaNacimientoAlumno.Name = "dtpFechaNacimientoAlumno";
            dtpFechaNacimientoAlumno.Size = new Size(239, 23);
            dtpFechaNacimientoAlumno.TabIndex = 22;
            // 
            // txtEmailAlumno
            // 
            txtEmailAlumno.Location = new Point(152, 212);
            txtEmailAlumno.Name = "txtEmailAlumno";
            txtEmailAlumno.Size = new Size(145, 23);
            txtEmailAlumno.TabIndex = 20;
            // 
            // txtDocumentoAlumno
            // 
            txtDocumentoAlumno.Location = new Point(152, 183);
            txtDocumentoAlumno.Name = "txtDocumentoAlumno";
            txtDocumentoAlumno.Size = new Size(123, 23);
            txtDocumentoAlumno.TabIndex = 19;
            // 
            // txtDireNumeroAlumno
            // 
            txtDireNumeroAlumno.Location = new Point(359, 125);
            txtDireNumeroAlumno.Name = "txtDireNumeroAlumno";
            txtDireNumeroAlumno.Size = new Size(100, 23);
            txtDireNumeroAlumno.TabIndex = 18;
            // 
            // txtTelefonoAlumno
            // 
            txtTelefonoAlumno.Location = new Point(152, 154);
            txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            txtTelefonoAlumno.Size = new Size(123, 23);
            txtTelefonoAlumno.TabIndex = 17;
            // 
            // txtDireCalleAlumno
            // 
            txtDireCalleAlumno.Location = new Point(152, 125);
            txtDireCalleAlumno.Name = "txtDireCalleAlumno";
            txtDireCalleAlumno.Size = new Size(123, 23);
            txtDireCalleAlumno.TabIndex = 16;
            // 
            // txtApellidoAlumno
            // 
            txtApellidoAlumno.Location = new Point(152, 96);
            txtApellidoAlumno.Name = "txtApellidoAlumno";
            txtApellidoAlumno.Size = new Size(123, 23);
            txtApellidoAlumno.TabIndex = 15;
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(152, 67);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(123, 23);
            txtNombreAlumno.TabIndex = 14;
            txtNombreAlumno.TextChanged += txtNombreAlumno_TextChanged_1;
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Panel panel3;
        private Label label1;
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
        private Label lblMatriculaAlumno;
    }
}