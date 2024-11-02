namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class FormExamenesRendidosModal
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
            panel3 = new Panel();
            lblIDExamen = new Label();
            label4 = new Label();
            cmbTipoExamen = new ComboBox();
            dtpFechaExamen = new DateTimePicker();
            label9 = new Label();
            lblAlumno = new Label();
            cmbIDMaterias = new ComboBox();
            cmbIDCarrera = new ComboBox();
            txtCalificacion = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(lblIDExamen);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(cmbTipoExamen);
            panel3.Controls.Add(dtpFechaExamen);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(lblAlumno);
            panel3.Controls.Add(cmbIDMaterias);
            panel3.Controls.Add(cmbIDCarrera);
            panel3.Controls.Add(txtCalificacion);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(79, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(448, 305);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // lblIDExamen
            // 
            lblIDExamen.AutoSize = true;
            lblIDExamen.Font = new Font("Microsoft Sans Serif", 12F);
            lblIDExamen.Location = new Point(147, 37);
            lblIDExamen.Name = "lblIDExamen";
            lblIDExamen.Size = new Size(0, 20);
            lblIDExamen.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(49, 37);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 26;
            label4.Text = "ID Examen:";
            // 
            // cmbTipoExamen
            // 
            cmbTipoExamen.FormattingEnabled = true;
            cmbTipoExamen.Location = new Point(147, 179);
            cmbTipoExamen.Name = "cmbTipoExamen";
            cmbTipoExamen.Size = new Size(129, 23);
            cmbTipoExamen.TabIndex = 25;
            // 
            // dtpFechaExamen
            // 
            dtpFechaExamen.Location = new Point(147, 150);
            dtpFechaExamen.Name = "dtpFechaExamen";
            dtpFechaExamen.Size = new Size(239, 23);
            dtpFechaExamen.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(17, 152);
            label9.Name = "label9";
            label9.Size = new Size(124, 20);
            label9.TabIndex = 23;
            label9.Text = "Fecha Examen :";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Microsoft Sans Serif", 12F);
            lblAlumno.Location = new Point(147, 57);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(0, 20);
            lblAlumno.TabIndex = 22;
            // 
            // cmbIDMaterias
            // 
            cmbIDMaterias.FormattingEnabled = true;
            cmbIDMaterias.Location = new Point(147, 120);
            cmbIDMaterias.Name = "cmbIDMaterias";
            cmbIDMaterias.Size = new Size(129, 23);
            cmbIDMaterias.TabIndex = 18;
            // 
            // cmbIDCarrera
            // 
            cmbIDCarrera.FormattingEnabled = true;
            cmbIDCarrera.Location = new Point(147, 87);
            cmbIDCarrera.Name = "cmbIDCarrera";
            cmbIDCarrera.Size = new Size(129, 23);
            cmbIDCarrera.TabIndex = 17;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Location = new Point(147, 213);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(129, 23);
            txtCalificacion.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(44, 212);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 12;
            label7.Text = "Calificación :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(32, 178);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 11;
            label5.Text = "Tipo Examen :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(71, 123);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 9;
            label3.Text = "Materia :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(71, 86);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 8;
            label2.Text = "Carrera :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(70, 57);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 7;
            label6.Text = "Alumno :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 72, 163);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSalir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 79);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25F);
            label1.Location = new Point(311, 20);
            label1.Name = "label1";
            label1.Size = new Size(178, 39);
            label1.TabIndex = 46;
            label1.Text = "Examenes";
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(725, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(63, 57);
            btnSalir.TabIndex = 45;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(675, 271);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(675, 216);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(675, 166);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormExamenesRendidosModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "FormExamenesRendidosModal";
            Text = "FormExamenesRendidosModal";
            Load += FormExamenesRendidosModal_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private ComboBox cmbTipoExamen;
        private DateTimePicker dtpFechaExamen;
        private Label label9;
        private Label lblAlumno;
        private TextBox txtExamenHora;
        private ComboBox cmbIDMaterias;
        private ComboBox cmbIDCarrera;
        private TextBox txtCalificacion;
        private TextBox txtFolio;
        private Label lblIDExamen;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Panel panel1;
        private Label label1;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
    }
}