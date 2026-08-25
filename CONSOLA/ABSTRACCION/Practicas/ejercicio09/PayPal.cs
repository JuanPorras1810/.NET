using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio09
{
    internal class PayPal : IMetodoPago, IValidable
    {
        private string email;

        public PayPal(string mail)
        {
            email = mail;
        }

        public string ObtenerComprobante()
        {
            return $"PP-{DateTime.Now:yyyyMMddHHmmss}";
        }

        public bool ProcesarPago(double monto)
        {
            if (!Validar())
                return false;

            Console.WriteLine($"Procesando ${monto:F0} con PayPal ({email})");
            return true;
        }

        public void Reembolsar(double monto)
        {
            Console.WriteLine($"Reembolsando ${monto:F0} a PayPal");
        }

        public bool Validar()
        {
            return email.Contains("@") && email.Contains(".");
        }
    }
}
