using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio02
{
    internal class Servicio:ICalculable
    {
        //Atributos
        private int hora;
        private double precio;

        //Propiedades
        public int Hora
        {
            get => hora;
            set
            {
                hora = value;
            }
        }

        public double Precio
        {
            get => precio;
            set
            {
                precio = value;
            }
        }

        //Metodo heredado de ICalculable
        public double CalcularTotal()
        {
            return hora * precio;
        }
    }
}
