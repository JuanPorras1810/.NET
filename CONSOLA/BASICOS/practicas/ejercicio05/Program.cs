using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculadora 

            //Captura
            Console.Write("Ingrese el valor 1: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor 2: ");
            int valor2 = int.Parse(Console.ReadLine());

            //Operacion
            int suma = valor1 + valor2;
            int resta = valor1 - valor2;
            int multiplicacion = valor1 * valor2;
            double division = Convert.ToDouble(valor1) / Convert.ToDouble(valor2);

            //Resultado 
            Console.Write($"Suma: {suma}\nResta: {resta}\nMultiplicacion: {multiplicacion}\nDivision: {division}");
        }
    }
}
