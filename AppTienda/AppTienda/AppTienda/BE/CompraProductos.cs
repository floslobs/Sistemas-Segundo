using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    public class CompraDeTalle
    {
        public int CompraId { get; set; }
        public int ProductoId { get; set; }
        public int CantCp { get; set; }
        public double Precio { get; set; }

        public CompraDeTalle() { }
        public CompraDeTalle(int pCompraId, int pProductoId, int pCantCp, double pPrecio)
        {
            CompraId = pCompraId;
            ProductoId = pProductoId;
            CantCp = pCantCp;
            Precio = pPrecio;
        }
    }
}
   
