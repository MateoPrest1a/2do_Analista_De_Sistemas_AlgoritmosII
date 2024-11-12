namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class FormExamenes
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
            panel1 = new Panel();
            btnSalir = new Button();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            btnBuscar = new Button();
            txtDni = new TextBox();
            cmbCarrera = new ComboBox();
            cmbEspecialidad = new ComboBox();
            txtNombreApellido = new TextBox();
            cmbFiltros = new ComboBox();
            label2 = new Label();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 63, 96);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 78);
            panel1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HelveticaNeueLT Std Med", 36F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 56);
            label1.TabIndex = 1;
            label1.Text = "Examenes";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 372);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 313);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(33, 63, 96);
            panel4.Controls.Add(btnBuscar);
            panel4.Controls.Add(txtDni);
            panel4.Controls.Add(cmbCarrera);
            panel4.Controls.Add(cmbEspecialidad);
            panel4.Controls.Add(txtNombreApellido);
            panel4.Controls.Add(cmbFiltros);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 311);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 61);
            panel4.TabIndex = 41;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(366, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(70, 23);
            btnBuscar.TabIndex = 46;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(233, 20);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(127, 23);
            txtDni.TabIndex = 45;
            // 
            // cmbCarrera
            // 
            cmbCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(233, 20);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(121, 23);
            cmbCarrera.TabIndex = 44;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(233, 20);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(121, 23);
            cmbEspecialidad.TabIndex = 43;
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(233, 20);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(127, 23);
            txtNombreApellido.TabIndex = 42;
            // 
            // cmbFiltros
            // 
            cmbFiltros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltros.FormattingEnabled = true;
            cmbFiltros.Location = new Point(97, 20);
            cmbFiltros.Name = "cmbFiltros";
            cmbFiltros.Size = new Size(121, 23);
            cmbFiltros.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Unicode MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 40;
            label2.Text = "Filtrar por :";
            // 
            // panel5
            // 
            panel5.Location = new Point(3, 84);
            panel5.Name = "panel5";
            panel5.Size = new Size(797, 59);
            panel5.TabIndex = 39;
            // 
            // FormExamenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormExamenes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormExamenes";
            Load += FormExamenes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnSalir;
        private DataGridView dataGridView1;
        private Panel panel4;
        private Button btnBuscar;
        private TextBox txtDni;
        private ComboBox cmbCarrera;
        private ComboBox cmbEspecialidad;
        private TextBox txtNombreApellido;
        private ComboBox cmbFiltros;
        private Label label2;
        private Panel panel5;
    }
}