using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNotes_MonitoreoTareas.Modelos
{
    public static class DatosApp
    {
        public static List<Usuario> Usuarios { get; set; } = new List<Usuario>();
        public static List<Grupo> Grupos { get; set; } = new List<Grupo>();
        public static List<Tarea> Tareas { get; set; } = new List<Tarea>();
        public static List<Notificacion> Notificaciones { get; set; } = new List<Notificacion>();
        public static Usuario UsuarioActual { get; set; }
    }
}
