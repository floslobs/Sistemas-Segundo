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
    internal class TalleProductoDAL
    {
        public string error { get; set; }

        // ====================================
        // OBTENER TALLES POR PRODUCTO
        // ====================================
        public List<Talles> ObtenerTallesPorProducto(int productoId)
        {
            var lista = new List<Talles>();
            string query = @"
            SELECT t.TalleId, t.Talles
            FROM TalleProducto tp
            JOIN Talles t ON t.TalleId = tp.TalleId
            WHERE tp.ProductoId = @ProductoId
            ORDER BY TRY_CAST(t.Talles AS INT), t.Talles";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@ProductoId", productoId);

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lista.Add(new Talles
                            {
                                TalleId = rdr.GetInt32(0),
                                Talle = rdr.IsDBNull(1) ? string.Empty : rdr.GetString(1)
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
        // AGREGAR TALLES A PRODUCTO
        // ====================================
        public bool AgregarTalleAProducto(int productoId, int talleId)
        {
            string query = @"INSERT INTO TalleProducto (TalleId, ProductoId)
                         VALUES (@TalleId, @ProductoId)";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@TalleId", talleId);
                    cmd.Parameters.AddWithValue("@ProductoId", productoId);

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
        // QUITAR TALLES
        // ====================================
        public bool QuitarTalleDeProducto(int productoId, int talleId)
        {
            string query = @"DELETE FROM TalleProducto
                         WHERE ProductoId = @ProductoId AND TalleId = @TalleId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@ProductoId", productoId);
                    cmd.Parameters.AddWithValue("@TalleId", talleId);

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
        // EXISTE?
        // ====================================
        public bool ExisteTalleEnProducto(int productoId, int talleId)
        {
            string query = @"SELECT COUNT(1)
                         FROM TalleProducto
                         WHERE ProductoId = @ProductoId AND TalleId = @TalleId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@ProductoId", productoId);
                    cmd.Parameters.AddWithValue("@TalleId", talleId);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
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
