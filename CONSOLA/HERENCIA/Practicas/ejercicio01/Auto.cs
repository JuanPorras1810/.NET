using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    internal class Auto:Vehiculo
    {
        public int puertas;
        public string color;
        public void AbrirMaletero()
        {
            Console.WriteLine("Maletero abierto");
        }
    }
}
