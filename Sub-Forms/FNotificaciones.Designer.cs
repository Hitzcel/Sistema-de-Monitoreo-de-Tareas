namespace TaskNotes_MonitoreoTareas.Sub_Forms
{
    partial class FNotificaciones
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
            btnNuevaTarea = new Button();
            label1 = new Label();
            panelHoy = new Panel();
            flowHoy = new FlowLayoutPanel();
            label2 = new Label();
            panelEstaSemana = new Panel();
            flowEstaSemana = new FlowLayoutPanel();
            label3 = new Label();
            panelAnteriores = new Panel();
            flowAnteriores = new FlowLayoutPanel();
            label4 = new Label();
            panel1.SuspendLayout();
            panelHoy.SuspendLayout();
            panelEstaSemana.SuspendLayout();
            panelAnteriores.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnNuevaTarea);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 125);
            panel1.TabIndex = 2;
            // 
            // btnNuevaTarea
            // 
            btnNuevaTarea.BackColor = Color.FromArgb(28, 28, 30);
            btnNuevaTarea.FlatAppearance.BorderColor = Color.FromArgb(28, 28, 30);
            btnNuevaTarea.FlatStyle = FlatStyle.Flat;
            btnNuevaTarea.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaTarea.ForeColor = SystemColors.ButtonHighlight;
            btnNuevaTarea.Image = Properties.Resources.icons8_nuevo_correo_electrónico_sin_leer_32;
            btnNuevaTarea.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevaTarea.Location = new Point(1034, 38);
            btnNuevaTarea.Name = "btnNuevaTarea";
            btnNuevaTarea.Size = new Size(283, 52);
            btnNuevaTarea.TabIndex = 1;
            btnNuevaTarea.Text = "Marcar todas como leídas";
            btnNuevaTarea.UseVisualStyleBackColor = false;
            btnNuevaTarea.Click += btnNuevaTarea_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 51);
            label1.Name = "label1";
            label1.Size = new Size(128, 24);
            label1.TabIndex = 0;
            label1.Text = "Notificaciones";
            // 
            // panelHoy
            // 
            panelHoy.Controls.Add(flowHoy);
            panelHoy.Controls.Add(label2);
            panelHoy.Location = new Point(34, 159);
            panelHoy.Name = "panelHoy";
            panelHoy.Size = new Size(1283, 222);
            panelHoy.TabIndex = 3;
            // 
            // flowHoy
            // 
            flowHoy.AutoScroll = true;
            flowHoy.Location = new Point(34, 64);
            flowHoy.Name = "flowHoy";
            flowHoy.Size = new Size(1227, 141);
            flowHoy.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(34, 27);
            label2.Name = "label2";
            label2.Size = new Size(43, 24);
            label2.TabIndex = 1;
            label2.Text = "Hoy";
            // 
            // panelEstaSemana
            // 
            panelEstaSemana.Controls.Add(flowEstaSemana);
            panelEstaSemana.Controls.Add(label3);
            panelEstaSemana.Location = new Point(34, 387);
            panelEstaSemana.Name = "panelEstaSemana";
            panelEstaSemana.Size = new Size(1283, 222);
            panelEstaSemana.TabIndex = 4;
            // 
            // flowEstaSemana
            // 
            flowEstaSemana.AutoScroll = true;
            flowEstaSemana.Location = new Point(34, 67);
            flowEstaSemana.Name = "flowEstaSemana";
            flowEstaSemana.Size = new Size(1227, 141);
            flowEstaSemana.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(34, 29);
            label3.Name = "label3";
            label3.Size = new Size(116, 24);
            label3.TabIndex = 2;
            label3.Text = "Esta Semana";
            // 
            // panelAnteriores
            // 
            panelAnteriores.Controls.Add(flowAnteriores);
            panelAnteriores.Controls.Add(label4);
            panelAnteriores.Location = new Point(34, 616);
            panelAnteriores.Name = "panelAnteriores";
            panelAnteriores.Size = new Size(1283, 222);
            panelAnteriores.TabIndex = 5;
            // 
            // flowAnteriores
            // 
            flowAnteriores.AutoScroll = true;
            flowAnteriores.Location = new Point(34, 65);
            flowAnteriores.Name = "flowAnteriores";
            flowAnteriores.Size = new Size(1227, 141);
            flowAnteriores.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(34, 29);
            label4.Name = "label4";
            label4.Size = new Size(98, 24);
            label4.TabIndex = 2;
            label4.Text = "Anteriores";
            // 
            // FNotificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 850);
            Controls.Add(panelAnteriores);
            Controls.Add(panelEstaSemana);
            Controls.Add(panelHoy);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FNotificaciones";
            Text = "FNotificaciones";
            Load += FNotificaciones_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelHoy.ResumeLayout(false);
            panelHoy.PerformLayout();
            panelEstaSemana.ResumeLayout(false);
            panelEstaSemana.PerformLayout();
            panelAnteriores.ResumeLayout(false);
            panelAnteriores.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNuevaTarea;
        private Label label1;
        private Panel panelHoy;
        private Panel panel2;
        private Panel panel3;
        private Panel panelEstaSemana;
        private Panel panelAnteriores;
        private FlowLayoutPanel flowHoy;
        private Label label2;
        private FlowLayoutPanel flowEstaSemana;
        private Label label3;
        private FlowLayoutPanel flowAnteriores;
        private Label label4;
    }
}