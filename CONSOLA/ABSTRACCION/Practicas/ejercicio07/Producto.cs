using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio07
{
    abstract class Producto
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public abstract double CalcularPrecioFinal();

        public void MostrarInfo() 
        {
            Console.WriteLine($"{Codigo} - {Nombre}");            
        }

    }
}
