using EmpleadosOrigin.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosOrigin.FE
{
    public partial class EmpleadosHs : Form
    {
        public EmpleadosHs()
        {
            InitializeComponent();
        }

        private void EmpleadosHs_Load(object sender, EventArgs e)
        {
            // Obtener empleados de la base de datos
            EmpleadoManager manager = new EmpleadoManager();
            DataTable empleados = manager.ObtenerTodosLosEmpleados(); // Asegurate de tener este método

            // Agregar columnas si aún no están
            if (dataGridEmpleHS.Columns.Count == 0)
            {
                dataGridEmpleHS.Columns.Add("Legajo", "Legajo");
                dataGridEmpleHS.Columns.Add("Nombre", "Nombre");
                dataGridEmpleHS.Columns.Add("HorasTrabajadas", "Horas Trabajadas"); // esta la llenás con el botón +
            }

            // Llenar la grilla con legajo y nombre
            foreach (DataRow row in empleados.Rows)
            {
                dataGridEmpleHS.Rows.Add(row["Legajo"], row["Nombre"]);
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (dataGridEmpleHS.CurrentRow != null)
            {
                // Obtener datos de la fila seleccionada
                int legajoSeleccionado = Convert.ToInt32(dataGridEmpleHS.CurrentRow.Cells["Legajo"].Value);
                DateTime fechaSeleccionada = dtFecha.Value; // Asegurate de tener un DateTimePicker llamado dtFecha

                // Crear instancia del form y pasar datos
                HorasEmpleados formHoras = new HorasEmpleados();
                formHoras.LegajoSeleccionado = legajoSeleccionado;
                formHoras.FechaSeleccionada = fechaSeleccionada; // esta propiedad la agregamos en el siguiente paso

                if (formHoras.ShowDialog() == DialogResult.OK)
                {
                    double horas = formHoras.HorasTrabajadas.TotalHours;

                    // Asignar o actualizar columna de horas trabajadas
                    dataGridEmpleHS.CurrentRow.Cells["HorasTrabajadas"].Value = horas.ToString("0.00");
                }
            }
        }
    }
}
