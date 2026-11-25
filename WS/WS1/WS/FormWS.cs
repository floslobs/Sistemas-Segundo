using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS
{
    public partial class FormWS : Form
    {
        public FormWS()
        {
            InitializeComponent();
        }
        public List<Usuario> usuariolis = new List<Usuario>();

        private void crearUsuario_Click(object sender, EventArgs e)
        {
            
            if (NombreUsu1.Text.Length == 0)
            {
                MessageBox.Show(text: "falta ingresar un nombre");
                return;
            }

            //crear un objeto de tipo usuario


        

            //CONVIERTE UN NUMERO A UN STRING
            MessageBox.Show(usuariolis.Count.ToString() + " USUARIO INGRESADO");
        }

        private void NombreUsu2_Click(object sender, EventArgs e)
        {
            NombreUsu2.Items.Clear();
            foreach (Usuario miUsuario in usuariolis)
            {
                NombreUsu2.Items.Add(NombreUsu1);

            }





        }
    }
}