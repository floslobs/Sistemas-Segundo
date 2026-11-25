using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.MODELOS
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string NombreModelo { get; set; }
        public int MarcaId { get; set; }
        public int TipoProductoId { get; set; }

        // Campos de ayuda (opcionales en DTO) para JOINs
        public string NombreMarca { get; set; }
        public string NombreTipoProducto { get; set; }
    }

}
