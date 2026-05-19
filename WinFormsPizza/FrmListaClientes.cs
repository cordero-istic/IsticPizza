using Entidades;
using Servicios;
namespace WinFormsPizza
{
    public partial class FrmListaClientes : Form
    {
        private readonly ClienteServ _clienteServ;
        public FrmListaClientes()
        {
            InitializeComponent();
            _clienteServ = new ClienteServ();
            LlenarGrid();
        }

        private void LlenarGrid()
        {
       
            List<Cliente> clientes = _clienteServ.GetClientes();
            dataGridClientes.AutoGenerateColumns = false;
            dataGridClientes.DataSource = clientes;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmCliente cliente = new FrmCliente();
            cliente.ShowDialog();
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
