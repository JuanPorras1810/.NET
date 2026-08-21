using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    internal class Padre
    {
        //Atributos
        protected string nombre;
        protected int edad;

        //Constructor
        public Padre(string nom, int eda)
        {
            Console.WriteLine("Ejecutando constructor padre...");
            nombre = nom;
            edad = eda;
        }

        //Metodo de salida
        public virtual void salida() 
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad}");

        }
    }
}
