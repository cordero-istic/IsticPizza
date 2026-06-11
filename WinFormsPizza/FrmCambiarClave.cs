using Entidades;
using Servicios.Implementaciones;
using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPizza
{
    public partial class FrmCambiarClave : Form
    {
        private readonly ISeguridadService _seguridadServ;
        public FrmCambiarClave(Usuario usuario)
        {
            InitializeComponent();
            _seguridadServ = new SeguridadService();
            TxtCorreo.Text = usuario.Correo;
        }
        
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Validaciones de campos

            _seguridadServ.CambiarClave(TxtCorreo.Text, TxtAnterior.Text, TxtNueva.Text);
            MessageBox.Show("Clave cambiada exitosamente");
            this.Close();

        }
    }
}
