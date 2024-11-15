namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class FormEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label12 = new Label();
            btnSalir = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            btnBuscar = new Button();
            txtDni = new TextBox();
            cmbCarrera = new ComboBox();
            cmbEspecialidad = new ComboBox();
            txtNombreApellido = new TextBox();
            cmbFiltros = new ComboBox();
            label2 = new Label();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 328);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 63, 96);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(btnSalir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 63);
            panel1.TabIndex = 36;
            panel1.Paint += panel1_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(0, 4);
            label12.Name = "label12";
            label12.Size = new Size(274, 55);
            label12.TabIndex = 2;
            label12.Text = "Empleados";
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
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 387);
            panel2.TabIndex = 37;
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
            panel4.Location = new Point(0, 326);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 61);
            panel4.TabIndex = 40;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(366, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(70, 23);
            btnBuscar.TabIndex = 46;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
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
            cmbFiltros.SelectedIndexChanged += cmbFiltros_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
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
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profesores";
            Load += FormEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Button btnSalir;
        private Label label12;
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