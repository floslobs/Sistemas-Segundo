using AppTienda.DAL;

namespace AppTienda
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion.ObtenerConexion(); // abre la conexion
                MessageBox.Show("Conexion abierta correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexion: " + ex.Message);
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conexion.CerrarConexion(); // cierra al salir

        }
    }
}
