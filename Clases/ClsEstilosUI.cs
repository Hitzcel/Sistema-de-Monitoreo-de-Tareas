using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNotes_MonitoreoTareas.Clases
{
    public class ClsEstilosUI
    {
        //Por si se usan imágenes de botones diseñados fuera de visual y se requiere que funcionen como botones normales
        public static void BtnImagenHover(PictureBox imagenNormal, PictureBox imagenHover)
        {
            imagenNormal.Visible = false;
            imagenHover.Visible = true;
        }

        public static void BtnImagenNormal(PictureBox imagenNormal, PictureBox imagenHover)
        {
            imagenNormal.Visible = true;
            imagenHover.Visible = false;
        }
    }
}
