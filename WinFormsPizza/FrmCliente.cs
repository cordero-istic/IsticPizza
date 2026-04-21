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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }



        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Recordemos Validar los Datos

            Cliente cliente = new Cliente() { IdCliente = 1, 
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                NroDocumento = TxtNroDoc.Text,
                Telefono = TxtTlf.Text,
                Correo = TxtCorreo.Text
            };

            

            

            cliente.AgregarCliente(cliente);
            this.Close();
            FrmListaClientes frmCliente = new FrmListaClientes();
            frmCliente.ShowDialog();
            
        }
    }
}
