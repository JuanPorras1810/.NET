using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaApp.ViewModels.LibroViewModels
{
    public class CrearEditarLibroViewModel
    {
        [Required(ErrorMessage = "El titulo es obligatorio")]
        [StringLength(100, ErrorMessage = "El titulo no puede exceder 100 caracteres")]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El titulo es obligatorio")]
        [StringLength(15, ErrorMessage = "El titulo no puede exceder los 15 caracteres")]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; } = string.Empty;

        [Required(ErrorMessage = "El año de publicacion es obligatorio")]
        [Range(1000, 9999, ErrorMessage = "El año debe tener 4 dígitos")]
        [Display(Name = "Año de publicacion")]
        public int? AnioPublicacion { get; set; }

        [Required(ErrorMessage = "El autor es obligatorio")]
        [Display(Name = "Autor")]
        public int? AutorId { get; set; }


        public IEnumerable<SelectListItem>? Autores { get; set; }
    }
}
