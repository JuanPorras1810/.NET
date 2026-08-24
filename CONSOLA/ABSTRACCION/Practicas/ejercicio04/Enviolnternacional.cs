using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio04
{
    internal class Enviolnternacional:IEnvio
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
            double impuesto = 25000;
            return (peso * 8000) + impuesto;
        }
    }
}
