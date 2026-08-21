using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    internal class Estudiante
    {
        public string nombre;
        public int codigo;
        public string programa;

        public Estudiante(string nom, int cod, string pro)
        {
            nombre = nom;
            codigo = cod;
            programa = pro;
        }

        public void Datos() 
        {
            Console.WriteLine($"Bienvenido {nombre} al programa {programa} registrado con el codigo {codigo}");
        }
    }
}
