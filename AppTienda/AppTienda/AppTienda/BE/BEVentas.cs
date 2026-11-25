using AppTienda.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class BEVentas
    {
        public string error { get; set; } // Para comunicar errores desde BE/DAL

        // ====================================
        // CREAR VENTA CON DETALLES
        // ====================================
        public int CrearVentaConDetalles(Ventas ventas)
        {
            try
            {
                VentasDAL dal = new VentasDAL();
                int id = dal.CrearVentaConDetalles(ventas);

                if (id <= 0)
                    error = dal.error;

                return id;
            }
            catch (Exception ex)
            {
                error = "Error al crear la venta: " + ex.Message;
                return -1;
            }
        }

        // ====================================
        // OBTENER VENTA POR ID
        // ====================================
        public Ventas ObtenerVentaPorId(int ventaId)
        {
            try
            {
                VentasDAL dal = new VentasDAL();
                var ventas = dal.ObtenerPorId(ventaId);

                if (ventas == null)
                    error = dal.error;

                return ventas;
            }
            catch (Exception ex)
            {
                error = "Error al obtener la venta: " + ex.Message;
                return null;
            }
        }

        // ====================================
        // OBTENER VENTAS POR FECHAS Y CLIENTE
        // ====================================
        public List<Ventas> ObtenerVentas(DateTime desde, DateTime hasta, int clienteId = 0)
        {
            try
            {
                VentasDAL dal = new VentasDAL();
                var lista = dal.ObtenerVentas(desde, hasta, clienteId);

                if (lista == null || lista.Count() == 0)
                    error = dal.error;

                return lista ?? new List<Ventas>();
            }
            catch (Exception ex)
            {
                error = "Error al obtener las ventas: " + ex.Message;
                return new List<Ventas>();
            }
        }

        // ====================================
        // ELIMINAR VENTA
        // ====================================
        public bool EliminarVenta(int VentaId)
        {
            try
            {
                VentasDAL dal = new VentasDAL();
                bool ok = dal.Eliminar(VentaId);

                if (!ok)
                    error = dal.error;

                return ok;
            }
            catch (Exception ex)
            {
                error = "Error al eliminar la venta: " + ex.Message;
                return false;
            }
        }

        // ====================================
        // DETALLES DE PRODUCTOS
        // ====================================
        public bool AgregarDetalleProducto(VentaDeTalle detalle)
        {
            try
            {
                VentasProductoDAL dal = new VentasProductoDAL();
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

        public bool EliminarDetallesPorVenta(int ventaId)
        {
            try
            {
                VentasProductoDAL dal = new VentasProductoDAL();
                bool ok = dal.EliminarDetallesPorVenta(ventaId);

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
        public bool AgregarDetalleTalle(VentasTalles detalle)
        {
            try
            {
                VentasTalleDAL dal = new VentasTalleDAL();
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

        public bool EliminarTallesPorVenta(int VentaId)
        {
            try
            {
                VentasTalleDAL dal = new VentasTalleDAL();
                bool ok = dal.EliminarTallesPorVenta(VentaId);

                if (!ok)
                    error = dal.error;

                return ok;
            }
            catch (Exception ex)
            {
                error = "Error al eliminar talles de la venta: " + ex.Message;
                return false;
            }
        }
    }
}
