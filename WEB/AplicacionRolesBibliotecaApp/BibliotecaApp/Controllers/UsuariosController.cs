using BibliotecaApp.ViewModels;
using BibliotecaApp.ViewModels.UsuarioViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BibliotecaApp.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class UsuariosController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsuariosController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: Usuarios/Crear
        public IActionResult Crear()
        {
            CargarRoles();
            return View();
        }

        // POST: Usuarios/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(CrearUsuarioViewModel model)
        {
            if (!ModelState.IsValid)
            {
                CargarRoles();
                return View(model);
            }

            var user = new IdentityUser { UserName = model.Email, Email = model.Email, EmailConfirmed = true };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                if (await _roleManager.RoleExistsAsync(model.Rol))
                {
                    await _userManager.AddToRoleAsync(user, model.Rol);
                }

                TempData["Exito"] = $"Usuario {model.Email} creado correctamente con el rol {model.Rol}.";
                return RedirectToAction(nameof(Crear));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            CargarRoles();
            return View(model);
        }

        private void CargarRoles()
        {
            var roles = _roleManager.Roles.Select(r => r.Name).ToList();
            ViewBag.Roles = new SelectList(roles);
        }
    }
}