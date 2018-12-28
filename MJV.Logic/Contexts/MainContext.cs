using Microsoft.EntityFrameworkCore;
using MJV.Logic.Models;

namespace MJV.Logic.Contexts
{        
    public class MainContext : DbContext
    {
        Conexion conexion = new Conexion();


        public virtual DbSet<Producto> Productos { get; set; }


        protected void OnConfiguring(DbContextOptionsBuilder<MainContext> optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conexion.connString);
        }
    }
}
