using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Productos
    {
        CD_Productos OCd_Productos = new CD_Productos();

        public DataTable Mostrar() 
        {
            return OCd_Productos.Mostrar();
        }

        public void Insertar(string nombre, string descripcion, string marca, string precio, string stock) 
        { 
            OCd_Productos.Insertar(nombre, descripcion, marca, Convert.ToSingle(precio), Convert.ToInt32(stock)); 
        }


        public void Actualizar(string id, string nombre, string descripcion, string marca, string precio, string stock) 
        {
            OCd_Productos.Actualizar(Convert.ToInt32(id), nombre, descripcion, marca, Convert.ToSingle(precio), Convert.ToInt32(stock));
        }

        public void Eliminar(string id) 
        {
            OCd_Productos.Eliminar(Convert.ToInt32(id));
        }
    }
}
