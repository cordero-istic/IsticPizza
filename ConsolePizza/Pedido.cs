using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePizza
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public double Total { get; set; }
        public DateTime FechaPedido {get; set; }
        public Cliente Cliente { get; set; }

    }
}
