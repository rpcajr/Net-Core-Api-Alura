using Filmes.Models;
using Microsoft.EntityFrameworkCore;

namespace Filmes.Data
{
    public class FilmeDbContext : DbContext
    {
        public FilmeDbContext(DbContextOptions<FilmeDbContext> options) : base(options){}

        public DbSet<Filme> Filmes { get; set; }
    }
}
