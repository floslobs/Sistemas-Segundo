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
    internal class ProveedorDAL
    {
        public string error { get; set; }

        // ====================================
        // OBTENER TODOS
        // ====================================
        public List<Proveedores> ObtenerTodos()
        {
            var lista = new List<Proveedores>();
            string query = @"SELECT ProveedorId, Nombre, CUIT
                             FROM Proveedores
                             ORDER BY Nombre, ProveedorId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lista.Add(new Proveedores
                            {
                                ProveedorId = rdr.GetInt32(0),
                                Nombre = rdr.IsDBNull(1) ? string.Empty : rdr.GetString(1),
                                CUIT = rdr.IsDBNull(2) ? string.Empty : rdr.GetString(2)
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
        public Proveedores ObtenerPorId(int proveedorId)
        {
            Proveedores prov = null;
            string query = @"SELECT ProveedorId, Nombre, CUIT
                             FROM Proveedores
                             WHERE ProveedorId = @ProveedorId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@ProveedorId", SqlDbType.Int).Value = proveedorId;

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            prov = new Proveedores
                            {
                                ProveedorId = rdr.GetInt32(0),
                                Nombre = rdr.IsDBNull(1) ? string.Empty : rdr.GetString(1),
                                CUIT = rdr.IsDBNull(2) ? string.Empty : rdr.GetString(2)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return prov;
        }

        // ====================================
        // INSERTAR
        // ====================================
        public int InsertarProveedor(Proveedores prov)
        {
            string query = @"
                INSERT INTO Proveedores (Nombre, CUIT)
                VALUES (@Nombre, @CUIT);
                SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 150).Value = prov.Nombre ?? string.Empty;
                    cmd.Parameters.Add("@CUIT", SqlDbType.NVarChar, 50).Value = prov.CUIT ?? string.Empty;

                    object result = cmd.ExecuteScalar();
                    return result == null ? -1 : Convert.ToInt32(result);
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
        public bool ModificarProveedor(Proveedores prov)
        {
            string query = @"
                UPDATE Proveedores
                SET Nombre = @Nombre,
                    CUIT   = @CUIT
                WHERE ProveedorId = @ProveedorId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 150).Value = prov.Nombre ?? string.Empty;
                    cmd.Parameters.Add("@CUIT", SqlDbType.NVarChar, 50).Value = prov.CUIT ?? string.Empty;
                    cmd.Parameters.Add("@ProveedorId", SqlDbType.Int).Value = prov.ProveedorId;

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
        public bool EliminarProveedor(int proveedorId)
        {
            string query = @"DELETE FROM Proveedores WHERE ProveedorId = @ProveedorId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@ProveedorId", SqlDbType.Int).Value = proveedorId;

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

