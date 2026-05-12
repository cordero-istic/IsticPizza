using Entidades;
namespace Servicios
{
    public class ProductoServ
    {
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
