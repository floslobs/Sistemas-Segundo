using System.Diagnostics.Eventing.Reader;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace WS
{
    public partial class FormWS : Form
    {
        public FormWS()
        {
            InitializeComponent();
        }

        public List<Usuario> usuariolis = new List<Usuario>();
        public List<Mensaje> mensajelis = new List<Mensaje>();
        private void bCrearUsu_Click(object sender, EventArgs e)
        {
            if (NomUsu.Text.Length == 0)
            {
                MessageBox.Show(text: "falta ingresar un nombre");
                return;
            }
            if (NumUsu.Value == 0)
            {
                MessageBox.Show(text: "falta ingresar un numero");
                return;
            }

            //crear un objeto de tipo usuario

            Usuario miUsuario = new Usuario((int)NumUsu.Value, NomUsu.Text);

            usuariolis.Add(miUsuario);

            //CONVIERTE UN NUMERO A UN STRING
            MessageBox.Show(usuariolis.Count.ToString() + " USUARIO INGRESADO");

        }

        private void UsuMens_Click(object sender, EventArgs e)
        {
            UsuMens.Items.Clear();
            foreach (Usuario miUsuario in usuariolis)
            {
                UsuMens.Items.Add(miUsuario);

            }
        }

        private void DestinoMens_Click(object sender, EventArgs e)
        {
            DestinoMens.Items.Clear();
            foreach (Usuario miUsuario in usuariolis)
            {
                DestinoMens.Items.Add(miUsuario);

            }
        }

        private void bEnviarMsn_Click(object sender, EventArgs e)
        {
            int i = UsuMens.SelectedIndex;
            int j = DestinoMens.SelectedIndex;
            if (TexMens.Text.Trim().Length == 0)
            {
                MessageBox.Show("debe ingresar el mensaje");
            }
            if (i >= 0 && j >= 0)
            {


                //OBTENGO EL OBJETO DEL COMBO Y LO CASTEO A UN OBJETO DEL TIPO USUARIO
                Usuario MiUsuMens = (Usuario)UsuMens.Items[i];
                Usuario MiDestinoMens = (Usuario)DestinoMens.Items[j];

                if (MiUsuMens.Numero == MiDestinoMens.Numero)
                {
                    MessageBox.Show("el usuario origen y el usuario destino no debe ser el mismo ");

                    return;
                }

                //FORMA1
               /* Mensaje MiMensaje = new Mensaje();
                MiMensaje.Fecha = DateTime.Now;
                MiMensaje.UsuMens = MiUsuMens;
                MiMensaje.DestinoMens = MiDestinoMens;
                MiMensaje.Texto = TexMens.Text;

                mensajelis.Add(MiMensaje);*/

                // Forma 2
                Mensaje MiMensaje2 = new Mensaje(TexMens.Text, DateTime.Now, MiUsuMens, MiDestinoMens);
                mensajelis.Add(MiMensaje2);
            }
            else
            {
                MessageBox.Show("Seleccione el usuario origen y destino");
                return;
            }
        }

        private void UsuMens2_Click(object sender, EventArgs e)
        {
            UsuMens2.Items.Clear();
            foreach (Usuario miUsuario in usuariolis)
            {
                UsuMens2.Items.Add(miUsuario);

            }
        }

        private void DestinoMens2_Click(object sender, EventArgs e)
        {
            DestinoMens2.Items.Clear();
            foreach (Usuario miUsuario in usuariolis)
            {
                DestinoMens2.Items.Add(miUsuario);

            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            // Obtenemos los índices seleccionados en los ComboBox de emisor y receptor
            int i = UsuMens2.SelectedIndex;
            int j = DestinoMens2.SelectedIndex;

            // Verificamos que se haya seleccionado un usuario en ambos ComboBox
            if (i >= 0 && j >= 0)
            {
                // Obtenemos el usuario emisor desde el ComboBox (lo casteamos porque el ComboBox guarda objetos de tipo Usuario)
                Usuario emisor = (Usuario)UsuMens2.Items[i];

                // Obtenemos el usuario receptor desde el otro ComboBox
                Usuario receptor = (Usuario)DestinoMens2.Items[j];

                // Filtramos los mensajes que cumplan con que el emisor y el receptor coincidan con los seleccionados
                // Usamos LINQ (.Where) para obtener solo los mensajes deseados de la lista general
                var mensajesFiltrados = mensajelis.Where(m =>
                    m.UsuMens.Numero == emisor.Numero &&       // Comprobamos que el número del emisor del mensaje coincida
                    m.DestinoMens.Numero == receptor.Numero    // Y que también coincida el receptor
                ).ToList(); // Convertimos el resultado en una lista para poder usarla fácilmente

                // Limpiamos el DataGridView para asegurarnos de que no haya datos anteriores
                dataGrid1.DataSource = null;

                // Asignamos la lista filtrada como fuente de datos al DataGridView
                // Esto muestra los mensajes correspondientes entre el emisor y el receptor seleccionados
                dataGrid1.DataSource = mensajesFiltrados;
            }
            else
            {
                // Si no se seleccionaron ambos usuarios, mostramos un mensaje al usuario
                MessageBox.Show("Seleccione el usuario origen y destino para buscar mensajes.");
            }


        }
    }
}
