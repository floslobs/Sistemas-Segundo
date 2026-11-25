using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTienda.FE;

namespace AppTienda.FE
{
    public partial class AppTienda : Form
    {
        public AppTienda()
        {
            InitializeComponent();
        }



        private void btnRegistrarCliente_Click_1(object sender, EventArgs e)
        {
            Clientes registrarCliente = new Clientes();
            registrarCliente.ShowDialog();
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            CargarProducto cargarProducto = new CargarProducto;
            cargarProducto.ShowDialog();
        }
    }
}
