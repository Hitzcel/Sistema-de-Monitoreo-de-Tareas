namespace TaskNotes_MonitoreoTareas.Sub_Forms
{
    partial class FUsuarios
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
            label1 = new Label();
            tabControl1 = new TabControl();
            tabUsuarios = new TabPage();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtBuscarUsuario = new TextBox();
            btnNuevoUsuario = new Button();
            dataGridView1 = new DataGridView();
            tabGrupos = new TabPage();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            txtBuscarGrupo = new TextBox();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            tabControl1.SuspendLayout();
            tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabGrupos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(34, 58);
            label1.Name = "label1";
            label1.Size = new Size(163, 24);
            label1.TabIndex = 0;
            label1.Text = "Usuarios y Grupos";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabUsuarios);
            tabControl1.Controls.Add(tabGrupos);
            tabControl1.Location = new Point(34, 111);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1262, 725);
            tabControl1.TabIndex = 2;
            // 
            // tabUsuarios
            // 
            tabUsuarios.BackColor = Color.FromArgb(247, 247, 245);
            tabUsuarios.Controls.Add(panel1);
            tabUsuarios.Controls.Add(pictureBox1);
            tabUsuarios.Controls.Add(txtBuscarUsuario);
            tabUsuarios.Controls.Add(btnNuevoUsuario);
            tabUsuarios.Controls.Add(dataGridView1);
            tabUsuarios.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabUsuarios.Location = new Point(4, 29);
            tabUsuarios.Name = "tabUsuarios";
            tabUsuarios.Padding = new Padding(3);
            tabUsuarios.Size = new Size(1254, 692);
            tabUsuarios.TabIndex = 0;
            tabUsuarios.Text = "Usuarios";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 28, 30);
            panel1.Location = new Point(45, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 10);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_búsqueda_50;
            pictureBox1.Location = new Point(649, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarUsuario.BackColor = Color.FromArgb(247, 247, 245);
            txtBuscarUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarUsuario.Font = new Font("Calibri", 9F);
            txtBuscarUsuario.Location = new Point(45, 37);
            txtBuscarUsuario.Multiline = true;
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.PlaceholderText = "Buscar usuario...";
            txtBuscarUsuario.Size = new Size(587, 33);
            txtBuscarUsuario.TabIndex = 3;
            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.BackColor = Color.FromArgb(28, 28, 30);
            btnNuevoUsuario.FlatAppearance.BorderColor = Color.FromArgb(28, 28, 30);
            btnNuevoUsuario.FlatStyle = FlatStyle.Flat;
            btnNuevoUsuario.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoUsuario.ForeColor = SystemColors.ButtonHighlight;
            btnNuevoUsuario.Image = Properties.Resources.icons8_más_24__1_;
            btnNuevoUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoUsuario.Location = new Point(513, 596);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(195, 51);
            btnNuevoUsuario.TabIndex = 2;
            btnNuevoUsuario.Text = "Nuevo Usuario";
            btnNuevoUsuario.UseVisualStyleBackColor = false;
            btnNuevoUsuario.Click += btnNuevoUsuario_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1151, 471);
            dataGridView1.TabIndex = 0;
            // 
            // tabGrupos
            // 
            tabGrupos.Controls.Add(panel2);
            tabGrupos.Controls.Add(pictureBox2);
            tabGrupos.Controls.Add(txtBuscarGrupo);
            tabGrupos.Controls.Add(button1);
            tabGrupos.Controls.Add(dataGridView2);
            tabGrupos.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabGrupos.Location = new Point(4, 29);
            tabGrupos.Name = "tabGrupos";
            tabGrupos.Padding = new Padding(3);
            tabGrupos.Size = new Size(1254, 692);
            tabGrupos.TabIndex = 1;
            tabGrupos.Text = "Grupos";
            tabGrupos.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(28, 28, 30);
            panel2.Location = new Point(52, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(587, 10);
            panel2.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_búsqueda_50;
            pictureBox2.Location = new Point(656, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // txtBuscarGrupo
            // 
            txtBuscarGrupo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarGrupo.BackColor = Color.FromArgb(247, 247, 245);
            txtBuscarGrupo.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarGrupo.Font = new Font("Calibri", 9F);
            txtBuscarGrupo.Location = new Point(52, 41);
            txtBuscarGrupo.Multiline = true;
            txtBuscarGrupo.Name = "txtBuscarGrupo";
            txtBuscarGrupo.PlaceholderText = "Buscar grupo...";
            txtBuscarGrupo.Size = new Size(587, 33);
            txtBuscarGrupo.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 28, 30);
            button1.FlatAppearance.BorderColor = Color.FromArgb(28, 28, 30);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.icons8_más_24__1_;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(520, 600);
            button1.Name = "button1";
            button1.Size = new Size(195, 51);
            button1.TabIndex = 7;
            button1.Text = "Nuevo Grupo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(52, 100);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1151, 471);
            dataGridView2.TabIndex = 6;
            // 
            // FUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 30);
            ClientSize = new Size(1350, 850);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FUsuarios";
            Text = "FUsuarios";
            tabControl1.ResumeLayout(false);
            tabUsuarios.ResumeLayout(false);
            tabUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabGrupos.ResumeLayout(false);
            tabGrupos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabUsuarios;
        private TabPage tabGrupos;
        private DataGridView dataGridView1;
        private Button btnNuevoUsuario;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtBuscarUsuario;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtBuscarGrupo;
        private Button button1;
        private DataGridView dataGridView2;
    }
}