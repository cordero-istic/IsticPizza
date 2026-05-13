using Entidades;
namespace Servicios
{
    public class ClienteServ
    {
        /*
        private static List<Cliente> ListClientes { get; set; } = new();

        public void AgregarCliente(Cliente cliente)
        {
            ListClientes.Add(cliente);
        }

        public List<Cliente> GetClientes()
        {
            return ListClientes;
        }
        */

        //Inyeccion de Dependencias
        private readonly IsticPizzaContext _context;

        public ClienteServ()
        {
            _context = new IsticPizzaContext();
        }

        public void AgregarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public List<Cliente> GetClientes()
        {
            return _context.Clientes.ToList();
        }



    }
}
