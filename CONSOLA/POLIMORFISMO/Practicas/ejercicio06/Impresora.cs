using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio06
{
    internal class Impresora
    {
        // Método que recibe una lista con elementos IImprimible y los imprime
        public void ImprimirTodo(List<IImprimible> items)
        {
            foreach (var item in items)
            {
                item.Imprimir();
            }
        }
    }
}
