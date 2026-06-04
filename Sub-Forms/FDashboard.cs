using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskNotes_MonitoreoTareas.Clases;

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
            label4.Text = "24";   // número total

            label5.Text = "8";    // pendientes

            label8.Text = "11";   // en progreso

            label11.Text = "5";    // completadas
        }

        private void CargarTareasRecientes()
        {
            flowTareas.Controls.Clear();
            flowTareas.FlowDirection = FlowDirection.TopDown;
            flowTareas.WrapContents = false;
            flowTareas.AutoScroll = true;

            // Simulación de datos, por el momento.
            var tareas = new[]
            {
                new { Nombre = "Revisar propuesta del cliente", Categoria = "Trabajo", Fecha = "Hoy", Progreso = 80 },
                new { Nombre = "Estudiar para parcial",         Categoria = "Estudio", Fecha = "Jue 06", Progreso = 40 },
                new { Nombre = "Llamar al médico",              Categoria = "Salud",   Fecha = "Vie 07", Progreso = 0  },
            };

            foreach (var t in tareas)
                flowTareas.Controls.Add(CrearTarjetaTarea(t.Nombre, t.Categoria, t.Fecha, t.Progreso));
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

            // Estos datos vendrán de tu modelo real
            var fechas = new[]
            {
        new { Etiqueta = "Hoy",    Color = Color.FromArgb(255, 200, 200), Texto = "Revisar propuesta cliente" },
        new { Etiqueta = "Mañana", Color = Color.FromArgb(255, 235, 180), Texto = "Entregar reporte mensual"  },
        new { Etiqueta = "Jue 06", Color = Color.FromArgb(200, 220, 255), Texto = "Parcial de programación"   },
    };

            foreach (var f in fechas)
                flowFechas.Controls.Add(CrearFilaFecha(f.Etiqueta, f.Color, f.Texto));
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
    }
}
