using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio06
{
    internal class Foto:IImprimible
    {
        //Metodo traido de la interfaz IImprimible
        public void Imprimir()
        {
            Console.WriteLine("Imprimiendo foto...");
        }
    }
}
