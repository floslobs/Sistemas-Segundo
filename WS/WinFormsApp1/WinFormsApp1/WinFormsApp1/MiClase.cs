using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class MiClase
    {
        public int Cantidad { get; set; }

        public MiClase() 
        {
            Cantidad++;
        }

        public void mostrarCantidad()
        {
            MessageBox.Show(Cantidad.ToString());
        }
    }
}
