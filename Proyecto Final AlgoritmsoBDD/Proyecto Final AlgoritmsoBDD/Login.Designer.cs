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
            checkBox1 = new CheckBox();
            btnAcceder = new Button();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(btnAcceder);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(47, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 322);
            panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(103, 254);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(130, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Mostrar Contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(64, 55, 223);
            btnAcceder.Font = new Font("Microsoft Sans Serif", 12F);
            btnAcceder.ForeColor = SystemColors.ButtonHighlight;
            btnAcceder.Location = new Point(103, 279);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(248, 34);
            btnAcceder.TabIndex = 4;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 15F);
            txtContraseña.Location = new Point(103, 205);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = " Contraseña";
            txtContraseña.Size = new Size(248, 34);
            txtContraseña.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 15F);
            txtUsuario.Location = new Point(103, 144);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = " Usuario";
            txtUsuario.Size = new Size(248, 34);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(103, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 431);
            Controls.Add(panel1);
            MaximumSize = new Size(567, 470);
            MinimumSize = new Size(567, 470);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}
