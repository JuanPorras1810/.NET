using GestionTareas.Data;
using GestionTareas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GestionTareas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context) 
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var tareas = _context.Tareas.ToList();
            return View(tareas);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contacto() 
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
