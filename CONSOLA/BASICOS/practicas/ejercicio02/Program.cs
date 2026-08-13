using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            string nombre = "Juan Porras";
            int edad = 18;
            double estatura = 1.79;
            bool esEstudiante = true;
            char inicial = 'J';
            //Mostrar variables en pantalla
            Console.WriteLine("=== INFORMACION PERSONAL ==");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad + " años");
            Console.WriteLine("Estatura: " + estatura + " metros");
            Console.WriteLine("¿Es estudiante?: " + esEstudiante);
            Console.WriteLine("Inicial: " + inicial);
        }
    }
}
