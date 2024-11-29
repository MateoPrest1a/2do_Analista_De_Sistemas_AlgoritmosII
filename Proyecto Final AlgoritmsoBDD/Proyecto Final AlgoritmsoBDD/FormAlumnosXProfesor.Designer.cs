namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class FormAlumnosXProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumnosXProfesor));
            panel2 = new Panel();
            label1 = new Label();
            btnSalir = new Button();
            panel3 = new Panel();
            btnRecargar = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            label3 = new Label();
            panel6 = new Panel();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel2.Size = new Size(800, 73);
            panel2.TabIndex = 39;
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
            panel3.BackColor = Color.FromArgb(33, 63, 96);
            panel3.Controls.Add(btnRecargar);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(comboBox3);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel6);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 394);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 56);
            panel3.TabIndex = 41;
            // 
            // btnRecargar
            // 
            btnRecargar.Location = new Point(722, 15);
            btnRecargar.Name = "btnRecargar";
            btnRecargar.Size = new Size(66, 30);
            btnRecargar.TabIndex = 47;
            btnRecargar.Text = "Recargar";
            btnRecargar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(366, 20);
            button2.Name = "button2";
            button2.Size = new Size(70, 23);
            button2.TabIndex = 46;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 45;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(233, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 44;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(233, 20);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 43;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(233, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 23);
            textBox2.TabIndex = 42;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(97, 20);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 19);
            label3.Name = "label3";
            label3.Size = new Size(79, 18);
            label3.TabIndex = 40;
            label3.Text = "Filtrar por :";
            // 
            // panel6
            // 
            panel6.Location = new Point(3, 84);
            panel6.Name = "panel6";
            panel6.Size = new Size(797, 59);
            panel6.TabIndex = 39;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 336);
            dataGridView1.TabIndex = 42;
            // 
            // FormAlumnosXProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "FormAlumnosXProfesor";
            Text = "FormAlumnosXProfesor";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Button btnSalir;
        private Panel panel3;
        private Button btnRecargar;
        private Button button2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private Label label3;
        private Panel panel6;
        private DataGridView dataGridView1;
    }
}