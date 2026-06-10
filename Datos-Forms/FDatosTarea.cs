using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskNotes_MonitoreoTareas.Datos_Forms
{
    public partial class FDatosTarea : Form
    {
        public FDatosTarea()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FDatosTarea_Load(object sender, EventArgs e)
        {

        }
    }
}
