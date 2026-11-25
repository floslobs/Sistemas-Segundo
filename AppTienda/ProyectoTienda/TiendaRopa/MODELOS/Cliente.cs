using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaRopa.MODELOS
{
    public class Cliente
    {
        public int ClienteId { get; set; }    // 0 para nuevos registros
        public string Nombre { get; set; }    // NOT NULL
        public string DNI { get; set; }       // NOT NULL
    }
}
