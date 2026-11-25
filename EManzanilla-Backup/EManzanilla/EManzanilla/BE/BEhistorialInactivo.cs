using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EManzanilla.BE;
using EManzanilla.DAL;

namespace EManzanilla.BE
{
    public class BEHistorialInactivo
    {
        public string Error { get; set; }

        private readonly DAL.HistorialInactivosDal dal;

        public BEHistorialInactivo()
        {
            dal = new DAL.HistorialInactivosDal();
        }

        public int RegistrarInactivo(HistorialInactivo hi)
        {
            try
            {
                return dal.RegistrarInactivo(hi);
            }
            catch (Exception ex)
            {
                Error = "Error al registrar inactivo: " + ex.Message;
                return -1;
            }
        }

        public int ReactivarEmpleado(int historialId, int empleadoId)
        {
            try
            {
                return dal.ReactivarEmpleado(historialId, empleadoId);
            }
            catch (Exception ex)
            {
                Error = "Error al reactivar empleado: " + ex.Message;
                return -1;
            }
        }

        public DataTable ObtenerHistorialPorEmpleado(int empleadoId)
        {
            try
            {
                return dal.ObtenerHistorialTodos();
            }
            catch (Exception ex)
            {
                Error = "Error al obtener historial: " + ex.Message;
                return new DataTable();
            }
        }

        public DataTable ObtenerHistorialTodos()
        {
            try
            {
                return dal.ObtenerHistorialTodos();
            }
            catch (Exception ex)
            {
                Error = "Error al obtener historial: " + ex.Message;
                return new DataTable();
            }
        }
    }
}
