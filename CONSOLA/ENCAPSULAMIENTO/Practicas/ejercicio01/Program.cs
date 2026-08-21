using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clase Libro con properties: Cree properties para título, autor y precio.Valide que precio sea positivo.

            Console.WriteLine("=== LIBRO ===");

            //Crear objeto y enviar datos
            Libro libro1 = new Libro();
            libro1.Titulo = "Cien años de soledad";
            libro1.Autor = "Gabriel García Márquez";
            libro1.Precio = 50000;

            //salida
            libro1.salida();

        }
    }
}
