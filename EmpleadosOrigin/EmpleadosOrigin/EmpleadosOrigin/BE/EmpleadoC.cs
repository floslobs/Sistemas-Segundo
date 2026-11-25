using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosOrigin.BE
{
    public class EmpleadoC
    {
        public int Legajo { get; set; }

        public string Nombre { get; set; }

        public int PrecioHora { get; set; }
        public DateTime FechaNac { get; set; }

        public EmpleadoC(int pLegajo, string pNom, int pPrecioHora, DateTime pFechaNac)
        {
            Legajo = pLegajo;
            Nombre = pNom;
            PrecioHora = pPrecioHora;
            FechaNac = pFechaNac;

        }
        public override string ToString()
        {
            return Nombre;//define como se muestra el combobox
        }
    }
}

