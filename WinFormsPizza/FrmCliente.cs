using Entidades;
using Servicios;
namespace WinFormsPizza
{
    public partial class FrmCliente : Form
    {
        private readonly ClienteServ _clienteServ;
        public FrmCliente()
        {
            InitializeComponent();
            _clienteServ = new ClienteServ();
        }



        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Recordemos Validar los Datos

            Cliente cliente = new Cliente()
            {
                //ClienteId = 1,
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                NroDocumento = TxtNroDoc.Text,
                Telefono = TxtTlf.Text,
                Correo = TxtCorreo.Text
            };

            _clienteServ.AgregarCliente(cliente);
            this.Close();
            FrmListaClientes frmCliente = new FrmListaClientes();
            frmCliente.ShowDialog();

        }
    }
}
