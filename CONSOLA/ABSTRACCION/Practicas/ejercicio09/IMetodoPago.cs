using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio09
{
    internal interface IMetodoPago
    {
        bool ProcesarPago(double monto);
        void Reembolsar(double monto);
        string ObtenerComprobante();
    }
}
