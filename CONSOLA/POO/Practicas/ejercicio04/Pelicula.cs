using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio04
{
    internal class Pelicula
    {
        //Atributos
        public string titulo;
        public string duracion;
        public string genero;

        //Constructor vacio
        public Pelicula()
        {
            titulo = "";
            duracion = "";
            genero = ""; 

        }

        //Constructor con datos
        public Pelicula(string tit, string dura, string gen)
        {
            titulo = tit;
            duracion = dura;
            genero = gen;
        }

        //Metodo de salida
        public void Informacion()
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Duración: {duracion}");
            Console.WriteLine($"Género: {genero}");
        }
    }
}
