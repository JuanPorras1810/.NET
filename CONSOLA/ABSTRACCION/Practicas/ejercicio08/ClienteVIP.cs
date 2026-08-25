using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio08
{
    internal class ClienteVIP : Cliente
    {
        public string AsesorPersonal { get; set; }

        public override double CalcularDescuento(double totalCompra)
        {
            return totalCompra * 0.20;
        }

        public override void RecibirCompra(string detalle)
        {
            Console.WriteLine($"{Nombre} recibirá su compra con entrega prioritaria");
            Console.WriteLine($"   Asesor: {AsesorPersonal}");
            Console.WriteLine($"   Detalle: {detalle}");
        }
    }
}
