using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.MODELOS
{
    public class VentaDetalle
    {
        // Corresponde a VentasProducto (VentaId, ProductoId, Cantidad, Precio)
        public int VentaId { get; set; }                // FK Ventas
        public int ProductoId { get; set; }             // FK Productos
        public int Cantidad { get; set; }
        public int Precio { get; set; }             // precio unitario
    }

}
