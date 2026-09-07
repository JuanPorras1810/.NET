
using BibliotecaApp.Data;
using BibliotecaApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

public class PrestamoController : Controller
{
    private readonly ApplicationDbContext _context;

    public PrestamoController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: PRESTAMOS
    public async Task<IActionResult> Index()    
    {
        var prestamos = await _context.Prestamos
        .Include(p => p.Libro)
            .ThenInclude(l => l.Autor)
        .ToListAsync();

        return View(prestamos);
    }

    // GET: PRESTAMOS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var prestamo = await _context.Prestamos
            .Include(p => p.Libro)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (prestamo == null)
        {
            return NotFound();
        }

        return View(prestamo);
    }

    // GET: PRESTAMOS/Create
    public IActionResult Create()
    {
        ViewBag.Libros = new SelectList(_context.Libros, "Id", "Titulo");
        return View();
    }

    // POST: PRESTAMOS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,NombreUsuario,FechaPrestamo,FechaDevolucion,LibroId,Libro")] Prestamo prestamo)
    {
        if (ModelState.IsValid)
        {
            prestamo.FechaPrestamo = DateTime.Now;
            _context.Add(prestamo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewBag.Libros = new SelectList(_context.Libros, "Id", "Titulo", prestamo.LibroId);
        return View(prestamo);
    }

    // GET: PRESTAMOS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var prestamo = await _context.Prestamos.FindAsync(id);
        if (prestamo == null)
        {
            return NotFound();
        }
        ViewBag.Libros = new SelectList(_context.Libros, "Id", "Titulo", prestamo.LibroId);
        return View(prestamo);
    }

    // POST: PRESTAMOS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,NombreUsuario,FechaPrestamo,FechaDevolucion,LibroId,Libro")] Prestamo prestamo)
    {
        if (id != prestamo.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(prestamo);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrestamoExists(prestamo.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        ViewBag.Libros = new SelectList(_context.Libros, "Id", "Titulo", prestamo.LibroId);
        return View(prestamo);
    }

    // GET: PRESTAMOS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var prestamo = await _context.Prestamos
            .Include(l => l.Libro)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (prestamo == null)
        {
            return NotFound();
        }

        return View(prestamo);
    }

    // POST: PRESTAMOS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var prestamo = await _context.Prestamos.FindAsync(id);
        if (prestamo != null)
        {
            _context.Prestamos.Remove(prestamo);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool PrestamoExists(int? id)
    {
        return _context.Prestamos.Any(e => e.Id == id);
    }
}
