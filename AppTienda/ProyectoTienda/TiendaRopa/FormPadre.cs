using Microsoft.Data.SqlClient;

namespace TiendaRopa
{
    public partial class FormPadre : Form
    {
        public FormPadre()
        {
            InitializeComponent();
        }
        public class ConexionBD
        {
            private readonly string _connectionString;

            public ConexionBD()
            {

                _connectionString = Environment.GetEnvironmentVariable("TiendaDB")
                                    ?? throw new InvalidOperationException("❌ No se encontró la variable de entorno CADENA_CONEXION_SQL_EmpresaManzanilla");
            }

            public SqlConnection ObtenerConexion()
            {
                return new SqlConnection(_connectionString);
            }
        }
    }
}
