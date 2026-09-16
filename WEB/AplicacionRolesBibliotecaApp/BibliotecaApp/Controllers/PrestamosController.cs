
using BibliotecaApp.Data;
using BibliotecaApp.Models;
using BibliotecaApp.Services.PrestamoServices;
using BibliotecaApp.ViewModels.PrestamoViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApp.Controllers
{
    [Authorize(Roles = "Administrador,Bibliotecario")]
    public class PrestamoController : Controller
    {
        private readonly IPrestamoService _prestamoService;

        public PrestamoController(IPrestamoService prestamoService)
        {
            _prestamoService = prestamoService;
        }

        // GET: PRESTAMOS
        public async Task<IActionResult> Index(string buscar)
        {
            var prestamos = await _prestamoService.ObtenerTodosAsync(buscar);
            ViewBag.Buscar = buscar;
            return View(prestamos);
        }

        // GET: PRESTAMOS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _prestamoService.ObtenerDetalleAsync(id.Value);

            if (prestamo == null)
            {
                return NotFound();
            }

            return View(prestamo);
        }

        // GET: PRESTAMOS/Create
        public async Task<IActionResult> Create()
        {
            var viewModel = await _prestamoService.ObtenerViewModelParaCrearAsync();
            return View(viewModel);
        }

        // POST: PRESTAMOS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CrearEditarPrestamoViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            await _prestamoService.CrearPrestamoAsync(viewModel);

            return RedirectToAction(nameof(Index));
        }

        // GET: PRESTAMOS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewModel = await _prestamoService.ObtenerViewModelParaEditarAsync(id.Value);

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        // POST: PRESTAMOS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CrearEditarPrestamoViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var exito = await _prestamoService.ActualizarPrestamoAsync(id, viewModel);

            if (!exito)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));

        }

        // GET: PRESTAMOS/Delete/5
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewModel = await _prestamoService.ObtenerParaEliminarAsync(id.Value);

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        // POST: PRESTAMOS/Delete/5
        [Authorize(Roles = "Administrador")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exito = await _prestamoService.EliminarPrestamoAsync(id);

            if (!exito)
            {
                TempData["Error"] = "No se puede eliminar el préstamo porque el libro todavía no ha sido devuelto.";
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}