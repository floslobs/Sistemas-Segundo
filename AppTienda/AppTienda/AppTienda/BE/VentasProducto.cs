using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class VentaDeTalle
    {
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public int CantVp { get; set; }

        public VentaDeTalle() { }
        VentaDeTalle(int pVentaId, int pProductId, int pCantVp)
        {
            VentaId = pVentaId;
            ProductoId = pProductId;
            CantVp = pCantVp;
        
        }

        
      


    }
}
