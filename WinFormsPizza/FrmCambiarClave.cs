using Entidades;
using Servicios.Implementaciones;
using Servicios.Interfaces;
using Servicios.Validators;
using System.ComponentModel.DataAnnotations;

namespace WinFormsPizza
{
    public partial class FrmCambiarClave : Form
    {
        private readonly ISeguridadService _seguridadServ;
        private readonly ValidadorContrasena _validadorContrasena;

        public FrmCambiarClave(Usuario usuario)
        {
            InitializeComponent();
            _seguridadServ = new SeguridadService();
            _validadorContrasena = new ValidadorContrasena();
            TxtCorreo.Text = usuario.Correo;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Validaciones
            string mensajeErrores = string.Empty;
            var resultadoClave = _validadorContrasena.Validar(TxtNueva.Text, TxtCorreo.Text);

            if (resultadoClave.EsValida == false)
            {
                mensajeErrores = string.Join("\n", resultadoClave.Errores);
                MessageBox.Show(mensajeErrores,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
            _seguridadServ.CambiarClave(TxtCorreo.Text, TxtAnterior.Text, TxtNueva.Text);
            MessageBox.Show("Clave cambiada exitosamente");
            this.Close();

        }
    }
}
