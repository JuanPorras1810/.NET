using BibliotecaApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }

        public DbSet<Autor> Autores { get; set; }

        public DbSet<Libro> Libros { get; set; }

        public DbSet<Prestamo> Prestamos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Autor>()
                .HasMany(a => a.Libros)
                .WithOne(l => l.Autor)
                .HasForeignKey(l => l.AutorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Libro>()
                .HasMany(l => l.Prestamos)
                .WithOne(p => p.Libro)
                .HasForeignKey(p => p.LibroId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
