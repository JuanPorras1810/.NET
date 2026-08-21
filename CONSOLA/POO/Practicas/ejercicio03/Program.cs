using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metodo que retorna el doble: Cree un metodo que reciba un numero y retorne el doble.

            Console.WriteLine("=== DOBLE DE UN NUMERO ===");
            
            //Declara y enviar datos al metodo
            NumeroDoble num1 = new NumeroDoble();
            int numero = 4;
            int operacion = num1.Operacion(numero);

            //Salida
            Console.WriteLine($"El doble de {numero } es {operacion}");

        }
    }
}
