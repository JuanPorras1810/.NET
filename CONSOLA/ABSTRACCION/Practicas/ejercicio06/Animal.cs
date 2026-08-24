using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio06
{
    internal class Animal : IAccion, IRaza
    {
        //Metodos heredados
        public void MostrarAccion()
        {
            Console.WriteLine("El perro corre");
        }

        public void MostrarRaza()
        {
            Console.WriteLine("Labrador");
        }
    }
}
