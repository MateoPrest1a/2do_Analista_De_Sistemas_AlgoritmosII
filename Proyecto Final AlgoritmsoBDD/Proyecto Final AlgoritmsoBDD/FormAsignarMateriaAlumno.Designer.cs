namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class FormAsignarMateriaAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsignarMateriaAlumno));
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            btnSalir = new Button();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            cmbEstado = new ComboBox();
            btnAgregar = new Button();
            label5 = new Label();
            txtIdMateria = new TextBox();
            label4 = new Label();
            txtAlumno = new TextBox();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 63, 96);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 73);
            panel2.TabIndex = 39;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 59);
            panel1.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 55);
            label1.TabIndex = 1;
            label1.Text = "Alumnos";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(729, 17);
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
            dataGridView1.Location = new Point(288, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(512, 284);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(33, 63, 96);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 381);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 69);
            panel3.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(288, 79);
            label3.Name = "label3";
            label3.Size = new Size(145, 18);
            label3.TabIndex = 42;
            label3.Text = "Listado de Materias :";
            // 
            // panel4
            // 
            panel4.Controls.Add(cmbEstado);
            panel4.Controls.Add(btnAgregar);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(txtIdMateria);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtAlumno);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 73);
            panel4.Name = "panel4";
            panel4.Size = new Size(289, 308);
            panel4.TabIndex = 43;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(131, 143);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(100, 23);
            cmbEstado.TabIndex = 16;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(168, 214);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(63, 48);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(39, 148);
            label5.Name = "label5";
            label5.Size = new Size(63, 18);
            label5.TabIndex = 12;
            label5.Text = "Estado :";
            // 
            // txtIdMateria
            // 
            txtIdMateria.Location = new Point(131, 105);
            txtIdMateria.Name = "txtIdMateria";
            txtIdMateria.ReadOnly = true;
            txtIdMateria.Size = new Size(100, 23);
            txtIdMateria.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(22, 105);
            label4.Name = "label4";
            label4.Size = new Size(80, 18);
            label4.TabIndex = 10;
            label4.Text = "Id Materia :";
            // 
            // txtAlumno
            // 
            txtAlumno.Location = new Point(131, 65);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.ReadOnly = true;
            txtAlumno.Size = new Size(100, 23);
            txtAlumno.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(41, 70);
            label2.Name = "label2";
            label2.Size = new Size(66, 18);
            label2.TabIndex = 9;
            label2.Text = "Alumno :";
            // 
            // FormAsignarMateriaAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "FormAsignarMateriaAlumno";
            Text = "FormAsignarMateriaAlumno";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Button btnSalir;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private ComboBox cmbEstado;
        private Button btnAgregar;
        private Label label5;
        private TextBox txtIdMateria;
        private Label label4;
        private TextBox txtAlumno;
        private Label label2;
    }
}