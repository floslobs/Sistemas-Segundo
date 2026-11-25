using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados.BE
{
    public class CargarEmpleados
    {
        public int Numero { get; set; }

        public string Nombre { get; set; }

        public int PrecioHora { get; set; }
        public DateTime FechaNac { get; set; }

        public CargarEmpleados(int pNum, string pNom, int pPrecioHora, DateTime pFechaNac)
        {
            Numero = pNum;
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
