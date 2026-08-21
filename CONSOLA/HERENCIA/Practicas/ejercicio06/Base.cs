using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    internal class Base
    {
        //Atributo
        private string nombreMascota;

        //Constructor
        public Base(string nom)
        {
            nombreMascota = nom;
        }

        //Metodo de salida
        public void MostrarBase()
        {
            Console.WriteLine($"Nombre mascota: {nombreMascota}");
        }
    }
}
