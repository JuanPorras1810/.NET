using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio05
{
    internal class Notas:IPromedio
    {
        //Atributos
        private double nota1;
        private double nota2;
        private double nota3;

        //Constructor
        public Notas(double not1, double not2, double not3)
        {
            nota1 = not1;
            nota2 = not2;
            nota3 = not3;
        }

        //Metodo heredado de interfaz IPromedio
        public double Promedio()
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
}
