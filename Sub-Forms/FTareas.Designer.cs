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
            radTodas = new RadioButton();
            radPendientes = new RadioButton();
            radEnCurso = new RadioButton();
            radCompletadas = new RadioButton();
            groupBox1 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panelButtons = new Panel();
            btnEliminar = new Button();
            btnEditar = new Button();
            panel5 = new Panel();
            panel4 = new Panel();
            lblAsignadoA = new Label();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            cmbEstado = new ComboBox();
            cmbPrioridad = new ComboBox();
            cmbCategoria = new ComboBox();
            lblFecha = new Label();
            lblDescripcion = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panelButtons.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            btnNuevaTarea.Size = new Size(172, 51);
            btnNuevaTarea.TabIndex = 1;
            btnNuevaTarea.Text = "Nueva tarea";
            btnNuevaTarea.UseVisualStyleBackColor = false;
            btnNuevaTarea.Click += btnNuevaTarea_Click;
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
            // radTodas
            // 
            radTodas.AutoSize = true;
            radTodas.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radTodas.Location = new Point(19, 56);
            radTodas.Name = "radTodas";
            radTodas.Size = new Size(70, 25);
            radTodas.TabIndex = 2;
            radTodas.TabStop = true;
            radTodas.Text = "Todas";
            radTodas.UseVisualStyleBackColor = true;
            // 
            // radPendientes
            // 
            radPendientes.AutoSize = true;
            radPendientes.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radPendientes.Location = new Point(138, 56);
            radPendientes.Name = "radPendientes";
            radPendientes.Size = new Size(108, 25);
            radPendientes.TabIndex = 3;
            radPendientes.TabStop = true;
            radPendientes.Text = "Pendientes";
            radPendientes.UseVisualStyleBackColor = true;
            // 
            // radEnCurso
            // 
            radEnCurso.AutoSize = true;
            radEnCurso.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radEnCurso.Location = new Point(285, 56);
            radEnCurso.Name = "radEnCurso";
            radEnCurso.Size = new Size(92, 25);
            radEnCurso.TabIndex = 4;
            radEnCurso.TabStop = true;
            radEnCurso.Text = "En Curso";
            radEnCurso.UseVisualStyleBackColor = true;
            // 
            // radCompletadas
            // 
            radCompletadas.AutoSize = true;
            radCompletadas.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radCompletadas.Location = new Point(413, 56);
            radCompletadas.Name = "radCompletadas";
            radCompletadas.Size = new Size(122, 25);
            radCompletadas.TabIndex = 5;
            radCompletadas.TabStop = true;
            radCompletadas.Text = "Completadas";
            radCompletadas.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radCompletadas);
            groupBox1.Controls.Add(radTodas);
            groupBox1.Controls.Add(radEnCurso);
            groupBox1.Controls.Add(radPendientes);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(34, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1262, 104);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar Tareas";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.ForeColor = SystemColors.ButtonHighlight;
            flowLayoutPanel1.Location = new Point(34, 278);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(535, 545);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelButtons);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(cmbEstado);
            panel2.Controls.Add(cmbPrioridad);
            panel2.Controls.Add(cmbCategoria);
            panel2.Controls.Add(lblFecha);
            panel2.Controls.Add(lblDescripcion);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(587, 278);
            panel2.Name = "panel2";
            panel2.Size = new Size(709, 545);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnEliminar);
            panelButtons.Controls.Add(btnEditar);
            panelButtons.Location = new Point(397, 16);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(271, 63);
            panelButtons.TabIndex = 17;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(232, 168, 56);
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(232, 168, 56);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(28, 28, 30);
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(147, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(121, 51);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(28, 28, 30);
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(232, 168, 56);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.FromArgb(232, 168, 56);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(3, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(121, 51);
            btnEditar.TabIndex = 22;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(panel4);
            panel5.Location = new Point(34, 449);
            panel5.Name = "panel5";
            panel5.Size = new Size(634, 76);
            panel5.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(28, 28, 30);
            panel4.Controls.Add(lblAsignadoA);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(626, 71);
            panel4.TabIndex = 15;
            // 
            // lblAsignadoA
            // 
            lblAsignadoA.AutoSize = true;
            lblAsignadoA.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsignadoA.ForeColor = Color.White;
            lblAsignadoA.Location = new Point(84, 38);
            lblAsignadoA.Name = "lblAsignadoA";
            lblAsignadoA.Size = new Size(98, 21);
            lblAsignadoA.TabIndex = 11;
            lblAsignadoA.Text = "detalle aquí.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(83, 14);
            label9.Name = "label9";
            label9.Size = new Size(75, 18);
            label9.TabIndex = 1;
            label9.Text = "Asignado a";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_llamada_de_conferencia_48;
            pictureBox2.Location = new Point(23, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.White;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(154, 400);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(243, 28);
            cmbEstado.TabIndex = 14;
            cmbEstado.SelectedIndexChanged += cmbEstado_SelectedIndexChanged;
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.BackColor = Color.White;
            cmbPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrioridad.Enabled = false;
            cmbPrioridad.FormattingEnabled = true;
            cmbPrioridad.Location = new Point(154, 291);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(243, 28);
            cmbPrioridad.TabIndex = 13;
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.White;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.Enabled = false;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(154, 240);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(243, 28);
            cmbCategoria.TabIndex = 12;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(154, 349);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(85, 18);
            lblFecha.TabIndex = 11;
            lblFecha.Text = "detalle aquí.";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(154, 195);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(85, 18);
            lblDescripcion.TabIndex = 10;
            lblDescripcion.Text = "detalle aquí.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(42, 405);
            label8.Name = "label8";
            label8.Size = new Size(53, 18);
            label8.TabIndex = 9;
            label8.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(42, 349);
            label7.Name = "label7";
            label7.Size = new Size(88, 18);
            label7.TabIndex = 8;
            label7.Text = "Fecha límite:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(42, 296);
            label6.Name = "label6";
            label6.Size = new Size(69, 18);
            label6.TabIndex = 7;
            label6.Text = "Prioridad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(42, 245);
            label5.Name = "label5";
            label5.Size = new Size(71, 18);
            label5.TabIndex = 6;
            label5.Text = "Categoría:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(42, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(626, 68);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 12);
            label3.Name = "label3";
            label3.Size = new Size(456, 42);
            label3.TabIndex = 1;
            label3.Text = "Tarea asignada por el administrador. Puedes cambiar el estado \r\ny agregar notas.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_información_50;
            pictureBox1.Location = new Point(18, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 38);
            label2.Name = "label2";
            label2.Size = new Size(170, 28);
            label2.TabIndex = 4;
            label2.Text = "Título de Tarea...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(42, 195);
            label4.Name = "label4";
            label4.Size = new Size(84, 18);
            label4.TabIndex = 3;
            label4.Text = "Descripción:";
            // 
            // FTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 30);
            ClientSize = new Size(1350, 850);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FTareas";
            Text = "FTareas";
            Load += FTareas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelButtons.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNuevaTarea;
        private Label label1;
        private RadioButton radTodas;
        private RadioButton radPendientes;
        private RadioButton radEnCurso;
        private RadioButton radCompletadas;
        private GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label label2;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblFecha;
        private Label lblDescripcion;
        private Panel panel4;
        private Label label9;
        private PictureBox pictureBox2;
        private ComboBox cmbEstado;
        private ComboBox cmbPrioridad;
        private ComboBox cmbCategoria;
        private Panel panel5;
        private Label lblAsignadoA;
        private Panel panelButtons;
        private Button btnEliminar;
        private Button btnEditar;
    }
}