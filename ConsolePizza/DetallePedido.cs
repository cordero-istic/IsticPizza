using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePizza
{
    public class DetallePedido
    {
        private List<ItemPedido> ItemsPedido { get; set; } = new();

        public void AgregarItemPedido(ItemPedido item)
        {
            item.SubTotal = item.Producto.Precio * item.Cantidad;
            ItemsPedido.Add(item);
        }

        public List<ItemPedido> ListarItems() => ItemsPedido; //Body Expression
        
    }
}
