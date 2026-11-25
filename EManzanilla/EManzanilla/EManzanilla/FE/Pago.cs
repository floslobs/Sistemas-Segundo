using EManzanilla.BE;
using EManzanilla.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EManzanilla.FE
{
    public partial class Pago : Form
    {
        private Empleado EmpleadoSeleccionado; // empleado seleccionado
        public Pago(Empleado emp)
        {
            InitializeComponent();

            dataGridViewPagos.AllowUserToAddRows = false;

            EmpleadoSeleccionado = emp;
            labelEmple2.Text = $"Empleado: {EmpleadoSeleccionado.Nombre}";

            checkBoxSeleccionarTodo.CheckedChanged += checkBoxSeleccionarTodo_CheckedChanged;
            dataGridViewPagos.CellValueChanged += dataGridViewPagos_CellValueChanged;
            dataGridViewPagos.CurrentCellDirtyStateChanged += dataGridViewPagos_CurrentCellDirtyStateChanged;

            CargarPagos();
        }

        private void Pago_Load(object sender, EventArgs e)
        {

        }

        private void CargarPagos()
        {
            BEhoras beHoras = new BEhoras();
            BEpago bEpago = new BEpago();

            DataTable dtHoras = beHoras.ObtenerHorasPorEmpleado(EmpleadoSeleccionado.EmpleadoId);
            DataTable dtPagos = bEpago.ObtenerPagosPorEmpleado(EmpleadoSeleccionado.EmpleadoId);

            dataGridViewPagos.Columns.Clear();
            dataGridViewPagos.Rows.Clear();

            dataGridViewPagos.Columns.Add("Fecha", "Fecha");
            dataGridViewPagos.Columns.Add("Horas", "Horas");
            dataGridViewPagos.Columns.Add("Monto", "Monto");

            DataGridViewTextBoxColumn pagoIdColumn = new DataGridViewTextBoxColumn();
            pagoIdColumn.Name = "PagoId";
            pagoIdColumn.HeaderText = "PagoId";
            pagoIdColumn.Visible = false;
            dataGridViewPagos.Columns.Add(pagoIdColumn);

            DataGridViewCheckBoxColumn seleccionarColumn = new DataGridViewCheckBoxColumn();
            seleccionarColumn.Name = "Seleccionar";
            seleccionarColumn.HeaderText = "Seleccionar";
            dataGridViewPagos.Columns.Add(seleccionarColumn);

            DataGridViewTextBoxColumn pagadoColumn = new DataGridViewTextBoxColumn();
            pagadoColumn.Name = "Pagado";
            pagadoColumn.HeaderText = "Pagado";
            pagadoColumn.ReadOnly = true;
            dataGridViewPagos.Columns.Add(pagadoColumn);

            foreach (DataRow row in dtHoras.Rows)
            {
                DateTime fecha = Convert.ToDateTime(row["Fecha"]);
                double horas = Convert.ToDouble(row["TotalHoras"]);
                double monto = Convert.ToDouble(row["MontoDia"]);
                // Buscar si ya existe un pago para esa fecha
                DataRow pagoRow = dtPagos.AsEnumerable()
                    .FirstOrDefault(p => Convert.ToDateTime(p["Fecha"]).Date == fecha.Date);

                bool isPagado = pagoRow != null;
                int pagoId = pagoRow != null ? Convert.ToInt32(pagoRow["PagoId"]) : 0;

                dataGridViewPagos.Rows.Add(
                    fecha.ToShortDateString(),
                    horas,
                    monto,
                    pagoId,
                    false,                       // Selección inicial
                    isPagado ? "Pagado" : "No pagado"// Buscar si ya existe un pago para esa fecha

                );
            }
        }


        private void checkBoxSeleccionarTodo_CheckedChanged(object sender, EventArgs e)
        {
            bool marcar = checkBoxSeleccionarTodo.Checked;

            foreach (DataGridViewRow fila in dataGridViewPagos.Rows)
            {
                // Solo marcar si no está pagado
                var valorCelda = fila.Cells["Pagado"].Value;
                string estado = valorCelda != null ? valorCelda.ToString() : "No pagado";

                if (estado == "No pagado")
                {
                    fila.Cells["Seleccionar"].Value = marcar;
                }
            }
            // Actualizar el total de los seleccionados
            ActualizarTotalSeleccionados();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            BEpago bEpago = new BEpago();
            bool anySelected = false;

            foreach (DataGridViewRow row in dataGridViewPagos.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Seleccionar"].Value);
                string estadoPagado = row.Cells["Pagado"].Value?.ToString() ?? "No pagado";

                if (isSelected && estadoPagado == "No pagado")
                {
                    anySelected = true;
                    break;
                }
            }
            if (!anySelected)
            {
                MessageBox.Show("No se seleccionaron pagos para marcar como pagados.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación
            if (MessageBox.Show("¿Desea marcar los pagos seleccionados como pagados?", "Confirmar pago",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            // Procesar pagos seleccionados
            foreach (DataGridViewRow row in dataGridViewPagos.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Seleccionar"].Value);
                string estadoPagado = row.Cells["Pagado"].Value?.ToString() ?? "No pagado";

                if (isSelected && estadoPagado == "No pagado")
                {
                    DateTime fecha = Convert.ToDateTime(row.Cells["Fecha"].Value);
                    double horas = Convert.ToDouble(row.Cells["Horas"].Value);
                    double monto = Convert.ToDouble(row.Cells["Monto"].Value);

                    BE.Pago pago = new BE.Pago
                    {
                        EmpleadoId = EmpleadoSeleccionado.EmpleadoId,
                        Fecha = fecha,
                        Horas = horas,
                        Monto = monto,
                        Pagado = true
                    };

                    int result = bEpago.AgregarPago(pago);

                    if (result == -1)
                    {
                        MessageBox.Show("Error al guardar pago: " + bEpago.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Actualizar grilla
                    row.Cells["Pagado"].Value = "Pagado";
                    row.Cells["Seleccionar"].Value = false;
                }
            }

            MessageBox.Show("Pagos marcados como pagados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Recargar la grilla
            CargarPagos();
        }

        // Método para calcular el total de los seleccionados
        private void ActualizarTotalSeleccionados()
        {
            double total = 0;

            foreach (DataGridViewRow fila in dataGridViewPagos.Rows)
            {
                if (fila.IsNewRow) continue; // ignorar fila vacía

                bool seleccionado = fila.Cells["Seleccionar"].Value != null &&
                                    (bool)fila.Cells["Seleccionar"].Value;

                if (seleccionado)
                {
                    double monto = fila.Cells["Monto"].Value != null ?
                                   Convert.ToDouble(fila.Cells["Monto"].Value) : 0;

                    total += monto;
                }
            }

            labelTotal.Text = $"Total: {total:C2}"; // muestra con formato moneda
        }

        private void dataGridViewPagos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewPagos.IsCurrentCellDirty)
            {
                dataGridViewPagos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridViewPagos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Solo cuando cambie la columna "Seleccionar"
            if (dataGridViewPagos.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                ActualizarTotalSeleccionados();
            }
        }
    }
}
