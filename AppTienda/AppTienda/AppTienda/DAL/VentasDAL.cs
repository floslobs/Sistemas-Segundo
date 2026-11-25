using AppTienda.BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.DAL
{
    internal class VentasDAL
    {
        public string error { get; set; }

        // ============================
        // CREAR VENTA COMPLETA
        // ============================
        public int CrearVentaConDetalles(Ventas venta)
        {
            int ventaId = -1;
            error = string.Empty;

            string sqlVenta = @"INSERT INTO Ventas (ClienteId, Fecha)
                            VALUES (@ClienteId, @Fecha);
                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            SqlConnection conn = Conexion.ObtenerConexion();
            SqlTransaction tx = null;

            try
            {

                tx = conn.BeginTransaction();

                // Insertar cabecera
                using (SqlCommand cmd = new SqlCommand(sqlVenta, conn, tx))
                {
                    cmd.Parameters.AddWithValue("@ClienteId", venta.ClienteId);
                    cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);

                    object res = cmd.ExecuteScalar();
                    if (res == null) throw new Exception("No se pudo insertar la venta.");

                    ventaId = Convert.ToInt32(res);
                }

                // -------------------------
                // INSERTAR DETALLES SIN TALLE
                // -------------------------
                foreach (var d in venta.Detalles)
                {
                    string sqlDetalle = @"INSERT INTO VentasProducto (VentaId, ProductoId, CantVp)
                                      VALUES (@VentaId, @ProductoId, @CantVp)";

                    using (SqlCommand cmd = new SqlCommand(sqlDetalle, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@VentaId", ventaId);
                        cmd.Parameters.AddWithValue("@ProductoId", d.ProductoId);
                        cmd.Parameters.AddWithValue("@CantVp", d.CantVp);

                        cmd.ExecuteNonQuery();
                    }
                }

                // -------------------------
                // INSERTAR DETALLES CON TALLE
                // -------------------------
                foreach (var t in venta.DetallesTalle)
                {
                    string sqlTalle = @"INSERT INTO VentasTalles (VentaId, ProductoId, TalleId, CantVt)
                                    VALUES (@VentaId, @ProductoId, @TalleId, @CantVt)";

                    using (SqlCommand cmd = new SqlCommand(sqlTalle, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@VentaId", ventaId);
                        cmd.Parameters.AddWithValue("@ProductoId", t.ProductoId);
                        cmd.Parameters.AddWithValue("@TalleId", t.TalleId);
                        cmd.Parameters.AddWithValue("@CantVt", t.CantVt);

                        cmd.ExecuteNonQuery();
                    }
                }

                tx.Commit();
            }
            catch (Exception ex)
            {
                try { tx?.Rollback(); } catch { }
                error = ex.Message;
                ventaId = -1;
            }
            finally
            {
                conn.Close();
            }

            return ventaId;
        }

        // ============================
        // OBTENER UNA VENTA
        // ============================
        public Ventas ObtenerPorId(int VentaId)
        {
            Ventas ventas = null;
            string query = "SELECT VentaId, ClienteId, Fecha FROM Ventas WHERE VentaId = @Id";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@Id", VentaId);

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            ventas = new Ventas
                            {
                                VentaId = rdr.GetInt32(0),
                                ClienteId = rdr.GetInt32(1),
                                Fecha = rdr.GetDateTime(2)
                            };
                        }
                    }
                }

                if (ventas != null)
                {
                    ventas.Detalles = ObtenerDetallesProducto(VentaId);
                    ventas.DetallesTalle = ObtenerDetallesTalle(VentaId);
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return ventas;
        }

        // ============================
        // DETALLES SIN TALLE
        // ============================
        public List<Ventas> ObtenerVentas(DateTime desde, DateTime hasta, int clienteId = 0)
        {
            var lista = new List<Ventas>();
            string query = @"SELECT VentaId, ClienteId, Fecha
                           FROM Ventas
                           WHERE Fecha BETWEEN @Desde AND @Hasta"
                         + (clienteId > 0 ? " AND ClienteId = @ClienteId" : "")
                         + " ORDER BY Fecha DESC";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    // Parámetros correctos
                    cmd.Parameters.AddWithValue("@Desde", desde);
                    cmd.Parameters.AddWithValue("@Hasta", hasta);

                    if (clienteId > 0)
                        cmd.Parameters.AddWithValue("@ClienteId", clienteId);

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lista.Add(new Ventas
                            {
                                VentaId = rdr.GetInt32(0),
                                ClienteId = rdr.GetInt32(1),
                                Fecha = rdr.GetDateTime(2)
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

        // ============================
        // DETALLES CON TALLE
        // ============================
        private List<VentasTalles> ObtenerDetallesTalle(int ventaId)
        {
            var lista = new List<VentasTalles>();
            string query = @"SELECT ProductoId, TalleId, Cant, Precio
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
                                VentaId = (int)rdr.GetInt32(0),
                                ProductoId = rdr.GetInt32(0),
                                TalleId = rdr.GetInt32(1),
                                CantVt = rdr.GetInt32(2),

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

        // ============================
        // ELIMINAR VENTA
        // ============================
        public bool Eliminar(int ventaId)
        {
            string query = "DELETE FROM Ventas WHERE VentaId = @VentaId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@VentaId", ventaId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    
        private List<VentaDeTalle> ObtenerDetallesProducto(int ventaId)
        {
            var lista = new List<VentaDeTalle>();

            string query = @"SELECT ProductoId, CantVp
                         FROM VentasProducto
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
                            lista.Add(new VentaDeTalle
                            {
                                VentaId = ventaId,
                                ProductoId = rdr.GetInt32(0),
                                CantVp = rdr.GetInt32(1)
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
    }
}

