using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;

namespace TaskNotes_MonitoreoTareas.Clases
{
    public class RoundPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath grpath = new GraphicsPath();
            grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(grpath);
            base.OnPaint(pe);
        }
    }
}
