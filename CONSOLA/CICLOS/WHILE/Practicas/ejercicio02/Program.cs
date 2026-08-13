using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota = 0;
            Console.Write("Ingresa la nota del aprendiz: ");
            nota = int.Parse(Console.ReadLine());

            while (nota<0 || nota>100)
            {
                Console.WriteLine("Nota invalidad, intentelo de nuevo");
                Thread.Sleep(2000);
                Console.Clear();
                Console.Write("Ingresa la nota del aprendiz: ");
                nota = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nota valida papi...");
        }
    }
}
