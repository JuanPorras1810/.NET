using System.ComponentModel.DataAnnotations;

namespace BibliotecaApp.ViewModels.PrestamoViewModels
{
    public class PrestamoIndexViewModel
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public int? LibroId { get; set; }
        public string NombreLibro { get; set; } = string.Empty;
    }
}
