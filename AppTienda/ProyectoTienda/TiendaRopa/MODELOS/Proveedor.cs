using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.MODELOS
{
    public class Proveedor
    {
        public int ProveedorId { get; set; }   // 0 para nuevos registros
        public string Nombre { get; set; }     // NOT NULL
        public string CUIT { get; set; }       // NOT NULL
    }
}
