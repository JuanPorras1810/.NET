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
            //Property solo lectura para Contador: Cree un contador que solo pueda incrementarse, no establecerse directamente.

            Console.WriteLine("=== CONTADOR ===");
            Console.WriteLine("Presiona ENTER para incrementar el contador.");
            Console.WriteLine("Presiona ESC para salir.");

            //Crear objeto y enviar datos
            Contador con = new Contador();
            while (true)
            {
                ConsoleKeyInfo tecla = Console.ReadKey();

                if (tecla.Key == ConsoleKey.Enter)
                {
                    con.Incrementar();
                    Console.WriteLine($"Contador: {con.Valor}");
                }
                if (tecla.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }

        }
    }
}
