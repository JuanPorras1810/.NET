using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio07
{
    internal class Circulo:Figura
    {
        //Atributo
        private double radio;

        //Constructor
        public Circulo(double rad)
        {
            radio = rad;
        }

        //Metodo de salida
        public override double area()
        {
            double resultado = Math.PI * (radio * radio);
            Console.WriteLine($"El area del circulo de {radio} radio es de: {resultado:f3}");
            return resultado;
        }
    }
}
