using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EManzanilla.BE;
using Microsoft.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace EManzanilla.DAL
{
    internal class PagoDal
    {
        public string Error { get; set; }

        private readonly Conexion conexion;

        public PagoDal()
        {
            conexion = new Conexion();
        }

        public int AgregarPago(BE.Pago pago)
        {
            int retorna = 0;
            try
            {
                string query = @"INSERT INTO Pagos (EmpleadoId, Fecha, Horas, Monto, Pagado)
                             VALUES (@EmpleadoId, @Fecha, @Horas, @Monto, 1)" +
                              "SELECT SCOPE_IDENTITY(); "; ;
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmpleadoId", pago.EmpleadoId);
                        cmd.Parameters.AddWithValue("@Fecha", pago.Fecha);
                        cmd.Parameters.AddWithValue("@Horas", pago.Horas);
                        cmd.Parameters.AddWithValue("@Monto", pago.Monto);
                        var result = cmd.ExecuteScalar();
                        retorna = Convert.ToInt32((decimal)result); // SCOPE_IDENTITY devuelve decimal

                    }
                    return retorna;

                }
            }
            catch (Exception ex)
            {
                Error = "Error al agregar el pago." + ex;
                return -1; // Valor por defecto en caso de excepción
            }
        }

        // Obtener pagos por empleado
        public DataTable ObtenerPagosPorEmpleado(int empleadoId)
        {
            DataTable dtPago = new DataTable();
            try
            {
                string query = @"
            SELECT PagoId, Fecha, Horas, Monto, Pagado
            FROM Pagos
            WHERE EmpleadoId = @EmpleadoId
            ORDER BY Fecha ASC;";

                using (SqlConnection conn = conexion.AbrirConexion())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpleadoId", empleadoId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dtPagos = new DataTable();
                        adapter.Fill(dtPagos);
                        return dtPagos;
                    }
                }
            }
            catch (Exception ex)
            {
                Error = "Error al obtener los pagos: " + ex.Message;
            }
            return dtPago;
        }

        public int MarcarComoPagado(int pagoId)
        {
            try
            {
                string query = "UPDATE Pagos SET Pagado = 1 WHERE PagoId = @PagoId";
                using (SqlConnection conn = conexion.AbrirConexion())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PagoId", pagoId);
                    return cmd.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                Error = "Error al marcar pago como pagado: " + ex.Message;
                return -1;
            }
        }
    }
}

   