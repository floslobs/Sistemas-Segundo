using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class Proveedores
    {
        public int ProveedorId { get; set; }
        public string Nombre { get; set; }  
        public long CUIT { get; set; }

        public Proveedores()
        {
        }
        public Proveedores(int pProveedorId, string pNombre, long pCUIT)
        {
            ProveedorId = pProveedorId;
            Nombre = pNombre;
            CUIT = pCUIT;
        }
    }
}
