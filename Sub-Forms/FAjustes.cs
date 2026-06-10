using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskNotes_MonitoreoTareas.Modelos;

namespace TaskNotes_MonitoreoTareas.Sub_Forms
{
    public partial class FAjustes : Form
    {
        public FAjustes()
        {
            InitializeComponent();
        }

        private void FAjustes_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            Usuario u = DatosApp.UsuarioActual;
            if (u == null) return;

            // Iniciales en el avatar
            string[] partes = u.Nombre.Split(' ');
            string iniciales = partes.Length >= 2
                ? $"{partes[0][0]}{partes[1][0]}"
                : $"{partes[0][0]}";
            label6.Text = iniciales.ToUpper();

            // Nombre y rol en el header del perfil
            lblNombreUsuario.Text = u.Nombre;
            lblNombre.Text = u.Nombre;
            lblCorreo.Text = u.Correo;
            lblEmail.Text = u.Correo;
            lblTelefono.Text = string.IsNullOrEmpty(u.Telefono) ? "No especificado" : u.Telefono;
            lblPassword.Text = "••••••••";
        }

        private void btnEditarCorreo_Click(object sender, EventArgs e)
        {
            string nuevoCorreo = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingresa tu nuevo correo:", "Editar correo", DatosApp.UsuarioActual.Correo);

            if (!string.IsNullOrEmpty(nuevoCorreo))
            {
                DatosApp.UsuarioActual.Correo = nuevoCorreo;
                CargarDatosUsuario();
            }
        }

        private void btnEditarTelefono_Click(object sender, EventArgs e)
        {
            string nuevoTel = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingresa tu nuevo teléfono:", "Editar teléfono", DatosApp.UsuarioActual.Telefono);

            if (!string.IsNullOrEmpty(nuevoTel))
            {
                DatosApp.UsuarioActual.Telefono = nuevoTel;
                CargarDatosUsuario();
            }
        }

        private void btnEditarPassword_Click(object sender, EventArgs e)
        {
            string actual = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingresa tu contraseña actual:", "Cambiar contraseña", "");

            if (actual != DatosApp.UsuarioActual.Contrasena)
            {
                MessageBox.Show("Contraseña incorrecta.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nueva = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingresa tu nueva contraseña:", "Cambiar contraseña", "");

            if (!string.IsNullOrEmpty(nueva))
            {
                DatosApp.UsuarioActual.Contrasena = nueva;
                MessageBox.Show("Contraseña actualizada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "¿Estás seguro que deseas cerrar sesión?",
                "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                DatosApp.UsuarioActual = null;
                Application.Restart();
            }
        }
    }
}
