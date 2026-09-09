using System.ComponentModel.DataAnnotations;

namespace BibliotecaApp.ViewModels
{
    public class CrearAutorViewModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres")]
        [Display(Name = "Nombre del Autor")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La nacionalidad es obligatoria")]
        [StringLength(50, ErrorMessage = "La nacionalidad no puede exceder 50 caracteres")]
        public string Nacionalidad { get; set; } = string.Empty;

        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime? FechaNacimiento { get; set; }
    }
}
