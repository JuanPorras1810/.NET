using System.ComponentModel.DataAnnotations;

namespace BibliotecaApp.Models
{
    public class Libro
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "El título es obligatorio")]
        public string Titulo { get; set; } = string.Empty;


        [Required(ErrorMessage = "El ISBN es obligatorio")]
        public string ISBN { get; set; } = string.Empty;

        [Display(Name = "Año publicacion")]
        [Required(ErrorMessage = "El año de publicacion es obligatorio")]
        public int? AnioPublicacion { get; set; }

        // Clave Foranea
        [Display(Name = "Autor")]
        [Required(ErrorMessage = "El autor es obligatorio")]
        public int? AutorId { get; set; }


        // Propiedades de navegacion
        public virtual Autor? Autor { get; set; } // Un libro tiene UN autor

        public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>(); // Un libro tiene muchos prestamos

    }
}
