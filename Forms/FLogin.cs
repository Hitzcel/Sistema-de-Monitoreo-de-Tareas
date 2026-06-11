using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskNotes_MonitoreoTareas.Clases;
using TaskNotes_MonitoreoTareas.Modelos;

namespace TaskNotes_MonitoreoTareas.Forms
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            btnMostrar.Visible = false;
            CargarUsuariosDePrueba();
        }

        private void CargarUsuariosDePrueba()
        {
            // Usuarios
            DatosApp.Usuarios.Add(new Usuario { Id = 1, Nombre = "Hitzcel Crúz", Correo = "admin@tasknotes.com", Telefono = "+504 9999-8888", Contrasena = "admin123", Rol = "Admin", Estado = "Activo" });
            DatosApp.Usuarios.Add(new Usuario { Id = 2, Nombre = "Mabel Mendoza", Correo = "mabel@tasknotes.com", Telefono = "+504 8888-7777", Contrasena = "empleado123", Rol = "Empleado", Estado = "Activo" });
            DatosApp.Usuarios.Add(new Usuario { Id = 3, Nombre = "Carlos Mejía", Correo = "carlos@tasknotes.com", Telefono = "+504 7777-6666", Contrasena = "empleado123", Rol = "Empleado", Estado = "Activo" });
            DatosApp.Usuarios.Add(new Usuario { Id = 4, Nombre = "María Torres", Correo = "maria@tasknotes.com", Telefono = "+504 6666-5555", Contrasena = "empleado123", Rol = "Empleado", Estado = "Activo" });

            // Grupos
            DatosApp.Grupos.Add(new Grupo { Id = 1, Nombre = "Grupo Desarrollo", Miembros = new List<Usuario> { DatosApp.Usuarios[1], DatosApp.Usuarios[2] }, FechaCreacion = DateTime.Now.AddDays(-10) });
            DatosApp.Grupos.Add(new Grupo { Id = 2, Nombre = "Grupo Diseño", Miembros = new List<Usuario> { DatosApp.Usuarios[3] }, FechaCreacion = DateTime.Now.AddDays(-5) });

            // Tareas
            DatosApp.Tareas.Add(new Tarea { Id = 1, Titulo = "Revisar propuesta del cliente", Descripcion = "Revisar los cambios solicitados antes de la reunión.", Categoria = "Trabajo", Prioridad = "Alta", Estado = "En progreso", FechaLimite = DateTime.Today, AsignadoA = "Mabel Anahí", CreadaPorId = 1 });
            DatosApp.Tareas.Add(new Tarea { Id = 2, Titulo = "Estudiar para parcial", Descripcion = "Repasar los temas del parcial de programación.", Categoria = "Estudio", Prioridad = "Alta", Estado = "Pendiente", FechaLimite = DateTime.Today.AddDays(2), AsignadoA = "Grupo Desarrollo", CreadaPorId = 1 });
            DatosApp.Tareas.Add(new Tarea { Id = 3, Titulo = "Entregar reporte mensual", Descripcion = "Preparar y enviar el reporte de actividades del mes.", Categoria = "Trabajo", Prioridad = "Media", Estado = "Pendiente", FechaLimite = DateTime.Today.AddDays(1), AsignadoA = "Carlos Mejía", CreadaPorId = 1 });
            DatosApp.Tareas.Add(new Tarea { Id = 4, Titulo = "Actualizar documentación", Descripcion = "Actualizar el README y los comentarios del código.", Categoria = "Trabajo", Prioridad = "Baja", Estado = "Pendiente", FechaLimite = DateTime.Today, AsignadoA = "Grupo Diseño", CreadaPorId = 1 });
            DatosApp.Tareas.Add(new Tarea { Id = 5, Titulo = "Reunión de equipo", Descripcion = "Reunión semanal de seguimiento del proyecto.", Categoria = "Trabajo", Prioridad = "Media", Estado = "Pendiente", FechaLimite = DateTime.Today.AddDays(4), AsignadoA = "Grupo Desarrollo", CreadaPorId = 1 });
            DatosApp.Tareas.Add(new Tarea { Id = 6, Titulo = "Revisar pull requests", Descripcion = "Revisar y aprobar los PR pendientes en el repositorio.", Categoria = "Trabajo", Prioridad = "Alta", Estado = "Completada", FechaLimite = DateTime.Today.AddDays(-1), AsignadoA = "Mabel Anahí", CreadaPorId = 1 });
            DatosApp.Tareas.Add(new Tarea { Id = 7, Titulo = "Capacitación de onboarding", Descripcion = "Completar los módulos de capacitación del nuevo sistema.", Categoria = "Trabajo", Prioridad = "Baja", Estado = "Completada", FechaLimite = DateTime.Today.AddDays(-5), AsignadoA = "Carlos Mejía", CreadaPorId = 1 });
            DatosApp.Tareas.Add(new Tarea { Id = 8, Titulo = "Llamar al médico", Descripcion = "Agendar cita médica de revisión.", Categoria = "Personal", Prioridad = "Media", Estado = "Pendiente", FechaLimite = DateTime.Today.AddDays(3), AsignadoA = "María Torres", CreadaPorId = 1 });

            // Notificaciones
            DatosApp.Notificaciones.Add(new Notificacion { Id = 1, Tipo = "Vencida", Mensaje = "'Revisar propuesta del cliente' venció hoy.", UsuarioId = 1, Fecha = DateTime.Now.AddMinutes(-10) });
            DatosApp.Notificaciones.Add(new Notificacion { Id = 2, Tipo = "Recordatorio", Mensaje = "'Estudiar para parcial' es mañana a las 8am.", UsuarioId = 1, Fecha = DateTime.Now.AddHours(-1) });
            DatosApp.Notificaciones.Add(new Notificacion { Id = 3, Tipo = "Completada", Mensaje = "Marcaste 'Revisar pull requests' como completada.", UsuarioId = 1, Fecha = DateTime.Now.AddHours(-2) });
            DatosApp.Notificaciones.Add(new Notificacion { Id = 4, Tipo = "Actualizada", Mensaje = "Cambiaste el estado de 'Entregar reporte' a En progreso.", UsuarioId = 1, Fecha = DateTime.Now.AddHours(-3) });
            DatosApp.Notificaciones.Add(new Notificacion { Id = 5, Tipo = "Recordatorio", Mensaje = "'Reunión de equipo' está programada para el viernes.", UsuarioId = 1, Fecha = DateTime.Now.AddDays(-2) });
            DatosApp.Notificaciones.Add(new Notificacion { Id = 6, Tipo = "Completada", Mensaje = "Marcaste 'Capacitación de onboarding' como completada.", UsuarioId = 1, Fecha = DateTime.Now.AddDays(-3) });
            DatosApp.Notificaciones.Add(new Notificacion { Id = 7, Tipo = "Asignada", Mensaje = "El admin te asignó 'Revisar documentación técnica'.", UsuarioId = 2, Fecha = DateTime.Now.AddDays(-4) });
            DatosApp.Notificaciones.Add(new Notificacion { Id = 8, Tipo = "Vencida", Mensaje = "'Entregar informe mensual' venció sin completarse.", UsuarioId = 1, Fecha = DateTime.Now.AddDays(-12) });
            DatosApp.Notificaciones.Add(new Notificacion { Id = 9, Tipo = "Asignada", Mensaje = "El admin te asignó 'Capacitación de onboarding'.", UsuarioId = 2, Fecha = DateTime.Now.AddDays(-15) });
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void lblRecuperar_MouseEnter(object sender, EventArgs e)
        {
            lblRecuperar.Font = new Font(lblRecuperar.Font.FontFamily, 10, FontStyle.Underline | FontStyle.Bold);
        }

        private void lblRecuperar_MouseLeave(object sender, EventArgs e)
        {
            lblRecuperar.Font = new Font(lblRecuperar.Font.FontFamily, 9, FontStyle.Regular | FontStyle.Bold);
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            ClsEstilosUI.BtnImagenHover(btnOcultar, btnMostrar);
            txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ClsEstilosUI.BtnImagenNormal(btnOcultar, btnMostrar);
            txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string correo = txtUsuario.Text.Trim();
            string contrasena = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor completa todos los campos.",
                    "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usuario = DatosApp.Usuarios.FirstOrDefault(u =>
                u.Correo == correo &&
                u.Contrasena == contrasena &&
                u.Estado == "Activo");

            if (usuario == null)
            {
                MessageBox.Show("Correo o contraseña incorrectos.",
                    "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            DatosApp.UsuarioActual = usuario;

            this.Hide();
            FPrincipal principal = new FPrincipal();
            principal.ShowDialog();
            this.Close();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            SetPlaceholderPassword();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                SetPlaceholderPassword();
            }
        }

        private void SetPlaceholderPassword()
        {
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.Text = "Contraseña...";
            txtPassword.Font = new Font(txtPassword.Font.FontFamily, 9, FontStyle.Regular);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña...")
            {
                txtPassword.Text = "";
                txtPassword.Font = new Font(txtPassword.Font.FontFamily, 9, FontStyle.Regular);
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
