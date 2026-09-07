using GestorEmpleadosApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GestorEmpleadosApp.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
