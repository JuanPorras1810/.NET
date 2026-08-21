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

            //Crea el objeto y envia los datos al constructor
            Pelicula peli1 = new Pelicula("Rápido y Furioso: Reto Tokio", "1h 44m", "Acción / Carreras");

            //Salida
            peli1.Informacion();

        }
    }
}
