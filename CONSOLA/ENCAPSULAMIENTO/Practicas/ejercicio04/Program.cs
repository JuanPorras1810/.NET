using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Validacion de edad con property: Valide que la edad esté entre 0 y 120 en el setter.

            Console.WriteLine("=== VALIDADOR DE EDAD ===");

            //Crear objeto
            Validacion edad = new Validacion();

            //Envia datos a la clase y hace la validacion
            while (true)
            {
                Console.Write("Ingrese su edad: ");
                int edadUsu = int.Parse(Console.ReadLine());

                edad.Edad = edadUsu;

            }
        }
    }
}
