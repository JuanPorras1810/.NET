using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string producto = "Laptop";
            double precio = 2500000;
            int cantidad = 3;
            double total = precio * cantidad;

            //Forma antigua (usando +)
            Console.WriteLine("El producto " + producto + " su precio es de $" + precio);

            //Forma moderna (interpolacion con $)
            Console.WriteLine($"Producto: {producto}");
            Console.WriteLine($"Precio: ${precio}");
            Console.WriteLine($"Cantidad: {cantidad}");
            Console.WriteLine($"Total a pagar: ${total}");
            //Formato de moneda
            Console.WriteLine($"Total formateado: ${total:f2}");
        }
    }
}
