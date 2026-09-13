using BibliotecaApp.Data;
using BibliotecaApp.Models;
using BibliotecaApp.ViewModels.AutorViewModels;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApp.Services.AutorServices
{
    public class AutorService : IAutorService
    {
        private readonly ApplicationDbContext _context;

        public AutorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AutorIndexViewModel>> ObtenerTodosAsync(string? buscar)
        {
            var query = _context.Autores.AsQueryable();
            if (!string.IsNullOrWhiteSpace(buscar))
            {
                query = query.Where(a => a.Nombre.Contains(buscar));
            }

            return await query.Select(a => new AutorIndexViewModel
            {
                Id = a.Id,
                Nombre = a.Nombre,
                Nacionalidad = a.Nacionalidad,
                FechaNacimiento = a.FechaNacimiento,
                TotalLibros = a.Libros.Count
            }).ToListAsync();
        }

        public async Task<AutorDetalleViewModel?> ObtenerDetalleAsync(int id)
        {
            var autor = await _context.Autores
                        .Include(a => a.Libros)
                        .FirstOrDefaultAsync(a => a.Id == id);

            if (autor == null)
            {
                return null;
            }

            return new AutorDetalleViewModel
            {
                Id = autor.Id,
                Nombre = autor.Nombre,
                Nacionalidad = autor.Nacionalidad,
                FechaNacimiento = autor.FechaNacimiento,
                TotalLibros = autor.Libros.Count,
                TitulosLibros = autor.Libros.Select(l => l.Titulo).ToList()
            };
        }


        public async Task<CrearEditarAutorViewModel?> ObtenerViewModelParaEditarAsync(int id)
        {
            var autor = await _context.Autores.FindAsync(id);

            if (autor == null)
            {
                return null;
            }

            return new CrearEditarAutorViewModel
            {
                Nombre = autor.Nombre,
                Nacionalidad = autor.Nacionalidad,
                FechaNacimiento = autor.FechaNacimiento
            };
        }

        public async Task<bool> CrearAutorAsync(CrearEditarAutorViewModel viewModel)
        {
            var autor = new Autor
            {
                Nombre = viewModel.Nombre,
                Nacionalidad = viewModel.Nacionalidad,
                FechaNacimiento = viewModel.FechaNacimiento
            };

            _context.Autores.Add(autor);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ActualizarAutorAsync(int id, CrearEditarAutorViewModel viewModel)
        {
            var autor = await _context.Autores.FindAsync(id);

            if (autor == null)
            {
                return false;
            }

            autor.Nombre = viewModel.Nombre;
            autor.Nacionalidad = viewModel.Nacionalidad;
            autor.FechaNacimiento = viewModel.FechaNacimiento;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<AutorIndexViewModel?> ObtenerParaEliminarAsync(int id)
        {
            var autor = await _context.Autores
                .Include(a => a.Libros)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (autor == null)
            {
                return null;
            }

            return new AutorIndexViewModel
            {
                Id = autor.Id,
                Nombre = autor.Nombre,
                Nacionalidad = autor.Nacionalidad,
                FechaNacimiento = autor.FechaNacimiento,
                TotalLibros = autor.Libros.Count
            };
        }

        public async Task<bool> EliminarAutorAsync(int id)
        {
            var autor = await _context.Autores.FindAsync(id);

            if (autor == null)
            {
                return false;
            }

            _context.Autores.Remove(autor);
            await _context.SaveChangesAsync();

            return true;
        }

    }  
}
