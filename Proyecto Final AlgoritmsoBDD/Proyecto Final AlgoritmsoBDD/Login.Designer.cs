namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            panel2 = new Panel();
            txtUsuario = new TextBox();
            checkBox1 = new CheckBox();
            txtContraseña = new TextBox();
            btnAcceder = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 432);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(txtContraseña);
            panel2.Controls.Add(btnAcceder);
            panel2.Location = new Point(249, 190);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 181);
            panel2.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("HoloLens MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = SystemColors.WindowText;
            txtUsuario.Location = new Point(47, 14);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = " Usuario";
            txtUsuario.Size = new Size(248, 27);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ImageAlign = ContentAlignment.TopLeft;
            checkBox1.Location = new Point(47, 94);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(143, 20);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Mostrar Contraseña";
            checkBox1.TextAlign = ContentAlignment.TopLeft;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("HoloLens MDL2 Assets", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(47, 61);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = " Contraseña";
            txtContraseña.Size = new Size(248, 27);
            txtContraseña.TabIndex = 2;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(64, 55, 223);
            btnAcceder.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = SystemColors.ButtonHighlight;
            btnAcceder.Location = new Point(12, 131);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(283, 34);
            btnAcceder.TabIndex = 4;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(185, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(508, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 432);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Button btnAcceder;
        private CheckBox checkBox1;
        private Panel panel2;
    }
}
