using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio07
{
    internal class ProductoDigital : Producto
    {
        public double PrecioBase { get; set; }
        public int DiasLicencia { get; set; }

        public override double CalcularPrecioFinal()
        {
            double descuento = DiasLicencia >= 365 ? 0.20 : 0;
            double iva = PrecioBase * 0.19;
            return (PrecioBase + iva) * (1 - descuento);
        }
    }
}
