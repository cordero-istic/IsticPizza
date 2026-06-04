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
    public partial class FrmLogin : Form
    {
        private readonly ISeguridadService _seguridadServ;
        public FrmLogin()
        {
            InitializeComponent();
            _seguridadServ = new SeguridadService();
        }
        
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            // En BtnIngresar_Click:
            if (!ValidarCampo(TxtUsuario, "El usuario") || !ValidarCampo(TxtClave, "La clave"))
                return;

            var Valido = _seguridadServ.ValidarUsuario(TxtUsuario.Text, TxtClave.Text);

            if (Valido)
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();

                this.Hide(); // Oculta el formulario de login, pero no lo cierra completamente
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUsuario.Focus();
            }

        }

        private bool ValidarCampo(TextBox textBox, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"{nombreCampo} es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void LinkRegistrese_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistrese frmRegistrese = new FrmRegistrese();
            frmRegistrese.ShowDialog();
        }
    }
}
