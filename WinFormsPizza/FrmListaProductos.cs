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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridProductos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para editar");
                return;
            }

            if (dataGridProductos.SelectedCells.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un Producto para Editar");
                return;
            }

            int Id;

            Id = int.Parse(dataGridProductos.CurrentRow.Cells["ColId"].Value.ToString());

            var Product = _productoServ.GetProductoById(Id);


        }
    }
}
