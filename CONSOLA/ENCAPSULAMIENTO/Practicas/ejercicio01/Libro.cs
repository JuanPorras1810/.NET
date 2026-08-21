using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    internal class Libro
    {
        //Propiedades
        public string Titulo { get; set; }
        public string Autor { get; set; }

        //Atributo
        private double precio;

        //Propiedad con validacion para el precio
        public double Precio 
        { 
            get { return precio; }
            set 
            {
                if (value >= 0)
                {
                    precio = value;
                }
            } 
        
        }

        //Metodo para mostrar la salida
        public void salida() 
        { 
            Console.WriteLine($"Libro: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Precio: {Precio}");

        }
    }
}
