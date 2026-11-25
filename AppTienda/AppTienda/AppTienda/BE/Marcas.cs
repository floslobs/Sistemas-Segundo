using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class Marcas
    {
        public int MarcaId { get; set; }
        public string Nombre { get; set; }

        public Marcas(){}
        public Marcas(int pMarcaId, string pNombre)
        {
            MarcaId = pMarcaId;
            Nombre = pNombre;
        }
    }
}
