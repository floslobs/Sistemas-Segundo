using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public class Usuarios
    {
        public Usuarios(int num, string nom) {
            numero = num;
            nombre = nom;
        }
        public int numero { get; set; }
        public string nombre { get; set; }
        public override string ToString()
        {
            return nombre; // Define cómo se muestra en el ComboBox
        }
    }
}
