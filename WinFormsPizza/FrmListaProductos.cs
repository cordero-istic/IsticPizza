using Entidades;
using Servicios;
namespace WinFormsPizza
{
    public partial class FrmListaProductos : Form
    {
        private readonly ProductoServ _productoServ;
        public FrmListaProductos()
        {
            InitializeComponent();
            _productoServ = new ProductoServ();
            CargarProductos();
        }

        private void CargarProductos()
        {
       
            var lista = _productoServ.GetProductos();

            // 👇 Opción A: DataGridView (recomendado)
            dataGridProductos.DataSource = lista;

            // 👇 Opción B: ListBox (más simple)
            // lstProductos.Items.Clear();
            // foreach(var p in lista)
            //     lstProductos.Items.Add($"{p.Nombre} - ${p.Precio}");
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmProducto producto = new();
            producto.ShowDialog();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
