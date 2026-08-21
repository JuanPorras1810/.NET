using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    internal class Validacion
    {
        //Atributo
        private int edad;

        //Propiedad
        public int Edad
        {
            //obtiene la edad
            get => edad;
            set //Valida la edad si es valida o no
            {
                if (value >= 0 && value <= 120)
                {
                    edad = value;
                    Console.WriteLine("Edad valida");
                }
                else
                {
                    Console.WriteLine("Error, edad no valida");
                }
            }
        
        }

    }
}
