using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS
{
    public class Usuario
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public Usuario(int pNum, string pNom)
        {
            Numero = pNum;
            Nombre = pNom;

        }
            //sobreescribir, metodo que devuleve un estring
        public override string ToString()
        {
            return Nombre;//define como se muestra el combobox
        }
    }
}
