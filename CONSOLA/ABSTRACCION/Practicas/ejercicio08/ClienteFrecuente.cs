using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio08
{
    internal class ClienteFrecuente : Cliente
    {
        public int PuntosAcumulados { get; set; }

        public override double CalcularDescuento(double totalCompra)
        {
            return totalCompra * 0.10;
        }

        public override void RecibirCompra(string detalle)
        {
            Console.WriteLine($"{Nombre} recibira su compra en domicilio (gratis)");
            PuntosAcumulados += 100;
            Console.WriteLine($" Puntos acumulados: {PuntosAcumulados}");
        }
    }
}
