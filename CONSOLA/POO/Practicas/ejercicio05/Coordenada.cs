using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio05
{
    internal class Coordenada
    {
        public int y;
        public int x;
    
        //Constructor
        public Coordenada(int x, int y )
        {
            this.y = y;
            this.x = x;
        }

        //Metodo para calcular distacia de la posicion 
        public void Distancia()
        {
            int posicionX = x * 5; 
            int posicionY = y * 10;
            Console.WriteLine($"X esta en: {posicionX}");
            Console.WriteLine($"Y esta en: {posicionY}");
        }
    }
}
