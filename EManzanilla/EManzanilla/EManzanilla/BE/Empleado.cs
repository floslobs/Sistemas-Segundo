using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManzanilla.BE
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; } 
        public string Telefono { get; set; }
        public int PHora { get; set; }
        public Boolean Activo { get; set; } = true; // Nuevo campo Activo, por defecto true
        public DateTime FechaIngreso { get; set; }

        public Empleado(int pEmpleadoId, string pNombre, string pDni, string pTelefono, int pPHora, Boolean pActivo, DateTime fechaIngreso)
        {
            EmpleadoId = pEmpleadoId;
            Nombre = pNombre;
            Dni = pDni;
            Telefono = pTelefono;
            PHora = pPHora;
            Activo = pActivo;
            FechaIngreso = fechaIngreso;
        }
        public Empleado() { }  // constructor vacío

    }
}
