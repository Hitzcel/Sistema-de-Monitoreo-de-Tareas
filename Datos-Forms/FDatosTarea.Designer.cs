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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 28, 30);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 94);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(282, 38);
            label1.Name = "label1";
            label1.Size = new Size(94, 19);
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
            txtTitulo.Location = new Point(170, 159);
            txtTitulo.Margin = new Padding(3, 2, 3, 2);
            txtTitulo.Multiline = true;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(346, 28);
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
            btnCancelar.Location = new Point(170, 478);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(158, 38);
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
            btnConfirmar.Location = new Point(358, 478);
            btnConfirmar.Margin = new Padding(3, 2, 3, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(158, 38);
            btnConfirmar.TabIndex = 25;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(28, 28, 30);
            label4.Location = new Point(170, 135);
            label4.Name = "label4";
            label4.Size = new Size(94, 14);
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
            txtDescripcion.Location = new Point(170, 227);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(346, 28);
            txtDescripcion.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(28, 28, 30);
            label2.Location = new Point(170, 203);
            label2.Name = "label2";
            label2.Size = new Size(123, 14);
            label2.TabIndex = 28;
            label2.Text = "Descripción de la tarea:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.White;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(170, 302);
            cmbCategoria.Margin = new Padding(3, 2, 3, 2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(164, 23);
            cmbCategoria.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(28, 28, 30);
            label3.Location = new Point(170, 278);
            label3.Name = "label3";
            label3.Size = new Size(123, 14);
            label3.TabIndex = 31;
            label3.Text = "Seleccione la categoría:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(28, 28, 30);
            label5.Location = new Point(352, 278);
            label5.Name = "label5";
            label5.Size = new Size(121, 14);
            label5.TabIndex = 33;
            label5.Text = "Seleccione la prioridad:";
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.BackColor = Color.White;
            cmbPrioridad.FormattingEnabled = true;
            cmbPrioridad.Location = new Point(352, 302);
            cmbPrioridad.Margin = new Padding(3, 2, 3, 2);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(164, 23);
            cmbPrioridad.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(28, 28, 30);
            label6.Location = new Point(170, 405);
            label6.Name = "label6";
            label6.Size = new Size(71, 14);
            label6.TabIndex = 34;
            label6.Text = "Fecha límite:";
            // 
            // dtpFechaLimite
            // 
            dtpFechaLimite.Location = new Point(170, 435);
            dtpFechaLimite.Margin = new Padding(3, 2, 3, 2);
            dtpFechaLimite.Name = "dtpFechaLimite";
            dtpFechaLimite.Size = new Size(346, 23);
            dtpFechaLimite.TabIndex = 35;
            // 
            // FDatosTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 527);
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
            Margin = new Padding(3, 2, 3, 2);
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
    }
}