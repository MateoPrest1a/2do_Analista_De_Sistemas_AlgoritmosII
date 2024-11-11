namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class FormExamenesRendidos
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
            panel2 = new Panel();
            label2 = new Label();
            btnSalir = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            btnAgregar = new Button();
            panel3 = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 63, 96);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 69);
            panel2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("HelveticaNeueLT Std Med", 36F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 9);
            label2.Name = "label2";
            label2.Size = new Size(559, 56);
            label2.TabIndex = 1;
            label2.Text = "Examenes del Alumno ";
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(729, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(59, 44);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(288, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(512, 284);
            dataGridView1.TabIndex = 38;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 63, 96);
            panel1.Controls.Add(btnAgregar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 381);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 69);
            panel1.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Unicode MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 9;
            label1.Text = "Alumno :";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(713, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 55);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Historial";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 312);
            panel3.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Arial Unicode MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(295, 74);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 11;
            label3.Text = "Listado de Examenes :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 27);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // FormExamenesRendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "FormExamenesRendidos";
            Text = "FormExamenesRendidos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Button btnSalir;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnAgregar;
        private Label label1;
        private Panel panel3;
        private TextBox textBox1;
        private Label label3;
    }
}