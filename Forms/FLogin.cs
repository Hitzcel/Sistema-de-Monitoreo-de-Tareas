using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskNotes_MonitoreoTareas.Clases;

namespace TaskNotes_MonitoreoTareas.Forms
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            btnMostrar.Visible = false;
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

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            ClsEstilosUI.BtnImagenHover(btnOcultar, btnMostrar);
            txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ClsEstilosUI.BtnImagenNormal(btnOcultar, btnMostrar);
            txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }
    }
}
