namespace TaskNotes_MonitoreoTareas.Sub_Forms
{
    partial class FDashboard
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
            txtUsuario = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            panel5 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel7 = new Panel();
            flowTareas = new FlowLayoutPanel();
            panel8 = new Panel();
            flowFechas = new FlowLayoutPanel();
            panel9 = new Panel();
            txtNota = new RichTextBox();
            panel10 = new Panel();
            label14 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 125);
            panel1.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.BackColor = Color.FromArgb(247, 247, 245);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Calibri", 9F);
            txtUsuario.Location = new Point(1052, 41);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Buscar tarea...";
            txtUsuario.Size = new Size(267, 43);
            txtUsuario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 51);
            label1.Name = "label1";
            label1.Size = new Size(102, 24);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(1350, 155);
            panel2.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label13);
            panel6.Location = new Point(988, 19);
            panel6.Name = "panel6";
            panel6.Size = new Size(253, 116);
            panel6.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(26, 40);
            label11.Name = "label11";
            label11.Size = new Size(43, 35);
            label11.TabIndex = 6;
            label11.Text = "00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 9F);
            label12.ForeColor = SystemColors.ControlDark;
            label12.Location = new Point(26, 86);
            label12.Name = "label12";
            label12.Size = new Size(76, 18);
            label12.TabIndex = 5;
            label12.Text = "Finalizadas";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlDark;
            label13.Location = new Point(26, 10);
            label13.Name = "label13";
            label13.Size = new Size(102, 21);
            label13.TabIndex = 4;
            label13.Text = "Completadas";
            label13.Click += label13_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(689, 19);
            panel5.Name = "panel5";
            panel5.Size = new Size(253, 116);
            panel5.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(24, 40);
            label8.Name = "label8";
            label8.Size = new Size(43, 35);
            label8.TabIndex = 6;
            label8.Text = "00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 9F);
            label9.ForeColor = SystemColors.ControlDark;
            label9.Location = new Point(24, 86);
            label9.Name = "label9";
            label9.Size = new Size(59, 18);
            label9.TabIndex = 5;
            label9.Text = "En curso";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlDark;
            label10.Location = new Point(24, 10);
            label10.Name = "label10";
            label10.Size = new Size(94, 21);
            label10.TabIndex = 4;
            label10.Text = "En progreso";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(393, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(253, 116);
            panel4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(18, 40);
            label5.Name = "label5";
            label5.Size = new Size(43, 35);
            label5.TabIndex = 6;
            label5.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9F);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(18, 86);
            label6.Name = "label6";
            label6.Size = new Size(68, 18);
            label6.TabIndex = 5;
            label6.Text = "Sin iniciar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(18, 10);
            label7.Name = "label7";
            label7.Size = new Size(90, 21);
            label7.TabIndex = 4;
            label7.Text = "Pendientes";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(94, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(253, 116);
            panel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(16, 40);
            label4.Name = "label4";
            label4.Size = new Size(43, 35);
            label4.TabIndex = 3;
            label4.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(16, 86);
            label3.Name = "label3";
            label3.Size = new Size(84, 18);
            label3.TabIndex = 2;
            label3.Text = "Esta semana";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(16, 10);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 1;
            label2.Text = "Total tareas";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(flowTareas);
            panel7.Location = new Point(94, 306);
            panel7.Name = "panel7";
            panel7.Size = new Size(552, 562);
            panel7.TabIndex = 2;
            // 
            // flowTareas
            // 
            flowTareas.Dock = DockStyle.Fill;
            flowTareas.Location = new Point(0, 0);
            flowTareas.Name = "flowTareas";
            flowTareas.Size = new Size(552, 562);
            flowTareas.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(flowFechas);
            panel8.Location = new Point(689, 306);
            panel8.Name = "panel8";
            panel8.Size = new Size(552, 271);
            panel8.TabIndex = 3;
            // 
            // flowFechas
            // 
            flowFechas.Dock = DockStyle.Fill;
            flowFechas.Location = new Point(0, 0);
            flowFechas.Name = "flowFechas";
            flowFechas.Size = new Size(552, 271);
            flowFechas.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(253, 243, 220);
            panel9.Controls.Add(txtNota);
            panel9.Controls.Add(panel10);
            panel9.Location = new Point(689, 597);
            panel9.Name = "panel9";
            panel9.Size = new Size(552, 241);
            panel9.TabIndex = 4;
            // 
            // txtNota
            // 
            txtNota.BackColor = Color.FromArgb(253, 243, 220);
            txtNota.BorderStyle = BorderStyle.None;
            txtNota.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNota.Location = new Point(16, 77);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(517, 142);
            txtNota.TabIndex = 6;
            txtNota.Text = "";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(232, 168, 56);
            panel10.Controls.Add(label14);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(552, 60);
            panel10.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Transparent;
            label14.Location = new Point(230, 20);
            label14.Name = "label14";
            label14.Size = new Size(92, 21);
            label14.TabIndex = 2;
            label14.Text = "Nota rápida";
            // 
            // FDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 245);
            ClientSize = new Size(1350, 850);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FDashboard";
            Text = "FDashboard";
            Load += FDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtUsuario;
        private Panel panel2;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private FlowLayoutPanel flowTareas;
        private FlowLayoutPanel flowFechas;
        private RichTextBox txtNota;
        private Label label14;
    }
}