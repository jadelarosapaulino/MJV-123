using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MJV.Logics.Models;

namespace MJV.Logics
{   
    public class MJVContext : DbContext, IDesignTimeDbContextFactory<MJVContext>
    {
        Conexion conexion = new Conexion();

        private readonly DbContextOptions<MJVContext> _options;

        public MJVContext()
        {
        }

        public MJVContext(DbContextOptions<MJVContext> options)
            : base(options)
        {
            _options = options;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@conexion.connString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public virtual DbSet<Producto> Producto { get; set; }

        public MJVContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<MJVContext>();
            optionBuilder.UseSqlServer(@conexion.connString);

            return new MJVContext(optionBuilder.Options);
        }
    }
}
