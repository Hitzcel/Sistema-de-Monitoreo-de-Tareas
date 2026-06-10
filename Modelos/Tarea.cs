using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNotes_MonitoreoTareas.Modelos
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }   // "Trabajo", "Personal", "Estudio"
        public string Prioridad { get; set; }   // "Alta", "Media", "Baja"
        public string Estado { get; set; }      // "Pendiente", "En progreso", "Completada"
        public DateTime FechaLimite { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string AsignadoA { get; set; }   // nombre del usuario o grupo
        public int CreadaPorId { get; set; }    // Id del admin que la creó

        public Tarea()
        {
            FechaCreacion = DateTime.Now;
            Estado = "Pendiente";
        }
    }
}
