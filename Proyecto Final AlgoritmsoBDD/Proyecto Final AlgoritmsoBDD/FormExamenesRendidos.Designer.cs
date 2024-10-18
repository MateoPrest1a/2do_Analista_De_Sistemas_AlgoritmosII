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
            btnAgregar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(48, 94, 214);
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
            label2.Font = new Font("Schadow BT", 25F);
            label2.Location = new Point(213, 15);
            label2.Name = "label2";
            label2.Size = new Size(339, 41);
            label2.TabIndex = 1;
            label2.Text = "Examenes del Alumno";
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Schadow BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 308);
            dataGridView1.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 94, 214);
            panel1.Controls.Add(btnAgregar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 377);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 69);
            panel1.TabIndex = 39;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(713, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 55);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // FormExamenesRendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "FormExamenesRendidos";
            Text = "FormExamenesRendidos";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Button btnSalir;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnAgregar;
    }
}