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
            //Override de metodo Saludar: Clase base con método Saludar virtual. Clase derivada que lo sobrescriba.

            Console.WriteLine("=== CLASE BASE ===");

            //Objetos y salida
            Base per1 = new Base("Juan Porras", 18);
            per1.saludar();

            Console.WriteLine("=== CLASE DERIVADA ===");
            Derivada per2 = new Derivada("Juan Porras", 18, "Floridablanca");
            per2.saludar();
        }
    }
}
