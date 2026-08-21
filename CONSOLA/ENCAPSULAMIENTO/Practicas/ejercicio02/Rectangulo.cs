using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    internal class Rectangulo
    {
        //Propiedades
        public double Base { get; set; }
        public double Altura { get; set; }

        public double Area 
        {
            get => Base * Altura;
        }

        //Constructor
        public Rectangulo(double bas, double alt)
        {
            Base = bas;
            Altura = alt;
        }

        //Metodo para mostrar la salida
        public void AreaRectangulo() 
        {
            Console.WriteLine($"El area del rectangulo de base {Base} y {Altura} es de {Area}");
        }
        
    }
}
