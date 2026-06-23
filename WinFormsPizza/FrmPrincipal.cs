using Entidades;

namespace WinFormsPizza
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            LblUser.Text = usuario.Correo.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            FrmListaClientes clientes = new FrmListaClientes();
            clientes.ShowDialog();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FrmListaProductos productos = new();
            productos.ShowDialog();
        }
    }
}
