using BibliotecaApp.Data;
using BibliotecaApp.Models;
using BibliotecaApp.ViewModels.AutorViewModels;
using BibliotecaApp.ViewModels.LibroViewModels;
using BibliotecaApp.ViewModels.PrestamoViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaApp.Services.PrestamoServices
{
    public class PrestamoService : IPrestamoService
    {
        private readonly ApplicationDbContext _context;

        public PrestamoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<PrestamoIndexViewModel>> ObtenerTodosAsync(string buscar)
        {
            var prestamos = _context.Prestamos.AsQueryable();
            if (!string.IsNullOrWhiteSpace(buscar))
            {
                prestamos = prestamos.Where(p => p.NombreUsuario.Contains(buscar));
            }

            return await prestamos.Select(p => new PrestamoIndexViewModel
            {
                Id = p.Id,
                NombreUsuario = p.NombreUsuario,
                FechaPrestamo = p.FechaPrestamo,
                FechaDevolucion = p.FechaDevolucion,
                NombreLibro = p.Libro != null ? p.Libro.Titulo : "Sin nombre"
            }).ToListAsync();
        }

        public async Task<PrestamoDetalleViewModel?> ObtenerDetalleAsync(int id)
        {
            var prestamo = await _context.Prestamos
                .Include(p => p.Libro)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (prestamo == null)
            {
                return null;
            }

            return new PrestamoDetalleViewModel
            {
                Id = prestamo.Id,
                NombreUsuario = prestamo.NombreUsuario,
                FechaPrestamo = prestamo.FechaPrestamo,
                FechaDevolucion = prestamo.FechaDevolucion,
                NombreLibro = prestamo.Libro != null ? prestamo.Libro.Titulo : "Sin nombre",
                DiasPrestado = (prestamo.FechaDevolucion - prestamo.FechaPrestamo)?.Days
            };
        }

        public async Task<CrearEditarPrestamoViewModel?> ObtenerViewModelParaCrearAsync()
        {
            return new CrearEditarPrestamoViewModel
            {
                Libros = await _context.Libros.Where(l => !_context.Prestamos
                .Any(p => p.LibroId == l.Id && p.FechaDevolucion == null))
                .Select(l => new SelectListItem
                {
                    Value = l.Id.ToString(),
                    Text = l.Titulo,
                }).ToListAsync()
            };
        }

        public async Task<bool> CrearPrestamoAsync(CrearEditarPrestamoViewModel viewModel)
        {
            var prestamo = new Prestamo 
            {
                NombreUsuario = viewModel.NombreUsuario,
                FechaPrestamo = DateTime.Now,
                LibroId = viewModel.LibroId
            };

            _context.Prestamos.Add(prestamo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<CrearEditarPrestamoViewModel?> ObtenerViewModelParaEditarAsync(int id)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);

            if (prestamo == null)
            {
                return null;
            }

            return new CrearEditarPrestamoViewModel
            {
                NombreUsuario = prestamo.NombreUsuario,
                FechaPrestamo = prestamo.FechaPrestamo,
                FechaDevolucion = prestamo.FechaDevolucion,
                LibroId =prestamo.LibroId,

                Libros = await _context.Libros.Select( l => new SelectListItem
                { 
                    Value = l.Id.ToString(),
                    Text = l.Titulo
                }).ToListAsync()
            };
        }

        public async Task<bool> ActualizarPrestamoAsync(int id, CrearEditarPrestamoViewModel viewModel)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);

            if (prestamo == null)
            {
                return false;
            }

            if (prestamo.FechaDevolucion == null && viewModel.FechaDevolucion.HasValue)
            {
                prestamo.FechaDevolucion = DateTime.Now;
            }


            await _context.SaveChangesAsync();
            
            return true;
        }

        public async Task<PrestamoIndexViewModel?> ObtenerParaEliminarAsync(int id)
        {
            var prestamo = await _context.Prestamos
                .Include(l => l.Libro)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (prestamo == null)
            {
                return null;
            }

            return new PrestamoIndexViewModel
            {
                NombreUsuario = prestamo.NombreUsuario,
                FechaPrestamo = prestamo.FechaPrestamo,
                FechaDevolucion = prestamo.FechaDevolucion,
                LibroId = prestamo.LibroId,
                NombreLibro = prestamo.Libro?.Titulo ?? "Libro sin nombre"
            };

        }   
        
        public async Task<bool> EliminarPrestamoAsync(int id)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);

            if (prestamo == null)
            {
                return false;
            }

            if (prestamo.FechaDevolucion == null)
            {
                return false;
            }

            _context.Prestamos.Remove(prestamo);
            _context.SaveChanges();

            return true;
        }

    }
}
