using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class ComprasTalles
    {
        public int ComprarId { get; set; }
        public int ProductoId { get; set; }
        public int TalleId { get; set; }
        public int CantCt { get; set; }

        public ComprasTalles()
        {
        }
        public ComprasTalles(int comprarId, int productoId, int talleId, int cantCt)
        {
            ComprarId = comprarId;
            ProductoId = productoId;
            TalleId = talleId;
            CantCt = cantCt;
        }
    }
}
