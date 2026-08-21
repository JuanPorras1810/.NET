using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    internal class Pelicula
    {
        public string titulo;
        public string duracion;
        public string genero;

        public Pelicula()
        {
            titulo = "";
            duracion = "";
            genero = ""; 

        }

        public Pelicula(string tit, string dura, string gen)
        {
            titulo = tit;
            duracion = dura;
            genero = gen;
        }

        public void Informacion()
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Duración: {duracion}");
            Console.WriteLine($"Género: {genero}");
        }
    }
}
