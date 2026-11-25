using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EManzanilla.BE;

namespace EManzanilla.FE
{
    public partial class Resumen : Form
    {
        private Empleado empleadoSeleccionado; // empleado seleccionado
        public Resumen(Empleado emp)
        {
            InitializeComponent();
            empleadoSeleccionado = emp;

            // Asignamos el nombre al label
            labelEmpleadoResumen.Text = $"{empleadoSeleccionado.Nombre}";

        }

        private void Resumen_Load(object sender, EventArgs e)
        {

            labelEmpleadoResumen.Text = empleadoSeleccionado.Nombre;

            CargarResumen();
        }

        private void CargarResumen()
        {
            BEhoras beHoras = new BEhoras();
            BEpago bePago = new BEpago();
            DataTable dtHoras = beHoras.ObtenerHorasPorEmpleado(empleadoSeleccionado.EmpleadoId);
            DataTable dtPagos = bePago.ObtenerPagosPorEmpleado(empleadoSeleccionado.EmpleadoId);

            // Limpiar grilla
            dataGridViewResumen.Columns.Clear();
            dataGridViewResumen.Rows.Clear();
            dataGridViewResumen.AutoGenerateColumns = false;

            // Crear columnas
            dataGridViewResumen.Columns.Add("Fecha", "Fecha");
            dataGridViewResumen.Columns.Add("Hingreso1", " Hs ingreso1");
            dataGridViewResumen.Columns.Add("Hsalida1", " Hs salida1");
            dataGridViewResumen.Columns.Add("Hingreso2", " Hs ingreso2");
            dataGridViewResumen.Columns.Add("Hsalida2", " Hs salida2");
            dataGridViewResumen.Columns.Add("HdescansoI", " Hs Descanso1");
            dataGridViewResumen.Columns.Add("HdescansoS", " Hs Descanso2");
            dataGridViewResumen.Columns.Add("FeriadoDomingo", "Feriado o Domingo");
            dataGridViewResumen.Columns.Add("PHora", "Precio Hora");
            dataGridViewResumen.Columns.Add("MontoDia", "Monto Día");
            dataGridViewResumen.Columns.Add("Pago", "Pago"); // nueva columna




            if (dtHoras.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron horas cargadas para este empleado.");
                return;
            }

            // Cargar filas
            foreach (DataRow row in dtHoras.Rows)
            {
                string fecha = Convert.ToDateTime(row["Fecha"]).ToShortDateString();
                string hingreso1 = row["Hingreso1"] != DBNull.Value ? TimeSpan.Parse(row["Hingreso1"].ToString()).ToString(@"hh\:mm") : "";
                string hsalida1 = row["Hsalida1"] != DBNull.Value ? TimeSpan.Parse(row["Hsalida1"].ToString()).ToString(@"hh\:mm") : "";
                string hingreso2 = row["Hingreso2"] != DBNull.Value ? TimeSpan.Parse(row["Hingreso2"].ToString()).ToString(@"hh\:mm") : "";
                string hsalida2 = row["Hsalida2"] != DBNull.Value ? TimeSpan.Parse(row["Hsalida2"].ToString()).ToString(@"hh\:mm") : "";
                string hdescansoI = row["HdescansoI"] != DBNull.Value ? TimeSpan.Parse(row["HdescansoI"].ToString()).ToString(@"hh\:mm") : "";
                string hdescansoS = row["HdescansoS"] != DBNull.Value ? TimeSpan.Parse(row["HdescansoS"].ToString()).ToString(@"hh\:mm") : "";
                bool feriadoDomingo = row["FeriadoDomingo"] != DBNull.Value && Convert.ToBoolean(row["FeriadoDomingo"]);
                double precioHora = Convert.ToDouble(row["Phora2"]);
                double montoDia = Convert.ToDouble(row["MontoDia"]);

                // Verificar si ya hay un pago para esta fecha
                DataRow pagoRow = dtPagos.AsEnumerable()
                                         .FirstOrDefault(p => Convert.ToDateTime(p["Fecha"]).Date == Convert.ToDateTime(row["Fecha"]).Date);
                string estadoPago = pagoRow != null ? "Pagado" : "No pagado";

                dataGridViewResumen.Rows.Add(fecha, hingreso1, hsalida1, hingreso2, hsalida2, hdescansoI, hdescansoS, feriadoDomingo, precioHora, montoDia,estadoPago);
            }
        }

        private void Resumen_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();

            foreach (DataGridViewRow fila in dataGridViewResumen.Rows)
            {
                if (fila.IsNewRow) continue;

                // Obtener valores de las columnas
                string fecha = fila.Cells["Fecha"].Value != null ? fila.Cells["Fecha"].Value.ToString().ToLower() : "";
                string feriadoDomingo = fila.Cells["FeriadoDomingo"].Value != null ? fila.Cells["FeriadoDomingo"].Value.ToString().ToLower() : "";

                // Mostrar la fila si alguna columna contiene el filtro
                fila.Visible = fecha.Contains(filtro) || feriadoDomingo.Contains(filtro);
            }

        }
    }

}
