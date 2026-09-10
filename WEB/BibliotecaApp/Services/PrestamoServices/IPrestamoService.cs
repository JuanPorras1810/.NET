using BibliotecaApp.ViewModels.AutorViewModels;
using BibliotecaApp.ViewModels.PrestamoViewModels;

namespace BibliotecaApp.Services.PrestamoServices
{
    public interface IPrestamoService
    {
        Task<IEnumerable<PrestamoIndexViewModel>> ObtenerTodosAsync(string buscar);
        Task<PrestamoDetalleViewModel?> ObtenerDetalleAsync(int id);
        Task<CrearEditarPrestamoViewModel?> ObtenerViewModelParaCrearAsync();
        Task<CrearEditarPrestamoViewModel?> ObtenerViewModelParaEditarAsync(int id);
        Task<PrestamoIndexViewModel?> ObtenerParaEliminarAsync(int id);
        Task<bool> CrearPrestamoAsync(CrearEditarAutorViewModel viewModel);
        Task<bool> ActualizarPrestamoAsync(int id, CrearEditarAutorViewModel viewModel);
        Task<bool> EliminarPrestamoAsync(int id);
    }
}
