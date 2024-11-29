namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class FormHistorialExamenAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistorialExamenAlumno));
            panel2 = new Panel();
            label1 = new Label();
            btnSalir = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnReporteAlumnoExamenes = new Button();
            label5 = new Label();
            btnRecargarTablaAlumnos = new Button();
            cmbMateriasExamenAlumno = new ComboBox();
            btnFiltrarExamenxAlumno = new Button();
            cmbFiltrosExamenxAlumno = new ComboBox();
            label2 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 63, 96);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 63);
            panel2.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(390, 55);
            label1.TabIndex = 2;
            label1.Text = "Examen Alumno";
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(734, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(63, 57);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 387);
            panel3.TabIndex = 42;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 318);
            dataGridView1.TabIndex = 49;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 63, 96);
            panel1.Controls.Add(btnReporteAlumnoExamenes);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnRecargarTablaAlumnos);
            panel1.Controls.Add(cmbMateriasExamenAlumno);
            panel1.Controls.Add(btnFiltrarExamenxAlumno);
            panel1.Controls.Add(cmbFiltrosExamenxAlumno);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 318);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 69);
            panel1.TabIndex = 48;
            // 
            // btnReporteAlumnoExamenes
            // 
            btnReporteAlumnoExamenes.FlatAppearance.BorderSize = 0;
            btnReporteAlumnoExamenes.FlatStyle = FlatStyle.System;
            btnReporteAlumnoExamenes.Location = new Point(586, 14);
            btnReporteAlumnoExamenes.Name = "btnReporteAlumnoExamenes";
            btnReporteAlumnoExamenes.Size = new Size(97, 40);
            btnReporteAlumnoExamenes.TabIndex = 55;
            btnReporteAlumnoExamenes.Text = "Generar Reporte";
            btnReporteAlumnoExamenes.UseVisualStyleBackColor = true;
            btnReporteAlumnoExamenes.Click += btnReporteAlumnoExamenes_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(700, 49);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 54;
            label5.Text = "Recargar Tabla";
            // 
            // btnRecargarTablaAlumnos
            // 
            btnRecargarTablaAlumnos.BackgroundImage = (Image)resources.GetObject("btnRecargarTablaAlumnos.BackgroundImage");
            btnRecargarTablaAlumnos.BackgroundImageLayout = ImageLayout.Stretch;
            btnRecargarTablaAlumnos.FlatAppearance.BorderSize = 0;
            btnRecargarTablaAlumnos.FlatStyle = FlatStyle.Flat;
            btnRecargarTablaAlumnos.Location = new Point(721, 10);
            btnRecargarTablaAlumnos.Name = "btnRecargarTablaAlumnos";
            btnRecargarTablaAlumnos.Size = new Size(40, 38);
            btnRecargarTablaAlumnos.TabIndex = 53;
            btnRecargarTablaAlumnos.UseVisualStyleBackColor = true;
            btnRecargarTablaAlumnos.Click += btnRecargarTablaAlumnos_Click;
            // 
            // cmbMateriasExamenAlumno
            // 
            cmbMateriasExamenAlumno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateriasExamenAlumno.FormattingEnabled = true;
            cmbMateriasExamenAlumno.Location = new Point(230, 24);
            cmbMateriasExamenAlumno.Name = "cmbMateriasExamenAlumno";
            cmbMateriasExamenAlumno.Size = new Size(121, 23);
            cmbMateriasExamenAlumno.TabIndex = 52;
            // 
            // btnFiltrarExamenxAlumno
            // 
            btnFiltrarExamenxAlumno.Location = new Point(367, 25);
            btnFiltrarExamenxAlumno.Name = "btnFiltrarExamenxAlumno";
            btnFiltrarExamenxAlumno.Size = new Size(70, 23);
            btnFiltrarExamenxAlumno.TabIndex = 51;
            btnFiltrarExamenxAlumno.Text = "Buscar";
            btnFiltrarExamenxAlumno.UseVisualStyleBackColor = true;
            btnFiltrarExamenxAlumno.Click += btnFiltrarExamenxAlumno_Click;
            // 
            // cmbFiltrosExamenxAlumno
            // 
            cmbFiltrosExamenxAlumno.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltrosExamenxAlumno.FormattingEnabled = true;
            cmbFiltrosExamenxAlumno.Location = new Point(103, 25);
            cmbFiltrosExamenxAlumno.Name = "cmbFiltrosExamenxAlumno";
            cmbFiltrosExamenxAlumno.Size = new Size(121, 23);
            cmbFiltrosExamenxAlumno.TabIndex = 49;
            cmbFiltrosExamenxAlumno.SelectedIndexChanged += cmbFiltrosExamenxAlumno_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(18, 24);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 48;
            label2.Text = "Filtrar por :";
            // 
            // FormHistorialExamenAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "FormHistorialExamenAlumno";
            Text = "Historial Examenes";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Button btnSalir;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private ComboBox cmbMateriasExamenAlumno;
        private Button btnFiltrarExamenxAlumno;
        private ComboBox cmbFiltrosExamenxAlumno;
        private Label label2;
        private Label label5;
        private Button btnRecargarTablaAlumnos;
        private Button btnReporteAlumnoExamenes;
    }
}