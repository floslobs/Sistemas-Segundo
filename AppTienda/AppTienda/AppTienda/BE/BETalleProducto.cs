using AppTienda.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTienda.BE
{
    internal class BETalleProducto
    {
        public string error { get; set; } // Para comunicar errores desde BE/DAL

        // ====================================
        // OBTENER TALLES POR PRODUCTO
        // ====================================
        public List<Talles> ObtenerTallesPorProducto(int productoId)
        {
            try
            {
                TalleProductoDAL dal = new TalleProductoDAL();
                var lista = dal.ObtenerTallesPorProducto(productoId);

                if (lista == null || lista.Count == 0)
                    error = dal.error;

                return lista ?? new List<Talles>();
            }
            catch (Exception ex)
            {
                error = "Error al obtener talles del producto: " + ex.Message;
                return new List<Talles>();
            }
        }

        // ====================================
        // AGREGAR TALLE A PRODUCTO
        // ====================================
        public bool AgregarTalleAProducto(int productoId, int talleId)
        {
            try
            {
                TalleProductoDAL dal = new TalleProductoDAL();
                bool ok = dal.AgregarTalleAProducto(productoId, talleId);

                if (!ok)
                    error = dal.error;

                return ok;
            }
            catch (Exception ex)
            {
                error = "Error al agregar talle al producto: " + ex.Message;
                return false;
            }
        }

        // ====================================
        // QUITAR TALLE DE PRODUCTO
        // ====================================
        public bool QuitarTalleDeProducto(int productoId, int talleId)
        {
            try
            {
                TalleProductoDAL dal = new TalleProductoDAL();
                bool ok = dal.QuitarTalleDeProducto(productoId, talleId);

                if (!ok)
                    error = dal.error;

                return ok;
            }
            catch (Exception ex)
            {
                error = "Error al quitar talle del producto: " + ex.Message;
                return false;
            }
        }

        // ====================================
        // VERIFICAR SI EXISTE UN TALLE EN UN PRODUCTO
        // ====================================
        public bool ExisteTalleEnProducto(int productoId, int talleId)
        {
            try
            {
                TalleProductoDAL dal = new TalleProductoDAL();
                bool existe = dal.ExisteTalleEnProducto(productoId, talleId);

                if (!existe && !string.IsNullOrEmpty(dal.error))
                    error = dal.error;

                return existe;
            }
            catch (Exception ex)
            {
                error = "Error al verificar talle en producto: " + ex.Message;
                return false;
            }
        }
    }
}
