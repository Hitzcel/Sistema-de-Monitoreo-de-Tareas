using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskNotes_MonitoreoTareas.Clases;
using TaskNotes_MonitoreoTareas.Modelos;

namespace TaskNotes_MonitoreoTareas.Sub_Forms
{
    public partial class FDashboard : Form
    {
        public FDashboard()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void CargarEstadisticas()
        {
            var misTareas = DatosApp.UsuarioActual.Rol == "Admin"
                ? DatosApp.Tareas.AsEnumerable()
                : DatosApp.Tareas.Where(t =>
                    t.AsignadoA == DatosApp.UsuarioActual.Nombre ||
                    DatosApp.Grupos.Any(g => g.Nombre == t.AsignadoA &&
                        g.Miembros.Any(m => m.Nombre == DatosApp.UsuarioActual.Nombre)));

            label4.Text = misTareas.Count().ToString();
            label5.Text = misTareas.Count(t => t.Estado == "Pendiente").ToString();
            label8.Text = misTareas.Count(t => t.Estado == "En progreso").ToString();
            label11.Text = misTareas.Count(t => t.Estado == "Completada").ToString();
        }

        private void CargarTareasRecientes()
        {
            flowTareas.Controls.Clear();
            flowTareas.FlowDirection = FlowDirection.TopDown;
            flowTareas.WrapContents = false;
            flowTareas.AutoScroll = true;

            var tareas = DatosApp.UsuarioActual.Rol == "Admin"
            ? DatosApp.Tareas.OrderBy(t => t.FechaLimite).Take(5)
            : DatosApp.Tareas
                .Where(t => t.AsignadoA == DatosApp.UsuarioActual.Nombre ||
                    DatosApp.Grupos.Any(g => g.Nombre == t.AsignadoA &&
                        g.Miembros.Any(m => m.Nombre == DatosApp.UsuarioActual.Nombre)))
                .OrderBy(t => t.FechaLimite)
                .Take(5);

            foreach (var t in tareas)
            {
                string fecha = t.FechaLimite.Date == DateTime.Today ? "Hoy" :
                               t.FechaLimite.Date == DateTime.Today.AddDays(1) ? "Mañana" :
                               t.FechaLimite.ToString("ddd dd");

                int progreso = t.Estado == "Completada" ? 100 :
                               t.Estado == "En progreso" ? 50 : 0;

                flowTareas.Controls.Add(CrearTarjetaTarea(t.Titulo, t.Categoria, fecha, progreso));
            }
        }

        private Panel CrearTarjetaTarea(string nombre, string categoria, string fecha, int progreso)
        {
            Panel card = new Panel
            {
                Width = flowTareas.Width - 20,
                Height = 70,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 8),
                Padding = new Padding(10)
            };

            Label lblNombre = new Label
            {
                Text = nombre,
                Font = new Font("Calibri", 10f, FontStyle.Bold),
                Location = new Point(10, 8),
                AutoSize = true
            };

            Label lblCat = new Label
            {
                Text = categoria,
                Font = new Font("Calibri", 8f),
                ForeColor = Color.Gray,
                Location = new Point(10, 30),
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblFecha = new Label
            {
                Text = fecha,
                Font = new Font("Calibri", 8f),
                ForeColor = fecha == "Hoy" ? Color.Red : Color.Gray,
                Location = new Point(card.Width - 60, 30),
                AutoSize = true
            };

            UIProgressBar bar = new UIProgressBar
            {
                Location = new Point(10, 52),
                Width = card.Width - 20,
                Height = 6,
                Minimum = 0,
                Maximum = 100,
                Value = progreso
            };

            card.Controls.AddRange(new Control[] { lblNombre, lblCat, lblFecha, bar });
            return card;
        }

