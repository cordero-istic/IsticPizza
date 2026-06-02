using Entidades;
using Microsoft.EntityFrameworkCore;
using Servicios.Interfaces;
namespace Servicios
{
    public class ProductoServ: IProductoServ
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

        public void EliminarProducto(int Id)
        {
            var productToDelete = _context.Productos.Find(Id);
            if (productToDelete != null)
            {
                _context.Productos.Remove(productToDelete);
                _context.SaveChanges();
            }
        }

        //public List<Producto> BuscarPorTipoYMarca(string tipo, string marca)
        //{
        //    return _context.Productos
        //        .Where(p => p.TipoProducto.Contains(tipo) && p.Marca.Contains(marca))
        //        .ToList();
        //}

        public List<Producto> BuscarPorTipo(string tipo)
        {
            return _context.Productos
                .Where(p => p.TipoProducto.Contains(tipo))
                .ToList();
        }

        //public List<Producto> BuscarPorMarca(string marca)
        //{
        //    return _context.Productos
        //        .Where(p => p.Marca.Contains(marca))
        //        .ToList();
        //}

    }
}
