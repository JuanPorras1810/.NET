using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoDeportivo deportivo = new AutoDeportivo();
            // Atributos de Vehículo(nivel 1)
            deportivo.marca = "Ferrari";
            deportivo.modelo = "488 GTB";
            deportivo.año = 2023;

            // Atributos de Auto (nivel 2)
            deportivo.puertas = 2;
            deportivo.color = "Rojo";

            // Atributos de AutoDeportivo (nivel 3)
            deportivo.caballosFuerza = 670;

            // Métodos heredados de los 3 niveles
            deportivo.Encender();
            deportivo.AbrirMaletero();
            deportivo.ActivarTurbo();

            Console.WriteLine();
            deportivo.MostrarEspecificaciones();

            deportivo.Apagar();
        }
    }
}
