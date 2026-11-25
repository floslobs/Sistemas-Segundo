using AppTienda.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class BEClientes
    {
        public string error { get; set; } // Para comunicar errores desde BE/DAL

        // ====================================
        // OBTENER TODOS LOS PRODUCTOS
        // ====================================
        public List<Productos> ObtenerTodos()
        {
            try
            {
                ProductosDAL dal = new ProductosDAL();
                var lista = dal.ObtenerTodos();

                if (lista == null || lista.Count == 0)
                    error = dal.error;

                return lista ?? new List<Productos>();
            }
            catch (Exception ex)
            {
                error = "Error al obtener los productos: " + ex.Message;
                return new List<Productos>();
            }
        }

        // ====================================
        // OBTENER UN PRODUCTO POR ID
        // ====================================
        public Productos ObtenerPorId(int productoId)
        {
            try
            {
                ProductosDAL dal = new ProductosDAL();
                var item = dal.ObtenerPorId(productoId);

                if (item == null)
                    error = dal.error;

                return item;
            }
            catch (Exception ex)
            {
                error = "Error al obtener el producto: " + ex.Message;
                return null;
            }
        }

        // ====================================
        // CREAR UN NUEVO PRODUCTO
        // ====================================
        public int Crear(Productos productos)
        {
            try
            {
                ProductosDAL dal = new ProductosDAL();
                int id = dal.Insertar(productos);

                if (id <= 0)
                    error = dal.error;

                return id;
            }
            catch (Exception ex)
            {
                error = "Error al crear el producto: " + ex.Message;
                return -1;
            }
        }

        // ====================================
        // MODIFICAR UN PRODUCTO
        // ====================================
        public bool Modificar(Productos productos)
        {
            try
            {
                ProductosDAL dal = new ProductosDAL();
                bool ok = dal.Modificar(productos);

                if (!ok)
                    error = dal.error;

                return ok;
            }
            catch (Exception ex)
            {
                error = "Error al modificar el producto: " + ex.Message;
                return false;
            }
        }

        // ====================================
        // ELIMINAR UN PRODUCTO
        // ====================================
        public bool Eliminar(int productoId)
        {
            try
            {
                ProductosDAL dal = new ProductosDAL();
                bool ok = dal.Eliminar(productoId);

                if (!ok)
                    error = dal.error;

                return ok;
            }
            catch (Exception ex)
            {
                error = "Error al eliminar el producto: " + ex.Message;
                return false;
            }
        }
    }
}
