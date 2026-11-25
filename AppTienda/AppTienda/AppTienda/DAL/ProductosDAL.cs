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
    internal class ProductosDAL
    {
        public string error { get; set; }

        // ====================================
        // OBTENER TODOS
        // ====================================
        public List<Productos> ObtenerTodos()
        {
            var lista = new List<Productos>();
            string query = @"
                SELECT ProductoId, NombreModelo, MarcaId, TipoProductoId
                FROM Productos
                ORDER BY NombreModelo, ProductoId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lista.Add(new Productos
                            {
                                ProductoId = rdr.GetInt32(0),
                                NombreModelo = rdr.IsDBNull(1) ? string.Empty : rdr.GetString(1),
                                MarcaId = rdr.GetInt32(2),
                                TipoProductoId = rdr.GetInt32(3)
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
        // OBTENER POR ID
        // ====================================
        public Productos ObtenerPorId(int id)
        {
            Productos prod = null;

            string query = @"
                SELECT ProductoId, NombreModelo, MarcaId, TipoProductoId
                FROM Productos
                WHERE ProductoId = @Id";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            prod = new Productos
                            {
                                ProductoId = rdr.GetInt32(0),
                                NombreModelo = rdr.IsDBNull(1) ? string.Empty : rdr.GetString(1),
                                MarcaId = rdr.GetInt32(2),
                                TipoProductoId = rdr.GetInt32(3)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return prod;
        }

        // ====================================
        // INSERTAR
        // ====================================
        public int Insertar(Productos p)
        {
            string query = @"
                INSERT INTO Productos (NombreModelo, MarcaId, TipoProductoId)
                VALUES (@NombreModelo, @MarcaId, @TipoProductoId);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@NombreModelo", SqlDbType.NVarChar, 200).Value = p.NombreModelo ?? string.Empty;
                    cmd.Parameters.Add("@MarcaId", SqlDbType.Int).Value = p.MarcaId;
                    cmd.Parameters.Add("@TipoProductoId", SqlDbType.Int).Value = p.TipoProductoId;

                    object res = cmd.ExecuteScalar();
                    return res == null ? -1 : Convert.ToInt32(res);
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
        }

        // ====================================
        // MODIFICAR
        // ====================================
        public bool Modificar(Productos p)
        {
            string query = @"
                UPDATE Productos
                SET NombreModelo = @NombreModelo,
                    MarcaId = @MarcaId,
                    TipoProductoId = @TipoProductoId
                WHERE ProductoId = @Id";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@NombreModelo", SqlDbType.NVarChar, 200).Value = p.NombreModelo ?? string.Empty;
                    cmd.Parameters.Add("@MarcaId", SqlDbType.Int).Value = p.MarcaId;
                    cmd.Parameters.Add("@TipoProductoId", SqlDbType.Int).Value = p.TipoProductoId;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = p.ProductoId;

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
            string query = @"DELETE FROM Productos WHERE ProductoId = @Id";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

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
