using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            while (edad>=18)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Beep(1000, 500);
                Console.WriteLine("Ya soy mayorcito mama");
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
            }
        }
    }
}