        private void CargarProximasFechas()
        {
            flowFechas.Controls.Clear();
            flowFechas.FlowDirection = FlowDirection.TopDown;
            flowFechas.WrapContents = false;
            flowFechas.AutoScroll = true;
            flowFechas.Padding = new Padding(8);

            var proximas = DatosApp.UsuarioActual.Rol == "Admin"
             ? DatosApp.Tareas
                 .Where(t => t.FechaLimite.Date >= DateTime.Today)
                 .OrderBy(t => t.FechaLimite)
                 .Take(5)
             : DatosApp.Tareas
                 .Where(t => t.FechaLimite.Date >= DateTime.Today &&
                     (t.AsignadoA == DatosApp.UsuarioActual.Nombre ||
                     DatosApp.Grupos.Any(g => g.Nombre == t.AsignadoA &&
                         g.Miembros.Any(m => m.Nombre == DatosApp.UsuarioActual.Nombre))))
                 .OrderBy(t => t.FechaLimite)
                 .Take(5);

            foreach (var t in proximas)
            {
                string etiqueta = t.FechaLimite.Date == DateTime.Today ? "Hoy" :
                                  t.FechaLimite.Date == DateTime.Today.AddDays(1) ? "Mañana" :
                                  t.FechaLimite.ToString("ddd dd");

                Color color = t.FechaLimite.Date == DateTime.Today
                    ? Color.FromArgb(255, 200, 200)
                    : t.FechaLimite.Date == DateTime.Today.AddDays(1)
                    ? Color.FromArgb(255, 235, 180)
                    : Color.FromArgb(200, 220, 255);

                flowFechas.Controls.Add(CrearFilaFecha(etiqueta, color, t.Titulo));
            }
        }

        private Panel CrearFilaFecha(string etiqueta, Color colorEtiqueta, string texto)
        {
            Panel fila = new Panel
            {
                Width = flowFechas.Width - 20,
                Height = 36,
                Margin = new Padding(0, 0, 0, 6),
                BackColor = Color.White
            };

            Label badge = new Label
            {
                Text = etiqueta,
                BackColor = colorEtiqueta,
                ForeColor = Color.FromArgb(60, 60, 60),
                Font = new Font("Calibri", 8.5f, FontStyle.Bold),
                Size = new Size(55, 22),
                Location = new Point(0, 7),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblTexto = new Label
            {
                Text = texto,
                Font = new Font("Calibri", 9.5f),
                ForeColor = Color.FromArgb(50, 50, 50),
                Location = new Point(65, 9),
                AutoSize = true
            };

            fila.Controls.Add(badge);
            fila.Controls.Add(lblTexto);
            return fila;
        }

        private void ConfigurarNotaRapida()
        {
            txtNota.BackColor = Color.FromArgb(255, 248, 225);
            txtNota.BorderStyle = BorderStyle.None;
            txtNota.Font = new Font("Calibri", 10f);
            txtNota.Padding = new Padding(10);
            txtNota.Text = "Escribe tu nota aquí...";
            txtNota.ForeColor = Color.Gray;

            txtNota.Enter += (s, e) =>
            {
                if (txtNota.Text == "Escribe tu nota aquí...")
                {
                    txtNota.Text = "";
                    txtNota.ForeColor = Color.Black;
                }
            };

            txtNota.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtNota.Text))
                {
                    txtNota.Text = "Escribe tu nota aquí...";
                    txtNota.ForeColor = Color.Gray;
                }
            };
        }

        private void FDashboard_Load(object sender, EventArgs e)
        {
            CargarEstadisticas();
            CargarTareasRecientes();
            CargarProximasFechas();
            ConfigurarNotaRapida();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim().ToLower();

            flowTareas.Controls.Clear();

            var tareas = DatosApp.UsuarioActual.Rol == "Admin"
                ? DatosApp.Tareas.AsEnumerable()
                : DatosApp.Tareas.Where(t =>
                    t.AsignadoA == DatosApp.UsuarioActual.Nombre ||
                    DatosApp.Grupos.Any(g => g.Nombre == t.AsignadoA &&
                        g.Miembros.Any(m => m.Nombre == DatosApp.UsuarioActual.Nombre)));

            var filtradas = string.IsNullOrEmpty(busqueda)
                ? tareas.OrderBy(t => t.FechaLimite).Take(5)
                : tareas.Where(t =>
                    t.Titulo.ToLower().Contains(busqueda) ||
                    t.Categoria.ToLower().Contains(busqueda) ||
                    t.AsignadoA.ToLower().Contains(busqueda));

            foreach (var t in filtradas)
            {
                string fecha = t.FechaLimite.Date == DateTime.Today ? "Hoy" :
                               t.FechaLimite.Date == DateTime.Today.AddDays(1) ? "Mañana" :
                               t.FechaLimite.ToString("ddd dd");

                int progreso = t.Estado == "Completada" ? 100 :
                               t.Estado == "En progreso" ? 50 : 0;

                flowTareas.Controls.Add(CrearTarjetaTarea(t.Titulo, t.Categoria, fecha, progreso));
            }
        }
    }
}
