using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    internal class AutoDeportivo: Auto
    {
        public int caballosFuerza;

        public void ActivarTurbo()
        {
            Console.WriteLine("¡Turbo activado!");
        }

        public void MostrarEspecificaciones()
        {
            Console.WriteLine($"{marca} {modelo} ({año})");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Puertas: {puertas}");
            Console.WriteLine($"Caballos de fuerza: {caballosFuerza}");
        }
    }
}
