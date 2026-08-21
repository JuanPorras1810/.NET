using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    internal class Producto
    {
        //Atributos
        public string producto;
        public int stock;

        //Constructor
        public Producto(string pro, int sto)
        {
            producto = pro;
            stock = sto;
        }

        //Metodo para agregar
        public bool Agregar(int cantidad)
        {
            if (cantidad > 0)
            {
                stock += cantidad;
                return true;
            }
            return false;
        }

        //Metodo para quitar
        public bool Quitar(int cantidad)
        {
            if (cantidad > 0 && cantidad <= stock)
            {
                stock -= cantidad;
                return true;
            }
            return false;
        }

    }
}
