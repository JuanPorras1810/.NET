using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ejercicio07
{
    internal class Cuadrado:Figura
    {
        //Atributo
        private double lado;

        //Constructor
        public Cuadrado(double lad)
        {
            lado = lad;
        }

        //Metodo de salida
        public override double area()
        {
            double resultado = lado * lado;
            Console.WriteLine($"El area del cuadrado de {lado} lado es de: {resultado:f3}");
            return resultado;
        }
    }
}
