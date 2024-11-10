namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class FormAgregarExamenAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarExamenAlumno));
            panel2 = new Panel();
            label1 = new Label();
            btnSalir = new Button();
            panel3 = new Panel();
            cmbTipoExamen = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtAlumno = new TextBox();
            label10 = new Label();
            dtpFechaExamenAlumno = new DateTimePicker();
            label2 = new Label();
            cmbCarreras = new ComboBox();
            cmbMateria = new ComboBox();
            lblMateriaID = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            txtCalificacion = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label1.Font = new Font("HelveticaNeueLT Std Med", 36F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(403, 56);
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
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(cmbTipoExamen);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtAlumno);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(dtpFechaExamenAlumno);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(cmbCarreras);
            panel3.Controls.Add(cmbMateria);
            panel3.Controls.Add(lblMateriaID);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtCalificacion);
            panel3.Location = new Point(68, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(499, 322);
            panel3.TabIndex = 42;
            // 
            // cmbTipoExamen
            // 
            cmbTipoExamen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoExamen.FormattingEnabled = true;
            cmbTipoExamen.Location = new Point(152, 183);
            cmbTipoExamen.Name = "cmbTipoExamen";
            cmbTipoExamen.Size = new Size(123, 23);
            cmbTipoExamen.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(36, 186);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 44;
            label6.Text = "Tipo Examen :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ImageAlign = ContentAlignment.BottomLeft;
            label5.Location = new Point(76, 38);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 43;
            label5.Text = "Alumno :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAlumno
            // 
            txtAlumno.Location = new Point(152, 38);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.ReadOnly = true;
            txtAlumno.Size = new Size(123, 23);
            txtAlumno.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F);
            label10.Location = new Point(21, 215);
            label10.Name = "label10";
            label10.Size = new Size(124, 20);
            label10.TabIndex = 41;
            label10.Text = "Fecha Examen :";
            // 
            // dtpFechaExamenAlumno
            // 
            dtpFechaExamenAlumno.Location = new Point(152, 212);
            dtpFechaExamenAlumno.Name = "dtpFechaExamenAlumno";
            dtpFechaExamenAlumno.Size = new Size(239, 23);
            dtpFechaExamenAlumno.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(76, 154);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 39;
            label2.Text = "Carrera :";
            // 
            // cmbCarreras
            // 
            cmbCarreras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarreras.FormattingEnabled = true;
            cmbCarreras.Location = new Point(152, 154);
            cmbCarreras.Name = "cmbCarreras";
            cmbCarreras.Size = new Size(123, 23);
            cmbCarreras.TabIndex = 38;
            // 
            // cmbMateria
            // 
            cmbMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(152, 96);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(123, 23);
            cmbMateria.TabIndex = 37;
            // 
            // lblMateriaID
            // 
            lblMateriaID.AutoSize = true;
            lblMateriaID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMateriaID.ImageAlign = ContentAlignment.BottomLeft;
            lblMateriaID.Location = new Point(152, 40);
            lblMateriaID.Name = "lblMateriaID";
            lblMateriaID.Size = new Size(0, 20);
            lblMateriaID.TabIndex = 36;
            lblMateriaID.TextAlign = ContentAlignment.MiddleCenter;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(48, 125);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 25;
            label4.Text = "Calificación :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.BottomLeft;
            label3.Location = new Point(76, 96);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 24;
            label3.Text = "Materia :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCalificacion
            // 
            txtCalificacion.Location = new Point(152, 125);
            txtCalificacion.Name = "txtCalificacion";
            txtCalificacion.Size = new Size(123, 23);
            txtCalificacion.TabIndex = 15;
            // 
            // FormAgregarExamenAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "FormAgregarExamenAlumno";
            Text = "FormAgregarExamenAlumno";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Button btnSalir;
        private Panel panel3;
        private Label label2;
        private ComboBox cmbCarreras;
        private ComboBox cmbMateria;
        private Label lblMateriaID;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private TextBox txtCalificacion;
        private Label label10;
        private DateTimePicker dtpFechaExamenAlumno;
        private Label label5;
        private TextBox txtAlumno;
        private ComboBox cmbTipoExamen;
        private Label label6;
    }
}