using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio02
{
    internal class Vehiculo
    {
        protected string placa;
        protected string marca;

        protected Vehiculo(string pla,string mar)
        {
            placa = pla;
            marca = mar;
        }

        public virtual void Describir() 
        {
            Console.WriteLine("Metodo base");
        }
    }
}
