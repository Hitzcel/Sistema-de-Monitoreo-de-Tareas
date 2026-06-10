using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNotes_MonitoreoTareas.Modelos
{
    public class Notificacion
    {
        public int Id { get; set; }
        public string Tipo { get; set; }     // "Vencida", "Recordatorio", "Completada", "Actualizada", "Asignada"
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }
        public bool Leida { get; set; }
        public int UsuarioId { get; set; }   // a quién pertenece

        public Notificacion()
        {
            Fecha = DateTime.Now;
            Leida = false;
        }

        public string TiempoRelativo()
        {
            var diff = DateTime.Now - Fecha;
            if (diff.TotalMinutes < 60) return $"hace {(int)diff.TotalMinutes} min";
            if (diff.TotalHours < 24) return $"hace {(int)diff.TotalHours}h";
            if (diff.TotalDays < 7) return $"hace {(int)diff.TotalDays} días";
            return Fecha.ToString("dd/MM/yyyy");
        }
    }
}
