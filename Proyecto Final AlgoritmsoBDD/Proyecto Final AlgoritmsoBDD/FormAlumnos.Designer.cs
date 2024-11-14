namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class FormAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumnos));
            errorProvider1 = new ErrorProvider(components);
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            btnSalir = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            btnBuscar = new Button();
            txtDni = new TextBox();
            cmbCarrera = new ComboBox();
            cmbAño = new ComboBox();
            txtNombreApellido = new TextBox();
            cmbFiltros = new ComboBox();
            label2 = new Label();
            panel5 = new Panel();
            btnRecargarTabla = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 323);
            dataGridView1.TabIndex = 37;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
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
            panel2.TabIndex = 38;
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
            label1.Click += label1_Click;
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
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 450);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(33, 63, 96);
            panel4.Controls.Add(btnRecargarTabla);
            panel4.Controls.Add(btnBuscar);
            panel4.Controls.Add(txtDni);
            panel4.Controls.Add(cmbCarrera);
            panel4.Controls.Add(cmbAño);
            panel4.Controls.Add(txtNombreApellido);
            panel4.Controls.Add(cmbFiltros);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 389);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 61);
            panel4.TabIndex = 39;
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
            // cmbAño
            // 
            cmbAño.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAño.FormattingEnabled = true;
            cmbAño.Location = new Point(233, 20);
            cmbAño.Name = "cmbAño";
            cmbAño.Size = new Size(121, 23);
            cmbAño.TabIndex = 43;
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
            // btnRecargarTabla
            // 
            btnRecargarTabla.Location = new Point(744, 12);
            btnRecargarTabla.Name = "btnRecargarTabla";
            btnRecargarTabla.Size = new Size(44, 38);
            btnRecargarTabla.TabIndex = 47;
            btnRecargarTabla.Text = "Refrescar";
            btnRecargarTabla.UseVisualStyleBackColor = true;
            btnRecargarTabla.Click += btnRecargarTabla_Click;
            // 
            // FormAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "FormAlumnos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alumnos";
            Load += FormAlumnos_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Button btnSalir;
        private DataGridView dataGridView1;
        private Panel panel4;
        private ComboBox cmbFiltros;
        private Label label2;
        private Panel panel5;
        private TextBox txtNombreApellido;
        private ComboBox cmbAño;
        private ComboBox cmbCarrera;
        private TextBox txtDni;
        private Button btnBuscar;
        private Button btnRecargarTabla;
    }
}