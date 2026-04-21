using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePizza
{
    public class ItemPedido
    {
        public Producto Producto { get; set; }
        public int Cantidad {  get; set; }
        public double SubTotal { get; set; }

        //public double CalcularSubTotal()
        //{
        //    Producto.Precio * Cantidad= SubTotal
        //}

    }

}
