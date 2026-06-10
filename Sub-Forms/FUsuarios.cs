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
    public partial class FUsuarios : Form
    {
        public FUsuarios()
        {
            InitializeComponent();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FDatosUsuario usuario = new FDatosUsuario();
            usuario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FDatosGrupo grupo = new FDatosGrupo();
            grupo.ShowDialog();
        }
    }
}
