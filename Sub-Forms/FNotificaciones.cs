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
    public partial class FNotificaciones : Form
    {
        public FNotificaciones()
        {
            InitializeComponent();
        }

        private void FNotificaciones_Load(object sender, EventArgs e)
        {
            CargarNotificaciones();
        }

        private void CargarNotificaciones()
        {
            flowHoy.Controls.Clear();
            flowEstaSemana.Controls.Clear();
            flowAnteriores.Controls.Clear();

            var notifs = DatosApp.Notificaciones
                .Where(n => n.UsuarioId == DatosApp.UsuarioActual.Id)
                .OrderByDescending(n => n.Fecha);

            bool hayHoy = false, haySemana = false, hayAnteriores = false;

            foreach (var notif in notifs)
            {
                Panel card = CrearCardNotificacion(notif);
                var diff = DateTime.Now - notif.Fecha;

                if (diff.TotalHours < 24)
                {
                    flowHoy.Controls.Add(card);
                    hayHoy = true;
                }
                else if (diff.TotalDays < 7)
                {
                    flowEstaSemana.Controls.Add(card);
                    haySemana = true;
                }
                else
                {
                    flowAnteriores.Controls.Add(card);
                    hayAnteriores = true;
                }
            }

            panelHoy.Visible = hayHoy;
            panelEstaSemana.Visible = haySemana;
            panelAnteriores.Visible = hayAnteriores;
        }

        private Panel CrearCardNotificacion(Notificacion notif)
        {
            // colores según tipo
            Color bgColor, borderColor, titleColor;
            switch (notif.Tipo)
            {
                case "Vencida":
                    bgColor = Color.FromArgb(252, 235, 235);
                    borderColor = Color.FromArgb(247, 193, 193);
                    titleColor = Color.FromArgb(163, 45, 45);
                    break;
                case "Recordatorio":
                    bgColor = Color.FromArgb(250, 238, 218);
                    borderColor = Color.FromArgb(250, 199, 117);
                    titleColor = Color.FromArgb(133, 79, 11);
                    break;
                case "Completada":
                    bgColor = Color.FromArgb(234, 243, 222);
                    borderColor = Color.FromArgb(192, 221, 151);
                    titleColor = Color.FromArgb(39, 80, 10);
                    break;
                default:
                    bgColor = Color.FromArgb(245, 245, 243);
                    borderColor = Color.FromArgb(200, 200, 200);
                    titleColor = Color.FromArgb(44, 44, 42);
                    break;
            }

            Panel card = new Panel
            {
                Width = flowHoy.Width - 25,
                Height = 75,
                BackColor = bgColor,
                Margin = new Padding(5, 4, 5, 4),
                Padding = new Padding(12, 8, 12, 8),
                Tag = notif
            };

            // punto de color (leída/no leída)
            Panel dot = new Panel
            {
                Width = 9,
                Height = 9,
                BackColor = notif.Leida ? Color.Transparent : titleColor,
                Location = new Point(10, 18)
            };
            dot.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, 9, 9, 9, 9));

            Label lblTipo = new Label
            {
                Text = notif.Tipo,
                Font = new Font("Calibri", 10f, FontStyle.Bold),
                ForeColor = titleColor,
                Location = new Point(26, 8),
                AutoSize = true
            };

            Label lblTiempo = new Label
            {
                Text = notif.TiempoRelativo(),
                Font = new Font("Calibri", 8f),
                ForeColor = Color.Gray,
                AutoSize = true
            };
            lblTiempo.Location = new Point(card.Width - lblTiempo.PreferredWidth - 15, 10);

            Label lblMensaje = new Label
            {
                Text = notif.Mensaje,
                Font = new Font("Calibri", 9f),
                ForeColor = Color.FromArgb(80, 80, 80),
                Location = new Point(26, 38),
                AutoSize = true
            };

            card.Controls.Add(dot);
            card.Controls.Add(lblTipo);
            card.Controls.Add(lblTiempo);
            card.Controls.Add(lblMensaje);

            // marcar como leída al hacer clic
            card.Click += (s, e) =>
            {
                notif.Leida = true;
                dot.BackColor = Color.Transparent;
            };

            return card;
        }

        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            var notifs = DatosApp.Notificaciones
                .Where(n => n.UsuarioId == DatosApp.UsuarioActual.Id);

            foreach (var n in notifs)
                n.Leida = true;

            CargarNotificaciones();
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);
    }
}
