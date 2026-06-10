using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskNotes_MonitoreoTareas.Datos_Forms;

namespace TaskNotes_MonitoreoTareas.Sub_Forms
{
    public partial class FTareas : Form
    {
        public FTareas()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            FDatosTarea tarea = new FDatosTarea();
            tarea.ShowDialog();
        }
    }
}
