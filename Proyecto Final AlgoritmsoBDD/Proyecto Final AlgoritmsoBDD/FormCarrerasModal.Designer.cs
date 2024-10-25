namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class FormCarrerasModal
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
            btnEliminarCarreras = new Button();
            btnModificarCarreras = new Button();
            btnAgregarCarreras = new Button();
            panel3 = new Panel();
            lblIDCarrera = new Label();
            label6 = new Label();
            txtResolucion = new TextBox();
            label5 = new Label();
            txtCarrera = new TextBox();
            label4 = new Label();
            label3 = new Label();
            lblCarrera = new Label();
            cmbAño = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 73, 153);
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
            btnSalir.TabIndex = 44;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25F);
            label1.Location = new Point(326, 20);
            label1.Name = "label1";
            label1.Size = new Size(149, 39);
            label1.TabIndex = 1;
            label1.Text = "Carreras";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEliminarCarreras);
            panel2.Controls.Add(btnModificarCarreras);
            panel2.Controls.Add(btnAgregarCarreras);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 372);
            panel2.TabIndex = 1;
            // 
            // btnEliminarCarreras
            // 
            btnEliminarCarreras.Location = new Point(649, 192);
            btnEliminarCarreras.Name = "btnEliminarCarreras";
            btnEliminarCarreras.Size = new Size(75, 23);
            btnEliminarCarreras.TabIndex = 12;
            btnEliminarCarreras.Text = "Eliminar";
            btnEliminarCarreras.UseVisualStyleBackColor = true;
            btnEliminarCarreras.Click += btnEliminarCarreras_Click;
            // 
            // btnModificarCarreras
            // 
            btnModificarCarreras.Location = new Point(649, 137);
            btnModificarCarreras.Name = "btnModificarCarreras";
            btnModificarCarreras.Size = new Size(75, 23);
            btnModificarCarreras.TabIndex = 11;
            btnModificarCarreras.Text = "Modificar";
            btnModificarCarreras.UseVisualStyleBackColor = true;
            btnModificarCarreras.Click += btnModificarCarreras_Click;
            // 
            // btnAgregarCarreras
            // 
            btnAgregarCarreras.Location = new Point(649, 87);
            btnAgregarCarreras.Name = "btnAgregarCarreras";
            btnAgregarCarreras.Size = new Size(75, 23);
            btnAgregarCarreras.TabIndex = 10;
            btnAgregarCarreras.Text = "Agregar";
            btnAgregarCarreras.UseVisualStyleBackColor = true;
            btnAgregarCarreras.Click += btnAgregarCarreras_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbAño);
            panel3.Controls.Add(lblIDCarrera);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtResolucion);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtCarrera);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblCarrera);
            panel3.Location = new Point(102, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(439, 261);
            panel3.TabIndex = 0;
            // 
            // lblIDCarrera
            // 
            lblIDCarrera.AutoSize = true;
            lblIDCarrera.Font = new Font("Microsoft Sans Serif", 12F);
            lblIDCarrera.Location = new Point(151, 43);
            lblIDCarrera.Name = "lblIDCarrera";
            lblIDCarrera.Size = new Size(0, 20);
            lblIDCarrera.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(6, 123);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 6;
            label6.Text = "Año Plan Estudio :";
            // 
            // txtResolucion
            // 
            txtResolucion.Location = new Point(151, 95);
            txtResolucion.Name = "txtResolucion";
            txtResolucion.Size = new Size(142, 23);
            txtResolucion.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(49, 94);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 4;
            label5.Text = "Resolución :";
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(151, 66);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(142, 23);
            txtCarrera.TabIndex = 3;
            txtCarrera.TextChanged += txtCarrera_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(75, 65);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 2;
            label4.Text = "Carrera :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(108, 45);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 1;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Microsoft Sans Serif", 12F);
            lblCarrera.Location = new Point(54, 45);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(91, 20);
            lblCarrera.TabIndex = 0;
            lblCarrera.Text = "ID Carrera :";
            // 
            // cmbAño
            // 
            cmbAño.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAño.FormattingEnabled = true;
            cmbAño.Location = new Point(151, 124);
            cmbAño.Name = "cmbAño";
            cmbAño.Size = new Size(142, 23);
            cmbAño.TabIndex = 40;
            // 
            // FormCarrerasModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormCarrerasModal";
            Text = "FormCarrerasModal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnSalir;
        private Panel panel3;
        private Label lblCarrera;
        private Label label4;
        private Label label3;
        private Label label6;
        private TextBox txtResolucion;
        private Label label5;
        private TextBox txtCarrera;
        private Button btnEliminarCarreras;
        private Button btnModificarCarreras;
        private Button btnAgregarCarreras;
        private Label lblIDCarrera;
        private ComboBox cmbAño;
    }
}