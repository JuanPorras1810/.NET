using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio05
{
    internal class Derivada:Base
    {
        //Atributo
        public string residencia;

        //Constructor
        public Derivada(string nom, int eda, string resi): base(nom, eda)
        {
            residencia = resi;
        }

        //Metodo de salida
        public override void saludar() 
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre}, tengo {Edad} años y vivo en {residencia}");
        }
    }
}
