using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double SumaNotas = 0;
            int CantNotas = 0;
            while (true)
            {
                Console.Write("Ingresa una nota y 0 para salir");
                double nota = double.Parse(Console.ReadLine());
                if (nota == 0)
                {
                    break;
                }
                SumaNotas += nota;
                CantNotas++;
            }
            Console.WriteLine($"El promedio de notas es de {SumaNotas / CantNotas}");
 
        }
    }
}
