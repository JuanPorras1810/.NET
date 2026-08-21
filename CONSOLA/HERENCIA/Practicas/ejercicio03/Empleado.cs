using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03
{
    internal class Empleado
    {
        protected string nombre;
        protected string identificacion;
        protected double salarioBase;

        public Empleado(string nom, string id, double salario)
        {
            nombre = nom;
            identificacion = id;
            salarioBase = salario;
        }

        //Metodo
        public virtual double CalcularSalario() 
        {
            return salarioBase;        
        }

        //Metodo arroja info
        public virtual void MostrarInfo() 
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Id: {identificacion}");
            Console.WriteLine($"Salario: {CalcularSalario():F0}");
        
        }
    }
}
