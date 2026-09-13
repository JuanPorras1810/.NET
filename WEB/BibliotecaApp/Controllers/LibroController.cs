
using BibliotecaApp.Data;
using BibliotecaApp.Models;
using BibliotecaApp.Services.LibroServices;
using BibliotecaApp.ViewModels.LibroViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class LibroController : Controller
{
    private readonly ILibroService _libroService;

    public LibroController(ILibroService libroService)
    {
        _libroService = libroService;
    }

    // GET: LIBROS
    public async Task<IActionResult> Index(string estado)
    {
        var libros = await _libroService.ObtenerTodosAsync(estado);
        ViewBag.Estado = estado; 
        return View(libros);
    }

    // GET: LIBROS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var libro = await _libroService.ObtenerDetalleAsync(id.Value);

        if (libro == null)
        {
            return NotFound();
        }

        return View(libro);
    }

    // GET: LIBROS/Create
    public async Task<IActionResult> Create()
    {
        var viewModel = await _libroService.ObtenerViewModelParaCrearAsync();
        return View(viewModel);
    }

    // POST: LIBROS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CrearEditarLibroViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }

        await _libroService.CrearLibroAsync(viewModel);

        return RedirectToAction(nameof(Index));
    }

    // GET: LIBROS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var viewModel = await _libroService.ObtenerViewModelParaEditarAsync(id.Value);

        if (viewModel == null)
        {
            return NotFound();
        }

        return View(viewModel);
    }

    // POST: LIBROS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, CrearEditarLibroViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }

        var exito = await _libroService.ActualizarLibroAsync(id, viewModel);

        if (!exito)
        {
            return NotFound();
        }

        return RedirectToAction(nameof(Index));
    }

    // GET: LIBROS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var viewModel = await _libroService.ObtenerParaEliminarAsync(id.Value);
       
        if (viewModel == null)
        {
            return NotFound();
        }

        return View(viewModel);
    }

    // POST: LIBROS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var exito = await _libroService.EliminarLibroAsync(id);

        if (!exito)
        {
            return NotFound();
        }

        return RedirectToAction(nameof(Index));
    }
}
