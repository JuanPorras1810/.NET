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
            //Clase Pelicula con multiples constructores: Un constructor vacío y otro con parámetros(título, duración, género).

            Console.WriteLine("=== PELICULA ===");

            Pelicula peli1 = new Pelicula("Rápido y Furioso: Reto Tokio", "1h 44m", "Acción / Carreras");
            peli1.Informacion();

        }
    }
}
