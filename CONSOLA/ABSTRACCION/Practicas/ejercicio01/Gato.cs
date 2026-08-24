using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio01
{
    internal class Gato : Animal
    {
        //Metodo heredado
        public override void HacerSonido()
        {
            Console.WriteLine("El gato hace: Miau");
        }
    }
}
