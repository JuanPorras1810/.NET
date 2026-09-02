using GestionTareas.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionTareas.Controllers
{
    public class TareaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TareaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var tareas = await _context.Tareas.ToListAsync();
            return View(tareas);
        }
    }
}
