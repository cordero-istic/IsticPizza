using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    public interface IProductoServ
    {
        public void AgregarProducto(Producto producto);
        public List<Producto> GetProductos();
        public Producto GetProductoById(int Id);
        public void EditarProducto(Producto productoToEdit);
        public void EliminarProducto(int Id);
        public List<Producto> BuscarPorTipo(string tipo);
    }
}
