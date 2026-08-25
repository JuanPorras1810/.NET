using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio09
{
    internal class TarjetaCredito : IMetodoPago, IValidable
    {
        private string numeroTarjeta;
        private string cvv;

        public TarjetaCredito(string num, string codigo)
        {
            numeroTarjeta = num;
            cvv = codigo;
        }

        public string ObtenerComprobante()
        {
            return $"TC-{DateTime.Now:yyyyMMddHHmmss}";
        }

        public bool ProcesarPago(double monto)
        {
            if(!Validar())
                return false;

            Console.WriteLine($"Procesando ${monto:F0} con tarjeta ****{numeroTarjeta.Substring(12)}");
            return true;
        }

        public void Reembolsar(double monto)
        {
            Console.WriteLine($"Reembolsando ${monto:F0} a tarjeta");
        }

        public bool Validar()
        {
            return numeroTarjeta.Length == 16 && cvv.Length == 3;
        }
    }
}
