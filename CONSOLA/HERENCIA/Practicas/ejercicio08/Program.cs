using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Protected en accion: Clase base con atributo protected. Clase derivada que lo use.

            Console.WriteLine("=== USO DE ATRIBUTO PROTECTED ===");

            //Crear objeto y enviar datos
            Derivada compra1 = new Derivada("Juan Porras", 20000, 0.1);

            //Salida
            compra1.factura();
        }
    }
}
