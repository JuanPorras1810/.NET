using BibliotecaApp.ViewModels.LibroViewModels;

namespace BibliotecaApp.Services.LibroServices
{
    public interface ILibroService
    {
        Task<IEnumerable<LIbroIndexViewModel>> ObtenerTodosAsync(string? buscarEstado);
        Task<LibroDetalleViewModel?> ObtenerDetalleAsync(int id);
        Task<CrearEditarLibroViewModel?> ObtenerViewModelParaCrearAsync();
        Task<CrearEditarLibroViewModel?> ObtenerViewModelParaEditarAsync(int id);
        Task<LIbroIndexViewModel?> ObtenerParaEliminarAsync(int id);
        Task<bool> CrearLibroAsync(CrearEditarLibroViewModel viewModel);
        Task<bool> ActualizarLibroAsync(int id, CrearEditarLibroViewModel viewModel);
        Task<bool> EliminarLibroAsync(int id);
    }
}
