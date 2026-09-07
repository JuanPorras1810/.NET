using System.ComponentModel.DataAnnotations;

namespace BibliotecaApp.Models
{
    public class Prestamo
    {
        public int Id { get; set; }

        [Display(Name = "Nombre Usuario")]
        [Required(ErrorMessage = "El nombre del usuario es obligatorio")]
        public string NombreUsuario { get; set; } = string.Empty;

        [Display(Name = "Fecha Prestamo")]
        public DateTime FechaPrestamo { get; set; }

        [Display(Name = "Fecha Devolucion")]
        public DateTime? FechaDevolucion { get; set; }

        // Clave Foranea
        [Display(Name = "Libro")]
        [Required(ErrorMessage = "El libro es obligatorio")]
        public int? LibroId { get; set; }

        // Propiedades de navegacion

        public virtual Libro? Libro { get; set; }
    }
}
