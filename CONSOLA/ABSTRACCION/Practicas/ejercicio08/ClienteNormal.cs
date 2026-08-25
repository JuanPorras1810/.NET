using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio08
{
    internal class ClienteNormal : Cliente
    {

        public override double CalcularDescuento(double totalCompra)
        {
            return 0;
        }

        public override void RecibirCompra(string detalle)
        {
            Console.WriteLine($"{Nombre} recibira su compra en tienda");
        }
    }
}
