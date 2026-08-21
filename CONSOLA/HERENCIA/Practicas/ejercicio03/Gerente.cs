using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    internal class Gerente:Empleado
    {
        private int empleadosACargo;

        public Gerente(string nom, string id, double salario, int empleados):base(nom, id, salario)
        {
            empleadosACargo = empleados;
        }

        public override double CalcularSalario()
        {
            double bono = empleadosACargo * 50000;
            return salarioBase + bono;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Tipo: Gerente");
            Console.WriteLine($"Empleados a cargo: {empleadosACargo}");
        }
    }
}
