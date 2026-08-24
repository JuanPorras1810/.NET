using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio03
{
    internal class Efectivo : Pago
    {
        public override void GenerarPago()
        {
            //Metodo traido de la clase padre abstracta
            Console.WriteLine("Generando pago con efectivo...");
        }
    }
}
