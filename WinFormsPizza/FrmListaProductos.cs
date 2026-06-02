using Entidades;
using Servicios;
using Servicios.Interfaces;
namespace WinFormsPizza
{
    public partial class FrmListaProductos : Form
    {
        private readonly IProductoServ _productoServ;
        public FrmListaProductos()
        {
            InitializeComponent();
            _productoServ = new ProductoServ();
            CargarProductos();
        }

        private void CargarProductos()
        {
            var lista = _productoServ.GetProductos();
            LlenarDataGrid(lista);

            // 👇 Opción B: ListBox (más simple)
            // lstProductos.Items.Clear();
            // foreach(var p in lista)
            //     lstProductos.Items.Add($"{p.Nombre} - ${p.Precio}");
        }

        private void LlenarDataGrid(List<Producto> productos)
        {
            dataGridProductos.AutoGenerateColumns = false;
            dataGridProductos.DataSource = null;
            dataGridProductos.DataSource = productos;
            dataGridProductos.ClearSelection();
            dataGridProductos.CurrentCell = null;
        }
        
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProducto producto = new();
            producto.ShowDialog();
            RefrescaPantalla();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccion() == false)
            {
                return;
            }

            //Consumir el servicio para obtener el producto seleccionado

            int Id = int.Parse(dataGridProductos.CurrentRow.Cells["ColId"].Value.ToString());
            var Product = _productoServ.GetProductoById(Id);

            if (Product == null)
            {
                MessageBox.Show("Producto no encontrado");
                return;
            }

            //Abrir el formulario de edición

            FrmProducto productoEdit = new FrmProducto(Product);
            productoEdit.Text = "Editar Producto";
            productoEdit.ShowDialog();

            RefrescaPantalla();
        }

        private void RefrescaPantalla()
        {
            this.Close();
            FrmListaProductos frmLista = new FrmListaProductos();
            frmLista.ShowDialog();
        }

        private bool ValidarSeleccion()
        {
            if (dataGridProductos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para editar");
                return false;
            }
            if (dataGridProductos.SelectedCells.Count == 0)//Validamos que haya una fila seleccionada
            {
                MessageBox.Show("Debe seleccionar un Producto para Editar");
                return false;
            }
            return true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccion() == false)
            {
                return;
            }

            if (MessageBox.Show("¿Confirma que desea eliminar el producto seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int Id = int.Parse(dataGridProductos.CurrentRow.Cells["ColId"].Value.ToString());
                _productoServ.EliminarProducto(Id);
                RefrescaPantalla();
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //string texto = txtBuscar.Text.Trim();
            //var lista = _productoServ.BuscarProductos(texto);
        
            var lista = _productoServ.BuscarPorTipo(TxtBuscaTipo.Text.Trim());
            LlenarDataGrid(lista);

        }
    }
}
