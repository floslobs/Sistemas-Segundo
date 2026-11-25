using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTienda.BE;
using System.Data;

namespace AppTienda.DAL
{
    internal class MarcasDAL
    {
        public string error { get; set; }

        // ====================================
        // INSERTAR MARCA (devuelve ID)
        // ====================================
        public int AgregarMarca(Marcas marcas)
        {
            string query = @"
            INSERT INTO Marcas (Nombre)
            VALUES (@Nombre);
            SELECT SCOPE_IDENTITY();";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 150).Value = marcas.Nombre;

                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                error = "Error al agregar marca: " + ex.Message;
                return -1;
            }
        }

        // ====================================
        // EDITAR MARCA (devuelve bool)
        // ====================================
        public bool EditarMarca(Marcas marcas)
        {
            string query = @"
            UPDATE Marcas
            SET Nombre = @Nombre
            WHERE MarcaId = @MarcaId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 150).Value = marcas.Nombre;
                    cmd.Parameters.Add("@MarcaId", SqlDbType.Int).Value = marcas.MarcaId;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                error = "Error al editar marca: " + ex.Message;
                return false;
            }
        }

        // ====================================
        // ELIMINAR MARCA (devuelve bool)
        // ====================================
        public bool EliminarMarca(int marcaId)
        {
            string query = @"DELETE FROM Marcas WHERE MarcaId = @MarcaId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@MarcaId", SqlDbType.Int).Value = marcaId;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                error = "Error al eliminar marca: " + ex.Message;
                return false;
            }
        }

        // ====================================
        // OBTENER TODAS LAS MARCAS
        // ====================================
        public List<Marcas> ObtenerTodas()
        {
            List<Marcas> marcas = new List<Marcas>();
            string query = @"SELECT MarcaId, Nombre FROM Marcas";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            marcas.Add(new Marcas
                            {
                                MarcaId = reader.GetInt32(reader.GetOrdinal("MarcaId")),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre"))
                            });
                        }
                    }
                }

                return marcas;
            }
            catch (Exception ex)
            {
                error = "Error al obtener marcas: " + ex.Message;
                return new List<Marcas>();
            }
        }
    }
}
