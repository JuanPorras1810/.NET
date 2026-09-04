using BibliotecaApp.Models;

namespace BibliotecaApp.Data
{
    public  class DbSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext context) 
        {
            if (context.Autores.Any())
            {
                return;  
            }

            var autores = new List<Autor>
            {
                new Autor { Nombre = "Gabriel García Márquez", Nacionalidad = "Colombiano", FechaNacimiento = new DateTime(1927, 3, 6) },
                new Autor { Nombre = "Mario Vargas Llosa", Nacionalidad = "Peruano", FechaNacimiento = new DateTime(1936, 3, 28) },
                new Autor { Nombre = "Jorge Luis Borges", Nacionalidad = "Argentino", FechaNacimiento = new DateTime(1899, 8, 24) }
            };

            await context.Autores.AddRangeAsync(autores);
            await context.SaveChangesAsync();

            var libros = new List<Libro>
            {
                new Libro { Titulo = "Cien Años de Soledad", ISBN = "978-0307474728", AnioPublicacion = 1967, AutorId = 1 },
                new Libro { Titulo = "El Amor en los Tiempos del Cólera", ISBN = "978-0307389732", AnioPublicacion = 1985, AutorId = 1 },
                new Libro { Titulo = "La Ciudad y los Perros", ISBN = "978-0307475671", AnioPublicacion = 1963, AutorId = 2 },
                new Libro { Titulo = "Ficciones", ISBN = "978-0394177601", AnioPublicacion = 1944, AutorId = 3 }
            };

            await context.Libros.AddRangeAsync(libros);
            await context.SaveChangesAsync();

            var prestamos = new List<Prestamo>
            {
                new Prestamo { NombreUsuario = "Juan Pérez", FechaPrestamo = DateTime.Now.AddDays(-10), LibroId = 1 },
                new Prestamo { NombreUsuario = "María García", FechaPrestamo = DateTime.Now.AddDays(-5), FechaDevolucion = DateTime.Now, LibroId = 2 },
                new Prestamo { NombreUsuario = "Carlos López", FechaPrestamo = DateTime.Now.AddDays(-2), LibroId = 3 }
            };

            await context.Prestamos.AddRangeAsync(prestamos);
            await context.SaveChangesAsync();
        }
    }
}
