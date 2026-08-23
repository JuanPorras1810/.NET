using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio03
{
    internal class Gato:Animal
    {
        //Metodo sobrescrito para el sonido del gato
        public override void HacerSonido()
        {
            Console.WriteLine("El gato hace: Miau");
        }
    }
}
