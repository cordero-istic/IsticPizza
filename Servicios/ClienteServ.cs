using Entidades;
namespace Servicios
{
    public class ClienteServ
    {
        private static List<Cliente> ListClientes { get; set; } = new();

        public void AgregarCliente(Cliente cliente)
        {
            ListClientes.Add(cliente);
        }

        public List<Cliente> GetClientes()
        {
            return ListClientes;
        }
    }
}
