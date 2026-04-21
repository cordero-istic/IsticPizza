using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePizza
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string TipoProducto { get; set; }
        public string UnidadMedida { get; set; }
        public string ImageUrl { get; set; }

        private static List<Producto> ListProductos { get; set; } = new();

        public void AgregarProducto(Producto producto)
        {
            ListProductos.Add(producto);
        }

        public List<Producto> GetProductos()
        {
            return ListProductos;
        }
    }
}
