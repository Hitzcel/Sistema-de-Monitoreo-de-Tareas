using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskNotes_MonitoreoTareas.Forms
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void lblRecuperar_MouseEnter(object sender, EventArgs e)
        {
            lblRecuperar.Font = new Font(lblRecuperar.Font.FontFamily, 10, FontStyle.Underline | FontStyle.Bold);
        }

        private void lblRecuperar_MouseLeave(object sender, EventArgs e)
        {
            lblRecuperar.Font = new Font(lblRecuperar.Font.FontFamily, 9, FontStyle.Regular | FontStyle.Bold);
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
