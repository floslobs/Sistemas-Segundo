using EmpleadosOrigin.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpleadosOrigin.FE
{
    public partial class Liquidacion : Form
    {
        private int legajo;
        private string nombre;
        public Liquidacion(int legajoRecibido, string nombreRecibido)
        {
            InitializeComponent();
            legajo = legajoRecibido;
            nombre = nombreRecibido;
            
        }

        private void Liquidacion_Load(object sender, EventArgs e)
        {
            // Mostrar nombre y fecha actual
            lblnombre.Text = "Empleado:   " + nombre;
            lblfecha.Text = "Mes:   " + DateTime.Now.ToString("MMMM yyyy");

            // Obtener horas y precio desde BE
            int horas = EmpleadoManager.ObtenerHorasTrabajadasDelMes(legajo);
            decimal precio = EmpleadoManager.ObtenerPrecioPorHora(legajo);
            decimal total = horas * precio;

            // Mostrar datos en pantalla
            lblHoras.Text = "Horas trabajadas:      " + horas;
            lblPrecioHora.Text = "Precio por hora:       $" + precio.ToString("0.00");
            lblTotal.Text = "Total a cobrar:         $" + total.ToString("0.00");
        }
    }
}
