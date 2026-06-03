using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace TaskNotes_MonitoreoTareas.Clases
{
    public class UIProgressBar : ProgressBar
    {
        public UIProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;
            Graphics g = e.Graphics;

            // Fondo
            g.FillRectangle(new SolidBrush(Color.FromArgb(44, 44, 46)), rect);

            // Calcular el ancho del progreso
            if (this.Maximum > 0)
            {
                double percent = (double)this.Value / this.Maximum;
                int fillWidth = (int)(rect.Width * percent);

                Rectangle fillRect = new Rectangle(0, 0, fillWidth, rect.Height);

                // Color dorado igual al de tu app
                g.FillRectangle(new SolidBrush(Color.FromArgb(232, 168, 56)), fillRect);
            }
        }
    }
}
