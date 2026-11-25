using AppTienda.BE;
using AppTienda.FE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppTienda.DAL
{
    internal class TalleDAL
    {
        public string error { get; set; }

        public List<Talles> ObtenerPorTipo(int tipoTalleId)
        {
            var lista = new List<Talles>();
            string query = @"
        SELECT t.TalleId, t.Talle
        FROM Talle t
        INNER JOIN TipoTalleDetalle d ON t.TalleId = d.TalleId
        WHERE d.TipoTalleId = @TipoTalleId
        ORDER BY t.Talle
    ";

            try
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TipoTalleId", tipoTalleId);

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Talles
                            {
                                TalleId = Convert.ToInt32(dr["TalleId"]),
                                Talle = dr["Talle"].ToString()
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
        // OBTENER TODOS
        // ====================================
        public List<Talles> ObtenerTodos()
        {
            var lista = new List<Talles>();
            string query = @"SELECT TalleId, Talles
                             FROM Talles
                             ORDER BY TRY_CAST(Talles AS INT), Talles";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
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
        // OBTENER POR ID
        // ====================================
        public Talles ObtenerPorId(int id)
        {
            Talles item = null;
            string query = @"SELECT TalleId, Talles
                             FROM Talles
                             WHERE TalleId = @Id";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                    using (SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (rdr.Read())
                        {
                            item = new Talles
                            {
                                TalleId = rdr.GetInt32(0),
                                Talle = rdr.IsDBNull(1) ? string.Empty : rdr.GetString(1)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return item;
        }

        // ====================================
        // INSERTAR
        // ====================================
        public int Insertar(Talles t)
        {
            string query = @"INSERT INTO Talles (Talles)
                             VALUES (@Talles);
                             SELECT CAST(SCOPE_IDENTITY() AS INT);";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@Talles", SqlDbType.NVarChar, 50).Value = "";

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
        public bool Modificar(Talles t)
        {
            string query = @"UPDATE Talles
                             SET Talles = @Talles
                             WHERE TalleId = @Id";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@Talles", SqlDbType.NVarChar, 50).Value = "";
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = t.TalleId;

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
            string query = @"DELETE FROM Talles
                             WHERE TalleId = @Id";

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
