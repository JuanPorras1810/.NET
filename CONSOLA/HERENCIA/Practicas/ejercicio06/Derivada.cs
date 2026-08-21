using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    internal class Derivada:Base
    {
        //Atributo
        private string raza;

        //Constructor
        public Derivada(string nom, string raz):base(nom)
        {
            raza = raz;
        }

        //Metodo de salida
        public void MostrarDerivada()
        {
            Console.WriteLine("----- Llamado constructo base -----");
            base.MostrarBase();
            Console.WriteLine("----- Informacion constructor -----");
            Console.WriteLine($"Raza: {raza}");
        }
    }
}
