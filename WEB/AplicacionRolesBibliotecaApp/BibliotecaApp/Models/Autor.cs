using System.ComponentModel.DataAnnotations;

namespace BibliotecaApp.Models
{
    public class Autor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La nacionalidad es obligatoria")]
        public string Nacionalidad { get; set; } = string.Empty;

        [Display(Name = "Fecha Nacimiento")]
        [Required(ErrorMessage = "La fecha de nacimiento es obligatorio")]
        public DateTime? FechaNacimiento { get; set; }

        // Propiedad de navegacion 
        public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
    }
}
