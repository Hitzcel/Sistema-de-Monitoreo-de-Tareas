namespace TaskNotes_MonitoreoTareas.Sub_Forms
{
    partial class FTareas
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
            panel1.SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // btnNuevaTarea
            // 
            btnNuevaTarea.BackColor = Color.FromArgb(28, 28, 30);
            btnNuevaTarea.FlatAppearance.BorderColor = Color.FromArgb(28, 28, 30);
            btnNuevaTarea.FlatStyle = FlatStyle.Flat;
            btnNuevaTarea.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaTarea.ForeColor = SystemColors.ButtonHighlight;
            btnNuevaTarea.Image = Properties.Resources.icons8_más_24__1_;
            btnNuevaTarea.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevaTarea.Location = new Point(1124, 38);
            btnNuevaTarea.Name = "btnNuevaTarea";
            btnNuevaTarea.Size = new Size(195, 51);
            btnNuevaTarea.TabIndex = 1;
            btnNuevaTarea.Text = "Nueva tarea";
            btnNuevaTarea.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 51);
            label1.Name = "label1";
            label1.Size = new Size(97, 24);
            label1.TabIndex = 0;
            label1.Text = "Mis tareas";
            // 
            // FTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 245);
            ClientSize = new Size(1350, 900);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FTareas";
            Text = "FTareas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNuevaTarea;
        private Label label1;
    }
}