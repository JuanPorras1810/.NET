using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio04
{
    internal class Cuadrado:Area
    {
        //Atributo
        private double lado;

        //Constructor
        public Cuadrado(double lad)
        {
            lado = lad;
        }

        //Metodo abstracto 
        public override double CalcularArea()
        {
            double areaCuadrado = lado * lado;
            return areaCuadrado;
        }
    }
}
