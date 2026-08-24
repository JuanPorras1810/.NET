using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio04
{
    internal class EnvioNacional:IEnvio
    {
        //Atributo
        private double peso;

        //Propiedad
        public double Peso
        {
            get => peso;
            set
            {
                peso = value;
            }
        }

        //Metodo heredado de la interfaz IEnvio
        public double CalcularCosto()
        {
            return peso * 8000;
        }
    }
}
