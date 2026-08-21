using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constructor con base: Clase derivada que llame al constructor de la base con base().

            Console.WriteLine("=== GENERANDO CONTRUCTOR CON BASE ===");

            //Crear objeto y enviar datos 
            Derivada perro1 = new Derivada("Firulais", "Criollo");

            //Salida
            perro1.MostrarDerivada();

            
        }
    }
}
