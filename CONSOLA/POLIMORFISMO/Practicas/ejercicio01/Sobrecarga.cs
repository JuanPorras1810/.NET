using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio01
{
    internal class Sobrecarga
    {
        public void Saludar() 
        {
            Console.WriteLine("Hola...");
        }

        public void Saludar(string nombre) 
        {
            Console.WriteLine($"Hola {nombre}");
        }

        public void Saludar(string nombre, int edad) 
        { 
            Console.WriteLine($"Hola {nombre}, tienes {edad} años");
        }
    }
}