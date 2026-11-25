using EManzanilla.BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManzanilla.DAL
{
    internal class HistorialInactivosDal
    {
        public string Error { get; set; }
        private readonly Conexion conexion;

        public HistorialInactivosDal()
        {
            conexion = new Conexion();
        }

        // Registrar cuando un empleado se pone inactivo
        public int RegistrarInactivo(BE.HistorialInactivo hi)
        {
            int retorna = 0;
            try
            {
                string query = @"
                INSERT INTO HistorialInactivos (EmpleadoId, FechaInactivo)
                VALUES (@EmpleadoId, @FechaInactivo);
                SELECT SCOPE_IDENTITY();";

                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmpleadoId", hi.EmpleadoId);
                        cmd.Parameters.AddWithValue("@FechaInactivo", hi.FechaInactivo);

                        var result = cmd.ExecuteScalar();
                        retorna = Convert.ToInt32((decimal)result);
                    }
                }
            }
            catch (Exception ex)
            {
                Error = "Error al registrar inactivo: " + ex;
                return -1;
            }

            return retorna;
        }

        // Reactivar un empleado (actualiza FechaReactivado y devuelve el resultado)
        public int ReactivarEmpleado(int historialId, int empleadoId)
        {
            int retorna = 0;
            try
            {
                string query = @"
                UPDATE HistorialInactivos
                SET FechaReactivado = GETDATE()
                WHERE HistorialId = @HistorialId;

                UPDATE Empleado
                SET Activo = 1
                WHERE EmpleadoId = @EmpleadoId;
            ";

                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HistorialId", historialId);
                        cmd.Parameters.AddWithValue("@EmpleadoId", empleadoId);

                        retorna = cmd.ExecuteNonQuery(); // Devuelve número de filas afectadas
                    }
                }
            }
            catch (Exception ex)
            {
                Error = "Error al reactivar empleado: " + ex;
                return -1;
            }

            return retorna;
        }

        public DataTable ObtenerHistorialTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = @"
            SELECT h.HistorialId, e.EmpleadoId, e.Nombre, e.Dni, h.FechaInactivo, h.FechaReactivado
            FROM HistorialInactivos h
            INNER JOIN Empleado e ON h.EmpleadoId = e.EmpleadoId
            WHERE h.FechaReactivado IS NULL"; // Solo los empleados inactivos

                using (SqlConnection conn = conexion.AbrirConexion())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Error = "Error al obtener historial: " + ex;
            }

            return dt;
        }
    }
}
