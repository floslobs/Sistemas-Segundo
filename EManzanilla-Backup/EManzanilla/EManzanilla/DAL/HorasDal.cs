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
    internal class HorasDal
    {
        public string Error { get; set; }

        private readonly Conexion conexion;
        public HorasDal()
        {
            conexion = new Conexion();
        }
        public int AgregarHoras(BE.Horas horas)
        {
            int retorna = 0;
            try
            {
                string query = "INSERT INTO Horas (EmpleadoId, Phora2, Fecha, Hingreso1, Hsalida1, Hingreso2, Hsalida2, HdescansoI, HdescansoS, TotalHoras, MontoDia) " +
                               "VALUES (@EmpleadoId, @Phora2,  @Fecha, @Hingreso1, @Hsalida1, @Hingreso2, @Hsalida2, @HdescansoI, @HdescansoS, @TotalHoras, @MontoDia)" +
                               "SELECT SCOPE_IDENTITY();";

                using (SqlConnection conn = conexion.AbrirConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmpleadoId", horas.EmpleadoId);
                        cmd.Parameters.AddWithValue("@Phora2", horas.Phora2);
                        cmd.Parameters.AddWithValue("@Fecha", horas.Fecha);
                        cmd.Parameters.AddWithValue("@Hingreso1", (object)horas.Hingreso1 ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Hsalida1", (object)horas.Hsalida1 ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Hingreso2", (object)horas.Hingreso2 ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Hsalida2", (object)horas.Hsalida2 ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@HdescansoI", (object)horas.HdescansoI ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@HdescansoS", (object)horas.HdescansoS ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalHoras", horas.TotalHoras);
                        cmd.Parameters.AddWithValue("@MontoDia", horas.MontoDia);

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

        public DataTable ObtenerHorasPorEmpleado(int empleadoId)
        {
            DataTable dtHoras = new DataTable();
            try
            {
                string query = @"
            SELECT HoraId, Fecha, Hingreso1, Hsalida1, Hingreso2, Hsalida2, HdescansoI, HdescansoS, FeriadoDomingo, TotalHoras, Phora2, MontoDia
            FROM Horas
            WHERE EmpleadoId = @EmpleadoId
            ORDER BY Fecha";

                using (SqlConnection conn = conexion.AbrirConexion())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmpleadoId", empleadoId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dtHoras);
                    }
                }
            }
            catch (Exception ex)
            {
                Error = "Error al obtener las horas del empleado: " + ex.Message;
            }

            return dtHoras;
        }
    }
}