using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaApp.ViewModels.PrestamoViewModels
{
    public class CrearEditarPrestamoViewModel
    {
        [Required(ErrorMessage = "El nombre del usuario es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        [Display(Name = "Nombre Usuario")]
        public string NombreUsuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha del prestamo es obligatoria")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha Prestamo")]
        public DateTime FechaPrestamo { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha Devolucion")]
        public DateTime? FechaDevolucion { get; set; }

        // Clave Foranea
        [Display(Name = "Libro")]
        [Required(ErrorMessage = "El libro es obligatorio")]
        public int? LibroId { get; set; }

        public IEnumerable<SelectListItem>? Libros { get; set; }
    }
}
