namespace TaskNotes_MonitoreoTareas.Forms
{
    partial class FPrincipal
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
            panelSidebar = new Panel();
            lblUsuarios = new Label();
            lblAjustes = new Label();
            lblNotificaciones = new Label();
            lblTareas = new Label();
            lblDashboard = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panelLoad = new Panel();
            lblMinimizar = new Label();
            lblCerrar = new Label();
            panel1.SuspendLayout();
            panelSidebar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 28, 30);
            panel1.Controls.Add(panelSidebar);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 900);
            panel1.TabIndex = 0;
            // 
            // panelSidebar
            // 
            panelSidebar.Controls.Add(lblUsuarios);
            panelSidebar.Controls.Add(lblAjustes);
            panelSidebar.Controls.Add(lblNotificaciones);
            panelSidebar.Controls.Add(lblTareas);
            panelSidebar.Controls.Add(lblDashboard);
            panelSidebar.Dock = DockStyle.Fill;
            panelSidebar.Location = new Point(0, 176);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 724);
            panelSidebar.TabIndex = 1;
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuarios.ForeColor = SystemColors.ControlLight;
            lblUsuarios.Location = new Point(25, 89);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(61, 18);
            lblUsuarios.TabIndex = 4;
            lblUsuarios.Tag = "menuItem";
            lblUsuarios.Text = "Usuarios";
            // 
            // lblAjustes
            // 
            lblAjustes.AutoSize = true;
            lblAjustes.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAjustes.ForeColor = SystemColors.ControlLight;
            lblAjustes.Location = new Point(25, 239);
            lblAjustes.Name = "lblAjustes";
            lblAjustes.Size = new Size(54, 18);
            lblAjustes.TabIndex = 3;
            lblAjustes.Tag = "menuItem";
            lblAjustes.Text = "Ajustes";
            // 
            // lblNotificaciones
            // 
            lblNotificaciones.AutoSize = true;
            lblNotificaciones.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotificaciones.ForeColor = SystemColors.ControlLight;
            lblNotificaciones.Location = new Point(25, 189);
            lblNotificaciones.Name = "lblNotificaciones";
            lblNotificaciones.Size = new Size(95, 18);
            lblNotificaciones.TabIndex = 2;
            lblNotificaciones.Tag = "menuItem";
            lblNotificaciones.Text = "Notificaciones";
            // 
            // lblTareas
            // 
            lblTareas.AutoSize = true;
            lblTareas.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTareas.ForeColor = SystemColors.ControlLight;
            lblTareas.Location = new Point(25, 141);
            lblTareas.Name = "lblTareas";
            lblTareas.Size = new Size(71, 18);
            lblTareas.TabIndex = 1;
            lblTareas.Tag = "menuItem";
            lblTareas.Text = "Mis tareas";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDashboard.ForeColor = SystemColors.ControlLight;
            lblDashboard.Location = new Point(25, 36);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(74, 18);
            lblDashboard.TabIndex = 0;
            lblDashboard.Tag = "menuItem";
            lblDashboard.Text = "Dashboard";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 176);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TaskNotes_lightlogo;
            pictureBox1.Location = new Point(-20, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelLoad
            // 
            panelLoad.Location = new Point(250, 50);
            panelLoad.Name = "panelLoad";
            panelLoad.Size = new Size(1350, 850);
            panelLoad.TabIndex = 1;
            // 
            // lblMinimizar
            // 
            lblMinimizar.AutoSize = true;
            lblMinimizar.Cursor = Cursors.Hand;
            lblMinimizar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinimizar.ForeColor = Color.FromArgb(232, 168, 56);
            lblMinimizar.Location = new Point(1476, -9);
            lblMinimizar.Name = "lblMinimizar";
            lblMinimizar.Size = new Size(41, 38);
            lblMinimizar.TabIndex = 2;
            lblMinimizar.Text = "__";
            lblMinimizar.Click += lblMinimizar_Click;
            // 
            // lblCerrar
            // 
            lblCerrar.AutoSize = true;
            lblCerrar.Cursor = Cursors.Hand;
            lblCerrar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCerrar.ForeColor = Color.FromArgb(232, 168, 56);
            lblCerrar.Location = new Point(1542, 0);
            lblCerrar.Name = "lblCerrar";
            lblCerrar.Size = new Size(32, 38);
            lblCerrar.TabIndex = 3;
            lblCerrar.Text = "x";
            lblCerrar.Click += lblCerrar_Click;
            // 
            // FPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 30);
            ClientSize = new Size(1600, 900);
            Controls.Add(lblCerrar);
            Controls.Add(lblMinimizar);
            Controls.Add(panelLoad);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FPrincipal";
            Load += FPrincipal_Load;
            panel1.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panelLoad;
        private Panel panelSidebar;
        private Label lblAjustes;
        private Label lblVencidas;
        private Label lblNotificaciones;
        private Label lblTareas;
        private Label lblDashboard;
        private Label lblUsuarios;
        private Label lblMinimizar;
        private Label lblCerrar;
    }
}