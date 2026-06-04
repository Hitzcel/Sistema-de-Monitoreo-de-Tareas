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
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.PasswordChar = '●';
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ClsEstilosUI.BtnImagenNormal(btnOcultar, btnMostrar);
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.PasswordChar = '\0';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuarioValido = "admin@gmail.com";
            string passwordValida = "1234";

            if (txtUsuario.Text == usuarioValido && txtPassword.Text == passwordValida)
            {
                MessageBox.Show("¡Bienvenido!", "Acceso correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                FPrincipal principal = new FPrincipal();
                principal.ShowDialog();
                this.Close();

            }
            else if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Por favor llena todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.ForeColor = Color.Gray;
            
        }



        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña...")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '●';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.ForeColor = Color.Gray;
                txtPassword.Text = "Contraseña...";
            }
        }
    }
}
