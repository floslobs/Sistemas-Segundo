using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Mensajes
    {
        public Mensajes() 
        {  
            texto = "";
            fecha = DateTime.Now;
            usuarioOrigen = new Usuarios(0, "");
            usuarioDestino = new Usuarios(0, "");
        }

        public Mensajes(string pTexto, DateTime pFecha, Usuarios pUsuarioOrigen, Usuarios pUsuarioDestino)
        {
            texto = pTexto;
            fecha = pFecha;
            usuarioOrigen = pUsuarioOrigen;
            usuarioDestino = pUsuarioDestino;
        }


        public string texto { get; set; }
        public DateTime fecha { get; set; }
        public Usuarios usuarioOrigen { get; set; }
        public Usuarios usuarioDestino { get; set; }

    }
}
