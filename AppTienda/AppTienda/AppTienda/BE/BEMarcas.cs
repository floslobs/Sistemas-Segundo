using AppTienda.DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class BEMarcas
    {
        public string error { get; set; } // Para comunicar errores desde BE/DAL

        // ====================================
        // OBTENER TODAS LAS MARCAS
        // ====================================
        public List<Marcas> ObtenerTodos()
        {
            try
            {
                MarcasDAL dal = new MarcasDAL();
                var lista = dal.ObtenerTodas();

                if (lista == null || lista.Count == 0)
                    error = dal.error;

                return lista ?? new List<Marcas>();
            }
            catch (Exception ex)
            {
                error = "Error al obtener las marcas: " + ex.Message;
                return new List<Marcas>();
            }
        }

        // ====================================
        // CREAR UNA NUEVA MARCA
        // ====================================
        public int Crear(Marcas marcas)
        {
            try
            {
                MarcasDAL dal = new MarcasDAL();
                int id = dal.AgregarMarca(marcas);

                if (id <= 0)
                    error = dal.error;

                return id;
            }
            catch (Exception ex)
            {
                error = "Error al crear la marca: " + ex.Message;
                return -1;
            }
        }

        // ====================================
        // MODIFICAR UNA MARCA
        // ====================================
        public bool Modificar(Marcas marca)
        {
            try
            {
                MarcasDAL dal = new MarcasDAL();
                bool ok = dal.EditarMarca(marca);

                if (!ok)
                    error = dal.error;

                return ok;
            }
            catch (Exception ex)
            {
                error = "Error al modificar la marca: " + ex.Message;
                return false;
            }
        }

        // ====================================
        // ELIMINAR UNA MARCA
        // ====================================
        public bool Eliminar(int marcaId)
        {
            string query = "DELETE FROM Marcas WHERE MarcaId = @MarcaId";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion()))
                {
                    cmd.Parameters.AddWithValue("@MarcaId", marcaId);
                    return cmd.ExecuteNonQuery() > 0; // ← devuelve bool
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}

