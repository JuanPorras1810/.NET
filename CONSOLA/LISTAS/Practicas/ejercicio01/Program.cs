using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aprendiz> aprendices = new List<Aprendiz>();
            aprendices.Add(new Aprendiz { Id = 1, Nombre = "Juan Porras", Direccion = "Tv 18 #43-35", Telefono = "323344232", Estado = true });
            aprendices.Add(new Aprendiz { Id = 2, Nombre = "María López", Direccion = "Cl 52 #20-18", Telefono = "310456789", Estado = true });
            aprendices.Add(new Aprendiz { Id = 3, Nombre = "Carlos Gómez", Direccion = "Cra 25 #15-42", Telefono = "315678234", Estado = true });

            foreach (var item in aprendices)
            {
                Console.WriteLine($"Nombre: {item.Nombre}");
            }
        }
    }
}
