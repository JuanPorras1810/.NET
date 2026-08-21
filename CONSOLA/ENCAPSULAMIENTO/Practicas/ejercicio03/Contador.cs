using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    internal class Contador
    {
        //Atributo
        private int valor = 0;

        //Propiedad
        public int Valor
        {
            get => valor;
        }

        //Incrementa el valor 
        public void Incrementar()
        {
            valor++;
        }
    }
}
