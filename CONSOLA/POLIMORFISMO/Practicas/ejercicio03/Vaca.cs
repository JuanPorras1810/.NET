using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio03
{
    internal class Vaca:Animal
    {
        //Metodo sobrescrito para el sonido de la vaca
        public override void HacerSonido()
        {
            Console.WriteLine("La vaca hace: muuuu");
        }
    }
}
