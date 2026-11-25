using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class WS : Form
    {
        public List<Usuarios> usuariosWS = new List<Usuarios>();
        public List<Mensajes> mensajesWS = new List<Mensajes>();

        public WS()
        {
            InitializeComponent();
        }

        private void GuardarUsuario_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Falta ingresar el nombre");
                return;
            }
            if (spNumero.Value == 0)
            {
                MessageBox.Show("Falta ingresar el número");
                return;
            }


            //Crear un objeto de tipo usuario
            Usuarios miNuevoUsuario = new Usuarios((int)spNumero.Value, txtNombre.Text);
            usuariosWS.Add(miNuevoUsuario);
            MessageBox.Show(usuariosWS.Count.ToString() + " Usuarios Ingresados ");
        }

        private void WS_Load(object sender, EventArgs e)
        {

        }

        private void cmbUsuarioOrigen_Click(object sender, EventArgs e)
        {
            cmbUsuarioOrigen.Items.Clear();
            foreach (Usuarios miUsuario in usuariosWS)
            {
                cmbUsuarioOrigen.Items.Add(miUsuario);
            }

        }

        private void cmbUsuarioDestino_Click(object sender, EventArgs e)
        {
            cmbUsuarioDestino.Items.Clear();
            foreach (Usuarios miUsuario in usuariosWS)
            {
                cmbUsuarioDestino.Items.Add(miUsuario);
            }
        }

        private void GuardarMensaje_Click(object sender, EventArgs e)
        {
            int i = cmbUsuarioOrigen.SelectedIndex;
            int j = cmbUsuarioDestino.SelectedIndex;
            if (txtTextoMensaje.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe ingresar el mensaje");
                return;
            }
            if (i >= 0 && j >= 0)
            {
                // Obtengo el objeto del combo y lo casteo a un objeto del tipo Usuarios
                Usuarios miUsuarioOrigen = (Usuarios)cmbUsuarioOrigen.Items[i];
                Usuarios miUsuarioDestino = (Usuarios)cmbUsuarioDestino.Items[j];

                if (miUsuarioOrigen.numero == miUsuarioDestino.numero)
                {
                    MessageBox.Show("El usuario origen y destino debe ser distinto");
                    return;
                }

                // Si llego hasta aca esta todo OK

                // Forma 1 
                Mensajes miMensaje = new Mensajes();
                miMensaje.fecha = DateTime.Now;
                miMensaje.usuarioOrigen = miUsuarioOrigen;
                miMensaje.usuarioDestino = miUsuarioDestino;
                miMensaje.texto = txtTextoMensaje.Text;

                mensajesWS.Add(miMensaje);

                // Forma 2
                Mensajes miMensaje2 = new Mensajes(txtTextoMensaje.Text, DateTime.Now, miUsuarioOrigen, miUsuarioDestino);
                mensajesWS.Add(miMensaje2);

            }
            else
            {
                MessageBox.Show("Seleccione el usuario origen y destino");
                return;
            }
        }
    }
}
