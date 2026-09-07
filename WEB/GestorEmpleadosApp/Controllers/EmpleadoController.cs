
using GestorEmpleadosApp.Data;
using GestorEmpleadosApp.Models;
using GestorEmpleadosApp.Services;
using GestorEmpleadosApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class EmpleadoController : Controller
{
    private readonly IEmpleadoService _empleadoService;

    public EmpleadoController(IEmpleadoService empleadoService)
    {
        _empleadoService = empleadoService;
    }

    // GET: EMPLEADOS
    public async Task<IActionResult> Index()    
    {
        var empleados = await _empleadoService.ObtenerTodosAsync();
        return View(empleados);
    }

    // GET: EMPLEADOS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var empleado = await _empleadoService.ObtenerPorIdAsync(id.Value);

        if (empleado == null)
        {
            return NotFound();
        }

        return View(empleado);
    }

    // GET: EMPLEADOS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: EMPLEADOS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CrearEmpleadoViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }

        await _empleadoService.CrearEmpleadoAsync(viewModel);
        return RedirectToAction(nameof(Index));
    }

    // GET: EMPLEADOS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var empleado = await _empleadoService.ObtenerPorIdAsync(id.Value);

        if (empleado == null)
        {
            return NotFound();
        }

        var viewModel = new CrearEmpleadoViewModel
        {
            Nombre = empleado.Nombre,
            Apellido = empleado.Apellido,
            Email = empleado.Email,
            Telefono = empleado.Telefono,
            FechaContratacion = empleado.FechaContratacion,
            Salario = empleado.Salario
        };

        return View(empleado);
    }

    // POST: EMPLEADOS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, CrearEmpleadoViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }

        var exito = await _empleadoService.ActualizarEmpleadoAsync(id, viewModel);

        if (!exito)
        {
            return NotFound();
        }

        return RedirectToAction(nameof(Index));
    }

    // GET: EMPLEADOS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var empleado = await _empleadoService.ObtenerPorIdAsync(id.Value);

        if (empleado == null)
        {
            return NotFound();
        }

        return View(empleado);
    }

    // POST: EMPLEADOS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _empleadoService.EliminarEmpleadoAsync(id);
        return RedirectToAction(nameof(Index));
    }

    //private bool EmpleadoExists(int? id)
    //{
    //    return _context.Empleados.Any(e => e.Id == id);
    //}
}
