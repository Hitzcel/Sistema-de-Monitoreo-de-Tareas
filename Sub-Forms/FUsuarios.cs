using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskNotes_MonitoreoTareas.Datos_Forms;
using TaskNotes_MonitoreoTareas.Modelos;

namespace TaskNotes_MonitoreoTareas.Sub_Forms
{
    public partial class FUsuarios : Form
    {
        public FUsuarios()
        {
            InitializeComponent();
        }

        private void FUsuarios_Load(object sender, EventArgs e)
        {
            ConfigurarColumnasDGVUsuarios();
            ConfigurarColumnasDGVGrupos();
            CargarUsuarios();
            CargarGrupos();
        }

        private void CargarUsuarios()
        {
            dgvUsuario.Rows.Clear();
            foreach (var u in DatosApp.Usuarios)
            {
                dgvUsuario.Rows.Add(u.Id, u.Nombre, u.Correo, u.Rol, u.Estado);
            }
        }

        private void CargarGrupos()
        {
            dgvGrupo.Rows.Clear();
            foreach (var g in DatosApp.Grupos)
            {
                dgvGrupo.Rows.Add(g.Id, g.Nombre, g.Miembros.Count,
                    g.FechaCreacion.ToString("dd/MM/yyyy"));
            }
        }

        private void ConfigurarColumnasDGVUsuarios()
        {
            dgvUsuario.Columns.Clear();
            dgvUsuario.Columns.Add("Id", "ID");
            dgvUsuario.Columns.Add("Nombre", "Nombre");
            dgvUsuario.Columns.Add("Correo", "Correo");
            dgvUsuario.Columns.Add("Rol", "Rol");
            dgvUsuario.Columns.Add("Estado", "Estado");

            dgvUsuario.Columns["Id"].Width = 50;
            dgvUsuario.Columns["Nombre"].Width = 200;
            dgvUsuario.Columns["Correo"].Width = 250;
            dgvUsuario.Columns["Rol"].Width = 100;
            dgvUsuario.Columns["Estado"].Width = 100;

            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuario.ReadOnly = true;
            dgvUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuario.AllowUserToAddRows = false;
        }

        private void ConfigurarColumnasDGVGrupos()
        {
            dgvGrupo.Columns.Clear();
            dgvGrupo.Columns.Add("Id", "ID");
            dgvGrupo.Columns.Add("Nombre", "Nombre");
            dgvGrupo.Columns.Add("Miembros", "Miembros");
            dgvGrupo.Columns.Add("FechaCreacion", "Fecha de creación");

            dgvGrupo.Columns["Id"].Width = 50;
            dgvGrupo.Columns["Nombre"].Width = 200;
            dgvGrupo.Columns["Miembros"].Width = 100;
            dgvGrupo.Columns["FechaCreacion"].Width = 150;

            dgvGrupo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrupo.ReadOnly = true;
            dgvGrupo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrupo.AllowUserToAddRows = false;
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscarUsuario.Text.Trim().ToLower();
            dgvUsuario.Rows.Clear();
            var filtrados = DatosApp.Usuarios
                .Where(u => u.Nombre.ToLower().Contains(busqueda) ||
                            u.Correo.ToLower().Contains(busqueda));
            foreach (var u in filtrados)
                dgvUsuario.Rows.Add(u.Id, u.Nombre, u.Correo, u.Rol, u.Estado);
        }

        private void txtBuscarGrupo_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscarGrupo.Text.Trim().ToLower();
            dgvGrupo.Rows.Clear();
            var filtrados = DatosApp.Grupos
                .Where(g => g.Nombre.ToLower().Contains(busqueda));
            foreach (var g in filtrados)
                dgvGrupo.Rows.Add(g.Id, g.Nombre, g.Miembros.Count,
                    g.FechaCreacion.ToString("dd/MM/yyyy"));
        }

        private void btnNuevoGrupo_Click(object sender, EventArgs e)
        {
            FDatosGrupo fGrupo = new FDatosGrupo();
            fGrupo.ShowDialog();
            CargarGrupos();
        }

        private void btnNuevoUsuario_Click_1(object sender, EventArgs e)
        {
            FDatosUsuario fDatos = new FDatosUsuario();
            fDatos.ShowDialog();
            CargarUsuarios();
        }
    }
}
