//using BibliotecaApp.Data;
//using BibliotecaApp.ViewModels.AutorViewModels;
//using BibliotecaApp.ViewModels.PrestamoViewModels;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;

//namespace BibliotecaApp.Services.PrestamoServices
//{
//    public class PrestamoService : IPrestamoService
//    {
//        private readonly ApplicationDbContext _context;

//        public PrestamoService(ApplicationDbContext context)
//        {
//            _context = context;
//        }
//        public async Task<IEnumerable<PrestamoIndexViewModel>> ObtenerTodosAsync(string buscar)
//        {
//            var prestamos = _context.Prestamos.AsQueryable();
//            if (!string.IsNullOrWhiteSpace(buscar))
//            {
//                prestamos = prestamos.Where(p => p.NombreUsuario.Contains(buscar));
//            }

//            return await prestamos.Select(p => new PrestamoIndexViewModel
//            {
//                Id = p.Id,
//                NombreUsuario = p.NombreUsuario,
//                FechaPrestamo = p.FechaPrestamo,
//                FechaDevolucion = p.FechaDevolucion,
//                NombreLibro = p.Libro != null ? p.Libro.Titulo : "Sin nombre"
//            }).ToListAsync();
//        }

//        public async Task<PrestamoDetalleViewModel?> ObtenerDetalleAsync(int id)
//        {
//            var prestamo = await _context.Prestamos
//                .Include(p => p.Libro)
//                .FirstOrDefaultAsync(p => p.Id == id);

//            if (prestamo == null)
//            {
//                return null;
//            }

//            return new PrestamoDetalleViewModel 
//            {
//                Id = prestamo.Id,
//                NombreUsuario = prestamo.NombreUsuario,
//                FechaPrestamo = prestamo.FechaPrestamo,
//                FechaDevolucion = prestamo.FechaDevolucion,
//                NombreLibro = prestamo.Libro != null ? prestamo.Libro.Titulo : "Sin nombre"
//            };
//        }

//        //public async Task<CrearEditarPrestamoViewModel?> ObtenerViewModelParaCrearAsync()
//        //{
//        //    return new CrearEditarAutorViewModel
//        //    {
//        //        Libros = await _context.Libros.Select(l => new SelectListItem
//        //        { 
//        //            Value = 
//        //        }).To
//        //    };
//        //}

//        //public Task<PrestamoIndexViewModel?> ObtenerParaEliminarAsync(int id)
//        //{

//        //}

//        public Task<bool> ActualizarPrestamoAsync(int id, CrearEditarAutorViewModel viewModel)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<bool> CrearPrestamoAsync(CrearEditarAutorViewModel viewModel)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<bool> EliminarPrestamoAsync(int id)
//        {
//            throw new NotImplementedException();
//        }

     



        

//        public Task<CrearEditarAutorViewModel?> ObtenerViewModelParaEditarAsync(int id)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
