using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class TipoProducto
    {
        public int TipoProductoId { get; set; }
        public string Nombre { get; set; }
        public Boolean PoseeTalle { get; set; }

        public TipoProducto() { }
        public TipoProducto(int pTipoProductoId, string pNombre, Boolean pPoseeTalle)
        {
            TipoProductoId = pTipoProductoId;
            Nombre = pNombre;
            PoseeTalle = pPoseeTalle;
        }
    }
}
