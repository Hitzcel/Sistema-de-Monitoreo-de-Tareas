using TaskNotes_MonitoreoTareas.Clases;

namespace TaskNotes_MonitoreoTareas
{
    partial class FSplahScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            barraCarga = new UIProgressBar();
            lblCarga = new Label();
            label1 = new Label();
            timerCarga = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TaskNotes_lightlogo;
            pictureBox1.Location = new Point(93, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(586, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // barraCarga
            // 
            barraCarga.BackColor = Color.FromArgb(44, 44, 46);
            barraCarga.ForeColor = Color.FromArgb(232, 168, 56);
            barraCarga.Location = new Point(257, 372);
            barraCarga.Name = "barraCarga";
            barraCarga.Size = new Size(267, 12);
            barraCarga.TabIndex = 1;
            // 
            // lblCarga
            // 
            lblCarga.AutoSize = true;
            lblCarga.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarga.ForeColor = SystemColors.Control;
            lblCarga.Location = new Point(360, 402);
            lblCarga.Name = "lblCarga";
            lblCarga.Size = new Size(52, 21);
            lblCarga.TabIndex = 2;
            lblCarga.Text = "label1";
            lblCarga.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(257, 304);
            label1.Name = "label1";
            label1.Size = new Size(267, 21);
            label1.TabIndex = 3;
            label1.Text = "Gestión de tareas sencilla y efectiva…";
            // 
            // timerCarga
            // 
            timerCarga.Tick += timerCarga_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 30);
            ClientSize = new Size(775, 475);
            Controls.Add(label1);
            Controls.Add(lblCarga);
            Controls.Add(barraCarga);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private UIProgressBar barraCarga;
        private Label lblCarga;
        private Label label1;
        private System.Windows.Forms.Timer timerCarga;
    }
}
