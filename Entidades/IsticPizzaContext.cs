using Microsoft.EntityFrameworkCore;

namespace Entidades
{
    public class IsticPizzaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\corde\\Downloads\\IsticPizza 6_4\\IsticPizza\\WinFormsPizza\\isticpizza.db");
        }
    }
}
