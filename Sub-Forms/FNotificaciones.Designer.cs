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
            this.panelHoy = new Panel();
            this.panelEstaSemana = new Panel();
            panelAnteriores = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            flowHoy = new FlowLayoutPanel();
            flowEstaSemana = new FlowLayoutPanel();
            flowAnteriores = new FlowLayoutPanel();
            panel1.SuspendLayout();
            this.panelHoy.SuspendLayout();
            this.panelEstaSemana.SuspendLayout();
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
            this.panelHoy.Controls.Add(flowHoy);
            this.panelHoy.Controls.Add(label2);
            this.panelHoy.Location = new Point(34, 159);
            this.panelHoy.Name = "panelHoy";
            this.panelHoy.Size = new Size(1283, 222);
            this.panelHoy.TabIndex = 3;
            // 
            // panelEstaSemana
            // 
            this.panelEstaSemana.Controls.Add(flowEstaSemana);
            this.panelEstaSemana.Controls.Add(label3);
            this.panelEstaSemana.Location = new Point(34, 387);
            this.panelEstaSemana.Name = "panelEstaSemana";
            this.panelEstaSemana.Size = new Size(1283, 222);
            this.panelEstaSemana.TabIndex = 4;
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
            // flowHoy
            // 
            flowHoy.Location = new Point(34, 64);
            flowHoy.Name = "flowHoy";
            flowHoy.Size = new Size(1227, 141);
            flowHoy.TabIndex = 2;
            // 
            // flowEstaSemana
            // 
            flowEstaSemana.Location = new Point(34, 67);
            flowEstaSemana.Name = "flowEstaSemana";
            flowEstaSemana.Size = new Size(1227, 141);
            flowEstaSemana.TabIndex = 3;
            // 
            // flowAnteriores
            // 
            flowAnteriores.Location = new Point(34, 65);
            flowAnteriores.Name = "flowAnteriores";
            flowAnteriores.Size = new Size(1227, 141);
            flowAnteriores.TabIndex = 3;
            // 
            // FNotificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 850);
            Controls.Add(panelAnteriores);
            Controls.Add(this.panelEstaSemana);
            Controls.Add(this.panelHoy);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FNotificaciones";
            Text = "FNotificaciones";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.panelHoy.ResumeLayout(false);
            this.panelHoy.PerformLayout();
            this.panelEstaSemana.ResumeLayout(false);
            this.panelEstaSemana.PerformLayout();
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