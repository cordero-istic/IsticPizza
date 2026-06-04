using Servicios.Implementaciones;
using Servicios.Interfaces;

namespace WinFormsPizza
{
    public partial class FrmRegistrese : Form
    {
        private readonly ISeguridadService _seguridadServ;
        public FrmRegistrese()
        {
            InitializeComponent();
            _seguridadServ = new SeguridadService();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Validar campos
            var NuevoUsuario = new Entidades.Usuario
            {
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                Correo = TxtCorreo.Text,
                Clave = _seguridadServ.GenerarClaveTemporal(),
                CambiarClave = true
            };

            //Guardar en la base de datos
            _seguridadServ.AltaUsuario(NuevoUsuario);

            //Mientras que implementamos el envio de correo, mostramos la clave en un mensaje
            MessageBox.Show($"Su clave temporal es: {NuevoUsuario.Clave}, anotalaaaaa");
            this.Close();
        }
    }
}
