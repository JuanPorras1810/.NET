using System;
using System.Collections.Generic;
using System.Text;

namespace NaturVida.App.Models
{
    internal class Categoria
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public bool Activo { get; set; } = true;
    }
}
