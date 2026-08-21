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
            //Clase Estudiante con constructor: Constructor que reciba nombre, código y programa.

            Console.WriteLine("=== BIENVENIDA A ESTUDIANTE ===");

            //Enviar datos a la clase
            Estudiante estu1 = new Estudiante("Juan Porras", 1234, "ADSO");
            estu1.Datos();
            
            

        }
    }
}
