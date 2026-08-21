using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    internal class Producto
    {
        //Propiedades
        public string Nombre { get; set; }
        public int StockMinimo { get; set; }

        //Atributo 
        private int stock;

        //Propiedad de solo lectura
        public int Stock
        {
            get => stock;
        }

        //Constructor
        public Producto(string nom, int stoMin, int stoIni)
        {
            Nombre = nom;
            StockMinimo = stoMin;
            stock = stoIni;
        }

        //Metodo para retirar productos
        public bool Retirar(int cantidad)
        {
            if (stock - cantidad >= StockMinimo)
            {
                stock -= cantidad;
                return true;
            }

            return false;
        }
    }
}
