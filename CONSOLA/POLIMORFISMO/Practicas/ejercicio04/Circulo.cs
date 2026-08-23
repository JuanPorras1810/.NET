using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio04
{
    internal class Circulo:Area
    {
        //Atributo
        public double radio;

        //Constructor
        public Circulo(double rad)
        {
            radio = rad;
        }

        //Metodo abstracto
        public override double CalcularArea()
        {
            double areaCirculo = Math.PI * (radio * radio);
            return areaCirculo;
        }
    }
}
