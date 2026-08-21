using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio07
{
    internal class Triangulo:Figura
    {
        //Atributos
        private double base1;
        private double altura;

        //Constructor
        public Triangulo(double bas, double alt)
        {
            base1 = bas;
            altura = alt;
        }

        //Metodo de salida
        public override double area()
        {
            double resultado = (base1 * altura) / 2;
            Console.WriteLine($"El area del triangulo de {base1} base y de {altura} altura es de: {resultado:f3}");
            return resultado;
        }
    }
}
