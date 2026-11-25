using EmpleadosOrigin.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosOrigin.BE
{
    // Clase que representa la logica para manejar empleados
    public class EmpleadoManager
    {
        
        public void GuardarEmpleado(EmpleadoC emp)
        {

            // Si el legajo es cero o menor, lanza un error
            if (emp.Legajo <= 0)
                throw new Exception("Legajo inválido.");

            // Si el precio por hora es cero o menor, lanza un error
            if (emp.PrecioHora <= 0)
                // Lanzo una excepción(throw) para que el formulario (FE) muestre el mensaje,
                // manteniendo separada la lógica y la interfaz.
                throw new Exception("Precio por hora inválido.");

            // Armamos la consulta SQL parametrizada 
            string query = "INSERT INTO Empleados (Legajo, Nombre, PrecioHora, FechaNacimiento) " +
                           "VALUES (@Legajo, @Nombre, @PrecioHora, @FechaNacimiento)";

            //  Creamos los parametros con los valores del objeto empleado
            // Creamos un array de parámetros que se usaran en la consulta SQL,
            // asignando los valores del objeto empleado a cada uno.
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Legajo", emp.Legajo),
                new SqlParameter("@Nombre", emp.Nombre),
                new SqlParameter("@PrecioHora", emp.PrecioHora),
                new SqlParameter("@FechaNacimiento", emp.FechaNac)
            };

            // Instanciamos la clase que accede a la base de datos (DAL)
            conexion con = new conexion();

            //  Ejecutamos la consulta pasando el SQL y los parametros
            con.EjecutarConsulta(query, parametros);
        }

        public List<EmpleadoC> ObtenerTodos()
        {
            // Creamos una lista vacía para guardar los empleados que vamos a obtener
            List<EmpleadoC> empleados = new List<EmpleadoC>();

            // Consulta SQL para seleccionar todos los datos de la tabla Empleados
            string query = "SELECT Legajo, Nombre, PrecioHora, FechaNacimiento FROM Empleados";

            // Instanciamos la clase de conexión a la base de datos
            conexion con = new conexion();

            // Ejecutamos la consulta usando el método EjecutarSelect, que devuelve un DataTable
            DataTable tabla = con.EjecutarSelect(query);

            // Recorremos cada fila del DataTable
            foreach (DataRow row in tabla.Rows)
            {
                // Creamos un objeto Empleado con los datos de la fila
                EmpleadoC emp = new EmpleadoC(
                    /*Hay que convertir porque los datos que vienen de una base de datos (a través de un DataTable)
                     * se almacenan como objetos genéricos de tipo object.*/
                    /*Cuando accedés a un valor con row["Nombre"], por ejemplo, eso devuelve un object, y para poder 
                     * usarlo con el tipo de dato correcto (como string, int, DateTime, etc.), hay que convertirlo explícitamente.*/
                    Convert.ToInt32(row["Legajo"]),
                    row["Nombre"].ToString(),
                    Convert.ToInt32(row["PrecioHora"]),
                    Convert.ToDateTime(row["FechaNacimiento"])
                );

                // Lo agregamos a la lista
                empleados.Add(emp);
            }

            // Devolvemos la lista de empleados
            return empleados;
        }

        public void ModificarEmpleado(EmpleadoC emp)
        {
            // Consulta SQL para actualizar los datos
            string query = "UPDATE Empleados SET Nombre = @Nombre, PrecioHora = @PrecioHora, FechaNacimiento = @FechaNacimiento WHERE Legajo = @Legajo";

            SqlParameter[] parametros = new SqlParameter[]
            {
                 new SqlParameter("@Nombre", emp.Nombre),
                 new SqlParameter("@PrecioHora", emp.PrecioHora),
                 new SqlParameter("@FechaNacimiento", emp.FechaNac),
                 new SqlParameter("@Legajo", emp.Legajo) // usamos el legajo para identificar al empleado
            };

            conexion con = new conexion();
            con.EjecutarConsulta(query, parametros); // Ejecuta el UPDATE
        }

        public void EliminarEmpleado(int legajo) // Método público que recibe el legajo del empleado a eliminar
        {
            string query = "DELETE FROM Empleados WHERE Legajo = @Legajo"; // Consulta SQL para eliminar un empleado según el legajo

            SqlParameter[] parametros = new SqlParameter[] // Se crea el parámetro SQL para evitar inyecciones y pasar el valor seguro
            {
                 new SqlParameter("@Legajo", legajo) // Se pasa el valor del legajo al parámetro
            };

            conexion con = new conexion(); // Se instancia la clase que maneja la conexión a la base de datos
            con.EjecutarConsulta(query, parametros); // Se ejecuta la consulta DELETE con los parámetros
        }

        public DataTable ObtenerTodosLosEmpleados()
        {
            string query = "SELECT Legajo, Nombre FROM Empleados";
            conexion con = new conexion();
            return con.EjecutarSelect(query);
        }

        public void GuardarHorasDiarias(int legajo, DateTime fecha, decimal HorasTrabajadas)
        {
            conexion con = new conexion();

            string consulta = "INSERT INTO HorasDiarias (Legajo, Fecha, HorasTrabajadas) VALUES (@Legajo, @Fecha, @HorasTrabajadas)";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Legajo", legajo),
                new SqlParameter("@Fecha", fecha),
                new SqlParameter("@HorasTrabajadas", HorasTrabajadas)
            };

            con.EjecutarConsulta(consulta, parametros);
        }

        public void GuardarHorasMensuales(int legajo, int mes, int anio, decimal horas)
        {
            conexion con = new conexion();

            string select = "SELECT COUNT(*) FROM HorasMensuales WHERE Legajo = @Legajo AND Mes = @Mes AND Anio = @Anio";
            SqlParameter[] parametrosSelect = new SqlParameter[]
            {
                 new SqlParameter("@Legajo", legajo),
                 new SqlParameter("@Mes", mes),
                 new SqlParameter("@Anio", anio)
            };

            bool existe = Convert.ToInt32(con.EjecutarEscalar(select, parametrosSelect)) > 0;

            string consulta;
            SqlParameter[] parametros;

            if (existe)
            {
                consulta = "UPDATE HorasMensuales SET TotalHoras = TotalHoras + @Horas WHERE Legajo = @Legajo AND Mes = @Mes AND Anio = @Anio";
            }
            else
            {
                consulta = "INSERT INTO HorasMensuales (Legajo, Mes, Anio, TotalHoras) VALUES (@Legajo, @Mes, @Anio, @Horas)";
            }

            parametros = new SqlParameter[]
            {
                 new SqlParameter("@Legajo", legajo),
                 new SqlParameter("@Mes", mes),
                 new SqlParameter("@Anio", anio),
                 new SqlParameter("@Horas", horas)
            };

            con.EjecutarConsulta(consulta, parametros);
        }

        // Obtiene el precio por hora de un empleado
        public static decimal ObtenerPrecioPorHora(int Legajo)
        {
            decimal precio = 0;
            string sql = "SELECT PrecioHora FROM Empleados WHERE Legajo = @Legajo";

            using (SqlConnection conn = new SqlConnection(conexion.CadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Legajo", Legajo);
                conn.Open();
                precio = Convert.ToDecimal(cmd.ExecuteScalar());
            }

            return precio;
        }

        // Obtiene las horas trabajadas del mes actual ya guardadas en la tabla HorasMensuales
        public static int ObtenerHorasTrabajadasDelMes(int Legajo)
        {
            int horas = 0;
            string sql = @"SELECT ISNULL(TotalHoras, 0)
                       FROM HorasMensuales
                       WHERE Legajo = @Legajo 
                       AND Mes = @Mes 
                       AND Anio = @Anio";

            using (SqlConnection conn = new SqlConnection(conexion.CadenaConexion))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Legajo", Legajo);
                cmd.Parameters.AddWithValue("@Mes", DateTime.Now.Month);
                cmd.Parameters.AddWithValue("@Anio", DateTime.Now.Year);
                conn.Open();
                object resultado = cmd.ExecuteScalar();

                if (resultado != DBNull.Value)
                    horas = Convert.ToInt32(resultado);
            }

            return horas;
        }


    }
}
