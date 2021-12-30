using Microsoft.EntityFrameworkCore;

namespace AplicacionPrueba.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Zapato> Zapatos { get; set; }
    }
}