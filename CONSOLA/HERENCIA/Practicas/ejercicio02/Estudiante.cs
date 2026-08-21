using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio02
{
    internal class Estudiante:Persona
    {
        public string Codigo { get; set; }
        public string Programa { get; set; }

        public Estudiante(string nombre,int edad, string codigo, string programa):base(nombre, edad)
        {
            Codigo = codigo;
            Programa = programa;
            Console.WriteLine("Constructor Estudiante");
        }
    }
}
