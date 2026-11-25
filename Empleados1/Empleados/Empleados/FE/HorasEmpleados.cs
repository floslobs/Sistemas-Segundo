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
    public partial class HorasEmpleados : Form
    {
        public TimeSpan HorasNetas { get; private set; }

        public HorasEmpleados()
        {
            InitializeComponent();

            // Asegurate de que los DateTimePickers estén en formato de hora
            dtEntrada.Format = DateTimePickerFormat.Time;
            dtEntrada.ShowUpDown = true;

            dtSalida.Format = DateTimePickerFormat.Time;
            dtSalida.ShowUpDown = true;

            dtDescansoInicio.Format = DateTimePickerFormat.Time;
            dtDescansoInicio.ShowUpDown = true;

            dtDescansoFin.Format = DateTimePickerFormat.Time;
            dtDescansoFin.ShowUpDown = true;
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            DateTime entrada = dtEntrada.Value;
            DateTime salida = dtSalida.Value;
            DateTime descansoInicio = dtDescansoInicio.Value;
            DateTime descansoFin = dtDescansoFin.Value;

            TimeSpan trabajoTotal = salida - entrada;
            TimeSpan descanso = descansoFin - descansoInicio;
            HorasNetas = trabajoTotal - descanso;

            if (HorasNetas.TotalHours < 0)
            {
                MessageBox.Show("Revisá las horas ingresadas.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}