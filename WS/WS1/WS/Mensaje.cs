using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS
{
    public class Mensaje
    {
        public Mensaje() {

            texto = "";
            fecha = DateTime.Now;
            UsuarioOrigen = new Usuario(0, "");
            UsuarioDestino = new Usuario(0, "");
        
        }
        public Mensaje(string Ptexto, DateTime Pfecha, Usuario PUsuarioOrigen, Usuario PUsuarioDestino)
        {
            this.texto = Ptexto;
            this.fecha = Pfecha;
            this.UsuarioOrigen = PUsuarioOrigen;
            this.UsuarioDestino = PUsuarioDestino;
        }

        public string texto {  get; set; }
        public DateTime fecha { get; set; }

        public Usuario UsuarioOrigen {  get; set; }
        public Usuario UsuarioDestino { get; set; }
    }
}
