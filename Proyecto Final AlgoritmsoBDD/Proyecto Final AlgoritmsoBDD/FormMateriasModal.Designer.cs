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
            btnEliminarMateria = new Button();
            btnModificarMateria = new Button();
            btnAgregarMateria = new Button();
            panel2 = new Panel();
            label1 = new Label();
            btnSalir = new Button();
            panel3 = new Panel();
            cmbAñoCursada = new ComboBox();
            lblMateriaID = new Label();
            lblMateria = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            txtNombreMateria = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEliminarMateria);
            panel1.Controls.Add(btnModificarMateria);
            panel1.Controls.Add(btnAgregarMateria);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // btnEliminarMateria
            // 
            btnEliminarMateria.Location = new Point(668, 257);
            btnEliminarMateria.Name = "btnEliminarMateria";
            btnEliminarMateria.Size = new Size(75, 23);
            btnEliminarMateria.TabIndex = 48;
            btnEliminarMateria.Text = "Eliminar";
            btnEliminarMateria.UseVisualStyleBackColor = true;
            btnEliminarMateria.Click += btnEliminarMateria_Click;
            // 
            // btnModificarMateria
            // 
            btnModificarMateria.Location = new Point(668, 202);
            btnModificarMateria.Name = "btnModificarMateria";
            btnModificarMateria.Size = new Size(75, 23);
            btnModificarMateria.TabIndex = 47;
            btnModificarMateria.Text = "Modificar";
            btnModificarMateria.UseVisualStyleBackColor = true;
            btnModificarMateria.Click += btnModificarMateria_Click;
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.Location = new Point(668, 152);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(75, 23);
            btnAgregarMateria.TabIndex = 46;
            btnAgregarMateria.Text = "Agregar";
            btnAgregarMateria.UseVisualStyleBackColor = true;
            btnAgregarMateria.Click += btnAgregarMateria_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 94, 214);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 63);
            panel2.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Schadow BT", 25F);
            label1.Location = new Point(312, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 41);
            label1.TabIndex = 2;
            label1.Text = "Materias";
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Schadow BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(734, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(63, 57);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(cmbAñoCursada);
            panel3.Controls.Add(lblMateriaID);
            panel3.Controls.Add(lblMateria);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtNombreMateria);
            panel3.Location = new Point(78, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(499, 322);
            panel3.TabIndex = 7;
            // 
            // cmbAñoCursada
            // 
            cmbAñoCursada.FormattingEnabled = true;
            cmbAñoCursada.Location = new Point(152, 67);
            cmbAñoCursada.Name = "cmbAñoCursada";
            cmbAñoCursada.Size = new Size(123, 23);
            cmbAñoCursada.TabIndex = 37;
            // 
            // lblMateriaID
            // 
            lblMateriaID.AutoSize = true;
            lblMateriaID.Font = new Font("Schadow BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMateriaID.ImageAlign = ContentAlignment.BottomLeft;
            lblMateriaID.Location = new Point(152, 40);
            lblMateriaID.Name = "lblMateriaID";
            lblMateriaID.Size = new Size(0, 19);
            lblMateriaID.TabIndex = 36;
            lblMateriaID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Schadow BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMateria.ImageAlign = ContentAlignment.BottomLeft;
            lblMateria.Location = new Point(46, 40);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(89, 19);
            lblMateria.TabIndex = 35;
            lblMateria.Text = "ID Materia :";
            lblMateria.TextAlign = ContentAlignment.MiddleCenter;
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
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(152, 96);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(123, 23);
            txtNombreMateria.TabIndex = 15;
            // 
            // FormMateriasModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormMateriasModal";
            Text = "FormMateriasModal";
            Load += FormMateriasModal_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label lblMateria;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private TextBox txtNombreMateria;
        private Label lblMateriaID;
        private Panel panel2;
        private Label label1;
        private Button btnSalir;
        private Button btnEliminarMateria;
        private Button btnModificarMateria;
        private Button btnAgregarMateria;
        private ComboBox cmbAñoCursada;
    }
}