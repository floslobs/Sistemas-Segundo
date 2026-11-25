using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManzanilla.BE
{
    public class Pago
    {
        public int PagoId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime Fecha { get; set; }
        public double Horas { get; set; }
        public double Monto { get; set; }

        public bool Pagado { get; set; }

        public Pago() { } // Constructor vacío
        public Pago(int pPagoId, int pEmpleadoId,  DateTime pFecha, double pHoras, double pMonto, bool pPagado)
        {
            PagoId = pPagoId;
            EmpleadoId = pEmpleadoId;
            Fecha = pFecha;
            Horas = pHoras;
            Monto = pMonto;
            Pagado = pPagado;

        }
    }
}
