using Empleados.BE;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Empleados.FE
{
    public partial class Empleados : Form
    {
        Conexion conexion = new Conexion();
        public Empleados()
        {
            InitializeComponent();
            dataGridEmple.DataSource = empleadolis;

        }

        BindingList<CargarEmpleados> empleadolis = new BindingList<CargarEmpleados>();

        //public List<CargarEmpleados> empleadolis = new List<CargarEmpleados>();

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (NomBre.Text.Length == 0)
            {
                MessageBox.Show(text: "falta ingresar un nombre");
                return;
            }
            if (NumeroL.Value == 0 & PrecioHora.Value == 0)
            {
                MessageBox.Show(text: "falta ingresar un numero");
                return;
            }

            CargarEmpleados miEmpleado = new CargarEmpleados((int)NumeroL.Value, NomBre.Text, (int)PrecioHora.Value, FechaNac.Value);

            empleadolis.Add(miEmpleado);

            string consulta = "INSERT INTO empleados (nombre, fecha nacimiento) VALUES (@nombre, @fecha nacimiento)";
            SqlParameter[] parametros = new SqlParameter[]
            {
               new SqlParameter("@nombre", NomBre.Text)
            };

            int filas = conexion.EjecutarConsulta(consulta, parametros);

            if (filas > 0)
                MessageBox.Show("Empleado guardado correctamente");
            else
                MessageBox.Show("Error al guardar");



        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada actualmente
            if (dataGridEmple.CurrentRow != null)
            {

                // Obtenemos el objeto de tipo CargarEmpleados asociado a la fila seleccionada
                CargarEmpleados empleadoSeleccionado = (CargarEmpleados)dataGridEmple.CurrentRow.DataBoundItem;

                // Modificamos directamente sus propiedades con los valores actuales del formulario
                empleadoSeleccionado.Numero = (int)NumeroL.Value;
                empleadoSeleccionado.Nombre = NomBre.Text;
                empleadoSeleccionado.PrecioHora = (int)PrecioHora.Value;
                empleadoSeleccionado.FechaNac = FechaNac.Value;

                // Refrescamos el DataGridView para que se vean los cambios
                dataGridEmple.Refresh();

                MessageBox.Show("Empleado modificado correctamente.");

            }
            else
            {
                // Si no hay fila seleccionada, muestra un mensaje de advertencia
                MessageBox.Show("Seleccione una fila para modificar.");
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (dataGridEmple.CurrentRow != null)
            {
                // Obtiene el empleado seleccionado desde la fila
                CargarEmpleados empleadoSeleccionado = (CargarEmpleados)dataGridEmple.CurrentRow.DataBoundItem;

                // Lo elimina de la lista
                empleadolis.Remove(empleadoSeleccionado);

                MessageBox.Show("Empleado eliminado");
            }
            else
            {
                MessageBox.Show("Seleccioná un empleado para eliminar");
            }

        }

        private void btnCargarHS_Click(object sender, EventArgs e)
        {
            // Creamos una lista vacía para almacenar solo los nombres
            List<string> nombres = new List<string>();

            // Recorremos la lista de empleados cargados
            foreach (CargarEmpleados emp in empleadolis)
            {
                nombres.Add(emp.Nombre); // Agregamos el nombre a la nueva lista
            }

            // Creamos una nueva instancia de EmpleadosHs y le pasamos la lista de nombres
            EmpleadosHs empleadosHsN = new EmpleadosHs(nombres);

            // Mostramos el formulario
            empleadosHsN.Show();
        }

        
    }
}
