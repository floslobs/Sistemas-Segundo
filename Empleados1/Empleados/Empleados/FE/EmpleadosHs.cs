using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados.FE
{
    public partial class EmpleadosHs : Form
    {

        // 🔸 Bandera para saber si ya se agregó la columna de "Horas Trabajadas"
        private bool columnaHorasAgregada = false;

        // 🔸 Constructor que recibe la lista de nombres de empleados
        public EmpleadosHs(List<string> nombres)
        {
            InitializeComponent();

            // Agrega solo la columna de NOMBRE al iniciar
            dataGridEmpleHS.Columns.Add("Nombre", "Nombre del Empleado");

            // Por cada nombre recibido, agregamos una fila con ese nombre
            foreach (string nombre in nombres)
            {
                dataGridEmpleHS.Rows.Add(nombre); // Solo una columna al principio
            }
        }

        // 🔸 Botón para agregar horas a un empleado
        private void btnMas_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (dataGridEmpleHS.CurrentRow != null)
            {
                // Obtenemos el índice de la fila seleccionada
                int rowIndex = dataGridEmpleHS.CurrentRow.Index;

                // Abrimos el formulario 3 para ingresar las horas
                HorasEmpleados formHoras = new HorasEmpleados();
                DialogResult result = formHoras.ShowDialog();

                // Si el usuario hizo clic en "Listo"
                if (result == DialogResult.OK)
                {
                    // Obtenemos las horas netas trabajadas
                    TimeSpan horasNetas = formHoras.HorasNetas;

                    // Si es la primera vez que se agregan horas, creamos la columna "Horas"
                    if (!columnaHorasAgregada)
                    {
                        dataGridEmpleHS.Columns.Add("Horas", "Horas Trabajadas");
                        columnaHorasAgregada = true; // Marcamos que ya se agregó
                    }

                    // Si por alguna razón no hay suficiente cantidad de celdas, agregamos una celda vacía (seguridad)
                    if (dataGridEmpleHS.Rows[rowIndex].Cells.Count < 2)
                    {
                        dataGridEmpleHS.Rows[rowIndex].Cells.Add(new DataGridViewTextBoxCell());
                    }

                    // Escribimos el valor en la columna "Horas"
                    dataGridEmpleHS.Rows[rowIndex].Cells["Horas"].Value =
                        horasNetas.TotalHours.ToString("0.##") + " hs";
                }
            }
            else
            {
                MessageBox.Show("Seleccioná un empleado para agregarle horas.");
            }
        }

        private void EmpleadosHs_Load(object sender, EventArgs e)
        {

        }
    }
}
