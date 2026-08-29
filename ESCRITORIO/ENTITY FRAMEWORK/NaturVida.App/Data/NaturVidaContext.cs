using Microsoft.EntityFrameworkCore;
using NaturVida.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaturVida.App.Data
{
    internal class NaturVidaContext:DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NaturVidaDB;Trusted_Connection=true;");
        }
    }
}
