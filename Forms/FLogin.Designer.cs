namespace TaskNotes_MonitoreoTareas.Forms
{
    partial class FLogin
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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel5 = new Panel();
            btnMostrar = new PictureBox();
            btnOcultar = new PictureBox();
            lblRecuperar = new Label();
            label5 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            panel4 = new Panel();
            label7 = new Label();
            btnEntrar = new Button();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            lblSalir = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMostrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnOcultar).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(253, 243, 220);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 685);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(116, 408);
            label1.Name = "label1";
            label1.Size = new Size(186, 42);
            label1.TabIndex = 1;
            label1.Text = "Tu espacio para organizar\r\nlo que importa.\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TaskNotes_lightdarklogo1;
            pictureBox1.Location = new Point(-123, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(668, 380);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(477, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 514);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnMostrar);
            panel5.Controls.Add(btnOcultar);
            panel5.Controls.Add(lblRecuperar);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txtPassword);
            panel5.Controls.Add(txtUsuario);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 125);
            panel5.Name = "panel5";
            panel5.Size = new Size(737, 264);
            panel5.TabIndex = 2;
            // 
            // btnMostrar
            // 
            btnMostrar.Image = Properties.Resources.icons8_visible_24;
            btnMostrar.Location = new Point(661, 150);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(43, 42);
            btnMostrar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMostrar.TabIndex = 6;
            btnMostrar.TabStop = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnOcultar
            // 
            btnOcultar.Image = Properties.Resources.icons8_ojo_cerrado_24;
            btnOcultar.Location = new Point(661, 150);
            btnOcultar.Name = "btnOcultar";
            btnOcultar.Size = new Size(43, 42);
            btnOcultar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnOcultar.TabIndex = 5;
            btnOcultar.TabStop = false;
            btnOcultar.Click += btnOcultar_Click;
            // 
            // lblRecuperar
            // 
            lblRecuperar.AutoSize = true;
            lblRecuperar.FlatStyle = FlatStyle.Flat;
            lblRecuperar.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecuperar.ForeColor = Color.FromArgb(232, 168, 56);
            lblRecuperar.Location = new Point(277, 217);
            lblRecuperar.Name = "lblRecuperar";
            lblRecuperar.Size = new Size(168, 18);
            lblRecuperar.TabIndex = 4;
            lblRecuperar.Text = "¿Olvidaste tu contraseña?";
            lblRecuperar.TextAlign = ContentAlignment.MiddleCenter;
            lblRecuperar.MouseEnter += lblRecuperar_MouseEnter;
            lblRecuperar.MouseLeave += lblRecuperar_MouseLeave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(37, 118);
            label5.Name = "label5";
            label5.Size = new Size(82, 18);
            label5.TabIndex = 3;
            label5.Text = "Contraseña:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(37, 28);
            label4.Name = "label4";
            label4.Size = new Size(60, 18);
            label4.TabIndex = 2;
            label4.Text = "Usuario:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(247, 247, 245);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Calibri", 9F);
            txtPassword.Location = new Point(37, 150);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(618, 42);
            txtPassword.TabIndex = 2;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.KeyDown += txtPassword_KeyDown;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.BackColor = Color.FromArgb(247, 247, 245);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Calibri", 9F);
            txtUsuario.Location = new Point(37, 58);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "example@gmail.com";
            txtUsuario.Size = new Size(667, 42);
            txtUsuario.TabIndex = 1;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            // 
            // panel4
            // 
            panel4.Controls.Add(label7);
            panel4.Controls.Add(btnEntrar);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 389);
            panel4.Name = "panel4";
            panel4.Size = new Size(737, 125);
            panel4.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(225, 86);
            label7.Name = "label7";
            label7.Size = new Size(278, 18);
            label7.TabIndex = 5;
            label7.Text = "¿Sin cuenta? Contacte con el Administrador.";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(28, 28, 30);
            btnEntrar.FlatAppearance.BorderColor = Color.FromArgb(28, 28, 30);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.ButtonHighlight;
            btnEntrar.Location = new Point(37, 18);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(667, 51);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(737, 125);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(37, 80);
            label3.Name = "label3";
            label3.Size = new Size(178, 18);
            label3.TabIndex = 1;
            label3.Text = "Inicie sesión para continuar.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 29);
            label2.Name = "label2";
            label2.Size = new Size(202, 41);
            label2.TabIndex = 0;
            label2.Text = "Bienvenido...";
            // 
            // lblSalir
            // 
            lblSalir.AutoSize = true;
            lblSalir.Cursor = Cursors.Hand;
            lblSalir.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalir.ForeColor = SystemColors.ControlDark;
            lblSalir.Location = new Point(1180, 35);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(34, 38);
            lblSalir.TabIndex = 2;
            lblSalir.Text = "X";
            lblSalir.Click += lblSalir_Click;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 245);
            ClientSize = new Size(1250, 685);
            Controls.Add(lblSalir);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FLogin";
            Load += FLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMostrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnOcultar).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label2;
        private Label label5;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Label label3;
        private Label lblRecuperar;
        private Button btnEntrar;
        private Label label7;
        private Label lblSalir;
        private PictureBox btnOcultar;
        private PictureBox btnMostrar;
    }
}