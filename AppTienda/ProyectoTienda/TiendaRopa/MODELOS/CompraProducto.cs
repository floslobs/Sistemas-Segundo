using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.MODELOS
{
    public class CompraDetalle
    {
        // Corresponde a ComprasProductos (CompraId, ProductoId, Cantidad, Precio)
        public int CompraId { get; set; }               // FK Compras
        public int ProductoId { get; set; }             // FK Productos
        public int Cantidad { get; set; }
        public int Precio { get; set; }             // precio unitario
    }


}
