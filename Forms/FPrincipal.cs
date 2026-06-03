using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskNotes_MonitoreoTareas.Forms
{
    public partial class FPrincipal : Form
    {
        private Label itemActivo;
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
            ConfigurarSidebar();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            // Resetear todos
            foreach (Control c in panelSidebar.Controls)
                if (c is Label l && l.Tag?.ToString() == "menuItem")
                {
                    l.ForeColor = Color.FromArgb(180, 180, 180);
                    l.BackColor = Color.Transparent;
                }

            Label clicked = (Label)sender;
            clicked.ForeColor = Color.White;
            //clicked.BackColor = Color.FromArgb(50, 50, 58);
            itemActivo = clicked;
            panelSidebar.Invalidate();  
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
