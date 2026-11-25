using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class Ventas
    {
        public int VentaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }

        public List<VentaDeTalle> Detalles { get; set; } = new List<VentaDeTalle>();
        public List<VentasTalles> DetallesTalle { get; set; } = new List<VentasTalles>();
        public Ventas() { }
        public Ventas(int ventaId, int clienteId, DateTime fecha)
        {
            VentaId = ventaId;
            ClienteId = clienteId;
            Fecha = fecha;
        }

    }
}
