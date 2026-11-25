using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class Productos
    {
        public int ProductoId { get; set; }
        public string NombreModelo { get; set; }
        public int MarcaId { get; set; }
        public int TipoProductoId { get; set; }

        public Productos()
        {
        }
        public Productos(int pProductoId, string pNombreModelo, int pMarcaId, int pTipoProductoId)
        {
            ProductoId = pProductoId;
            NombreModelo = pNombreModelo;
            MarcaId = pMarcaId;
            TipoProductoId = pTipoProductoId;
        }
    }
}
