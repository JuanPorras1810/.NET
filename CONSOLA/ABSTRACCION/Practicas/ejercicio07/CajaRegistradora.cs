using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio07
{
    internal class CajaRegistradora
    {
        public void Cobrar(List<Producto> carrito) 
        {
            Console.WriteLine("=== TIKECT DE COMPRA ===");
            double total = 0;

            foreach (Producto prod in carrito)
            {
                prod.MostrarInfo();

                double precio = prod.CalcularPrecioFinal();

                Console.WriteLine($" Precio final: ${precio:F0}");
                total += precio;
                Console.WriteLine();
            }
            Console.WriteLine($"TOTAL A PAGAR: ${total:F0}");
        }
    }
}
