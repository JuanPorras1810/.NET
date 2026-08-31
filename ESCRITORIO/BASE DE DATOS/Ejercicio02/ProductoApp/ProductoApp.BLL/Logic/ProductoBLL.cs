using ProductoApp.DAL.Data;
using ProductoApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoApp.BLL.Logic
{
    public class ProductoBLL
    {
        private readonly ProductoDAL _dal;

        public ProductoBLL()
        {
            _dal = new ProductoDAL();
        }

        public List<Producto> Listar()
        {
            try
            {
                return _dal.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar productos: " + ex.Message, ex);
            }
        }

        private string ValidarProducto(Producto p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre))
                return "El nombre del producto es obligatorio.";

            if (p.Nombre.Length > 100)
                return "El nombre no puede exceder 100 caracteres.";

            if (p.Precio <= 0)
                return "El precio debe ser mayor a 0.";

            if (p.Stock < 0)
                return "El stock no puede ser negativo.";

            return string.Empty;
        }

        public Producto ObtenerPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID debe ser mayor a cero.");

            return _dal.ObtenerPorId(id);
        }

        public string Insertar(Producto producto) 
        {
            string error = ValidarProducto(producto);

            if (!string.IsNullOrEmpty(error))
                return error;

            try
            {
                int nuevoId = _dal.Insertar(producto);
                return "Producto insertado correctamente. ID: " + nuevoId;
            }
            catch (Exception ex)
            {
                return "Error al guardar: " + ex.Message;
            }
        }

        public string Actualizar(Producto producto)
        {
            string error = ValidarProducto(producto);
            if(!string.IsNullOrEmpty(error))
                return error;

            try
            {
                bool actualizado = _dal.Actualizar(producto);
                return actualizado ? "Producto actualizado correctamente." : "No se encontró el producto para actualizar.";
            }
            catch (Exception ex) 
            {
                return "Error al actualizar: " + ex.Message;
            }
        }

        public string Eliminar(int idProducto)
        {
            if (idProducto <= 0)
                return "ID inválido.";

            try
            {
                bool eliminado = _dal.Eliminar(idProducto);
                return eliminado? "Producto eliminado correctamente." : "No se encontró el producto.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar: " + ex.Message;
            }
        }
    }
}
