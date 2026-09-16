using BibliotecaApp.Data;
using BibliotecaApp.Models;
using BibliotecaApp.ViewModels.LibroViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApp.Services.LibroServices
{
    public class LibroService: ILibroService
    {
        private readonly ApplicationDbContext _context;

        public LibroService(ApplicationDbContext context)
        {
                _context = context;
        }

        public async Task<IEnumerable<LIbroIndexViewModel>> ObtenerTodosAsync(string? buscarEstado)
        {
            var libros = _context.Libros
                .AsQueryable();

            if (buscarEstado == "Disponible")
            {
                libros = libros.Where(l => !l.Prestamos.Any(p => p.FechaDevolucion == null));
            }
            else if (buscarEstado == "No Disponible")
            {
                libros = libros.Where(l => l.Prestamos.Any(p => p.FechaDevolucion == null));
            }

            return await libros.Select(a => new LIbroIndexViewModel
                { 
                Id = a.Id,
                Titulo = a.Titulo,
                ISBN = a.ISBN,
                AnioPublicacion = a.AnioPublicacion,
                NombreAutor = a.Autor != null ? a.Autor.Nombre : "Sin Autor",
                Estado = a.Prestamos.Any(p => p.FechaDevolucion == null) ? "No Disponible" : "Disponible"
            }).ToListAsync();
        }


        public async Task<LibroDetalleViewModel?> ObtenerDetalleAsync(int id)
        {
            var libro = await _context.Libros
                .Include(a => a.Autor)
                .Include(a => a.Prestamos)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (libro == null)
            {
                return null;
            }

            return new LibroDetalleViewModel 
            {
                Id =libro.Id,
                Titulo = libro.Titulo, 
                ISBN = libro.ISBN,
                AnioPublicacion = libro.AnioPublicacion,
                NombreAutor = libro.Autor != null ? libro.Autor.Nombre : "Sin Autor",
                Estado = libro.Prestamos.Any(p => p.FechaDevolucion == null) ? "No disponible" : "Disponible"
            };
        }

        public async Task<CrearEditarLibroViewModel?> ObtenerViewModelParaCrearAsync()
        {

            return new CrearEditarLibroViewModel
            {
                Autores = await _context.Autores.Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Nombre
                 }).ToListAsync()
            };

        }

        public async Task<bool> CrearLibroAsync(CrearEditarLibroViewModel viewModel)
        {
            var libro = new Libro
            {
                Titulo = viewModel.Titulo,
                ISBN = viewModel.ISBN,
                AnioPublicacion = viewModel.AnioPublicacion,
                AutorId = viewModel.AutorId
            };

            _context.Libros.Add(libro);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<CrearEditarLibroViewModel?> ObtenerViewModelParaEditarAsync(int id)
        {
           
            var libro = await _context.Libros.FindAsync(id);
           
            if (libro == null)
            {
                return null;
            }

            return new CrearEditarLibroViewModel
            {
                Titulo = libro.Titulo,
                ISBN = libro.ISBN,
                AnioPublicacion = libro.AnioPublicacion,
                AutorId = libro.AutorId,

                Autores = await _context.Autores.Select(a => new SelectListItem
                {
                    Value = a.Id.ToString(),
                    Text = a.Nombre
                }).ToListAsync()
            };


        }

        public async Task<bool> ActualizarLibroAsync(int id, CrearEditarLibroViewModel viewModel)
        {
            var libro = await _context.Libros.FindAsync(id);

            if (libro == null)
            {
                return false;
            }

            libro.Titulo = viewModel.Titulo;
            libro.ISBN = viewModel.ISBN;
            libro.AnioPublicacion = viewModel.AnioPublicacion;
            libro.AutorId = viewModel.AutorId;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<LIbroIndexViewModel?> ObtenerParaEliminarAsync(int id)
        {
            var libro = await _context.Libros
                .Include(l => l.Autor)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (libro == null)
            {
                return null;
            }

            return new LIbroIndexViewModel
            {
                Titulo = libro.Titulo,
                ISBN = libro.ISBN,
                AnioPublicacion = libro.AnioPublicacion,
                NombreAutor = libro.Autor?.Nombre ?? "Sin Autor"
            };
        }

        public async Task<bool> EliminarLibroAsync(int id)
        {
            var libro = await _context.Libros.FindAsync(id);
            if (libro == null)
            {
                return false;
            }

            _context.Libros.Remove(libro);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
