namespace BibliotecaApp.ViewModels.LibroViewModels
{
    public class LibroDetalleViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public int? AnioPublicacion { get; set; }
        public string NombreAutor { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        //public string Prestamo { get; set; } = string.Empty;
    }
}
