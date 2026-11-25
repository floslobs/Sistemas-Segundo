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
    public partial class LiquidacionEmple : Form
    {
        public LiquidacionEmple()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dataGridEmpleLiqui.CurrentRow != null)
            {
                // Obtener legajo y nombre de la fila seleccionada
                int legajo = Convert.ToInt32(dataGridEmpleLiqui.CurrentRow.Cells["Legajo"].Value);
                string nombre = dataGridEmpleLiqui.CurrentRow.Cells["Nombre"].Value.ToString();

                // Abrir formulario de recibo y pasar los datos
                Liquidacion liquidacionEm = new Liquidacion(legajo, nombre);
                liquidacionEm.ShowDialog(); // o .Show() si querés dejarlo abierto
            }
            else
            {
                MessageBox.Show("Seleccione un empleado.");
            }
        }

        private void CargarEmpleadosEnGrilla()
        {
            // Limpia filas anteriores para evitar duplicados
            dataGridEmpleLiqui.Rows.Clear();

            // Si no hay columnas, las agrega
            if (dataGridEmpleLiqui.Columns.Count == 0)
            {
                dataGridEmpleLiqui.Columns.Add("Legajo", "Legajo");
                dataGridEmpleLiqui.Columns.Add("Nombre", "Nombre");
                dataGridEmpleLiqui.Columns.Add("PrecioHora", "Precio por Hora");
                //dataGridEmpleLiqui.Columns.Add("FechaNac", "Fecha de Nacimiento");
            }

            // Trae la lista de empleados desde la base
            EmpleadoManager manager = new EmpleadoManager();
            List<EmpleadoC> empleados = manager.ObtenerTodos();

            // Muestra cada empleado en una fila
            foreach (EmpleadoC emp in empleados)
            {
                dataGridEmpleLiqui.Rows.Add(
                    emp.Legajo,
                    emp.Nombre,
                    emp.PrecioHora
                   // emp.FechaNac.ToShortDateString()
                );
            }
        }
        private void LiquidacionEmple_Load(object sender, EventArgs e)
        {
            CargarEmpleadosEnGrilla(); // solo llamás al método

        }
    }
}
