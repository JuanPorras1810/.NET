using GestionTareas.Data;
using GestionTareas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace GestionTareas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var tareas = await _context.Tareas.ToListAsync();
            return View(tareas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tarea tarea)
        {
            if (ModelState.IsValid)
            {
                tarea.FechaCreacion = DateTime.Now;
                _context.Add(tarea);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(tarea);
        }

        public IActionResult Details(int? id) 
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarea = _context.Tareas.FirstOrDefault(m => m.Id == id);

            if (tarea == null)
            {
                return NotFound();
            }
            return View(tarea);
        }


        public IActionResult Edit(int? id) 
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarea = _context.Tareas.Find(id);

            if (tarea == null)
            {
                return NotFound();
            }

            return View(tarea);

        }

        [HttpPost]
        public IActionResult Edit(int? id, Tarea tarea)
        {
            if (id != tarea.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Tareas.Update(tarea);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(tarea);

        }

        public IActionResult Delete(int? id) 
        {
            if (id == null)
            {
                return NotFound();
            }

            var tarea = _context.Tareas.FirstOrDefault(m => m.Id == id);

            if (tarea == null)
            {
                return NotFound();
            }

            return View(tarea);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var tarea = _context.Tareas.Find(id);
           
            if (tarea != null)
            {
                _context.Tareas.Remove(tarea);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
