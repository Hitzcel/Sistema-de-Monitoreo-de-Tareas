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
    public partial class FTareas : Form
    {
        private string _rol;
        private Tarea _tareaSeleccionada;


        public FTareas(string rol)
        {
            InitializeComponent();
            _rol = rol;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            FDatosTarea fDatos = new FDatosTarea();
            fDatos.ShowDialog();
            CargarTareas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_tareaSeleccionada == null)
            {
                MessageBox.Show("Selecciona una tarea primero.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FDatosTarea fDatos = new FDatosTarea(_tareaSeleccionada);
            fDatos.ShowDialog();
            CargarTareas();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_tareaSeleccionada == null)
            {
                MessageBox.Show("Selecciona una tarea primero.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"¿Eliminar la tarea '{_tareaSeleccionada.Titulo}'?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                DatosApp.Tareas.Remove(_tareaSeleccionada);
                _tareaSeleccionada = null;
                label2.Text = "Título de Tarea...";
                lblDescripcion.Text = "detalle aquí.";
                lblFecha.Text = "detalle aquí.";
                lblAsignadoA.Text = "detalle aquí.";
                CargarTareas();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FTareas_Load(object sender, EventArgs e)
        {
            ConfigurarSegunRol();
            ConfigurarComboBoxes();
            ConfigurarFiltros();
            CargarTareas();
            radTodas.Checked = true;

        }


        private void ConfigurarSegunRol()
        {
            bool esAdmin = _rol == "Admin";
            btnNuevaTarea.Visible = esAdmin;
            btnEditar.Visible = esAdmin;
            btnEliminar.Visible = esAdmin;
            cmbCategoria.Enabled = esAdmin;
            cmbPrioridad.Enabled = esAdmin;
            panel3.Visible = !esAdmin; // aviso "tarea asignada por admin"
        }

        private void ConfigurarComboBoxes()
        {
            cmbCategoria.Items.AddRange(new string[] { "Trabajo", "Personal", "Estudio" });
            cmbPrioridad.Items.AddRange(new string[] { "Alta", "Media", "Baja" });
            cmbEstado.Items.AddRange(new string[] { "Pendiente", "En progreso", "Completada" });
        }

        private void ConfigurarFiltros()
        {
            radTodas.CheckedChanged += Filtro_Changed;
            radPendientes.CheckedChanged += Filtro_Changed;
            radEnCurso.CheckedChanged += Filtro_Changed;
            radCompletadas.CheckedChanged += Filtro_Changed;
        }


        private void Filtro_Changed(object sender, EventArgs e)
        {
            CargarTareas();
        }

        private void CargarTareas()
        {
            flowLayoutPanel1.Controls.Clear();

            var tareas = DatosApp.Tareas.AsEnumerable();

            // filtrar por rol
            if (_rol != "Admin")
            {
                string nombreActual = DatosApp.UsuarioActual?.Nombre;
                tareas = tareas.Where(t => t.AsignadoA == nombreActual ||
                    DatosApp.Grupos.Any(g => g.Nombre == t.AsignadoA &&
                        g.Miembros.Any(m => m.Nombre == nombreActual)));
            }

            // filtrar por estado
            if (radPendientes.Checked)
                tareas = tareas.Where(t => t.Estado == "Pendiente");
            else if (radEnCurso.Checked)
                tareas = tareas.Where(t => t.Estado == "En progreso");
            else if (radCompletadas.Checked)
                tareas = tareas.Where(t => t.Estado == "Completada");

            foreach (var tarea in tareas)
                flowLayoutPanel1.Controls.Add(flowLayoutPanel1(tarea));
        }

        private Panel CrearCardTarea(Tarea tarea)
        {
            Panel card = new Panel
            {
                Width = flowLayoutPanel1.Width - 20,
                Height = 80,
                BackColor = Color.FromArgb(40, 40, 42),
                Margin = new Padding(5),
                Cursor = Cursors.Hand,
                Tag = tarea
            };

            Label lblTitulo = new Label
            {
                Text = tarea.Titulo,
                Font = new Font("Calibri", 10f, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(12, 10),
                AutoSize = true
            };

            Label lblCategoria = new Label
            {
                Text = tarea.Categoria,
                Font = new Font("Calibri", 8f),
                ForeColor = Color.FromArgb(232, 168, 56),
                Location = new Point(12, 40),
                AutoSize = true
            };

            Label lblFechaCard = new Label
            {
                Text = tarea.FechaLimite.ToString("dd/MM/yyyy"),
                Font = new Font("Calibri", 8f),
                ForeColor = tarea.FechaLimite.Date == DateTime.Today
                    ? Color.FromArgb(216, 90, 48)
                    : Color.Gray,
                Location = new Point(card.Width - 90, 40),
                AutoSize = true
            };

            card.Controls.Add(lblTitulo);
            card.Controls.Add(lblCategoria);
            card.Controls.Add(lblFechaCard);

            card.Click += (s, e) => MostrarDetalle(tarea);
            lblTitulo.Click += (s, e) => MostrarDetalle(tarea);
            lblCategoria.Click += (s, e) => MostrarDetalle(tarea);
            lblFechaCard.Click += (s, e) => MostrarDetalle(tarea);

            return card;
        }

        private void MostrarDetalle(Tarea tarea)
        {
            _tareaSeleccionada = tarea;

            label2.Text = tarea.Titulo;
            lblDescripcion.Text = tarea.Descripcion;
            lblFecha.Text = tarea.FechaLimite.ToString("dd 'de' MMMM, yyyy");
            lblAsignadoA.Text = tarea.AsignadoA;

            cmbCategoria.SelectedItem = tarea.Categoria;
            cmbPrioridad.SelectedItem = tarea.Prioridad;
            cmbEstado.SelectedItem = tarea.Estado;
        }


    }
}
