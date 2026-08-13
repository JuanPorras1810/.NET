using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero de la tabla de multiplicar: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{numero} * {i} = {numero * i}");
            }

        }
    }
}
