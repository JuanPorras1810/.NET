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
            //Clase Vehiculo: Cree una clase Vehiculo con marca, modelo, ano. Metodo para mostrar datos.

            //Enviar datos a la clase
            Vehiculo carro1 = new Vehiculo();
            carro1.marca = "lamborghini";
            carro1.modelo = "Aventador SVJ";
            carro1.año = 2018;

            //Mostrar datos desde la clase
            carro1.Datos();

        }
    }
}
