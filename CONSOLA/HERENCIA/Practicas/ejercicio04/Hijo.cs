using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    internal class Hijo:Padre
    {
        //Atributo
        private string escuela;

        //Constructor
        public Hijo(string nom, int eda, string scu) : base(nom, eda)
        {
            escuela = scu;
        }

        //Metodo de salida
        public override void salida()
        {
            base.salida();
            Console.WriteLine("Ejecutando constructor hijo...");
            Console.WriteLine($"Escuela: {escuela}");


        }
    }
}
