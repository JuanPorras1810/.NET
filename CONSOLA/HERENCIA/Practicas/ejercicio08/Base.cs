using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio08
{
    internal class Base
    {
        //Atributo
        protected string nombreCliente;
        protected double valorCompra;

        //Constructor
        public Base(string nom, double val)
        {
            nombreCliente = nom;
            valorCompra = val;
        }

        //Metodo de salida
        public virtual void factura() 
        {
            Console.WriteLine("Generando factura...");
            Console.WriteLine($"Nombre cliente: {nombreCliente}");
            Console.WriteLine($"Valor compra: {valorCompra}");
        }
    }
}
