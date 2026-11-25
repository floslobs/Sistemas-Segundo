using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EManzanilla.BE;
using Microsoft.Data.SqlClient;

namespace EManzanilla.DAL
{
    public class EmpleadoDal
    {
        public string Error { get; set; }

        private readonly Conexion conexion;
        public EmpleadoDal()
        {
            conexion = new Conexion();
        }

        public int AgregarEmpleado(BE.Empleado empleado)
        {
            int retorna = 0;
            try
            {
                string query = "INSERT INTO Empleado (Nombre, Dni, Telefono, PHora, Activo) " +
                               "VALUES (@Nombre, @Dni, @Telefono, @PHora, @Activo); " +
                               "SELECT SCOPE_IDENTITY();"; // Obtener el ID del registro insertado
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                        cmd.Parameters.AddWithValue("@Dni", empleado.Dni);
                        cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                        cmd.Parameters.AddWithValue("@PHora", empleado.PHora);
                        cmd.Parameters.Add("@Activo", SqlDbType.Bit).Value = empleado.Activo;


                        var result = cmd.ExecuteScalar();
                        retorna = Convert.ToInt32((decimal)result); // SCOPE_IDENTITY devuelve decimal
                    }
                    return retorna;
                }
            }
            catch (Exception ex)
            {
                Error = "Error al agregar el empleado." + ex;
                return -1; // Valor por defecto en caso de excepción
            }
        }
        public int EditarEmpleado(BE.Empleado empleado)
        {
            int retorna = 0;
            try
            {
                string query = "UPDATE Empleado SET Nombre = @Nombre, Dni = @Dni, Telefono = @Telefono, PHora = @PHora, Activo = @Activo WHERE EmpleadoId = @EmpleadoId";
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                        cmd.Parameters.AddWithValue("@Dni", empleado.Dni);
                        cmd.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                        cmd.Parameters.AddWithValue("@PHora", empleado.PHora);
                        cmd.Parameters.AddWithValue("@EmpleadoId", empleado.EmpleadoId); // Muy importante
                        cmd.Parameters.AddWithValue("@Activo", empleado.Activo);
                        retorna = cmd.ExecuteNonQuery();
                    }
                }
                return retorna;
            }
            catch (Exception ex)
            {
                Error = "Error al editar el empleado." + ex;
                return -1; // Valor por defecto en caso de excepción
            }

        }

        public int EliminarEmpleado(int EmpleadoId)
        {
            int retorna = 0;
            try
            {
                string query = "UPDATE Empleado SET Activo = 0 WHERE EmpleadoId = @EmpleadoId";
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmpleadoId", EmpleadoId);
                        retorna = cmd.ExecuteNonQuery();
                    }
                }
                return retorna;
            }
            catch (Exception ex)
            {
                Error = "Error al desactivar el empleado." + ex.Message;
                return -1;
            }
        }

        public List<Empleado> ObtenerTodos()
        {
            List<Empleado> empleados = new List<Empleado>();

            try
            {
               
                string query = "SELECT EmpleadoId, Nombre, Dni, Telefono, PHora, Activo, FechaIngreso FROM dbo.Empleado WHERE Activo = 1";
                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                           
                            while (reader.Read())
                            {
                                Empleado emp = new Empleado
                                {
                                    EmpleadoId = Convert.ToInt32(reader["EmpleadoId"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Dni = reader["Dni"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    PHora = Convert.ToInt32(reader["PHora"]), // si PHora es decimal, usar Convert.ToDecimal
                                    Activo = Convert.ToBoolean(reader["Activo"]), // nuevo campo Activo
                                    FechaIngreso = Convert.ToDateTime(reader["FechaIngreso"])

                                };
                                empleados.Add(emp);
                            }
                        }
                    }
                }

                return empleados;
            }
            catch (Exception ex)
            {
                Error = "Error al obtener los empleados: " + ex.Message;
                return new List<Empleado>(); // devuelve lista vacía en caso de error
            }
        }

    }
}


