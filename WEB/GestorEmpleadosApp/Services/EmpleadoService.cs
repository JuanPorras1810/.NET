using GestorEmpleadosApp.Data;
using GestorEmpleadosApp.Models;
using GestorEmpleadosApp.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace GestorEmpleadosApp.Services
{
    public class EmpleadoService : IEmpleadoService
    {

        private readonly ApplicationDbContext _context;

        public EmpleadoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> ActualizarEmpleadoAsync(int id, CrearEmpleadoViewModel viewModel)
        {
            var empleado = await _context.Empleados.FindAsync(id);

            if (empleado == null)
            {
                return false;
            }

            empleado.Nombre = viewModel.Nombre;
            empleado.Apellido = viewModel.Apellido;
            empleado.Email = viewModel.Email;
            empleado.Telefono = viewModel.Telefono;
            empleado.FechaContratacion = viewModel.FechaContratacion;
            empleado.Salario = viewModel.Salario;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> CrearEmpleadoAsync(CrearEmpleadoViewModel viewModel)
        {
            var empleado = new Empleado
            {
                Nombre = viewModel.Nombre,
                Apellido = viewModel.Apellido,
                Email = viewModel.Email,
                Telefono = viewModel.Telefono,
                FechaContratacion = viewModel.FechaContratacion,
                Salario = viewModel.Salario
            };

            _context.Empleados.Add(empleado);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> EliminarEmpleadoAsync(int id)
        {
            var empleado = await _context.Empleados.FindAsync(id);

            if (empleado == null)
            {
                return false;
            }

            _context.Empleados.Remove(empleado);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Empleado?> ObtenerPorIdAsync(int id)
        {
            return await _context.Empleados.FindAsync(id);
        }

        public async Task<IEnumerable<Empleado>> ObtenerTodosAsync()
        {
            return await _context.Empleados.ToListAsync();
        }
    }
}
