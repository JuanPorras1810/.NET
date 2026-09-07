using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestorEmpleadosApp.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [StringLength(100)]
        public string Apellido { get; set; } = string.Empty;

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Teléfono inválido")]
        public string? Telefono { get; set; }

        [Display(Name = "Fecha de Contratación")]
        [DataType(DataType.Date)]
        public DateTime? FechaContratacion { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, 1000000, ErrorMessage = "El salario debe estar entre 0 y 1,000,000")]
        public decimal Salario { get; set; }
    }
}
