using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio01
{
    internal class Sobrecarga
    {
        //Metodo sin parametros
        public void Saludar() 
        {
            Console.WriteLine("Hola...");
        }

        //Metodo con nombre
        public void Saludar(string nombre) 
        {
            Console.WriteLine($"Hola {nombre}");
        }

        //Metodo con nombre y edad
        public void Saludar(string nombre, int edad) 
        { 
            Console.WriteLine($"Hola {nombre}, tienes {edad} años");
        }
    }
}