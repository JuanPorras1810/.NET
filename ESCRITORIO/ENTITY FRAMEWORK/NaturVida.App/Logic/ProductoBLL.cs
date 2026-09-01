using NaturVida.App.Data;
using NaturVida.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaturVida.App.Logic
{
    internal class ProductoBLL
    {
        private readonly ProductoDAL dal = new();

        public List<Producto> Listar() => dal.ObtenerTodos();

        public string Guardar(Producto pro) 
        {
            if (string.IsNullOrWhiteSpace(pro.Nombre))
                return "El nombre es obligatorio.";

            if (pro.Nombre.Length > 50)
                return "El nombre no puede exceder 50 caracteres.";

            if (pro.Precio <= 0)
                return "El precio debe ser un número mayor a 0.";

            try
            {
                if (pro.Id > 0)
                {
                    dal.Actualizar(pro);
                    return "Actualizado correctamente.";
                }
                else
                {
                    dal.Insertar(pro);
                    return "Guardado correctamente.";
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }


        public string Eliminar(int id)
        {
            try
            {
                dal.Eliminar(id);
                return "Eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }

        }
    }
}
