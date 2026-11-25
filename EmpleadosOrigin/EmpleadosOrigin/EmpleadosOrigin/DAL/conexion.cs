using System;
using System.Data;
using System.Data.SqlClient;

namespace EmpleadosOrigin.DAL
{
    // Clase que encapsula la conexión y consultas SQL
    public class conexion
    {
        // Cadena de conexión que no se puede modificar después del constructor
        private readonly string cadena;
       

        // Constructor: inicializa la cadena de conexión
        public conexion()
        {
            cadena = "Server=FLOR;Database=BD_manzanilla;Trusted_Connection=True;";
        }
        public static string CadenaConexion => "Server=FLOR;Database=BD_manzanilla;Trusted_Connection=True;";

        // Método para ejecutar INSERT, UPDATE o DELETE
        public int EjecutarConsulta(string consulta, SqlParameter[] parametros = null)
        {
            SqlConnection con = new SqlConnection(cadena);
            try
            {
                con.Open(); // Abre la conexión a la base de datos
                SqlCommand cmd = new SqlCommand(consulta, con); // Crea el comando

                if (parametros != null)
                    cmd.Parameters.AddRange(parametros); // Agrega parámetros si existen

                return cmd.ExecuteNonQuery(); // Ejecuta y devuelve cantidad de filas afectadas
            }
            catch (SqlException ex)
            {
                // Si ocurre un error, lanza una excepción más clara
                throw new Exception("Error al ejecutar la consulta: " + ex.Message, ex);
            }
            // El bloque finally se ejecuta siempre, haya o no error, y se usa para cerrar la conexión a la base de datos.
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        // Método para ejecutar SELECT que devuelve una tabla de datos
        public DataTable EjecutarSelect(string consulta, SqlParameter[] parametros = null)
        {
            SqlConnection con = new SqlConnection(cadena);
            try
            {
                SqlCommand cmd = new SqlCommand(consulta, con);

                if (parametros != null)
                    cmd.Parameters.AddRange(parametros); // Agrega parámetros si hay

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd); // Adaptador para llenar tabla
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla); // Llena la tabla con los resultados del SELECT

                return tabla; // Devuelve los datos obtenidos
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al ejecutar el SELECT: " + ex.Message, ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close(); // Siempre cerrar conexión
            }
        }

        // Método para ejecutar SELECT que devuelve un único valor (como COUNT, MAX, etc.)
        public object EjecutarEscalar(string consulta, SqlParameter[] parametros = null)
        {
            SqlConnection con = new SqlConnection(cadena);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(consulta, con);

                if (parametros != null)
                    cmd.Parameters.AddRange(parametros);

                return cmd.ExecuteScalar(); // Devuelve el primer valor de la primera fila
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al ejecutar consulta escalar: " + ex.Message, ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        // Metodo para verificar si un valor existe en la base de datos
        public bool Existe(string consulta, SqlParameter[] parametros = null)
        {
            try
            {
                object resultado = EjecutarEscalar(consulta, parametros);
                // Si no es null ni DBNull, entonces existe
                return resultado != null && resultado != DBNull.Value;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar existencia de datos: " + ex.Message, ex);
            }
        }
    }
}