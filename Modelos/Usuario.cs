using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNotes_MonitoreoTareas.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; } // "Admin" o "Empleado"
        public string Estado { get; set; } // "Activo" o "Inactivo"
        public DateTime FechaCreacion { get; set; }

        public Usuario()
        {
            FechaCreacion = DateTime.Now;
            Estado = "Activo";
        }

        public override string ToString() => Nombre;
    }
}
