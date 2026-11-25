using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS
{
    public class Mensaje
    {
        public string Texto { get; set; }
        public DateTime Fecha { get; set; }

        public Usuario UsuMens { get; set; }
        public Usuario DestinoMens { get; set; }
        public Mensaje()
        {

            Texto = "";
            Fecha = DateTime.Now;
            UsuMens = new Usuario(0, "");
            DestinoMens = new Usuario(0, "");

        }
        public Mensaje(string Ptexto, DateTime Pfecha, Usuario PUsuMens, Usuario PDestinoMens)
        {
            this.Texto = Ptexto;
            this.Fecha = Pfecha;
            this.UsuMens = PUsuMens;
            this.DestinoMens = PDestinoMens;
        }
    }
}
