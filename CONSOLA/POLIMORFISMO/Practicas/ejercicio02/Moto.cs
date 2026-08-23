using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio02
{
    internal class Moto:Vehiculo
    {
        //Atributos
        private int cilindraje;

        //Constructor
        public Moto(string pla, string mar, int cil) : base(pla, mar)
        {
            cilindraje = cil;
        }

        //Metodo
        public override void Describir()
        {
            Console.WriteLine($"\n--- DATOS CARRO ---");
            Console.WriteLine($"Placa: {placa}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Cilindraje: {cilindraje}");
        }
    }
}
