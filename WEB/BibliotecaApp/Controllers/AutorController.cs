
using BibliotecaApp.Data;
using BibliotecaApp.Models;
using BibliotecaApp.Services.AutorServices;
using BibliotecaApp.ViewModels.AutorViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class AutorController : Controller
{
    private readonly IAutorService _autorService;

    public AutorController(IAutorService autorService)
    {
        _autorService = autorService;   
    }

    // GET: AUTORS
    public async Task<IActionResult> Index(string buscar)    
    {
        var autores = await _autorService.ObtenerTodosAsync(buscar);
        ViewBag.Buscar = buscar;
        return View(autores);
    }

    // GET: AUTORS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var autor = await _autorService.ObtenerDetalleAsync(id.Value);

        if (autor == null)
        {
            return NotFound();
        }

        return View(autor);
    }

    // GET: AUTORS/Create
    public IActionResult Create()
    {
        var viewModel = new CrearEditarAutorViewModel();
        return View(viewModel);
    }

    // POST: AUTORS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CrearEditarAutorViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }

        await _autorService.CrearAutorAsync(viewModel);
        return RedirectToAction(nameof(Index));
    }

    // GET: AUTORS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var viewModel = await _autorService.ObtenerViewModelParaEditarAsync(id.Value);
            
        if (viewModel == null)
        {
            return NotFound();
        }

        return View(viewModel);
    }

    // POST: AUTORS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, CrearEditarAutorViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }

        var exito = await _autorService
            .ActualizarAutorAsync(id, viewModel);

        if (!exito)
        {
            return NotFound();
        }

        return RedirectToAction(nameof(Index));
    }


    // GET: AUTORS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var viewModel = await _autorService.ObtenerParaEliminarAsync(id.Value);

        if (viewModel == null)
        {
            return NotFound();
        }

        return View(viewModel);
    }

    // POST: AUTORS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var exito = await _autorService
        .EliminarAutorAsync(id);

        if (!exito)
        {
            return NotFound();
        }

        return RedirectToAction(nameof(Index));
    }
}
