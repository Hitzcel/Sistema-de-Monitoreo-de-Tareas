namespace TaskNotes_MonitoreoTareas.Datos_Forms
{
    partial class FDatosUsuario
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
            btnCancelar = new Button();
            btnConfirmar = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            cmbRol = new ComboBox();
            cmbEstado = new ComboBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtPrimerApellido = new TextBox();
            txtPrimerNombre = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 28, 30);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbRol);
            panel1.Controls.Add(cmbEstado);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtPrimerApellido);
            panel1.Controls.Add(txtPrimerNombre);
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 695);
            panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(28, 28, 30);
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(232, 168, 56);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(232, 168, 56);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(189, 604);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 51);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(232, 168, 56);
            btnConfirmar.FlatAppearance.BorderColor = Color.FromArgb(28, 28, 30);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.FromArgb(28, 28, 30);
            btnConfirmar.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmar.Location = new Point(404, 604);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(180, 51);
            btnConfirmar.TabIndex = 20;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(189, 523);
            label7.Name = "label7";
            label7.Size = new Size(139, 18);
            label7.TabIndex = 19;
            label7.Text = "Seleccione el estado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(189, 468);
            label6.Name = "label6";
            label6.Size = new Size(114, 18);
            label6.TabIndex = 18;
            label6.Text = "Seleccione el rol:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(189, 368);
            label5.Name = "label5";
            label5.Size = new Size(189, 18);
            label5.TabIndex = 17;
            label5.Text = "Ingrese el correo electrónico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(189, 288);
            label3.Name = "label3";
            label3.Size = new Size(201, 18);
            label3.TabIndex = 16;
            label3.Text = "Ingrese el número de teléfono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(189, 209);
            label2.Name = "label2";
            label2.Size = new Size(172, 18);
            label2.TabIndex = 15;
            label2.Text = "Ingrese el primer apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(189, 128);
            label4.Name = "label4";
            label4.Size = new Size(170, 18);
            label4.TabIndex = 14;
            label4.Text = "Ingrese el primer nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(316, 65);
            label1.Name = "label1";
            label1.Size = new Size(134, 24);
            label1.TabIndex = 13;
            label1.Text = "Nuevo Usuario";
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.White;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(327, 463);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(257, 28);
            cmbRol.TabIndex = 12;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.White;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(363, 513);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(221, 28);
            cmbEstado.TabIndex = 11;
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCorreo.BackColor = Color.FromArgb(232, 168, 56);
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Font = new Font("Calibri", 9F);
            txtCorreo.ForeColor = Color.Black;
            txtCorreo.Location = new Point(189, 400);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(395, 36);
            txtCorreo.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.BackColor = Color.FromArgb(232, 168, 56);
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Calibri", 9F);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Location = new Point(189, 319);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(395, 36);
            txtTelefono.TabIndex = 7;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPrimerApellido.BackColor = Color.FromArgb(232, 168, 56);
            txtPrimerApellido.BorderStyle = BorderStyle.FixedSingle;
            txtPrimerApellido.Font = new Font("Calibri", 9F);
            txtPrimerApellido.ForeColor = Color.Black;
            txtPrimerApellido.Location = new Point(189, 238);
            txtPrimerApellido.Multiline = true;
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(395, 36);
            txtPrimerApellido.TabIndex = 5;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPrimerNombre.BackColor = Color.FromArgb(232, 168, 56);
            txtPrimerNombre.BorderStyle = BorderStyle.FixedSingle;
            txtPrimerNombre.Font = new Font("Calibri", 9F);
            txtPrimerNombre.ForeColor = Color.Black;
            txtPrimerNombre.Location = new Point(189, 159);
            txtPrimerNombre.Multiline = true;
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.Size = new Size(395, 36);
            txtPrimerNombre.TabIndex = 3;
            // 
            // FDatosUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 168, 56);
            ClientSize = new Size(807, 703);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FDatosUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FDatosUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtPrimerNombre;    // primer nombre
        private TextBox txtPrimerApellido; // segundo apellido
        private TextBox txtTelefono;       // teléfono
        private TextBox txtCorreo;         // correo
        private ComboBox cmbRol;
        private ComboBox cmbEstado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnCancelar;        // Cancelar
        private Button btnConfirmar; // Confirmar
    }
}