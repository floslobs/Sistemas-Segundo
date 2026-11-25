using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManzanilla.BE
{
    public class BEpago
    {
        public string Error { get; set; }

        private readonly DAL.PagoDal dal;

        public BEpago()
        {
            dal = new DAL.PagoDal();
        }

        // Método para agregar un pago
        public int AgregarPago(Pago pago)
        {
            try
            {
                return dal.AgregarPago(pago);
            }
            catch (Exception ex)
            {
                Error = "Error al agregar pago: " + ex.Message;
                return -1;
            }
        }

        // Método para obtener pagos por empleado
        public DataTable ObtenerPagosPorEmpleado(int empleadoId)
        {
            try
            {
                return dal.ObtenerPagosPorEmpleado(empleadoId);
            }
            catch (Exception ex)
            {
                Error = "Error al obtener pagos por empleado: " + ex.Message;
                return new DataTable();
            }
        }

        public int MarcarComoPagado(int pagoId)
        {
            try
            {
                return dal.MarcarComoPagado(pagoId);
            }
            catch (Exception ex)
            {
                Error = "Error al marcar pago: " + ex.Message;
                return -1;
            }
        }
    }
}
