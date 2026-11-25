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
    public partial class HorasTrabajo : Form
    {
        private Empleado empleadoSeleccionado; // empleado seleccionado
        private Horas horasActual; // objeto Horas que vamos a guardar

        public HorasTrabajo(Empleado emp)
        {
            InitializeComponent();
            empleadoSeleccionado = emp;

            // Asignamos el nombre al label
            labelNombreEmple.Text = $"{empleadoSeleccionado.Nombre}";

            // Inicializamos objeto Horas
            horasActual = new Horas();

            // Setear precio por hora inicial en numericUpDown
            numericUpDownPHora2.Value = empleadoSeleccionado.PHora;

            // Conectar eventos para recalcular monto en tiempo real
            HorasEntrada.ValueChanged += CalcularMonto;
            HorasSalida.ValueChanged += CalcularMonto;
            HorasEntrada2.ValueChanged += CalcularMonto;
            HorasSalida2.ValueChanged += CalcularMonto;
            HorasDescanso1.ValueChanged += CalcularMonto;
            HorasDescanso2.ValueChanged += CalcularMonto;
            numericUpDownPHora2.ValueChanged += CalcularMonto;
            numericUpDownTipoCambio.ValueChanged += CalcularMonto;
            checkBoxFeriadoOdomingo.CheckedChanged += CalcularMonto;
            checkBoxDolar.CheckedChanged += CalcularMonto;

        }

        private void HorasTrabajo_Load(object sender, EventArgs e)
        {
            numericUpDownPHora2.Value = (decimal)empleadoSeleccionado.PHora;

            CalcularMonto();
        }
        private void CalcularMonto(object sender = null, EventArgs e = null)
        {
            // Turno 1
            horasActual.Hingreso1 = HorasEntrada.Checked ? HorasEntrada.Value.TimeOfDay : (TimeSpan?)null;
            horasActual.Hsalida1 = HorasSalida.Checked ? HorasSalida.Value.TimeOfDay : (TimeSpan?)null;

            // Turno 2
            horasActual.Hingreso2 = HorasEntrada2.Checked ? HorasEntrada2.Value.TimeOfDay : (TimeSpan?)null;
            horasActual.Hsalida2 = HorasSalida2.Checked ? HorasSalida2.Value.TimeOfDay : (TimeSpan?)null;

            // Descanso
            horasActual.HdescansoI = HorasDescanso1.Checked ? HorasDescanso1.Value.TimeOfDay : (TimeSpan?)null;
            horasActual.HdescansoS = HorasDescanso2.Checked ? HorasDescanso2.Value.TimeOfDay : (TimeSpan?)null;

            // Feriado/Domingo
            horasActual.FeriadoDomingo = checkBoxFeriadoOdomingo.Checked;

            //dolar o no
            horasActual.Dolar = checkBoxDolar.Checked;

            // Precio por hora
            horasActual.Phora2 = (double)numericUpDownPHora2.Value;

            //PRECIO DOLAR
            horasActual.TipoCambio = (double)numericUpDownTipoCambio.Value;

            // Calcular horas y monto
            horasActual.CalcularHorasYTotal();


        }
        private void btnListo_Click(object sender, EventArgs e)
        {

            // Validar precio por hora
            if (numericUpDownPHora2.Value <= 0)
            {
                MessageBox.Show("El precio por hora debe ser mayor a 0.");
                return;
            }
            if (numericUpDownTipoCambio.Value <= 0)
            {
                MessageBox.Show("El precio del tipo de cambio debe ser mayor a 0.");
                return;
            }
            horasActual.EmpleadoId = empleadoSeleccionado.EmpleadoId;
            horasActual.Fecha = dateTimePickerFecha.Value;
            // Tomamos el valor del NumericUpDown directamente como double
            horasActual.Phora2 = (double)numericUpDownPHora2.Value;
            horasActual.TipoCambio = (double)numericUpDownTipoCambio.Value;
            // Guardar en la base usando BE
            BEhoras beHoras = new BEhoras();
            int resultado = beHoras.AgregarHoras(horasActual);

            if (resultado > 0)
                MessageBox.Show("Horas cargadas correctamente.");
            else
                MessageBox.Show("Error al guardar horas: " + beHoras.Error);
        }
    }
}
