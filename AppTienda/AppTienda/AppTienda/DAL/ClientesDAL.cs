using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using AppTienda.BE;


namespace AppTienda.DAL
{
    internal class ClientesDAL
    {
        public string error { get; set; }
        public int InsertarCliente(Clientes cli)
        {
            

            try
            {
                string query = @"
                INSERT INTO Clientes (Nombre, DNI)
                VALUES (@Nombre, @DNI);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@Nombre", cli.Nombre ?? string.Empty);
                    cmd.Parameters.AddWithValue("@DNI", cli.DNI ?? string.Empty);

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

      
        /// Modifica un cliente existente. Devuelve true si se actualizó al menos 1 fila.
       
        public bool ModificarCliente(Clientes cli)
        {
            string query = @"
                UPDATE Clientes
                SET Nombre = @Nombre,
                    DNI    = @DNI
                WHERE ClienteId = @ClienteId;";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@Nombre", cli.Nombre ?? string.Empty);
                    cmd.Parameters.AddWithValue("@DNI", cli.DNI ?? string.Empty);
                    cmd.Parameters.AddWithValue("@ClienteId", cli.ClienteId);

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

        /// <summary>
        /// Elimina físicamente un cliente por id. Devuelve true si se borró al menos 1 fila.
        /// </summary>
        public bool EliminarCliente(int clienteId)
        {
            string query = @"DELETE FROM Clientes WHERE ClienteId = @ClienteId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@ClienteId", clienteId);

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

        public List<Clientes> ObtenerTodos()
        {
            var lista = new List<Clientes>();
            string query = @"SELECT ClienteId, Nombre, DNI
                           FROM Clientes
                           ORDER BY Nombre, ClienteId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            lista.Add(new Clientes
                            {
                                ClienteId = rdr.GetInt32(0),
                                Nombre = rdr.IsDBNull(1) ? string.Empty : rdr.GetString(1),
                                DNI = rdr.IsDBNull(2) ? string.Empty : rdr.GetString(2)
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

        /// <summary>
        /// Obtiene un cliente por id, o null si no existe
        /// </summary>
        public Clientes ObtenerPorId(int clienteId)
        {
            Clientes cliente = null;
            string query = @"SELECT ClienteId, Nombre, DNI
                           FROM Clientes
                           WHERE ClienteId = @ClienteId";

            try
            {

                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                        cmd.Parameters.Add("@ClienteId", SqlDbType.Int).Value = clienteId;
                    

                    using var rdr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    if (rdr.Read())
                    {
                        cliente = new Clientes
                        {
                            ClienteId = rdr.GetInt32(0),
                            Nombre = rdr.IsDBNull(1) ? string.Empty : rdr.GetString(1),
                            DNI = rdr.IsDBNull(2) ? string.Empty : rdr.GetString(2)
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return cliente;
        }

    }
}


