using AppTienda.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class BEProveedores
    {
        public string error { get; set; } // Para comunicar errores desde BE/DAL

        // ====================================
        // OBTENER TODOS LOS PROVEEDORES
        // ====================================
        public List<Proveedores> ObtenerTodos()
        {
            try
            {
                ProveedorDAL dal = new ProveedorDAL();
                var lista = dal.ObtenerTodos();

                if (lista == null || lista.Count == 0)
                    error = dal.error;

                return lista ?? new List<Proveedores>();
            }
            catch (Exception ex)
            {
                error = "Error al obtener los proveedores: " + ex.Message;
                return new List<Proveedores>();
            }
        }

        // ====================================
        // OBTENER PROVEEDOR POR ID
        // ====================================
        public Proveedores ObtenerPorId(int proveedorId)
        {
            try
            {
                ProveedorDAL dal = new ProveedorDAL();
                var prov = dal.ObtenerPorId(proveedorId);

                if (prov == null)
                    error = dal.error;

                return prov;
            }
            catch (Exception ex)
            {
                error = "Error al obtener el proveedor: " + ex.Message;
                return null;
            }
        }

        // ====================================
        // CREAR UN NUEVO PROVEEDOR
        // ====================================
        public int Crear(Proveedores proveedor)
        {
            try
            {
                ProveedorDAL dal = new ProveedorDAL();
                int id = dal.InsertarProveedor(proveedor);

                if (id <= 0)
                    error = dal.error;

                return id;
            }
            catch (Exception ex)
            {
                error = "Error al crear el proveedor: " + ex.Message;
                return -1;
            }
        }

        // ====================================
        // MODIFICAR UN PROVEEDOR
        // ====================================
        public bool Modificar(Proveedores proveedor)
        {
            try
            {
                ProveedorDAL dal = new ProveedorDAL();
                bool ok = dal.ModificarProveedor(proveedor);

                if (!ok)
                    error = dal.error;

                return ok;
            }
            catch (Exception ex)
            {
                error = "Error al modificar el proveedor: " + ex.Message;
                return false;
            }
        }

        // ====================================
        // ELIMINAR UN PROVEEDOR
        // ====================================
        public bool Eliminar(int proveedorId)
        {
            try
            {
                ProveedorDAL dal = new ProveedorDAL();
                bool ok = dal.EliminarProveedor(proveedorId);

                if (!ok)
                    error = dal.error;

                return ok;
            }
            catch (Exception ex)
            {
                error = "Error al eliminar el proveedor: " + ex.Message;
                return false;
            }
        }
    }
}
