using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace EmpleadosOrigin.FE
{
    public partial class PrincipalEmpleados : Form
    {
        public PrincipalEmpleados()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // ¡Esto es obligatorio!
            this.BackColor = System.Drawing.Color.DarkOliveGreen; // Cambia 'LightBlue' por el color que prefieras
            this.Load += PrincipalEmpleados_Load; // Asegúrate de que el evento esté suscrito

        }
        private void PrincipalEmpleados_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient mdi)
                {
                    try
                    {
                        mdi.BackColor = Color.DarkOliveGreen;
                    }
                    catch { /* Ignorar errores de acceso */ }
                }
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            // Crea una nueva instancia del formulario "Empleados"
            Empleados empleForm1 = new Empleados();

            // Establece que el formulario actual (this) es el contenedor MDI del formulario hijo.
            // Esto permite que el formulario "Empleados" se abra dentro del formulario principal.
            empleForm1.MdiParent = this;
            empleForm1.BackColor = this.BackColor; // Hereda el color del padre

            // Muestra el formulario "Empleados" dentro del contenedor MDI.
            empleForm1.Show();
        }

        private void btnHoras_Click(object sender, EventArgs e)
        {
            EmpleadosHs empleform2 = new EmpleadosHs();
            empleform2.MdiParent = this;
            empleform2.BackColor = this.BackColor; // Hereda el color del padre
            empleform2.Show();

        }

        private void btnLiquidacion_Click(object sender, EventArgs e)
        {
            LiquidacionEmple empleform3 = new LiquidacionEmple();
            empleform3.MdiParent = this;
            empleform3.BackColor = this.BackColor; // Hereda el color del padre
            empleform3.Show();

        }
    }
}
