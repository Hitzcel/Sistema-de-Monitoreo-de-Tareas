using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskNotes_MonitoreoTareas.Sub_Forms;

namespace TaskNotes_MonitoreoTareas.Forms
{
    public partial class FPrincipal : Form
    {
        private Label itemActivo;
        private Dictionary<string, Form> screens = new Dictionary<string, Form>();
        public FPrincipal()
        {
            InitializeComponent();
            panelSidebar.Paint += (s, e) =>
            {
                if (itemActivo != null)
                {
                    e.Graphics.FillRectangle(
                        new SolidBrush(Color.FromArgb(232, 168, 56)),
                        new Rectangle(0, itemActivo.Top, 4, itemActivo.Height)
                    );
                }
            };
        } 

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            screens.Add("Dashboard", new FDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            screens.Add("Tareas", new FTareas() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            screens.Add("Notificaciones", new FNotificaciones() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            screens.Add("Ajustes", new FAjustes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true });
            
            ConfigurarSidebar();
        }

        private void loadPanel(string iTitle)
        {
            Form iForm = screens[iTitle];
            this.panelLoad.Controls.Clear();
            this.panelLoad.Controls.Add(iForm);
            iForm.Show();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            foreach (Label l in new Label[] { lblDashboard, lblTareas, lblNotificaciones, lblAjustes })
            {
                l.ForeColor = Color.FromArgb(180, 180, 180);
                l.BackColor = Color.Transparent;
            }

            Label clicked = (Label)sender;
            clicked.ForeColor = Color.White;
            itemActivo = clicked;
            panelSidebar.Invalidate();

            if (clicked == lblDashboard) loadPanel("Dashboard");
            else if (clicked == lblTareas) loadPanel("Tareas");
            else if (clicked == lblNotificaciones) loadPanel("Notificaciones");
            else if (clicked == lblAjustes) loadPanel("Ajustes");
        }

        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl != itemActivo)
                lbl.BackColor = Color.FromArgb(28, 28, 30);
        }

        private void MenuItem_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            if (lbl != itemActivo)
                lbl.BackColor = Color.Transparent;
        }

        private void ConfigurarSidebar()
        {
            //panelSidebar.BackColor = Color.FromArgb(30, 30, 35);
            panelSidebar.Width = 180;
            panelSidebar.Dock = DockStyle.Left;

            Label[] items = { lblDashboard, lblTareas, lblNotificaciones, lblAjustes };

            foreach (Label lbl in items)
            {
                lbl.ForeColor = Color.FromArgb(180, 180, 180);
                lbl.Font = new Font("Calibri", 11f);
                lbl.Cursor = Cursors.Hand;
                lbl.TextAlign = ContentAlignment.MiddleLeft; 
                lbl.Padding = new Padding(20, 0, 0, 0);
                lbl.Height = 40;
                lbl.Width = panelSidebar.Width;            
                lbl.AutoSize = false;                        
                lbl.MouseEnter += MenuItem_MouseEnter;
                lbl.MouseLeave += MenuItem_MouseLeave;
                lbl.Click += MenuItem_Click;
            }

            MenuItem_Click(lblDashboard, EventArgs.Empty);
        }
    }
}
