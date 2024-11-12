namespace Proyecto_Final_AlgoritmsoBDD
{
    partial class FormEmpleadosModal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleadosModal));
            panel1 = new Panel();
            panel4 = new Panel();
            btnSalir = new Button();
            label1 = new Label();
            panel3 = new Panel();
            btnEliminarEmpleado = new Button();
            btnModificarEmpleado = new Button();
            btnAgregarEmpleado = new Button();
            cmbEspecialidadEmpleado = new ComboBox();
            lblEmpleado = new Label();
            lblEmpleado2 = new Label();
            label12 = new Label();
            txtSalarioEmpleados = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dtpFechaNacimientoEmpleado = new DateTimePicker();
            txtEmailEmpleados = new TextBox();
            txtDocumentoEmpleados = new TextBox();
            txtDireNumeroEmpleados = new TextBox();
            txtTelefonoEmpleados = new TextBox();
            txtDireCalleEmpleados = new TextBox();
            txtApellidoEmpleados = new TextBox();
            txtNombreEmpleados = new TextBox();
            error1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(33, 63, 96);
            panel4.Controls.Add(btnSalir);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 70);
            panel4.TabIndex = 5;
            panel4.Paint += panel4_Paint;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(725, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(63, 57);
            btnSalir.TabIndex = 43;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HelveticaNeueLT Std Med", 36F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 6);
            label1.Name = "label1";
            label1.Size = new Size(286, 56);
            label1.TabIndex = 0;
            label1.Text = "Empleados";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnEliminarEmpleado);
            panel3.Controls.Add(btnModificarEmpleado);
            panel3.Controls.Add(btnAgregarEmpleado);
            panel3.Controls.Add(cmbEspecialidadEmpleado);
            panel3.Controls.Add(lblEmpleado);
            panel3.Controls.Add(lblEmpleado2);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtSalarioEmpleados);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dtpFechaNacimientoEmpleado);
            panel3.Controls.Add(txtEmailEmpleados);
            panel3.Controls.Add(txtDocumentoEmpleados);
            panel3.Controls.Add(txtDireNumeroEmpleados);
            panel3.Controls.Add(txtTelefonoEmpleados);
            panel3.Controls.Add(txtDireCalleEmpleados);
            panel3.Controls.Add(txtApellidoEmpleados);
            panel3.Controls.Add(txtNombreEmpleados);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 450);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Location = new Point(670, 260);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(75, 23);
            btnEliminarEmpleado.TabIndex = 45;
            btnEliminarEmpleado.Text = "Eliminar";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // btnModificarEmpleado
            // 
            btnModificarEmpleado.Location = new Point(670, 205);
            btnModificarEmpleado.Name = "btnModificarEmpleado";
            btnModificarEmpleado.Size = new Size(75, 23);
            btnModificarEmpleado.TabIndex = 44;
            btnModificarEmpleado.Text = "Modificar";
            btnModificarEmpleado.UseVisualStyleBackColor = true;
            btnModificarEmpleado.Click += btnModificarEmpleado_Click;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(670, 155);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(75, 23);
            btnAgregarEmpleado.TabIndex = 43;
            btnAgregarEmpleado.Text = "Agregar";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // cmbEspecialidadEmpleado
            // 
            cmbEspecialidadEmpleado.FormattingEnabled = true;
            cmbEspecialidadEmpleado.Location = new Point(175, 362);
            cmbEspecialidadEmpleado.Name = "cmbEspecialidadEmpleado";
            cmbEspecialidadEmpleado.Size = new Size(182, 23);
            cmbEspecialidadEmpleado.TabIndex = 42;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Microsoft Sans Serif", 12F);
            lblEmpleado.Location = new Point(180, 101);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(0, 20);
            lblEmpleado.TabIndex = 41;
            // 
            // lblEmpleado2
            // 
            lblEmpleado2.AutoSize = true;
            lblEmpleado2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmpleado2.ImageAlign = ContentAlignment.BottomLeft;
            lblEmpleado2.Location = new Point(63, 101);
            lblEmpleado2.Name = "lblEmpleado2";
            lblEmpleado2.Size = new Size(110, 20);
            lblEmpleado2.TabIndex = 40;
            lblEmpleado2.Text = "ID Empleado :";
            lblEmpleado2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F);
            label12.Location = new Point(63, 362);
            label12.Name = "label12";
            label12.Size = new Size(107, 20);
            label12.TabIndex = 38;
            label12.Text = "Especialidad :";
            // 
            // txtSalarioEmpleados
            // 
            txtSalarioEmpleados.Location = new Point(175, 333);
            txtSalarioEmpleados.Name = "txtSalarioEmpleados";
            txtSalarioEmpleados.Size = new Size(182, 23);
            txtSalarioEmpleados.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(105, 335);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 35;
            label2.Text = "Salario :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(412, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F);
            label10.Location = new Point(27, 307);
            label10.Name = "label10";
            label10.Size = new Size(145, 20);
            label10.TabIndex = 31;
            label10.Text = "Fecha Nacimiento :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(111, 275);
            label9.Name = "label9";
            label9.Size = new Size(56, 20);
            label9.TabIndex = 30;
            label9.Text = "Email :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(71, 246);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 29;
            label8.Text = "Documento :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(91, 217);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 28;
            label7.Text = "Telefono :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(304, 188);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 27;
            label6.Text = "Numero :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(48, 188);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 26;
            label5.Text = "Dirección Calle :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(96, 159);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 25;
            label4.Text = "Apellido :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.BottomLeft;
            label3.Location = new Point(96, 130);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 24;
            label3.Text = "Nombre :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpFechaNacimientoEmpleado
            // 
            dtpFechaNacimientoEmpleado.Location = new Point(175, 303);
            dtpFechaNacimientoEmpleado.Name = "dtpFechaNacimientoEmpleado";
            dtpFechaNacimientoEmpleado.Size = new Size(239, 23);
            dtpFechaNacimientoEmpleado.TabIndex = 22;
            // 
            // txtEmailEmpleados
            // 
            txtEmailEmpleados.Location = new Point(175, 275);
            txtEmailEmpleados.Name = "txtEmailEmpleados";
            txtEmailEmpleados.Size = new Size(182, 23);
            txtEmailEmpleados.TabIndex = 20;
            // 
            // txtDocumentoEmpleados
            // 
            txtDocumentoEmpleados.Location = new Point(175, 246);
            txtDocumentoEmpleados.Name = "txtDocumentoEmpleados";
            txtDocumentoEmpleados.Size = new Size(157, 23);
            txtDocumentoEmpleados.TabIndex = 19;
            // 
            // txtDireNumeroEmpleados
            // 
            txtDireNumeroEmpleados.Location = new Point(383, 189);
            txtDireNumeroEmpleados.Name = "txtDireNumeroEmpleados";
            txtDireNumeroEmpleados.Size = new Size(100, 23);
            txtDireNumeroEmpleados.TabIndex = 18;
            // 
            // txtTelefonoEmpleados
            // 
            txtTelefonoEmpleados.Location = new Point(175, 217);
            txtTelefonoEmpleados.Name = "txtTelefonoEmpleados";
            txtTelefonoEmpleados.Size = new Size(157, 23);
            txtTelefonoEmpleados.TabIndex = 17;
            // 
            // txtDireCalleEmpleados
            // 
            txtDireCalleEmpleados.Location = new Point(175, 188);
            txtDireCalleEmpleados.Name = "txtDireCalleEmpleados";
            txtDireCalleEmpleados.Size = new Size(123, 23);
            txtDireCalleEmpleados.TabIndex = 16;
            // 
            // txtApellidoEmpleados
            // 
            txtApellidoEmpleados.Location = new Point(175, 159);
            txtApellidoEmpleados.Name = "txtApellidoEmpleados";
            txtApellidoEmpleados.Size = new Size(123, 23);
            txtApellidoEmpleados.TabIndex = 15;
            // 
            // txtNombreEmpleados
            // 
            txtNombreEmpleados.Location = new Point(175, 130);
            txtNombreEmpleados.Name = "txtNombreEmpleados";
            txtNombreEmpleados.Size = new Size(123, 23);
            txtNombreEmpleados.TabIndex = 14;
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // FormEmpleadosModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormEmpleadosModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEmpleadosModal";
            Load += FormEmpleadosModal_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpFechaNacimientoEmpleado;
        private TextBox txtEmailEmpleados;
        private TextBox txtDocumentoEmpleados;
        private TextBox txtDireNumeroEmpleados;
        private TextBox txtTelefonoEmpleados;
        private TextBox txtDireCalleEmpleados;
        private TextBox txtApellidoEmpleados;
        private TextBox txtNombreEmpleados;
        private TextBox txtSalarioEmpleados;
        private Label label2;
        private Label label12;
        private Label lblEmpleado2;
        private Label lblEmpleado;
        private ComboBox cmbEspecialidadEmpleado;
        private Button btnSalir;
        private Button btnEliminarEmpleado;
        private Button btnModificarEmpleado;
        private Button btnAgregarEmpleado;
        private ErrorProvider error1;
    }
}