using EmpleadosOrigin.BE;
using EmpleadosOrigin.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace EmpleadosOrigin.FE
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }
        // Evento que se ejecuta al cargar el formulario para inicializar datos y controles.
        private void Empleados_Load_1(object sender, EventArgs e)
        {
            CargarEmpleadosEnGrilla(); // Carga la grilla automáticamente al iniciar
        }
        private void CargarEmpleadosEnGrilla()
        {
            // Limpia filas anteriores para evitar duplicados
            dataGridEmple.Rows.Clear();

            // Si no hay columnas, las agrega
            if (dataGridEmple.Columns.Count == 0)
            {
                dataGridEmple.Columns.Add("Legajo", "Legajo");
                dataGridEmple.Columns.Add("Nombre", "Nombre");
                dataGridEmple.Columns.Add("PrecioHora", "Precio por Hora");
                dataGridEmple.Columns.Add("FechaNac", "Fecha de Nacimiento");
            }

            // Trae la lista de empleados desde la base
            EmpleadoManager manager = new EmpleadoManager();
            List<EmpleadoC> empleados = manager.ObtenerTodos();

            // Muestra cada empleado en una fila
            foreach (EmpleadoC emp in empleados)
            {
                dataGridEmple.Rows.Add(
                    emp.Legajo,
                    emp.Nombre,
                    emp.PrecioHora,
                    emp.FechaNac.ToShortDateString()
                );
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            //try: aquí va el codigo que puede fallar(por ejemplo, acceder a base de datos, leer un archivo, etc.)
            try
            {
                // Creamos un nuevo objeto EmpleadoC con los datos que ingreso el usuario en los controles del formulario.
                EmpleadoC emp = new EmpleadoC(
                    (int)Legajo.Value,
                    NomBre.Text,
                    (int)PrecioHora.Value,
                    FechaNac.Value
                );

                // Creamos una instancia de la clase EmpleadoManager, que maneja la lógica de negocio y acceso a datos.
                EmpleadoManager manager = new EmpleadoManager();

                // Guardamos el empleado en la base de datos llamando al método GuardarEmpleado.
                // Puede lanzar una excepción si algo falla (por ejemplo, datos inválidos o error en la DB).
                manager.GuardarEmpleado(emp);

                // Una vez guardado el empleado, recargamos la grilla para mostrar todos los empleados actualizados.
                CargarEmpleadosEnGrilla();

                // Mostramos un mensaje para informar que el empleado fue guardado correctamente.
                MessageBox.Show("Empleado guardado correctamente.");
            }
            //catch: aquí va el codigo que maneja el error si algo sale mal dentro del try
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya una fila seleccionada
                if (dataGridEmple.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccioná una fila para modificar.");
                    return;
                }

                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridEmple.SelectedRows[0];

                // Obtener el legajo (clave primaria)
                int legajoOriginal = Convert.ToInt32(filaSeleccionada.Cells["Legajo"].Value);

                // Crear un nuevo objeto con los datos actualizados desde los controles del formulario
                EmpleadoC empModificado = new EmpleadoC(
                    legajoOriginal,                 // Legajo original (no editable)
                    NomBre.Text,                    // Nombre nuevo desde textbox
                    (int)PrecioHora.Value,          // Precio por hora nuevo
                    FechaNac.Value                  // Fecha de nacimiento nueva
                );

                // Llamar a la lógica para actualizar en la base de datos
                EmpleadoManager manager = new EmpleadoManager();
                manager.ModificarEmpleado(empModificado);

                // Actualizar la fila del DataGridView con los nuevos datos
                filaSeleccionada.Cells["Nombre"].Value = empModificado.Nombre;
                filaSeleccionada.Cells["PrecioHora"].Value = empModificado.PrecioHora;
                filaSeleccionada.Cells["FechaNac"].Value = empModificado.FechaNac.ToShortDateString();

                MessageBox.Show("Empleado modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        // CellClick se usa para detectar qué fila fue seleccionada y cargar sus datos en los controles del formulario.
        private void dataGridEmple_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si se hizo clic en una fila válida (no en el encabezado)
            if (e.RowIndex >= 0)
            {
                // Obtener la fila clickeada
                DataGridViewRow fila = dataGridEmple.Rows[e.RowIndex];

                // Cargar los valores de la fila en los controles del formulario
                Legajo.Value = Convert.ToInt32(fila.Cells["Legajo"].Value);
                NomBre.Text = fila.Cells["Nombre"].Value.ToString();
                PrecioHora.Value = Convert.ToInt32(fila.Cells["PrecioHora"].Value);
                FechaNac.Value = Convert.ToDateTime(fila.Cells["FechaNac"].Value);
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try // Intenta ejecutar el bloque de código que puede fallar
            {
                // Verifica si hay al menos una fila seleccionada en la grilla
                if (dataGridEmple.SelectedRows.Count > 0)
                {
                    // Obtiene la primera fila seleccionada del DataGridView
                    DataGridViewRow filaSeleccionada = dataGridEmple.SelectedRows[0];

                    // Extrae el valor de la celda "Legajo" y lo convierte a entero
                    int legajo = Convert.ToInt32(filaSeleccionada.Cells["Legajo"].Value);

                    // Instancia el manejador de empleados y llama al método para eliminar por legajo
                    EmpleadoManager manager = new EmpleadoManager();
                    manager.EliminarEmpleado(legajo);

                    // Elimina la fila del DataGridView
                    dataGridEmple.Rows.Remove(filaSeleccionada);

                    // Muestra mensaje de éxito
                    MessageBox.Show("Empleado eliminado correctamente.");
                }
                else
                {
                    // Si no se seleccionó ninguna fila, se muestra un mensaje de advertencia
                    MessageBox.Show("Por favor seleccioná una fila para eliminar.");
                }
            }
            catch (Exception ex) // Si ocurre un error, lo captura y muestra un mensaje con el error
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica si hay una fila seleccionada en el DataGridView (dataGridEmple)
                if (dataGridEmple.CurrentRow != null)
                {
                    // Obtiene el legajo del empleado desde la columna "Legajo"
                    int legajo = Convert.ToInt32(dataGridEmple.CurrentRow.Cells["Legajo"].Value);

                    // Obtiene el nuevo precio por hora desde la columna "PrecioHora"
                    decimal nuevoPrecio = Convert.ToDecimal(dataGridEmple.CurrentRow.Cells["PrecioHora"].Value);

                    // Crea y abre una conexión con la base de datos
                    using (SqlConnection conn = new SqlConnection(conexion.CadenaConexion))
                    {
                        conn.Open();

                        // Inicia una transacción SQL
                        SqlTransaction trans = conn.BeginTransaction();

                        try
                        {
                            // Define la sentencia SQL de actualización
                            string sql = "UPDATE Empleados SET PrecioHora = @precio WHERE Legajo = @legajo";

                            // Crea el comando SQL, ligado a la conexión y la transacción
                            using (SqlCommand cmd = new SqlCommand(sql, conn, trans))
                            {
                                // Asigna los valores a los parámetros de la consulta
                                cmd.Parameters.AddWithValue("@precio", nuevoPrecio);
                                cmd.Parameters.AddWithValue("@legajo", legajo);

                                // Ejecuta el comando y devuelve cuántas filas fueron afectadas
                                int filasAfectadas = cmd.ExecuteNonQuery();

                                // 🧪 Esta línea puede usarse para forzar un error y probar la transacción
                                // throw new Exception("Error de prueba: fuerza rollback.");

                                // Si se afectó una fila, significa que el update fue exitoso
                                if (filasAfectadas == 1)
                                {
                                    // Confirma la transacción
                                    trans.Commit();
                                    MessageBox.Show("Precio actualizado correctamente.");
                                }
                                else
                                {
                                    // Si no se afectó ninguna fila, algo falló (legajo no existe), se lanza un error
                                    throw new Exception("No se encontró el empleado.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Si hay un error dentro del bloque, se revierte la transacción
                            trans.Rollback();
                            MessageBox.Show("Error al actualizar: " + ex.Message);
                        }
                    }
                }
                else
                {
                    // Si no hay ninguna fila seleccionada en la grilla, se muestra un mensaje
                    MessageBox.Show("Seleccione una fila para actualizar.");
                }
            }
            catch (Exception ex)
            {
                // Captura cualquier otro error general del proceso completo
                MessageBox.Show("Error general: " + ex.Message);
            }
        }
    }
}
