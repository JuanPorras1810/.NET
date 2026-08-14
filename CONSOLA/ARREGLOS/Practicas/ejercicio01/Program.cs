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
            //Declarar y crear con tamaño
            int[] nota = new int[6];
            nota[0] = 0;
            nota[1] = 1;
            nota[2] = 2;
            nota[3] = 3;
            nota[4] = 4;
            nota[5] = 5;

            for (int i = 0; i < nota.Length-1; i++)
            {
                Console.WriteLine(nota[i]);
            }

            //Declara con valores iniciales
            int[] temperatura = { 32, 58, 42, 25, 10, -5, 0 };

            Console.WriteLine($"La temperatura es de °{temperatura[2]}");
        }
    }
}
