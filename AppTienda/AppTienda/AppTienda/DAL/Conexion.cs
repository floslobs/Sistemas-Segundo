using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace AppTienda.DAL
{
    public class Conexion
    {
        private static SqlConnection conexion;

        public static SqlConnection ObtenerConexion()
        {
            if (conexion == null)
            {
                string cadena = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                conexion = new SqlConnection(cadena);
                conexion.Open();
            }
            else if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }

            return conexion;
        }

        public static void CerrarConexion()
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
