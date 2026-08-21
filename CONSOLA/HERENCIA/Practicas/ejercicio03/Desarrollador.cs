using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    internal class Desarrollador:Empleado
    {
        //Atributos
        private string lenguajePrincipal;
        private int proyectosCompletados;

        //Constructor
        public Desarrollador(string nom, string id, double salario, string lenguaje, int proyectos):base(nom, id, salario)
        {
            lenguajePrincipal = lenguaje;
            proyectosCompletados = proyectos;
        }

        //Metodo para calcular salario
        public override double CalcularSalario()
        {
            double bono = proyectosCompletados * 100000;
            return salarioBase + bono;
        }

        //Metodo que arroja la info
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Tipo: Desarrollador");
            Console.WriteLine($"Lenguaje: {lenguajePrincipal}");
            Console.WriteLine($"Proyectos: {proyectosCompletados}");

        }
    }
}
