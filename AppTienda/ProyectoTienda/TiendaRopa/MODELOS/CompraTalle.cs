using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.MODELOS
{
    public class CompraTalle
    {
        // Corresponde a ComprasTalles (CompraId, ProductoId, TalleId, Cant)
        public int CompraId { get; set; }               // FK Compras
        public int ProductoId { get; set; }             // FK Productos
        public int TalleId { get; set; }                // FK Talles
        public int Cant { get; set; }                   // cantidad por talle (entero)
    }


}
