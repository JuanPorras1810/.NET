using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio08
{
    abstract class Cliente
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public abstract double CalcularDescuento(double totalCompra);
        public abstract void RecibirCompra(string detalle);

        public void MostrarDatos() 
        {
            Console.WriteLine($"Cliente: {Nombre}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Telefono: {Telefono}");
        }
    }
}
