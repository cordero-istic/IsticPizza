using Entidades;
using Servicios;
namespace WinFormsPizza
{
    public partial class FrmProducto : Form
    {
        private readonly ProductoServ _productoServ;
        private Producto _producto;
        public FrmProducto() //Nuevo producto
        {
            InitializeComponent();
            _productoServ = new ProductoServ();
        }

        public FrmProducto(Producto producto) //Editar producto
        {
            InitializeComponent();
            _productoServ = new ProductoServ();
            _producto = producto;
            LlenarCampos();
        }

        private void LlenarCampos()
        {
            if (_producto != null)
            {
                TxtNombre.Text = _producto.Nombre;
                TxtDescripcion.Text = _producto.Descripcion;
                TxtPrecio.Text = _producto.Precio.ToString();
                TxtTipoProducto.Text = _producto.TipoProducto;
                TxtUnidadMedida.Text = _producto.UnidadMedida;
                TxtImageUrl.Text = _producto.ImageUrl;
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListaProductos frmLista = new FrmListaProductos();
            frmLista.ShowDialog();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Validar datos obligatorios
            if (string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtPrecio.Text))
            {
                MessageBox.Show("Nombre y Precio son obligatorios",
                              "Validación",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }


            if (_producto != null) // Editar
            {
                _producto.Nombre = TxtNombre.Text;
                _producto.Descripcion = TxtDescripcion.Text;
                _producto.Precio = double.TryParse(TxtPrecio.Text, out var precio) ? precio : 0;
                _producto.TipoProducto = TxtTipoProducto.Text;
                _producto.UnidadMedida = TxtUnidadMedida.Text;
                _producto.ImageUrl = TxtImageUrl.Text;
                _productoServ.EditarProducto(_producto);
            }
            else // Nuevo
            {
                // Crear instancia del producto
                _producto = new Producto()
                {
                    //ProductoId = 1, // TODO: implementar auto-incremental
                    Nombre = TxtNombre.Text,
                    Descripcion = TxtDescripcion.Text,
                    Precio = double.TryParse(TxtPrecio.Text, out var precio) ? precio : 0,
                    TipoProducto = TxtTipoProducto.Text,
                    UnidadMedida = TxtUnidadMedida.Text,
                    ImageUrl = TxtImageUrl.Text
                };

                //Persistir usando el patrón del modelo
                _productoServ.AgregarProducto(_producto);
            }
                       

            //Navegar a la lista de productos
            this.Close();
            FrmListaProductos frmLista = new FrmListaProductos();
            frmLista.ShowDialog();
        }
    }
}
