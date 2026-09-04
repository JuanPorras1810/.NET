namespace BibliotecaApp.Models
{
    public class Autor
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Nacionalidad { get; set; } = string.Empty;

        public DateTime FechaNacimiento { get; set; }

        // Propiedad de navegacion 
        public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
    }
}
