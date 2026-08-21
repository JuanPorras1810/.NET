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
            //Property calculada para Area: Cree una clase Rectangulo con property calculada para el área.

            Console.WriteLine("=== AREA RECTANGULO ===");

            //Crear objeto y enviar datos
            Rectangulo rect1 = new Rectangulo(5, 3);

            //Salida
            rect1.AreaRectangulo();
        }
    }
}
