using GestorEmpleadosApp.Models;
using GestorEmpleadosApp.ViewModels;

namespace GestorEmpleadosApp.Services
{
    public interface IEmpleadoService
    {
        Task<IEnumerable<Empleado>> ObtenerTodosAsync();
        Task<Empleado?> ObtenerPorIdAsync(int id);
        Task<bool> CrearEmpleadoAsync(CrearEmpleadoViewModel viewModel);
        Task<bool> ActualizarEmpleadoAsync(int id, CrearEmpleadoViewModel viewModel);
        Task<bool> EliminarEmpleadoAsync(int id);
    }
}
