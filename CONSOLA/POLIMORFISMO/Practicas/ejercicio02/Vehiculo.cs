using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio02
{
    internal class Vehiculo
    {
        //Atributos
        protected string placa;
        protected string marca;

        //Constructor
        protected Vehiculo(string pla,string mar)
        {
            placa = pla;
            marca = mar;
        }

        //Metodo base 
        public virtual void Describir() 
        {
            Console.WriteLine("Metodo base");
        }
    }
}
