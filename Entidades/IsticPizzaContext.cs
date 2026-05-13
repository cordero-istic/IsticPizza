using Microsoft.EntityFrameworkCore;

namespace Entidades
{
    public class IsticPizzaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\vcordero\\IsticPizza\\WinFormsPizza\\isticpizza.db");
        }
    }
}
