namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class PaginaPrincipal
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
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            btnCarreras = new Button();
            btnMaterias = new Button();
            btnAdministrativo = new Button();
            btnProfesores = new Button();
            btnAlumnos = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 65);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Schadow BT", 20F);
            label2.Location = new Point(176, 18);
            label2.Name = "label2";
            label2.Size = new Size(183, 32);
            label2.TabIndex = 1;
            label2.Text = "Administrador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Schadow BT", 20F);
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(148, 32);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido:";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnCarreras);
            panel2.Controls.Add(btnMaterias);
            panel2.Controls.Add(btnAdministrativo);
            panel2.Controls.Add(btnProfesores);
            panel2.Controls.Add(btnAlumnos);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(679, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(121, 385);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 3);
            label3.Name = "label3";
            label3.Size = new Size(88, 30);
            label3.TabIndex = 7;
            label3.Text = "  Altas, Bajas y \r\nModificaciones";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Schadow BT", 9F);
            button2.Location = new Point(14, 330);
            button2.Name = "button2";
            button2.Size = new Size(95, 43);
            button2.TabIndex = 6;
            button2.Text = "Permisos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Schadow BT", 9F);
            button1.Location = new Point(14, 281);
            button1.Name = "button1";
            button1.Size = new Size(95, 43);
            button1.TabIndex = 5;
            button1.Text = "Examenes";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCarreras
            // 
            btnCarreras.FlatStyle = FlatStyle.Popup;
            btnCarreras.Font = new Font("Schadow BT", 9F);
            btnCarreras.Location = new Point(14, 232);
            btnCarreras.Name = "btnCarreras";
            btnCarreras.Size = new Size(95, 43);
            btnCarreras.TabIndex = 4;
            btnCarreras.Text = "Carreras";
            btnCarreras.UseVisualStyleBackColor = true;
            // 
            // btnMaterias
            // 
            btnMaterias.FlatStyle = FlatStyle.Popup;
            btnMaterias.Font = new Font("Schadow BT", 9F);
            btnMaterias.Location = new Point(14, 183);
            btnMaterias.Name = "btnMaterias";
            btnMaterias.Size = new Size(95, 43);
            btnMaterias.TabIndex = 3;
            btnMaterias.Text = "Materias";
            btnMaterias.UseVisualStyleBackColor = true;
            btnMaterias.Click += btnMaterias_Click;
            // 
            // btnAdministrativo
            // 
            btnAdministrativo.FlatStyle = FlatStyle.Popup;
            btnAdministrativo.Font = new Font("Schadow BT", 9F);
            btnAdministrativo.Location = new Point(14, 134);
            btnAdministrativo.Name = "btnAdministrativo";
            btnAdministrativo.Size = new Size(95, 43);
            btnAdministrativo.TabIndex = 2;
            btnAdministrativo.Text = "Administrativo";
            btnAdministrativo.UseVisualStyleBackColor = true;
            // 
            // btnProfesores
            // 
            btnProfesores.FlatStyle = FlatStyle.Popup;
            btnProfesores.Font = new Font("Schadow BT", 9F);
            btnProfesores.Location = new Point(14, 85);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new Size(95, 43);
            btnProfesores.TabIndex = 1;
            btnProfesores.Text = "Profesores";
            btnProfesores.UseVisualStyleBackColor = true;
            btnProfesores.Click += btnProfesores_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.FlatStyle = FlatStyle.Popup;
            btnAlumnos.Font = new Font("Schadow BT", 9F);
            btnAlumnos.Location = new Point(14, 36);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(95, 43);
            btnAlumnos.TabIndex = 0;
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PaginaPrincipal";
            Text = "PaginaPrincipal";
            Load += PaginaPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btnProfesores;
        private Button btnAlumnos;
        private Button btnCarreras;
        private Button btnMaterias;
        private Button btnAdministrativo;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}