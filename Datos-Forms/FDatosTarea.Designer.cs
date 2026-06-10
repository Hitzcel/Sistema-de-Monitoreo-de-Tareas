namespace TaskNotes_MonitoreoTareas.Datos_Forms
{
    partial class FDatosTarea
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
            label1 = new Label();
            txtTitulo = new TextBox();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            label4 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            cmbCategoria = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            cmbPrioridad = new ComboBox();
            label6 = new Label();
            dtpFechaLimite = new DateTimePicker();
            label7 = new Label();
            cmbAsignarA = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 28, 30);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(322, 51);
            label1.Name = "label1";
            label1.Size = new Size(113, 24);
            label1.TabIndex = 14;
            label1.Text = "Nueva Tarea";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTitulo.BackColor = Color.Gainsboro;
            txtTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtTitulo.Font = new Font("Calibri", 9F);
            txtTitulo.ForeColor = Color.Black;
            txtTitulo.Location = new Point(194, 212);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(395, 36);
            txtTitulo.TabIndex = 27;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.FlatAppearance.BorderColor = Color.Silver;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(28, 28, 30);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(194, 629);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 51);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(28, 28, 30);
            btnConfirmar.FlatAppearance.BorderColor = Color.FromArgb(28, 28, 30);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.Location = new Point(409, 629);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(180, 51);
            btnConfirmar.TabIndex = 25;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(28, 28, 30);
            label4.Location = new Point(194, 180);
            label4.Name = "label4";
            label4.Size = new Size(116, 18);
            label4.TabIndex = 24;
            label4.Text = "Título de la tarea:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.BackColor = Color.Gainsboro;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Calibri", 9F);
            txtDescripcion.ForeColor = Color.Black;
            txtDescripcion.Location = new Point(194, 303);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(395, 36);
            txtDescripcion.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(28, 28, 30);
            label2.Location = new Point(194, 271);
            label2.Name = "label2";
            label2.Size = new Size(152, 18);
            label2.TabIndex = 28;
            label2.Text = "Descripción de la tarea:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.White;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(194, 403);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(187, 28);
            cmbCategoria.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(28, 28, 30);
            label3.Location = new Point(194, 371);
            label3.Name = "label3";
            label3.Size = new Size(153, 18);
            label3.TabIndex = 31;
            label3.Text = "Seleccione la categoría:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(28, 28, 30);
            label5.Location = new Point(402, 371);
            label5.Name = "label5";
            label5.Size = new Size(153, 18);
            label5.TabIndex = 33;
            label5.Text = "Seleccione la prioridad:";
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.BackColor = Color.White;
            cmbPrioridad.FormattingEnabled = true;
            cmbPrioridad.Location = new Point(402, 403);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(187, 28);
            cmbPrioridad.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(28, 28, 30);
            label6.Location = new Point(194, 530);
            label6.Name = "label6";
            label6.Size = new Size(88, 18);
            label6.TabIndex = 34;
            label6.Text = "Fecha límite:";
            // 
            // dtpFechaLimite
            // 
            dtpFechaLimite.Location = new Point(194, 564);
            dtpFechaLimite.Name = "dtpFechaLimite";
            dtpFechaLimite.Size = new Size(395, 27);
            dtpFechaLimite.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(28, 28, 30);
            label7.Location = new Point(194, 453);
            label7.Name = "label7";
            label7.Size = new Size(68, 18);
            label7.TabIndex = 37;
            label7.Text = "Asignar a:";
            // 
            // cmbAsignarA
            // 
            cmbAsignarA.BackColor = Color.White;
            cmbAsignarA.FormattingEnabled = true;
            cmbAsignarA.Location = new Point(194, 485);
            cmbAsignarA.Name = "cmbAsignarA";
            cmbAsignarA.Size = new Size(395, 28);
            cmbAsignarA.TabIndex = 36;
            // 
            // FDatosTarea
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 703);
            Controls.Add(label7);
            Controls.Add(cmbAsignarA);
            Controls.Add(dtpFechaLimite);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbPrioridad);
            Controls.Add(label3);
            Controls.Add(cmbCategoria);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(txtTitulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FDatosTarea";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FDatosTarea";
            Load += FDatosTarea_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtTitulo;
        private Button btnCancelar;
        private Button btnConfirmar;
        private TextBox txtNombreUsuario;
        private Button button1;
        private Button btnNuevoUsuario;
        private Label label4;
        private TextBox txtDescripcion;
        private TextBox textBox1;
        private Label label2;
        private ComboBox cmbCategoria;
        private ComboBox comboBox3;
        private Label label3;
        private Label label5;
        private ComboBox cmbPrioridad;
        private Label label6;
        private DateTimePicker dtpFechaLimite;
        private Label label7;
        private ComboBox cmbAsignarA;
    }
}