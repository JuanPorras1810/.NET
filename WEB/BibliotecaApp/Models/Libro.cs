namespace BibliotecaApp.Models
{
    public class Libro
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string ISBN { get; set; } = string.Empty;

        public int AnioPublicacion { get; set; }

        // Clave Foranea
        public int AutorId { get; set; }


        // Propiedades de navegacion
        public virtual Autor? Autor { get; set; } // Un libro tiene UN autor

        public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>(); // Un libro tiene muchos prestamos

    }
}
