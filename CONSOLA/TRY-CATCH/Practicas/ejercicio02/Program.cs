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
            try
            {
                Console.Write("Ingrese el dividendo: ");
                int dividendo = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el divisor: ");
                int divisor = int.Parse(Console.ReadLine());

                int resultado = dividendo / divisor;

                Console.WriteLine($"Resultado: {dividendo} / {divisor} = {resultado}");

            }
            catch (FormatException)
            {
                Console.WriteLine("Debe ingresar un numero");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("No se´puede dividir entre 0");
            }
        }
    }
}
