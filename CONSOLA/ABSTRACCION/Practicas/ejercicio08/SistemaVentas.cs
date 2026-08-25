using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio08
{
    internal class SistemaVentas
    {
        public void ProcesarVenta(Cliente cliente, double totalCompra, string productos)
        {
            Console.WriteLine("\n=== PROCESANDO VENTA ===");

            cliente.MostrarDatos();

            double descuento = cliente.CalcularDescuento(totalCompra);
            double totalPagar = totalCompra - descuento;

            Console.WriteLine($"Subtotal: ${totalCompra:F0}");
            Console.WriteLine($"Descuento: ${descuento:F0}");
            Console.WriteLine($"Total a pagar: ${totalPagar:F0}");

            cliente.RecibirCompra(productos);
        }
    }
}
