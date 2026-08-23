using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio02
{
    internal class Auto:Vehiculo
    {
        //Atributos
        private int puertas;

        //Constructor
        public Auto(string pla, string mar, int pue): base(pla, mar)
        {
            puertas = pue;
        }

        //Metodo
        public override void Describir()
        {
            Console.WriteLine($"\n--- DATOS MOTO ---");
            Console.WriteLine($"Placa: {placa}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Puertas: {puertas}");
        }
    }
}
