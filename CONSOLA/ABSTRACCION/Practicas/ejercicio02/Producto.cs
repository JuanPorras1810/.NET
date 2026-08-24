using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio02
{
    internal class Producto:ICalculable
    {
        //Atributos
        private int cantidad;
        private double precio;

        //Propiedades
        public int Cantidad
        {
            get => cantidad;
            set
            {
                cantidad = value;
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
            return cantidad * precio;
        }

    }
}
