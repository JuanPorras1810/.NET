using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio05
{
    internal class Base
    {
        //Atributos
        private string nombre;
        private int edad;

        //Propiedades
        public string Nombre
        {
            get { return nombre; }
        }

        public int Edad
        {
            get { return edad; }
        }

        //Constructor
        public Base(string nom, int eda)
        {
            nombre = nom;
            edad = eda;
        }

        //Metodo de salida
        public virtual void saludar() 
        {
            Console.WriteLine($"Hola, mi nombre es {nombre} y tengo {edad}");
        } 
    }
}
