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
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            /*
            if (TxtUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("El usuario es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUsuario.Focus();
                return;
            }

            if (TxtClave.Text == string.Empty)
            {
                MessageBox.Show("La clave es requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtClave.Focus();
                return;
            }
            */

            // En BtnIngresar_Click:
            if (!ValidarCampo(TxtUsuario, "El usuario") || !ValidarCampo(TxtClave, "La clave"))
                return;


            if (TxtUsuario.Text == "Admin" && TxtClave.Text == "123456")
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

    }
}
