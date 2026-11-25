using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class Compras
    {
        public int CompraId { get; set; }
        public int ProveedorId { get; set; }
        public DateTime Fecha { get; set; }
        public int Compra {  get; set; }
       public Compras(int pCompraId, int pProveedorId, DateTime pFecha)
        {
            CompraId = pCompraId;
            ProveedorId = pProveedorId;
            Fecha = pFecha;
        }
    }
}
