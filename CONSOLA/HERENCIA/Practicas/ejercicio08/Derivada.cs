using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio08
{
    internal class Derivada:Base
    {
        //Atributo
        protected double descuento;

        //Constructor
        public Derivada(string nom, double val, double desc) : base(nom, val)
        {
            descuento = desc;
        }

        //Metodo de salida
        public override void factura() 
        {
            base.factura();
            double valorDescuento = valorCompra * descuento; 
            double total = valorCompra - valorDescuento;
            Console.WriteLine($"Descuento: {valorDescuento}");
            Console.WriteLine($"Total a pagar: {total}");
        }
    }
}
