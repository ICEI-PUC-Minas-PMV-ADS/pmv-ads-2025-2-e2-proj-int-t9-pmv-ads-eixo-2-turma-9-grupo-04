using CriarGrupo.Models;
using Microsoft.EntityFrameworkCore;

namespace SportConnect.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Grupo> Grupos { get; set; }

        public DbSet<Evento> Eventos { get; set; }

        public DbSet<Participacao> Participacoes { get; set; }

    }
}