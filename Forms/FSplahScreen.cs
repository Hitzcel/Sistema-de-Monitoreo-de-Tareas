using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskNotes_MonitoreoTareas.Forms;

namespace TaskNotes_MonitoreoTareas
{
    
    public partial class FSplahScreen : Form
    {
        private int carga = 0;
        

        public FSplahScreen()
        {
            InitializeComponent();
            lblCarga.Text = "Iniciando...";
            this.ShowInTaskbar = false; 

            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerCarga.Start();
        }

        private void timerCarga_Tick(object sender, EventArgs e)
        {
            carga += 2;
            barraCarga.Value = carga;

            if (barraCarga.Value > 90)
            {
                lblCarga.Text = "Abriendo...";
            }

            if (barraCarga.Value == 100)
            {
                barraCarga.Value = 0;
                timerCarga.Stop();
                this.Hide();

                FLogin login = new FLogin();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
