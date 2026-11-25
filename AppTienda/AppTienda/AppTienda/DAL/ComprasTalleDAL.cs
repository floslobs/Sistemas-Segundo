using AppTienda.BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.DAL
{
    internal class ComprasTalleDAL
    {
        public string error { get; set; }

        // ====================================
        // OBTENER TALLE POR COMPRA
        // ====================================
        public List<ComprasTalles> ObtenerPorCompra(int compraId)
        {
            var lista = new List<ComprasTalles>();
            string query = @"
                SELECT CompraId, ProductoId, TalleId, Cant
                FROM ComprasTalles
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
                            lista.Add(new ComprasTalles
                            {
                                CompraId = rdr.GetInt32(0),
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
        // INSERT NORMAL (FUERA DE TRANSACCIÓN)
        // ====================================
        public bool InsertarDetalle(ComprasTalles detalle)
        {
            string query = @"
                INSERT INTO ComprasTalles (CompraId, ProductoId, TalleId, Cant)
                VALUES (@CompraId, @ProductoId, @TalleId, @Cant)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@CompraId", SqlDbType.Int).Value = detalle.CompraId;
                    cmd.Parameters.Add("@ProductoId", SqlDbType.Int).Value = detalle.ProductoId;
                    cmd.Parameters.Add("@TalleId", SqlDbType.Int).Value = detalle.TalleId;
                    cmd.Parameters.Add("@Cant", SqlDbType.Int).Value = detalle.Cant;

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
        // INSERT TRANSACCIONAL (LLAMADO DESDE ComprasDAL)
        // ====================================
        internal bool InsertarDetalleTransactional(CompraTalle detalle, SqlConnection cn, SqlTransaction tx)
        {
            string query = @"
                INSERT INTO ComprasTalles (CompraId, ProductoId, TalleId, Cant)
                VALUES (@CompraId, @ProductoId, @TalleId, @Cant)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, cn, tx))
                {
                    cmd.Parameters.Add("@CompraId", SqlDbType.Int).Value = detalle.CompraId;
                    cmd.Parameters.Add("@ProductoId", SqlDbType.Int).Value = detalle.ProductoId;
                    cmd.Parameters.Add("@TalleId", SqlDbType.Int).Value = detalle.TalleId;
                    cmd.Parameters.Add("@Cant", SqlDbType.Int).Value = detalle.Cant;

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
        public bool EliminarTallesPorCompra(int compraId)
        {
            string query = @"DELETE FROM ComprasTalles WHERE CompraId = @CompraId";

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
