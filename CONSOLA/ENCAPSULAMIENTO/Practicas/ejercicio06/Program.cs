using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clase Producto con stock minimo: No permitir retirar stock si queda por debajo del minimo.

            Console.WriteLine("=== PRODUCTO ===");

            //Crear objeto para producto
            Producto prod1= new Producto("Mouse", 5, 10);
            Console.WriteLine($"Producto: {prod1.Nombre}");

            //Mostrar stock inicial
            Console.WriteLine($"Stock inicial: {prod1.Stock}");

            //Retirar 3 productos
            if (prod1.Retirar(3))
            {
                Console.WriteLine("Extrayendo 3 productos...");
            }
            else
            {
                Console.WriteLine("No se puede retirar");
            }

            //Mostrar stock final
            Console.WriteLine($"Stock final: {prod1.Stock}");

            //Intento de retirar mas del minimo
            Console.WriteLine("Extrayendo mas del minimo...");
            if (prod1.Retirar(5))
            {
                Console.WriteLine("Retiro realizado");
            }
            else
            {
                Console.WriteLine("No se puede retirar");
            }

            //Mostrar stock final
            Console.WriteLine($"Stock final: {prod1.Stock}");
        }
    }
}
