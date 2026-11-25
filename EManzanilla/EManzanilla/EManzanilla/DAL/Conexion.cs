using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EManzanilla.DAL
{
    public class Conexion
    {
        private readonly string cadenaConexion;

        public Conexion()
        {
            // Lee la cadena de conexión desde App.config
            cadenaConexion = ConfigurationManager.ConnectionStrings["conexion"]?.ConnectionString;

            if (string.IsNullOrEmpty(cadenaConexion))
            {
                MessageBox.Show("❌ No se encontró la cadena de conexión 'conexion' en App.config");
            }
        }

        public SqlConnection AbrirConexion()
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            conn.Open();
            return conn;
        }

        public void CerrarConexion(SqlConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}
