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
            txtNombreUsuario = new TextBox();
            chkUsuarios = new CheckedListBox();
            button1 = new Button();
            btnNuevoUsuario = new Button();
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
            panel1.Controls.Add(txtNombreUsuario);
            panel1.Controls.Add(chkUsuarios);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnNuevoUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 695);
            panel1.TabIndex = 1;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreUsuario.BackColor = Color.FromArgb(232, 168, 56);
            txtNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNombreUsuario.Font = new Font("Calibri", 9F);
            txtNombreUsuario.ForeColor = Color.Black;
            txtNombreUsuario.Location = new Point(189, 160);
            txtNombreUsuario.Multiline = true;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(395, 36);
            txtNombreUsuario.TabIndex = 23;
            // 
            // chkUsuarios
            // 
            chkUsuarios.BackColor = Color.FromArgb(232, 168, 56);
            chkUsuarios.BorderStyle = BorderStyle.FixedSingle;
            chkUsuarios.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkUsuarios.FormattingEnabled = true;
            chkUsuarios.Location = new Point(189, 246);
            chkUsuarios.Name = "chkUsuarios";
            chkUsuarios.Size = new Size(395, 324);
            chkUsuarios.TabIndex = 22;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 28, 30);
            button1.FlatAppearance.BorderColor = Color.FromArgb(232, 168, 56);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(232, 168, 56);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(189, 604);
            button1.Name = "button1";
            button1.Size = new Size(180, 51);
            button1.TabIndex = 21;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.BackColor = Color.FromArgb(232, 168, 56);
            btnNuevoUsuario.FlatAppearance.BorderColor = Color.FromArgb(28, 28, 30);
            btnNuevoUsuario.FlatStyle = FlatStyle.Flat;
            btnNuevoUsuario.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoUsuario.ForeColor = Color.FromArgb(28, 28, 30);
            btnNuevoUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoUsuario.Location = new Point(404, 604);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(180, 51);
            btnNuevoUsuario.TabIndex = 20;
            btnNuevoUsuario.Text = "Confirmar";
            btnNuevoUsuario.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(189, 209);
            label2.Name = "label2";
            label2.Size = new Size(183, 18);
            label2.TabIndex = 15;
            label2.Text = "Ingrese el segundo apellido:";
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
        private TextBox txtNombreUsuario;
    }
}