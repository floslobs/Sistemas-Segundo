using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class VentasTalles
    {
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public int TalleId { get; set; }
        public int CantVt { get; set; }
        public string Talles {  get; set; }
        public VentasTalles()
        {
        }

        public VentasTalles(int ventaId, int peoductoId, int talleId, int cantVt)
        {
            VentaId = ventaId;
            ProductoId = peoductoId;
            TalleId = talleId;
            this.CantVt = cantVt;
        }
    }
}
