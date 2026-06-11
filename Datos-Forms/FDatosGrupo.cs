using System;
using System.Linq;
using System.Windows.Forms;
using TaskNotes_MonitoreoTareas.Modelos;

namespace TaskNotes_MonitoreoTareas.Datos_Forms
{
    public partial class FDatosGrupo : Form
    {
        public FDatosGrupo()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            chkListUsuario.Items.Clear();
            foreach (var usuario in DatosApp.Usuarios.Where(u => u.Estado == "Activo"))
            {
                chkListUsuario.Items.Add(usuario);
            }
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Escribe un nombre para el grupo.",
                    "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chkListUsuario.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selecciona al menos un usuario.",
                    "Sin miembros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Grupo nuevo = new Grupo
            {
                Id = DatosApp.Grupos.Count + 1,
                Nombre = nombre
            };

            foreach (var item in chkListUsuario.CheckedItems)
            {
                nuevo.Miembros.Add((Usuario)item);
            }

            DatosApp.Grupos.Add(nuevo);
            MessageBox.Show($"Grupo '{nuevo.Nombre}' creado con {nuevo.Miembros.Count} miembro(s).",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}