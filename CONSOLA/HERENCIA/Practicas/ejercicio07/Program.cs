using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jerarquía de Figuras: Figura - Círculo, Cuadrado, Triángulo.Cada uno con su área.

            Console.WriteLine("=== AREA FIGURAS ===");

            //Area circulo
            Circulo fig1 = new Circulo(4);
            fig1.area();

            //Area cuadrado
            Cuadrado fig2 = new Cuadrado(8);
            fig2.area();

            //Area triangulo
            Triangulo fig3 = new Triangulo(16, 4);
            fig3.area();

        }
    }
}
