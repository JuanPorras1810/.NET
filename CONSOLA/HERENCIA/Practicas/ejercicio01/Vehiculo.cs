using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    internal class Vehiculo
    {
        public string marca;
        public string modelo;
        public int año;

        public void Encender() 
        {
            Console.WriteLine("Vehiculo encendido");
        }

        public void Apagar()
        { 
            Console.WriteLine("Vehiculo apagadp");
        }
    }
}
