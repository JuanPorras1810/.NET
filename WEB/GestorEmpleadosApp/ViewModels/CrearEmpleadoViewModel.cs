using System.ComponentModel.DataAnnotations;

namespace GestorEmpleadosApp.ViewModels
{
    public class CrearEmpleadoViewModel
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; } = string.Empty;

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Teléfono inválido")]
        [Display(Name = "Teléfono")]
        public string? Telefono { get; set; }

        [Display(Name = "Fecha de Contratación")]
        [DataType(DataType.Date)]
        public DateTime? FechaContratacion { get; set; }

        [Range(0, 1000000, ErrorMessage = "El salario debe estar entre 0 y 1,000,000")]
        [Display(Name = "Salario")]
        public decimal Salario { get; set; }
    }
}
