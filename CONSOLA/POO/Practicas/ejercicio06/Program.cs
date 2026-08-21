using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sistema de Inventario simple: Clase Producto con metodos para agregar y quitar stock.Retornar bool si es exitoso.

            Console.WriteLine("=== INVENTARIO ===");

            //Crear objeto y enviar datos al constructor
            Producto pro1 = new Producto("Pc gamer", 10);
            Console.WriteLine("Ingresando producto demo...");
            Console.WriteLine($"Producto: {pro1.producto}");
            Console.WriteLine($"Stock: {pro1.stock}");

            //Agregar stock
            bool agregar = pro1.Agregar(5);
            Console.WriteLine("Agregando stock...");
            Console.WriteLine($"¿Se agrego al stock?: {agregar}");
            Console.WriteLine($"Stock actual: {pro1.stock}");

            //Quitar stock
            bool quitar = pro1.Quitar(3);
            Console.WriteLine("Quitando stock...");
            Console.WriteLine($"¿Se quito al stock?: {quitar}");
            Console.WriteLine($"Stock actual: {pro1.stock}");
        }
    }
}
