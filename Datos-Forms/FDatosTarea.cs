using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskNotes_MonitoreoTareas.Modelos;

namespace TaskNotes_MonitoreoTareas.Datos_Forms
{
    public partial class FDatosTarea : Form
    {
        private Tarea _tareaEditar;


        public FDatosTarea()
        {
            InitializeComponent();
            _tareaEditar = null;
        }

        public FDatosTarea(Tarea tareaSeleccionada)
        {
            InitializeComponent();
            _tareaEditar = tareaSeleccionada;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FDatosTarea_Load(object sender, EventArgs e)
        {
            // Llenar combos
            cmbCategoria.Items.AddRange(new string[] { "Trabajo", "Personal", "Estudio" });
            cmbPrioridad.Items.AddRange(new string[] { "Alta", "Media", "Baja" });

            // Llenar asignar a: usuarios y grupos
            cmbAsignarA.Items.Clear();
            foreach (var u in DatosApp.Usuarios.Where(u => u.Estado == "Activo"))
                cmbAsignarA.Items.Add(u.Nombre);
            foreach (var g in DatosApp.Grupos)
                cmbAsignarA.Items.Add(g.Nombre);

            // Si es edición, cargar datos existentes
            if (_tareaEditar != null)
            {
                txtTitulo.Text = _tareaEditar.Titulo;
                txtDescripcion.Text = _tareaEditar.Descripcion;
                cmbCategoria.SelectedItem = _tareaEditar.Categoria;
                cmbPrioridad.SelectedItem = _tareaEditar.Prioridad;
                dtpFechaLimite.Value = _tareaEditar.FechaLimite;
                cmbAsignarA.SelectedItem = _tareaEditar.AsignadoA;
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitulo.Text.Trim()) ||
                cmbCategoria.SelectedIndex == -1 ||
                cmbPrioridad.SelectedIndex == -1 ||
                cmbAsignarA.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor completa todos los campos.",
                    "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_tareaEditar == null)
            {
                // Nueva tarea
                Tarea nueva = new Tarea
                {
                    Id = DatosApp.Tareas.Count + 1,
                    Titulo = txtTitulo.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim(),
                    Categoria = cmbCategoria.SelectedItem.ToString(),
                    Prioridad = cmbPrioridad.SelectedItem.ToString(),
                    FechaLimite = dtpFechaLimite.Value,
                    AsignadoA = cmbAsignarA.SelectedItem.ToString(),
                    CreadaPorId = DatosApp.UsuarioActual.Id
                };
                DatosApp.Tareas.Add(nueva);
                MessageBox.Show("Tarea creada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Editar tarea existente
                _tareaEditar.Titulo = txtTitulo.Text.Trim();
                _tareaEditar.Descripcion = txtDescripcion.Text.Trim();
                _tareaEditar.Categoria = cmbCategoria.SelectedItem.ToString();
                _tareaEditar.Prioridad = cmbPrioridad.SelectedItem.ToString();
                _tareaEditar.FechaLimite = dtpFechaLimite.Value;
                _tareaEditar.AsignadoA = cmbAsignarA.SelectedItem.ToString();
                MessageBox.Show("Tarea actualizada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }
    }
}
