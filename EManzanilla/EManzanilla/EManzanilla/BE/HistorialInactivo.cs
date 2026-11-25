using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManzanilla.BE
{
    public class HistorialInactivo
    {
        public int HistorialId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaInactivo { get; set; }
        public DateTime? FechaReactivado { get; set; }
    }


}
