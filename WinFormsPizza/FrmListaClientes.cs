using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsolePizza;

namespace WinFormsPizza
{
    public partial class FrmListaClientes : Form
    {
        public FrmListaClientes()
        {
            InitializeComponent();
            LlenarGrid();
        }

        private void LlenarGrid()
        {
            Cliente cliente = new Cliente();

            List<Cliente> clientes = cliente.GetClientes();
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
