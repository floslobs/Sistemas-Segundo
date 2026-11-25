using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EManzanilla.BE;
using FluentValidation;


namespace EManzanilla.FE
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            CargarEmpleadosEnGrilla();
            dataGridViewEmple.SelectionChanged += dataGridViewEmple_SelectionChanged;

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var emp = new Empleado
            {
                Nombre = comboBoxNomyApe.Text.Trim(),
                Dni = numericUpDownDni.Value.ToString(),
                Telefono = numericUpDownTelefono.Value.ToString(),
                PHora = (int)numericUpDownPHora.Value,
                Activo = checkBoxActivo.Checked
            };
            var bEempleado = new BEempleado();

            int nuevoId = bEempleado.AgregarEmpleado(emp, dataGridViewEmple);

            if (nuevoId > 0)
            {
                emp.EmpleadoId = nuevoId;

                // 🔹 agrega solo una fila a la grilla actual
                dataGridViewEmple.Rows.Add(
                    emp.EmpleadoId,
                    emp.Nombre,
                    emp.Dni,
                    emp.Telefono,
                    emp.PHora,
                    emp.Activo
                );

                MessageBox.Show("Empleado agregado correctamente");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error: " + bEempleado.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmple.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un empleado para editar");
                return;
            }

            DataGridViewRow fila = dataGridViewEmple.SelectedRows[0];

            var emp = new Empleado
            {
                EmpleadoId = Convert.ToInt32(fila.Cells["EmpleadoId"].Value), // importante para el WHERE
                Nombre = comboBoxNomyApe.Text.Trim(),
                Dni = numericUpDownDni.Value.ToString(),
                Telefono = numericUpDownTelefono.Value.ToString(),
                PHora = (int)numericUpDownPHora.Value,
                Activo = checkBoxActivo.Checked
            };

            var bEempleado = new BEempleado();
            int resultado = bEempleado.EditarEmpleado(emp);

            if (resultado > 0)
            {
                MessageBox.Show("Empleado actualizado correctamente");

                // 🔹 Actualizar la fila de la grilla directamente
                fila.Cells["Nombre"].Value = emp.Nombre;
                fila.Cells["Dni"].Value = emp.Dni;
                fila.Cells["Telefono"].Value = emp.Telefono;
                fila.Cells["PHora"].Value = emp.PHora;
                fila.Cells["Activo"].Value = emp.Activo;
                dataGridViewEmple.Refresh();  // 🔹 fuerza el refresco visual de la grilla


                // 🔹 Registrar en HistorialInactivos si quedó inactivo
                if (!emp.Activo)
                {
                    BEHistorialInactivo beHist = new BEHistorialInactivo();
                    BE.HistorialInactivo hi = new BE.HistorialInactivo
                    {
                        EmpleadoId = emp.EmpleadoId,
                        FechaInactivo = DateTime.Now
                    };

                    int historialId = beHist.RegistrarInactivo(hi);

                    if (historialId > 0)
                        MessageBox.Show("Empleado registrado como inactivo en el historial."); // 🔹 Registrar en HistorialInactivos si quedó inactivo
                                                                                               // 🔹 Quitamos la fila de la grilla
                    dataGridViewEmple.Rows.Remove(fila);
                }
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar el empleado: " + bEempleado.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmple.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un empleado para eliminar.");
                return;
            }

            DataGridViewRow fila = dataGridViewEmple.SelectedRows[0];
            int empleadoId = Convert.ToInt32(fila.Cells["EmpleadoId"].Value);

            var bEempleado = new BEempleado();
            int resultado = bEempleado.EliminarEmpleado(empleadoId);

            if (resultado > 0)
            {
                MessageBox.Show("Empleado eliminado correctamente.");
                dataGridViewEmple.Rows.Remove(fila);
            }
            else
            {
                MessageBox.Show("Error al eliminar el empleado: " + bEempleado.Error);
            }
        }
        private void LimpiarCampos()
        {
            comboBoxNomyApe.SelectedIndex = -1;
            comboBoxNomyApe.Text = "";

            numericUpDownDni.Value = numericUpDownDni.Minimum;
            numericUpDownTelefono.Value = numericUpDownTelefono.Minimum;
            numericUpDownPHora.Value = numericUpDownPHora.Minimum;
            checkBoxActivo.Checked = true;
        }
        private void CargarEmpleadosEnGrilla()
        {
            dataGridViewEmple.Rows.Clear();

            if (dataGridViewEmple.Columns.Count == 0)
            {
                dataGridViewEmple.Columns.Add("EmpleadoId", "EmpleadoId");
                dataGridViewEmple.Columns.Add("Nombre", "Nombre");
                dataGridViewEmple.Columns.Add("Dni", "Dni");
                dataGridViewEmple.Columns.Add("Telefono", "Telefono");
                dataGridViewEmple.Columns.Add("PHora", "PHora");
                dataGridViewEmple.Columns.Add("Activo", "Activo");


            }
            // Ocultamos la columna de ID
            dataGridViewEmple.Columns["EmpleadoId"].Visible = false;

            BEempleado bEempleado = new BEempleado();
            List<Empleado> empleados = bEempleado.ObtenerTodosEmpleados();

            if (empleados.Count == 0)
            {
                MessageBox.Show("No hay empleados cargados en la base de datos.");
                return;
            }

            foreach (Empleado emp in empleados)
            {
                dataGridViewEmple.Rows.Add(
                    emp.EmpleadoId,
                    emp.Nombre,
                    emp.Dni,
                    emp.Telefono,
                    emp.PHora,
                    emp.Activo
                );
            }

        }

        private void dataGridViewEmple_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEmple.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridViewEmple.SelectedRows[0];

                // Asignamos valores a los controles
                comboBoxNomyApe.Text = fila.Cells["Nombre"].Value.ToString();
                numericUpDownDni.Value = Convert.ToDecimal(fila.Cells["Dni"].Value);
                numericUpDownTelefono.Value = Convert.ToDecimal(fila.Cells["Telefono"].Value);
                numericUpDownPHora.Value = Convert.ToDecimal(fila.Cells["PHora"].Value);
                checkBoxActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value);
            }
        }

        private void btnCargarHoras_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmple.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un empleado antes de cargar horas.");
                return;
            }

            DataGridViewRow fila = dataGridViewEmple.SelectedRows[0];
            Empleado empSeleccionado = new Empleado
            {
                EmpleadoId = Convert.ToInt32(fila.Cells["EmpleadoId"].Value),
                Nombre = fila.Cells["Nombre"].Value.ToString(),
                Dni = numericUpDownDni.Value.ToString(),
                Telefono = numericUpDownTelefono.Value.ToString(),
                PHora = Convert.ToInt32(fila.Cells["PHora"].Value),
                Activo = Convert.ToBoolean(fila.Cells["Activo"].Value)
            };

            HorasTrabajo frmHoras = new HorasTrabajo(empSeleccionado);
            frmHoras.ShowDialog();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            // Verificamos que haya una fila seleccionada
            if (dataGridViewEmple.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un empleado antes de ver el resumen.");
                return;
            }

            // Tomamos la fila seleccionada
            DataGridViewRow fila = dataGridViewEmple.SelectedRows[0];

            // Creamos el objeto Empleado con los datos de esa fila
            Empleado empSeleccionado = new Empleado
            {
                EmpleadoId = Convert.ToInt32(fila.Cells["EmpleadoId"].Value),
                Nombre = fila.Cells["Nombre"].Value.ToString(),
                Dni = numericUpDownDni.Value.ToString(),
                Telefono = numericUpDownTelefono.Value.ToString(),
                PHora = Convert.ToInt32(fila.Cells["PHora"].Value),
                Activo = Convert.ToBoolean(fila.Cells["Activo"].Value)
            };

            // Abrimos el formulario de Resumen y le pasamos el empleado
            Resumen frmResumen = new Resumen(empSeleccionado);
            frmResumen.ShowDialog();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();

            foreach (DataGridViewRow fila in dataGridViewEmple.Rows)
            {
                if (fila.Cells["Nombre"].Value != null &&
                    fila.Cells["Dni"].Value != null &&
                    fila.Cells["Telefono"].Value != null)
                {
                    // Mostramos la fila si el Nombre, DNI o Teléfono contiene el texto
                    fila.Visible = fila.Cells["Nombre"].Value.ToString().ToLower().Contains(filtro)
                                || fila.Cells["Dni"].Value.ToString().Contains(filtro)
                                || fila.Cells["Telefono"].Value.ToString().Contains(filtro);
                }
            }
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            // Verificamos que haya una fila seleccionada
            if (dataGridViewEmple.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un empleado antes de ver los pagos.");
                return;
            }

            // Tomamos la fila seleccionada
            DataGridViewRow fila = dataGridViewEmple.SelectedRows[0];

            // Creamos el objeto Empleado con los datos de esa fila
            Empleado empSeleccionado = new Empleado
            {
                EmpleadoId = Convert.ToInt32(fila.Cells["EmpleadoId"].Value),
                Nombre = fila.Cells["Nombre"].Value.ToString(),
                Dni = numericUpDownDni.Value.ToString(),
                Telefono = numericUpDownTelefono.Value.ToString(),
                PHora = Convert.ToInt32(fila.Cells["PHora"].Value),
                Activo = Convert.ToBoolean(fila.Cells["Activo"].Value)
            };

            // Abrimos el formulario de Pagos y le pasamos el empleado
            Pago frmPago = new Pago(empSeleccionado);
            frmPago.ShowDialog();
        }

        private void btnHistorialInactivos_Click(object sender, EventArgs e)
        {
            BEHistorialInactivo beHist = new BEHistorialInactivo();
            DataTable dt = beHist.ObtenerHistorialTodos(); // Trae solo los empleados inactivos

            HistorialInactivos formHistorial = new HistorialInactivos();
            formHistorial.CargarHistorial(dt); // Carga la grilla del historial
            formHistorial.ShowDialog();
        }

        private void ValidarCampos()
        {
            var empleado = new Empleado
            {
                Nombre = comboBoxNomyApe.Text.Trim(),
                Dni = numericUpDownDni.Value.ToString(),
                Telefono = numericUpDownTelefono.Value.ToString(),
                PHora = (int)numericUpDownPHora.Value,
                Activo = checkBoxActivo.Checked
            };

            var validator = new Val.ValidarEmpleado();
            var result = validator.Validate(empleado);

            // Limpiar errores anteriores
            errorProvider1.Clear();

            // Nombre
            var errorNombre = result.Errors.FirstOrDefault(e => e.PropertyName == "Nombre");
            if (errorNombre != null)
                errorProvider1.SetError(comboBoxNomyApe, errorNombre.ErrorMessage);

            // DNI
            var errorDni = result.Errors.FirstOrDefault(e => e.PropertyName == "Dni");
            if (errorDni != null)
                errorProvider1.SetError(numericUpDownDni, errorDni.ErrorMessage);

            // Teléfono
            var errorTelefono = result.Errors.FirstOrDefault(e => e.PropertyName == "Telefono");
            if (errorTelefono != null)
                errorProvider1.SetError(numericUpDownTelefono, errorTelefono.ErrorMessage);

            // Precio por Hora
            var errorPHora = result.Errors.FirstOrDefault(e => e.PropertyName == "PHora");
            if (errorPHora != null)
                errorProvider1.SetError(numericUpDownPHora, errorPHora.ErrorMessage);
        }

        private void comboBoxNomyApe_TextChanged(object sender, EventArgs e) => ValidarCampos();

        private void numericUpDownDni_ValueChanged(object sender, EventArgs e) => ValidarCampos();

        private void numericUpDownTelefono_ValueChanged(object sender, EventArgs e) => ValidarCampos();

        private void numericUpDownPHora_ValueChanged(object sender, EventArgs e) => ValidarCampos();

        private void checkBoxActivo_CheckedChanged(object sender, EventArgs e) => ValidarCampos();

    }
}
