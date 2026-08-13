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
            int cuenta = 0;
            int idas = 3;
            for (int i = 0; i < idas; i++)
            {
                Console.Write($"Cuanto va a consignar {i+1} vez ?: $");
                int valor = int.Parse( Console.ReadLine() );
                cuenta += valor;
            }
            Console.WriteLine($"Tu cuenta actual tiene ${cuenta}");
        }
    }
}
