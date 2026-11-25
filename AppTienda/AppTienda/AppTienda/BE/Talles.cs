using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class Talles
    {
        public int TalleId { get; set; }
        public string Talle { get; set; }
       
                public Talles() { }
        
        public Talles(int pTalleId, string pTalle)
        {
            TalleId = pTalleId;
            Talle = pTalle;
        }
    }
}
