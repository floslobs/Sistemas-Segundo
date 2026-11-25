using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class TalleProducto
    {
        public int TalleId { get; set; }
        public int ProductoId { get; set; }

        public TalleProducto(int talleId, int productoId)
        {
            TalleId = talleId;
            ProductoId = productoId;
        }
    }
}
