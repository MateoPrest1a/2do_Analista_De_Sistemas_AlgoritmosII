namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class FormExamenesRendidos
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
            panel2 = new Panel();
            label2 = new Label();
            btnSalir = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnHistorial = new Button();
            label1 = new Label();
            panel3 = new Panel();
            btnBorrar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            txtCalificacion = new TextBox();
            label5 = new Label();
            txtIdExamen = new TextBox();
            label4 = new Label();
            txtAlumno = new TextBox();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 63, 96);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 69);
            panel2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 9);
            label2.Name = "label2";
            label2.Size = new Size(538, 55);
            label2.TabIndex = 1;
            label2.Text = "Examenes del Alumno ";
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(729, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(59, 44);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(288, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(512, 284);
            dataGridView1.TabIndex = 38;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 63, 96);
            panel1.Controls.Add(btnHistorial);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 381);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 69);
            panel1.TabIndex = 39;
            // 
            // btnHistorial
            // 
            btnHistorial.Location = new Point(713, 6);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(75, 55);
            btnHistorial.TabIndex = 8;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(41, 70);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 9;
            label1.Text = "Alumno :";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnBorrar);
            panel3.Controls.Add(btnModificar);
            panel3.Controls.Add(btnAgregar);
            panel3.Controls.Add(txtCalificacion);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtIdExamen);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtAlumno);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 312);
            panel3.TabIndex = 40;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(188, 222);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(71, 48);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(102, 222);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(71, 48);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(22, 222);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(63, 48);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Location = new Point(131, 143);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(100, 23);
            txtCalificacion.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(15, 148);
            label5.Name = "label5";
            label5.Size = new Size(92, 18);
            label5.TabIndex = 12;
            label5.Text = "Calificación :";
            // 
            // txtIdExamen
            // 
            txtIdExamen.Location = new Point(131, 105);
            txtIdExamen.Name = "txtIdExamen";
            txtIdExamen.ReadOnly = true;
            txtIdExamen.Size = new Size(100, 23);
            txtIdExamen.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(22, 105);
            label4.Name = "label4";
            label4.Size = new Size(85, 18);
            label4.TabIndex = 10;
            label4.Text = "Id Examen :";
            // 
            // txtAlumno
            // 
            txtAlumno.Location = new Point(131, 65);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.ReadOnly = true;
            txtAlumno.Size = new Size(100, 23);
            txtAlumno.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(295, 74);
            label3.Name = "label3";
            label3.Size = new Size(158, 18);
            label3.TabIndex = 11;
            label3.Text = "Listado de Examenes :";
            // 
            // FormExamenesRendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "FormExamenesRendidos";
            Text = "FormExamenesRendidos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Button btnSalir;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnHistorial;
        private Label label1;
        private Panel panel3;
        private TextBox txtAlumno;
        private Label label3;
        private TextBox txtIdExamen;
        private Label label4;
        private TextBox txtCalificacion;
        private Label label5;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
    }
}