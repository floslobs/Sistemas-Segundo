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
    public partial class HorasEmpleados : Form
    {
        public TimeSpan HorasTrabajadas { get; private set; } // Propiedad para pasar horas
        public int LegajoSeleccionado { get; set; }
        public DateTime FechaSeleccionada { get; set; }  // Nueva propiedad para recibir la fecha
      


        public HorasEmpleados()
        {
            InitializeComponent();
        }
     
        private void btnListo_Click(object sender, EventArgs e)
        {
            // 1. Calcular horas trabajadas
            TimeSpan entrada = dtEntrada.Value.TimeOfDay;
            TimeSpan salida = dtSalida.Value.TimeOfDay;

            if (salida <= entrada)
            {
                MessageBox.Show("La hora de salida debe ser mayor que la de entrada.");
                return;
            }

            // Resta de horarios para obtener duración neta
            HorasTrabajadas = salida - entrada;

            // 2. Obtener el legajo del empleado seleccionado (asumimos que lo pasaste desde el otro form)
            int legajo = LegajoSeleccionado;

            // 3. Obtener la fecha seleccionada
            DateTime fecha = FechaSeleccionada.Date; // usamos la propiedad que recibimos desde el otro form

            // 4. Guardar en base de datos
            EmpleadoManager manager = new EmpleadoManager();

            // Guardar las horas diarias
            manager.GuardarHorasDiarias(legajo, fecha, (decimal)HorasTrabajadas.TotalHours);

            // Guardar (o actualizar) las horas del mes
            int mes = fecha.Month;
            int anio = fecha.Year;
            manager.GuardarHorasMensuales(legajo, mes, anio, (decimal)HorasTrabajadas.TotalHours);

            // 5. Devolver el resultado al formulario anterior
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
