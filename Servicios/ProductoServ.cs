using Entidades;
using Microsoft.EntityFrameworkCore;
namespace Servicios
{
    public class ProductoServ
    {
        private readonly IsticPizzaContext _context;

        public ProductoServ()
        {
            _context = new IsticPizzaContext();
        }

        public void AgregarProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public List<Producto> GetProductos()
        {
            return _context.Productos.ToList();
        }

        public Producto GetProductoById(int Id)
        {
            var Product = _context.Productos.FirstOrDefault(p => p.ProductoId == Id);
            return Product;
        }

        public void EditarProducto(Producto productoToEdit)
        {
            var existingProduct = _context.Productos.Find(productoToEdit.ProductoId);
            if (existingProduct != null)
            {
                existingProduct.Nombre = productoToEdit.Nombre;
                existingProduct.Descripcion = productoToEdit.Descripcion;
                existingProduct.Precio = productoToEdit.Precio;
                existingProduct.TipoProducto = productoToEdit.TipoProducto;
                existingProduct.UnidadMedida = productoToEdit.UnidadMedida;
                existingProduct.ImageUrl = productoToEdit.ImageUrl;
                _context.SaveChanges();
            }
        }

    }
}
