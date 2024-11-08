namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class FormExamenesModal
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
            panel1 = new Panel();
            label1 = new Label();
            btnSalir = new Button();
            panel2 = new Panel();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            panel3 = new Panel();
            cmbTipoExamen = new ComboBox();
            dtpFechaExamen = new DateTimePicker();
            label9 = new Label();
            lblIDExamen = new Label();
            txtExamenHora = new TextBox();
            cmbIDMaterias = new ComboBox();
            cmbIDCarrera = new ComboBox();
            txtLibro = new TextBox();
            txtFolio = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblExamenID = new Label();
            error1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 0;
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
            // panel2
            // 
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 371);
            panel2.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(643, 216);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(643, 161);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(643, 111);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbTipoExamen);
            panel3.Controls.Add(dtpFechaExamen);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(lblIDExamen);
            panel3.Controls.Add(txtExamenHora);
            panel3.Controls.Add(cmbIDMaterias);
            panel3.Controls.Add(cmbIDCarrera);
            panel3.Controls.Add(txtLibro);
            panel3.Controls.Add(txtFolio);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblExamenID);
            panel3.Location = new Point(112, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(448, 305);
            panel3.TabIndex = 0;
            // 
            // cmbTipoExamen
            // 
            cmbTipoExamen.FormattingEnabled = true;
            cmbTipoExamen.Location = new Point(147, 191);
            cmbTipoExamen.Name = "cmbTipoExamen";
            cmbTipoExamen.Size = new Size(129, 23);
            cmbTipoExamen.TabIndex = 25;
            // 
            // dtpFechaExamen
            // 
            dtpFechaExamen.Location = new Point(147, 162);
            dtpFechaExamen.Name = "dtpFechaExamen";
            dtpFechaExamen.Size = new Size(239, 23);
            dtpFechaExamen.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(15, 164);
            label9.Name = "label9";
            label9.Size = new Size(124, 20);
            label9.TabIndex = 23;
            label9.Text = "Fecha Examen :";
            // 
            // lblIDExamen
            // 
            lblIDExamen.AutoSize = true;
            lblIDExamen.Font = new Font("Microsoft Sans Serif", 12F);
            lblIDExamen.Location = new Point(147, 34);
            lblIDExamen.Name = "lblIDExamen";
            lblIDExamen.Size = new Size(0, 20);
            lblIDExamen.TabIndex = 22;
            // 
            // txtExamenHora
            // 
            txtExamenHora.Location = new Point(147, 129);
            txtExamenHora.Name = "txtExamenHora";
            txtExamenHora.Size = new Size(129, 23);
            txtExamenHora.TabIndex = 19;
            txtExamenHora.TextChanged += txtExamenHora_TextChanged;
            txtExamenHora.KeyPress += txtExamenHora_KeyPress;
            // 
            // cmbIDMaterias
            // 
            cmbIDMaterias.FormattingEnabled = true;
            cmbIDMaterias.Location = new Point(147, 97);
            cmbIDMaterias.Name = "cmbIDMaterias";
            cmbIDMaterias.Size = new Size(129, 23);
            cmbIDMaterias.TabIndex = 18;
            // 
            // cmbIDCarrera
            // 
            cmbIDCarrera.FormattingEnabled = true;
            cmbIDCarrera.Location = new Point(147, 65);
            cmbIDCarrera.Name = "cmbIDCarrera";
            cmbIDCarrera.Size = new Size(129, 23);
            cmbIDCarrera.TabIndex = 17;
            cmbIDCarrera.SelectedIndexChanged += cmbIDCarrera_SelectedIndexChanged_1;
            // 
            // txtLibro
            // 
            txtLibro.Location = new Point(147, 225);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(129, 23);
            txtLibro.TabIndex = 15;
            // 
            // txtFolio
            // 
            txtFolio.Location = new Point(147, 255);
            txtFolio.Name = "txtFolio";
            txtFolio.Size = new Size(129, 23);
            txtFolio.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(90, 254);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 13;
            label8.Text = "Folio :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(89, 224);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 12;
            label7.Text = "Libro :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(32, 194);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 11;
            label5.Text = "Tipo Examen :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(27, 128);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 10;
            label4.Text = "Hora Examen :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(71, 96);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 9;
            label3.Text = "Materia :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(71, 63);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 8;
            label2.Text = "Carrera :";
            // 
            // lblExamenID
            // 
            lblExamenID.AutoSize = true;
            lblExamenID.Font = new Font("Microsoft Sans Serif", 12F);
            lblExamenID.Location = new Point(45, 34);
            lblExamenID.Name = "lblExamenID";
            lblExamenID.Size = new Size(96, 20);
            lblExamenID.TabIndex = 7;
            lblExamenID.Text = "ID Examen :";
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // FormExamenesModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormExamenesModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormExamenesModal";
            Load += FormExamenesModal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSalir;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblExamenID;
        private Label label8;
        private Label label7;
        private Label label5;
        private ComboBox cmbIDMaterias;
        private ComboBox cmbIDCarrera;
        private TextBox txtLibro;
        private TextBox txtFolio;
        private TextBox txtExamenHora;
        private Label lblIDExamen;
        private Label label9;
        private DateTimePicker dtpFechaExamen;
        private ComboBox cmbTipoExamen;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private ErrorProvider error1;
    }
}