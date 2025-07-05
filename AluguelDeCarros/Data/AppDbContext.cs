using Microsoft.EntityFrameworkCore;
using AluguelDeCarros.Models;

namespace AluguelDeCarros.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Carro> Carros { get; set; }
    }
}
