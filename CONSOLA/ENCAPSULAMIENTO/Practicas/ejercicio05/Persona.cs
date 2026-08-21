using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio05
{
    internal class Persona
    {
        //Propiedad
        public string FechaNacimiento { get; init; }

        //Constructor
        public Persona(string fecha)
        {
            FechaNacimiento = fecha;
        }

        //Metodo que imprime algo
        public void Salida()
        {
            Console.WriteLine($"Fecha de nacimiento: {FechaNacimiento}");
        }


    }
}
