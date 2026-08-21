using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nom, int edad)
        {
            Nombre = nom;
            Edad = edad;
            Console.WriteLine("Constructor Persona");

        }
    }
}
