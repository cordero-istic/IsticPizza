using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePizza
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        private static List<Cliente> ListClientes { get; set; } = new();

        public void AgregarCliente(Cliente cliente)
        {
            ListClientes.Add(cliente);
        }

        public List<Cliente> GetClientes() { 
            return ListClientes;
        }
    }
}
