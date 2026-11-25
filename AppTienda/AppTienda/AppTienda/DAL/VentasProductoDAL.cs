using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTienda.BE;
using Microsoft.Extensions.Logging;

namespace AppTienda.DAL
{
    internal class VentasProductoDAL
    {
        public string error { get; set; }

        // ====================================
        // OBTENER DETALLES POR VENTA
        // ====================================
        public List<VentaDeTalle> ObtenerPorVenta(int VentaId)
        {
            var lista = new List<VentaDeTalle>();
            string query = @"SELECT VentaId, ProductoId, Cantidad, Precio
                         FROM VentasProducto
                         WHERE VentaId = @VentaId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@VentaId", VentaId);

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lista.Add(new VentaDeTalle
                            {
                              
                                VentaId = rdr.GetInt32(0),
                                ProductoId = rdr.GetInt32(1),
                                CantVp = rdr.GetInt32(2),

                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return lista;
        }

        // ====================================
        // INSERTAR DETALLE (SIN TRANSACCIÓN)
        // ====================================
        public bool InsertarDetalle(VentaDeTalle detalle)
        {
            string query = @"INSERT INTO VentasProducto (VentaId, ProductoId, CantVp)
                         VALUES (@VentaId, @ProductoId, @CantVp)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@VentaId", detalle.VentaId);
                    cmd.Parameters.AddWithValue("@ProductoId", detalle.ProductoId);
                    cmd.Parameters.AddWithValue("@Cantidad", detalle.CantVp);
                   

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // ====================================
        // INSERTAR DETALLE DENTRO DE UNA TRANSACCIÓN
        // ====================================
        internal bool InsertarDetalleTransactional(VentaDeTalle detalle, SqlConnection conn, SqlTransaction tx)
        {
            string query = @"INSERT INTO VentasProducto (VentaId, ProductoId, TalleId, Precio)
                         VALUES (@VentaId, @ProductoId, @TalleId, @Precio)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn, tx))
                {
                    cmd.Parameters.AddWithValue("@VentaId", detalle.VentaId);
                    cmd.Parameters.AddWithValue("@ProductoId", detalle.ProductoId);
                    
                    cmd.Parameters.AddWithValue("@Precio", detalle.CantVp);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // ====================================
        // ELIMINAR DETALLES POR VENTA
        // ====================================
        public bool EliminarDetallesPorVenta(int ventaId)
        {
            string query = "DELETE FROM VentasProducto WHERE VentaId = @VentaId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@VentaId", ventaId);

                    int rows = cmd.ExecuteNonQuery();
                    return rows >= 0;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
