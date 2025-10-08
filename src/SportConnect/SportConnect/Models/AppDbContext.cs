using Microsoft.EntityFrameworkCore;

namespace SportConnect.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
