using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clase Padre Hijo: Cree clase Padre con nombre y edad. Clase Hijo que herede y agregue escuela.
            
            //Clase padre
            Console.WriteLine("=== USANDO CLASE PADRE ===");
            Padre per1 = new Padre("Juan",18);
            per1.salida();

            //Clase hijo
            Console.WriteLine("=== USANDO CLASE HIJO ===");
            Hijo per2 = new Hijo("Carlos", 19, "SENA");
            per2.salida();

        }
    }
}
