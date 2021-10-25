using CPAPP.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CPAPP.Infrastucture.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Produto> Produtos { get; set; }
        // public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     base.OnModelCreating(builder);
        //     builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        // }
    }
}