using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManzanilla.BE
{
    public class Horas
    {
        public int HorasId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime Fecha { get; set; }
        public double Phora2 { get; set; }  // precio por hora
        public double TipoCambio { get; set; }
        public TimeSpan? Hingreso1 { get; set; }
        public TimeSpan? Hsalida1 { get; set; }
        public TimeSpan? Hingreso2 { get; set; }
        public TimeSpan? Hsalida2 { get; set; }
        public TimeSpan? HdescansoI { get; set; }
        public TimeSpan? HdescansoS { get; set; }
        public double TotalHoras { get; set; }
        public double MontoDia { get; set; }
        public bool FeriadoDomingo { get; set; }
        public bool Dolar { get; set; }

        // Constructor vacío
        public Horas() { }

        // Método para calcular horas y monto
        public void CalcularHorasYTotal()
        {
            double totalHoras = 0;

            if (Hsalida1 != null && Hingreso1 != null)
                totalHoras += (Hsalida1 - Hingreso1).Value.TotalHours;

            if (Hsalida2 != null && Hingreso2 != null)
                totalHoras += (Hsalida2 - Hingreso2).Value.TotalHours;

            // Restar descanso
            if (HdescansoI != null && HdescansoS != null)
                totalHoras -= (HdescansoS - HdescansoI).Value.TotalHours;

            TotalHoras = totalHoras;

            // Si es feriado o domingo, monto se duplica
            MontoDia = TotalHoras * Phora2;
            if (FeriadoDomingo)
                MontoDia *= 2;

            //Si es en dolar , se cargan horas por el precio del dolar 
            
            if (Dolar)
                MontoDia *= TipoCambio;

        }
    }
}
