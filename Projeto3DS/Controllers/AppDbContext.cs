using Projeto3DS.Models;
using Microsoft.EntityFrameworkCore;

namespace Projeto3DS.Controllers
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Categoria> Categoria {get; set;}
        public DbSet<Lanche> Lanche { get; set; }
    }
}
