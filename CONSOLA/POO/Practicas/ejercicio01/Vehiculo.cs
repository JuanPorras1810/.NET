using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    internal class Vehiculo
    {
        //Atributos
        public string marca;
        public string modelo;
        public int año;

        //Metodo de salida
        public void Datos() 
        {
            Console.WriteLine("=== VEHICULO ===");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Año: {año}");
        }
    }
}
