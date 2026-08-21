using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clase Coordenada con this: Use 'this' para diferenciar atributos de parametros en el constructor.
            Console.WriteLine("=== COORDENADA ===");

            //Crear objeto y enviar datos al constructor
            Coordenada cor1 = new Coordenada(5,12);

            //Salida
            cor1.Distancia();
        }
    }
}
