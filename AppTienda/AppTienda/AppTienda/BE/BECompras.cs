using AppTienda.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class BECompras
    {
        public string error { get; set; } // Para comunicar errores desde BE/DAL

        // ====================================
        // CREAR COMPRA CON DETALLES
        // ====================================
        public int CrearCompraConDetalles(Compras compra)
        {
            try
            {
                ComprasDAL dal = new ComprasDAL();
                int id = dal.CrearCompraConDetalles(compra);

                if (id <= 0)
                    error = dal.error;

                return id;
            }
            catch (Exception ex)
            {
                error = "Error al crear la compra: " + ex.Message;
                return -1;
            }
        }

        // ====================================
        // OBTENER COMPRA POR ID
        // ====================================
        public Compras ObtenerCompraPorId(int compraId)
        {
            try
            {
                ComprasDAL dal = new ComprasDAL();
                var compra = dal.ObtenerPorId(compraId);

                if (compra == null)
                    error = dal.error;

                return compra;
            }
            catch (Exception ex)
            {
                error = "Error al obtener la compra: " + ex.Message;
                return null;
            }
        }

        // ====================================
        // OBTENER COMPRAS POR FECHAS Y PROVEEDOR
        // ====================================
        public List<Compras> ObtenerCompras(DateTime desde, DateTime hasta, int proveedorId = 0)
        {
            try
            {
                ComprasDAL dal = new ComprasDAL();
                var lista = dal.ObtenerTodos(desde, hasta, proveedorId);

                if (lista == null || lista.Count == 0)
                    error = dal.error;

                return lista ?? new List<Compras>();
            }
            catch (Exception ex)
            {
                error = "Error al obtener las compras: " + ex.Message;
                return new List<Compras>();
            }
        }

        // ====================================
        // ELIMINAR COMPRA
        // ====================================
        public bool EliminarCompra(int compraId)
        {
            try
            {
                ComprasDAL dal = new ComprasDAL();
                bool ok = dal.EliminarCompra(compraId);

                if (!ok)
                    error = dal.error;

                return ok;
            }
            catch (Exception ex)
            {
                error = "Error al eliminar la compra: " + ex.Message;
                return false;
            }
        }

        // ====================================
        // DETALLES DE PRODUCTOS
        // ====================================
        public bool AgregarDetalleProducto(CompraDeTalle detalle)
        {
            try
            {
                CompraProdDAL dal = new CompraProdDAL();
                bool ok = dal.InsertarDetalle(detalle);

                if (!ok)
                    error = dal.error;

                return ok;
            }
            catch (Exception ex)
            {
                error = "Error al agregar detalle de producto: " + ex.Message;
                return false;
            }
        }

        public bool EliminarDetallesPorCompra(int compraId)
        {
            try
            {
                CompraProdDAL dal = new CompraProdDAL();
                bool ok = dal.EliminarDetallesPorCompra(compraId);

                if (!ok)
                    error = dal.error;

                return ok;
            }
            catch (Exception ex)
            {
                error = "Error al eliminar detalles de productos: " + ex.Message;
                return false;
            }
        }

        // ====================================
        // DETALLES DE TALLES
        // ====================================
        public bool AgregarDetalleTalle(ComprasTalles detalle)
        {
            try
            {
                ComprasTalleDAL dal = new ComprasTalleDAL();
                bool ok = dal.InsertarDetalle(detalle);

                if (!ok)
                    error = dal.error;

                return ok;
            }
            catch (Exception ex)
            {
                error = "Error al agregar detalle de talle: " + ex.Message;
                return false;
            }
        }

        public bool EliminarTallesPorCompra(int compraId)
        {
            try
            {
                ComprasTalleDAL dal = new ComprasTalleDAL();
                bool ok = dal.EliminarTallesPorCompra(compraId);

                if (!ok)
                    error = dal.error;

                return ok;
            }
            catch (Exception ex)
            {
                error = "Error al eliminar talles de la compra: " + ex.Message;
                return false;
            }
        }
    }
}
