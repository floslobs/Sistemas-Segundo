using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTienda.DAL;

namespace AppTienda.BE
{
    internal class BETalles
    {
        public string error { get; set; } // Para comunicar errores desde BE/DAL

        // ====================================
        // OBTENER TODOS LOS TALLES
        // ====================================
        public List<Talles> ObtenerTodos()
        {
            try
            {
                TalleDAL dal = new TalleDAL();
                var lista = dal.ObtenerTodos();

                if (lista == null || lista.Count == 0)
                    error = dal.error;

                return lista;
            }
            catch (Exception ex)
            {
                error = "Error al obtener los talles: " + ex.Message;
                return new List<Talles>();
            }
        }

        // ====================================
        // OBTENER UN TALLE POR ID
        // ====================================
        public Talles ObtenerPorId(int talleId)
        {
            try
            {
                TalleDAL dal = new TalleDAL();
                var item = dal.ObtenerPorId(talleId);

                if (item == null)
                    error = dal.error;

                return item;
            }
            catch (Exception ex)
            {
                error = "Error al obtener el talle: " + ex.Message;
                return null;
            }
        }

        // ====================================
        // CREAR UN NUEVO TALLE
        // ====================================
        public int Crear(Talles talle)
        {
            try
            {
                TalleDAL dal = new TalleDAL();
               // int id = dal.Insertar(talle);

                /*if (id <= 0)
                    error = dal.error;*/

                return 0;
            }
            catch (Exception ex)
            {
                error = "Error al crear el talle: " + ex.Message;
                return -1;
            }
        }

        // ====================================
        // MODIFICAR UN TALLE
        // ====================================
        public bool Modificar(Talles talles)
        {
            try
            {
                TalleDAL dal = new TalleDAL();
               // bool ok = dal.Modificar(talles);

                /*if (!ok)
                    error = dal.error;*/

                return true;
            }
            catch (Exception ex)
            {
                error = "Error al modificar el talle: " + ex.Message;
                return false;
            }
        }

        // ====================================
        // ELIMINAR UN TALLE
        // ====================================
        public bool Eliminar(int talleId)
        {
            try
            {
                TalleDAL dal = new TalleDAL();
                bool ok = dal.Eliminar(talleId);

                if (!ok)
                    error = dal.error;

                return ok;
            }
            catch (Exception ex)
            {
                error = "Error al eliminar el talle: " + ex.Message;
                return false;
            }
        }
    }
}
