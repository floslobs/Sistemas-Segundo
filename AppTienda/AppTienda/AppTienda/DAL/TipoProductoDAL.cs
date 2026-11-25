using AppTienda.BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.DAL
{
    internal class TipoProductoDAL
    {
        public string error { get; set; }

        // ====================================
        // OBTENER TODOS
        // ====================================
        public List<TipoProducto> ObtenerTodos()
        {
            var lista = new List<TipoProducto>();
            string query = @"SELECT TipoProductoId, Nombre, PoseeTalle
                         FROM TipoProducto
                         ORDER BY Nombre";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lista.Add(new TipoProducto
                            {
                                TipoProductoId = rdr.GetInt32(0),
                                Nombre = rdr.IsDBNull(1) ? string.Empty : rdr.GetString(1),
                                PoseeTalle = rdr.GetBoolean(2)
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
        // INSERTAR
        // ====================================
        public int Insertar(TipoProducto tp)
        {
            int retorna = -1;
            string query = @"
            INSERT INTO TipoProducto (Nombre, PoseeTalle)
            VALUES (@Nombre, @PoseeTalle);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@Nombre", tp.Nombre ?? string.Empty);
                    cmd.Parameters.AddWithValue("@PoseeTalle", tp.PoseeTalle);

                    retorna = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return retorna;
        }

        // ====================================
        // MODIFICAR
        // ====================================
        public bool Modificar(TipoProducto tp)
        {
            string query = @"
            UPDATE TipoProducto
            SET Nombre = @Nombre,
                PoseeTalle = @PoseeTalle
            WHERE TipoProductoId = @Id";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@Nombre", tp.Nombre ?? string.Empty);
                    cmd.Parameters.AddWithValue("@PoseeTalle", tp.PoseeTalle);
                    cmd.Parameters.AddWithValue("@Id", tp.TipoProductoId);

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
        // ELIMINAR
        // ====================================
        public bool Eliminar(int id)
        {
            string query = @"DELETE FROM TipoProducto WHERE TipoProductoId = @Id";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

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
    }
}
