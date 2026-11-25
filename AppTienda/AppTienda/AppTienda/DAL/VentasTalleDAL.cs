using AppTienda.BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.DAL
{
    internal class VentasTalleDAL
    {
        public string error { get; set; }

        // ====================================
        // OBTENER TALLES POR VENTA
        // ====================================
        public List<VentasTalles> ObtenerPorVenta(int ventaId)
        {
            var lista = new List<VentasTalles>();
            string query = @"SELECT VentaId, ProductoId, TalleId, Cant
                         FROM VentasTalles
                         WHERE VentaId = @VentaId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@VentaId", ventaId);

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lista.Add(new VentasTalles
                            {
                                VentaId = rdr.GetInt32(0),
                                ProductoId = rdr.GetInt32(1),
                                TalleId = rdr.GetInt32(2),
                                Cant = rdr.GetInt32(3)
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
        // INSERTAR DETALLE SIN TRANSACCIÓN
        // ====================================
        public bool InsertarDetalle(VentasTalles detalle)
        {
            string query = @"INSERT INTO VentasTalles (VentaId, ProductoId, TalleId, Cant)
                         VALUES (@VentaId, @ProductoId, @TalleId, @Cant)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@VentaId", detalle.VentaId);
                    cmd.Parameters.AddWithValue("@ProductoId", detalle.ProductoId);
                    cmd.Parameters.AddWithValue("@TalleId", detalle.TalleId);
                    cmd.Parameters.AddWithValue("@Cant", detalle.Cant);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // ====================================
        // INSERTAR DETALLE (TRANSACCIONAL)
        // ====================================
        internal bool InsertarDetalleTransactional(VentasTalles detalle, SqlConnection conn, SqlTransaction tx)
        {
            string query = @"INSERT INTO VentasTalles (VentaId, ProductoId, TalleId, Cant)
                         VALUES (@VentaId, @ProductoId, @TalleId, @Cant)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn, tx))
                {
                    cmd.Parameters.AddWithValue("@VentaId", detalle.VentaId);
                    cmd.Parameters.AddWithValue("@ProductoId", detalle.ProductoId);
                    cmd.Parameters.AddWithValue("@TalleId", detalle.TalleId);
                    cmd.Parameters.AddWithValue("@Cant", detalle.Cant);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // ====================================
        // ELIMINAR TALLES DE UNA VENTA
        // ====================================
        public bool EliminarTallesPorVenta(int ventaId)
        {
            string query = @"DELETE FROM VentasTalles WHERE VentaId = @VentaId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@VentaId", ventaId);

                    int filas = cmd.ExecuteNonQuery();
                    return filas >= 0;
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
