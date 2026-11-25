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
    public partial class HistorialInactivos : Form
    {
        public HistorialInactivos()
        {
            InitializeComponent();
        }

        private void HistorialInactivos_Load(object sender, EventArgs e)
        {

        }

        public void CargarHistorial(DataTable dt)
        {
            dataGridViewHinactivos.Rows.Clear();
            dataGridViewHinactivos.Columns.Clear();

            dataGridViewHinactivos.Columns.Add("HistorialId", "HistorialId");
            dataGridViewHinactivos.Columns["HistorialId"].Visible = false; // ocultar id interno
            dataGridViewHinactivos.Columns.Add("EmpleadoId", "EmpleadoId");
            dataGridViewHinactivos.Columns["EmpleadoId"].Visible = false; // opcional
            dataGridViewHinactivos.Columns.Add("Nombre", "Nombre");
            dataGridViewHinactivos.Columns.Add("Dni", "DNI");
            dataGridViewHinactivos.Columns.Add("FechaInactivo", "Fecha Inactivo");
            dataGridViewHinactivos.Columns.Add("FechaReactivado", "Fecha Reactivado");

            DataGridViewCheckBoxColumn reactivarCol = new DataGridViewCheckBoxColumn();
            reactivarCol.Name = "Reactivar";
            reactivarCol.HeaderText = "Reactivar";
            dataGridViewHinactivos.Columns.Add(reactivarCol);

            foreach (DataRow row in dt.Rows)
            {
                dataGridViewHinactivos.Rows.Add(
                    row["HistorialId"],
                    row["EmpleadoId"],
                    row["Nombre"],
                    row["Dni"],
                    Convert.ToDateTime(row["FechaInactivo"]).ToShortDateString(),
                    row["FechaReactivado"] != DBNull.Value ? Convert.ToDateTime(row["FechaReactivado"]).ToShortDateString() : ""
                );
            }
        }

        private void dataGridViewHinactivos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewHinactivos.Columns[e.ColumnIndex].Name == "Reactivar")
            {
                bool marcado = Convert.ToBoolean(dataGridViewHinactivos.Rows[e.RowIndex].Cells["Reactivar"].Value);
                if (marcado)
                {
                    int historialId = Convert.ToInt32(dataGridViewHinactivos.Rows[e.RowIndex].Cells["HistorialId"].Value);
                    int empleadoId = Convert.ToInt32(dataGridViewHinactivos.Rows[e.RowIndex].Cells["EmpleadoId"].Value);

                    BEHistorialInactivo beHist = new BEHistorialInactivo();
                    beHist.ReactivarEmpleado(historialId, empleadoId);

                    // Actualizar la grilla
                    dataGridViewHinactivos.Rows[e.RowIndex].Cells["FechaReactivado"].Value = DateTime.Now.ToShortDateString();
                    MessageBox.Show("Empleado reactivado correctamente.");
                }
            }
        }

        private void dataGridViewHinactivos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewHinactivos.IsCurrentCellDirty)
                dataGridViewHinactivos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
