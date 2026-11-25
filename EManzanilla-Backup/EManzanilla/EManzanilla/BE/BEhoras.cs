using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManzanilla.BE
{
    public class BEhoras
    {
        public string Error { get; set; }  // Para comunicar errores desde DAL

        private readonly DAL.HorasDal dal;

        public BEhoras()
        {
            dal = new DAL.HorasDal();
        }

        public int AgregarHoras(Horas horas)
        {
            try
            {
                // Calculamos total antes de guardar
                horas.CalcularHorasYTotal();
                return dal.AgregarHoras(horas);
            }
            catch (Exception ex)
            {
                Error = "Error al agregar horas: " + ex.Message;
                return -1;
            }
        }

        public DataTable ObtenerHorasPorEmpleado(int empleadoId)
        {
            try
            {
                return dal.ObtenerHorasPorEmpleado(empleadoId);
            }
            catch (Exception ex)
            {
                Error = "Error al obtener horas: " + ex.Message;
                return new DataTable();
            }
        }
    }
}

