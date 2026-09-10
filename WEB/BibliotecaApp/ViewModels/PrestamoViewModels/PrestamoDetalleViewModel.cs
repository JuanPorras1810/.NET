namespace BibliotecaApp.ViewModels.PrestamoViewModels
{
    public class PrestamoDetalleViewModel
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string NombreLibro { get; set; } = string.Empty;
    }
}
