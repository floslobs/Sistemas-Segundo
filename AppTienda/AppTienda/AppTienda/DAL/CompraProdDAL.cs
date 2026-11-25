using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using AppTienda.BE;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace AppTienda.DAL
{
    public class CompraProdDAL
    {
        public string error { get; set; }

        // ====================================
        // OBTENER DETALLES POR COMPRA
        // ====================================
        public List<CompraDeTalle> ObtenerPorCompra(int compraId)
        {
            var lista = new List<CompraDeTalle>();
            string query = @"
                SELECT CompraId, ProductoId, CantCp, Precio
                FROM ComprasProductos
                WHERE CompraId = @CompraId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@CompraId", SqlDbType.Int).Value = compraId;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lista.Add(new CompraDeTalle
                            {
                                CompraId = rdr.GetInt32(0),
                                ProductoId = rdr.GetInt32(1),
                                CantCp = rdr.GetInt32(2),
                                Precio = rdr.GetInt32(3)
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
        // INSERT NORMAL (FUERA DE TRANSACCIÓN)
        // ====================================
        public bool InsertarDetalle(CompraDeTalle detalle)
        {
            string query = @"
                INSERT INTO ComprasProductos (CompraId, ProductoId, CantCp, Precio)
                VALUES (@CompraId, @ProductoId, @CantCp, @Precio)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@CompraId", SqlDbType.Int).Value = detalle.CompraId;
                    cmd.Parameters.Add("@ProductoId", SqlDbType.Int).Value = detalle.ProductoId;
                    cmd.Parameters.Add("@CantCp", SqlDbType.Int).Value = detalle.CantCp;
                    cmd.Parameters.Add("@Precio", SqlDbType.Int).Value = detalle.Precio;

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
        // INSERT TRANSACCIONAL (PARA ComprasDAL)
        // ====================================
        internal bool InsertarDetalleTransactional(CompraDeTalle detalle, SqlConnection cn, SqlTransaction tx)
        {
            string query = @"
                INSERT INTO ComprasProductos (CompraId, ProductoId, CantCp, Precio)
                VALUES (@CompraId, @ProductoId, @CantCp, @Precio)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, cn, tx))
                {
                    cmd.Parameters.Add("@CompraId", SqlDbType.Int).Value = detalle.CompraId;
                    cmd.Parameters.Add("@ProductoId", SqlDbType.Int).Value = detalle.ProductoId;
                    cmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = detalle.CantCp;
                    cmd.Parameters.Add("@Precio", SqlDbType.Int).Value = detalle.Precio;

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
        // ELIMINAR POR COMPRA
        // ====================================
        public bool EliminarDetallesPorCompra(int compraId)
        {
            string query = @"DELETE FROM ComprasProductos WHERE CompraId = @CompraId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@CompraId", SqlDbType.Int).Value = compraId;

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

