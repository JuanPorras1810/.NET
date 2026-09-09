
using BibliotecaApp.Data;
using BibliotecaApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

public class LibroController : Controller
{
    private readonly ApplicationDbContext _context;

    public LibroController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: LIBROS
    public async Task<IActionResult> Index(string estado)
    {
        var libros = _context.Libros
            .Include(l => l.Autor)
            .Include(l => l.Prestamos)
            .AsQueryable();

        if (estado == "Disponible")
        {
            libros = libros.Where(l => !_context.Prestamos.Any(p => p.LibroId == l.Id && p.FechaDevolucion == null));
        }
        else if (estado == "No Disponible")
        {
            libros = libros.Where(l => _context.Prestamos.Any(p => p.LibroId == l.Id && p.FechaDevolucion == null));
        }

        ViewBag.Estado = estado;

        return View(await libros.ToListAsync());
    }

    // GET: LIBROS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var libro = await _context.Libros
            .FirstOrDefaultAsync(m => m.Id == id);

        if (libro == null)
        {
            return NotFound();
        }

        return View(libro);
    }

    // GET: LIBROS/Create
    public IActionResult Create()
    {
        ViewBag.Autores = new SelectList(_context.Autores, "Id", "Nombre");
        return View();
    }

    // POST: LIBROS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Titulo,ISBN,AnioPublicacion,AutorId,Autor,Prestamos")] Libro libro)
    {
        if (ModelState.IsValid)
        {
            _context.Add(libro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewBag.Autores = new SelectList(_context.Autores, "Id", "Nombre", libro.AutorId);
        return View(libro);
    }

    // GET: LIBROS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var libro = await _context.Libros.FindAsync(id);
        if (libro == null)
        {
            return NotFound();
        }
        ViewBag.Autores = new SelectList(_context.Autores, "Id", "Nombre", libro.AutorId);
        return View(libro);
    }

    // POST: LIBROS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Titulo,ISBN,AnioPublicacion,AutorId,Autor,Prestamos")] Libro libro)
    {
        if (id != libro.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(libro);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibroExists(libro.Id))
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
        ViewBag.Autores = new SelectList(_context.Autores, "Id", "Nombre", libro.AutorId);
        return View(libro);
    }

    // GET: LIBROS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var libro = await _context.Libros
            .Include(l => l.Autor)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (libro == null)
        {
            return NotFound();
        }

        return View(libro);
    }

    // POST: LIBROS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var libro = await _context.Libros.FindAsync(id);
        if (libro != null)
        {
            _context.Libros.Remove(libro);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool LibroExists(int? id)
    {
        return _context.Libros.Any(e => e.Id == id);
    }
}
