using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio03
{
    internal class Perro:Animal
    {
        //Metodo sobrescrito para el sonido del perro
        public override void HacerSonido()
        {
            Console.WriteLine("El perro hace: Guau");
        }
    }
}
