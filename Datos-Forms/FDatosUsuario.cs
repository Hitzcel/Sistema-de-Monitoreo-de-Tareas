using System;
using System.Linq;
using System.Windows.Forms;
using TaskNotes_MonitoreoTareas.Modelos;

namespace TaskNotes_MonitoreoTareas.Datos_Forms
{
    public partial class FDatosUsuario : Form
    {
        public FDatosUsuario()
        {
            InitializeComponent();
            cmbRol.Items.AddRange(new string[] { "Admin", "Empleado" });
            cmbEstado.Items.AddRange(new string[] { "Activo", "Inactivo" });
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            string nombre = txtPrimerNombre.Text.Trim();
            string apellido = txtPrimerApellido.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(correo) || cmbRol.SelectedIndex == -1 ||
                cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor completa todos los campos.",
                    "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DatosApp.Usuarios.Any(u => u.Correo == correo))
            {
                MessageBox.Show("Ya existe un usuario con ese correo.",
                    "Correo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario nuevo = new Usuario
            {
                Id = DatosApp.Usuarios.Count + 1,
                Nombre = $"{nombre} {apellido}",
                Correo = correo,
                Telefono = telefono,
                Contrasena = "tasknotes123", // contraseña por defecto
                Rol = cmbRol.SelectedItem.ToString(),
                Estado = cmbEstado.SelectedItem.ToString()
            };

            DatosApp.Usuarios.Add(nuevo);
            MessageBox.Show($"Usuario '{nuevo.Nombre}' creado correctamente.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}