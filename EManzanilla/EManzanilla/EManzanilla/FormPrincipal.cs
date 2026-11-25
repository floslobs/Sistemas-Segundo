using Microsoft.Data.SqlClient;
using EManzanilla.FE;
using System.Data;
using System.Drawing.Drawing2D;

namespace EManzanilla
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            string texto = label1.Text;
            Font fuente = label1.Font;
            Graphics g = e.Graphics;

            // Dibujar borde negro
            g.DrawRectangle(Pens.Black, 0, 0, label1.Width - 1, label1.Height - 1);

            // Dibujar contorno del texto
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddString(texto, fuente.FontFamily, (int)fuente.Style, g.DpiY * fuente.SizeInPoints / 72, new Point(0, 0), StringFormat.GenericDefault);
                g.DrawPath(Pens.Black, path); // contorno
                g.FillPath(Brushes.White, path); // relleno
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
            empleados.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
