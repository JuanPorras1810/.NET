using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio09
{
    sealed class Sealed
    {
        public int Numero { get; set; }

        public void salida() 
        {
            Console.WriteLine($"Numero: {Numero}");
        }
    }
}
