namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class FormMateriasModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMateriasModal));
            panel1 = new Panel();
            panel3 = new Panel();
            txtMatriculaAlumno = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            txtApellidoAlumno = new TextBox();
            txtNombreAlumno = new TextBox();
            label2 = new Label();
            cmbProfesores = new ComboBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(cmbProfesores);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtMatriculaAlumno);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtApellidoAlumno);
            panel3.Controls.Add(txtNombreAlumno);
            panel3.Location = new Point(210, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(499, 322);
            panel3.TabIndex = 7;
            // 
            // txtMatriculaAlumno
            // 
            txtMatriculaAlumno.Location = new Point(152, 40);
            txtMatriculaAlumno.Name = "txtMatriculaAlumno";
            txtMatriculaAlumno.Size = new Size(123, 23);
            txtMatriculaAlumno.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Schadow BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(46, 40);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 35;
            label1.Text = "ID Materia :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            label4.Font = new Font("Schadow BT", 12F);
            label4.Location = new Point(8, 96);
            label4.Name = "label4";
            label4.Size = new Size(127, 19);
            label4.TabIndex = 25;
            label4.Text = "Nombre Materia :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Schadow BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.BottomLeft;
            label3.Location = new Point(29, 67);
            label3.Name = "label3";
            label3.Size = new Size(106, 19);
            label3.TabIndex = 24;
            label3.Text = "Año Cursada :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtApellidoAlumno
            // 
            txtApellidoAlumno.Location = new Point(152, 96);
            txtApellidoAlumno.Name = "txtApellidoAlumno";
            txtApellidoAlumno.Size = new Size(123, 23);
            txtApellidoAlumno.TabIndex = 15;
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Location = new Point(152, 67);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.Size = new Size(123, 23);
            txtNombreAlumno.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Schadow BT", 12F);
            label2.Location = new Point(60, 129);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 37;
            label2.Text = "Profesor :";
            // 
            // cmbProfesores
            // 
            cmbProfesores.FormattingEnabled = true;
            cmbProfesores.Location = new Point(152, 129);
            cmbProfesores.Name = "cmbProfesores";
            cmbProfesores.Size = new Size(121, 23);
            cmbProfesores.TabIndex = 38;
            cmbProfesores.SelectedIndexChanged += cmbProfesores_SelectedIndexChanged;
            // 
            // FormMateriasModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormMateriasModal";
            Text = "FormMateriasModal";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private TextBox txtMatriculaAlumno;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private TextBox txtApellidoAlumno;
        private TextBox txtNombreAlumno;
        private ComboBox cmbProfesores;
    }
}