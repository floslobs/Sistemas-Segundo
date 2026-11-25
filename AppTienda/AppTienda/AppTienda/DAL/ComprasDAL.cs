using AppTienda.BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AppTienda.DAL;
using System.Collections;


namespace AppTienda.DAL
{
    internal class ComprasDAL
    {
        public string error { get; set; }
        public int CrearCompraConDetalles(Compras compra)
        {
            if (compra == null) { error = "Compra nula"; return -1; }

            string query = @"INSERT INTO Compras (ProveedorId, Fecha)
                                       VALUES (@ProveedorId, @Fecha);
                                       SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
            {
                SqlTransaction tx = cmd.Connection.BeginTransaction();
                cmd.Transaction = tx;

                try
                {
                    // Insertar cabecera


                    cmd.Parameters.Add("@ProveedorId", SqlDbType.Int).Value = compra.ProveedorId;
                    cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = compra.Fecha;
                    object result = cmd.ExecuteScalar();
                    if (result == null) throw new Exception("No se pudo insertar cabecera de compra.");
                    compra.CompraId = Convert.ToInt32(result);


                    // Insertar detalles productos
                    var comprasProductosDal = new CompraProdDAL();
                    foreach (var d in compras.Detalles)
                    {
                        d.CompraId = compra.CompraId;
                        if (!comprasProductosDal.InsertarDetalleTransactional(d, cmd.Connection, tx))
                            throw new Exception(comprasProductosDal.Error ?? "Error al insertar detalle producto.");
                    }

                    // Insertar detalles por talle
                    var comprasTallesDal = new ComprasTalleDAL;
                    foreach (var t in compra.DetallesTalle)
                    {
                        t.CompraId = compra.CompraId;
                        if (!comprasTallesDal.InsertarDetalleTransactional(t, cmd.Connection, tx))
                            throw new Exception(comprasTallesDal.error ?? "Error al insertar detalle por talle.");
                    }

                    tx.Commit();
                    return compra.CompraId;
                }
                catch (Exception ex)
                {
                    try { tx.Rollback(); } catch { }
                    error = ex.Message;
                    return -1;
                }
                finally
                {

                }
            }
         }

        /// <summary>
        /// Obtiene una compra con sus detalles y talles
        /// </summary>
        public Compras ObtenerPorId(int compraId)
        {
            Compras compra = null;
            string query = @"SELECT CompraId, ProveedorId, Fecha FROM Compras WHERE CompraId = @CompraId";
            try
            {

                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@CompraId", SqlDbType.Int).Value = compraId;
                 
                    using var rdr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    if (rdr.Read())
                    {
                        compras = new Compras
                        {
                            CompraId = rdr.GetInt32(0),
                            ProveedorId = rdr.GetInt32(1),
                            Fecha = rdr.GetDateTime(2)
                        };
                    }
                    if (compras != null)
                    {
                        var prodDal = new CompraProdDAL;
                        compras.Detalles = prodDal.ObtenerPorCompra(compraId);

                        var talleDal = new ComprasTalleDAL;
                        compra.DetallesTalle = talleDal.ObtenerPorCompra(compraId);
                    }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return compra;
        }

        /// <summary>
        /// Lista compras (sin detalles) entre fechas; si proveedorId = 0 no filtra por proveedor
        /// </summary>
        public List<Compras> ObtenerTodos(DateTime desde, DateTime hasta, int proveedorId = 0)
        {
            var lista = new List<Compras>();
            string query = @"SELECT CompraId, ProveedorId, Fecha
                           FROM Compras
                           WHERE Fecha BETWEEN @Desde AND @Hasta"
                         + (proveedorId > 0 ? " AND ProveedorId = @ProveedorId" : "")
                         + " ORDER BY Fecha DESC";

            try
            {

                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@Desde", SqlDbType.DateTime).Value = desde;
                    cmd.Parameters.Add("@Hasta", SqlDbType.DateTime).Value = hasta;
                    if (proveedorId > 0) cmd.Parameters.Add("@ProveedorId", SqlDbType.Int).Value = proveedorId;
                   
                    using var rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        lista.Add(new Compra
                        {
                            CompraId = rdr.GetInt32(0),
                            ProveedorId = rdr.GetInt32(1),
                            Fecha = rdr.GetDateTime(2)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return lista;
        }

        /// <summary>
        /// Elimina físicamente una compra (cuidado: elimina también detalles por FK en BD si cascade)
        /// </summary>
        public bool EliminarCompra(int compraId)
        {
            string query = "DELETE FROM Compras WHERE CompraId = @CompraId";
            try
            {

                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.Add("@CompraId", SqlDbType.Int).Value = compraId;
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

        // Constructor interno para que otros DALs reutilicen la misma ConexionBD sin exponerla publicamente
        
    }
}
    

