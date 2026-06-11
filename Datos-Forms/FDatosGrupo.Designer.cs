namespace TaskNotes_MonitoreoTareas.Datos_Forms
{
    partial class FDatosGrupo
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
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            txtNombre = new TextBox();
            chkListUsuario = new CheckedListBox();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(189, 128);
            label4.Name = "label4";
            label4.Size = new Size(187, 18);
            label4.TabIndex = 14;
            label4.Text = "Ingrese el nombre del grupo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(316, 65);
            label1.Name = "label1";
            label1.Size = new Size(122, 24);
            label1.TabIndex = 13;
            label1.Text = "Nuevo Grupo";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 28, 30);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(chkListUsuario);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 695);
            panel1.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.BackColor = Color.FromArgb(232, 168, 56);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Calibri", 9F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(189, 160);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(395, 36);
            txtNombre.TabIndex = 23;
            // 
            // chkListUsuario
            // 
            chkListUsuario.BackColor = Color.FromArgb(232, 168, 56);
            chkListUsuario.BorderStyle = BorderStyle.FixedSingle;
            chkListUsuario.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkListUsuario.FormattingEnabled = true;
            chkListUsuario.Location = new Point(189, 246);
            chkListUsuario.Name = "chkListUsuario";
            chkListUsuario.Size = new Size(395, 324);
            chkListUsuario.TabIndex = 22;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(189, 209);
            label2.Name = "label2";
            label2.Size = new Size(174, 18);
            label2.TabIndex = 15;
            label2.Text = "Elija miembros del equipo:";
            // 
            // FDatosGrupo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 168, 56);
            ClientSize = new Size(807, 703);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FDatosGrupo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FDatosGrupo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private Button btnNuevoUsuario;
        private Label label2;
        private CheckedListBox chkUsuarios;
        private TextBox txtNombre;
        private Button btnCancelar;
        private Button btnConfirmar;
        private CheckedListBox chkListUsuario;
    }
}