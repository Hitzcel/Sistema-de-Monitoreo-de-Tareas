using System;
using System.Collections.Generic;
using System.Text;

namespace TaskNotes_MonitoreoTareas.Clases
{
    public class ClsEstilosUI
    {
        //Por si se usan imágenes de botones diseñados fuera de visual y se requiere que funcionen como botones normales
        public static void BtnImagenHover(PictureBox imagenNormal, PictureBox imagenHover)
        {
            imagenNormal.Visible = false;
            imagenHover.Visible = true;
        }

        public static void BtnImagenNormal(PictureBox imagenNormal, PictureBox imagenHover)
        {
            imagenNormal.Visible = true;
            imagenHover.Visible = false;
        }

        //Para aplicarle estilo a los dgv
        public static void EstiloDataGridView(DataGridView dgv)
        {
            dgv.ClearSelection();
            dgv.EnableHeadersVisualStyles = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.ScrollBars = ScrollBars.Both;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(28, 28, 30);   // Color encabezado
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;                // Texto blanco
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Calibrí", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;                                             // Altura del encabezado

            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(28, 28, 30);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            dgv.DefaultCellStyle.BackColor = Color.FromArgb(175, 171, 171);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 168, 56);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(28, 28, 30);
            dgv.DefaultCellStyle.Font = new Font("Calibrí", 9, FontStyle.Regular);

            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.BackgroundColor = Color.FromArgb(175, 171, 171);
            dgv.GridColor = Color.FromArgb(175, 171, 171);

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(190, 186, 186);
            dgv.DataSourceChanged -= DgvLimpiarSeleccion;
            dgv.DataSourceChanged += DgvLimpiarSeleccion;

            dgv.RowsAdded -= DgvLimpiarSeleccion;
            dgv.RowsAdded += DgvLimpiarSeleccion;
        }

        private static void DgvLimpiarSeleccion(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;

            // Usar BeginInvoke para ejecutar DESPUÉS de que se rendericen las filas
            dgv.BeginInvoke(new Action(() =>
            {
                dgv.ClearSelection();
                dgv.CurrentCell = null;
            }));
        }
    }
}
