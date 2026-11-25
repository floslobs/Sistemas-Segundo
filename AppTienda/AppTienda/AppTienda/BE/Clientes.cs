using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    public class Clientes
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }

        public Clientes() { }
        public Clientes(int ClienteId, string pNombre, string pDNI)
        {

            ClienteId = ClienteId;
            Nombre = pNombre;
            DNI = pDNI;

        }
    }

    
}
