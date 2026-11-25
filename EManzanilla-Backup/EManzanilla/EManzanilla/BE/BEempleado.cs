using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EManzanilla.DAL;
using EManzanilla.FE;
using EManzanilla.Val;
using Microsoft.Data.SqlClient;
using FluentValidation.Results;

namespace EManzanilla.BE
{
    public class BEempleado
    {
        public string Error { get; set; }  // Variable para almacenar errores, comunicar desde capa BA y DAL  

        private readonly Conexion db;      // Maneja la conexión a SQL

        public BEempleado()
        {
            db = new Conexion();
        }




        public int AgregarEmpleado(Empleado empleado, DataGridView dataGridViewEmple)
        {

            try
            {
                // 🔹 VALIDAR antes de guardar
                var validador = new ValidarEmpleado();
                ValidationResult resultado = validador.Validate(empleado);

                if (!resultado.IsValid)
                {
                    Error = string.Join("\n", resultado.Errors.Select(e => e.ErrorMessage));
                    return -1; // ❌ No se agrega si no pasa validación
                }
                DAL.EmpleadoDal empleadoDAL = new DAL.EmpleadoDal();

                return empleadoDAL.AgregarEmpleado(empleado);
            }
            catch (Exception ex)
            {
                Error = "Error al agregar el usuario." + ex;
                return -1; // Return a default value in case of an exception  
            }
        }

        public int EditarEmpleado(Empleado empleado)
        {
            try
            {
                // 🔹 También validamos al editar
                var validador = new ValidarEmpleado();
                ValidationResult resultado = validador.Validate(empleado);

                if (!resultado.IsValid)
                {
                    Error = string.Join("\n", resultado.Errors.Select(e => e.ErrorMessage));
                    return -1;
                }

                EmpleadoDal empleadoDAL = new EmpleadoDal();
                return empleadoDAL.EditarEmpleado(empleado);
            }
            catch (Exception ex)
            {
                Error = "Error al actualizar el empleado: " + ex.Message;
                return -1;
            }
        }
    
        public int EliminarEmpleado(int empleadoId)
        {
            EmpleadoDal EmpleadoDAL = new EmpleadoDal();
            try
            {
                return EmpleadoDAL.EliminarEmpleado(empleadoId);
            }
            catch (Exception ex)
            {
                Error = "Error al eliminar el usuario: " + ex.Message;
                return -1;
            }
        }

        public List<Empleado> ObtenerTodosEmpleados()
        {
            try
            {
                EmpleadoDal empleadoDAL = new EmpleadoDal();
                // Llamamos al DAL para obtener la lista de empleados
                List<Empleado> listaEmpleados = empleadoDAL.ObtenerTodos();
                return listaEmpleados;
            }
            catch (Exception ex)
            {
                this.Error = "Error al obtener los empleados: " + ex.Message;
                return new List<Empleado>();
            }
        }
     
        

    }
}




