using Microsoft.EntityFrameworkCore;
using RegistroClientesEN;  // Donde está tu clase `Clientes`

namespace RegistrarClientesDAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Clientes> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
