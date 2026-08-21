using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    internal class Estudiante
    {
        //Atributos
        public string nombre;
        public int codigo;
        public string programa;

        //Constructor
        public Estudiante(string nom, int cod, string pro)
        {
            nombre = nom;
            codigo = cod;
            programa = pro;
        }

        //Metodo de salida
        public void Datos() 
        {
            Console.WriteLine($"Bienvenido {nombre} al programa {programa} registrado con el codigo {codigo}");
        }
    }
}
