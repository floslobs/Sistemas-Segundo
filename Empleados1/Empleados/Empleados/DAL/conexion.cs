using System;
using System.Data;
using System.Data.SqlClient;

public class Conexion
{
    private SqlConnection con;

    public Conexion()
    {
        // Cadena de conexión (ajustá el nombre del servidor y la base de datos si es necesario)
        string cadena = "Server=FLOR;Database=BD_manzanilla;Trusted_Connection=True;";
        con = new SqlConnection(cadena);
    }

    // INSERT, UPDATE, DELETE
    public int EjecutarConsulta(string consulta, SqlParameter[] parametros = null)
    {
        using (SqlCommand cmd = new SqlCommand(consulta, con))
        {
            if (parametros != null)
                cmd.Parameters.AddRange(parametros);

            con.Open();
            int filasAfectadas = cmd.ExecuteNonQuery();
            con.Close();

            return filasAfectadas;
        }
    }

    // SELECT que devuelve una tabla
    public DataTable EjecutarSelect(string consulta, SqlParameter[] parametros = null)
    {
        using (SqlCommand cmd = new SqlCommand(consulta, con))
        {
            if (parametros != null)
                cmd.Parameters.AddRange(parametros);

            using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
            {
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }
    }

    // Devuelve un solo valor (ej: COUNT, MAX, etc.)
    public object EjecutarEscalar(string consulta, SqlParameter[] parametros = null)
    {
        using (SqlCommand cmd = new SqlCommand(consulta, con))
        {
            if (parametros != null)
                cmd.Parameters.AddRange(parametros);

            con.Open();
            object resultado = cmd.ExecuteScalar();
            con.Close();

            return resultado;
        }
    }

    // Verifica si existe un dato
    public bool Existe(string consulta, SqlParameter[] parametros = null)
    {
        object resultado = EjecutarEscalar(consulta, parametros);
        return resultado != null && resultado != DBNull.Value;
    }
}
