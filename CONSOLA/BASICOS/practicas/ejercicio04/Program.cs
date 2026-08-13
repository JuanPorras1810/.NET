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
            //Capturar nombre
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            //Capturar Edad
            Console.Write("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"La identidad secreta de batman es: {nombre} y su edad es de {edad} años");
        }
    }
}
