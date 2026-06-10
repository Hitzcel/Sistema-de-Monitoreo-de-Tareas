using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNotes_MonitoreoTareas.Modelos
{
    public class Grupo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Usuario> Miembros { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Grupo()
        {
            Miembros = new List<Usuario>();
            FechaCreacion = DateTime.Now;
        }

        public override string ToString() => Nombre;
    }
}
