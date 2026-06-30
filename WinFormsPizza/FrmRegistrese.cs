using Servicios.Implementaciones;
using Servicios.Interfaces;
using Servicios.Validators;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace WinFormsPizza
{
    public partial class FrmRegistrese : Form
    {
        private readonly ISeguridadService _seguridadServ;
        private readonly ValidadorEmail _validadorEmail;
        public FrmRegistrese()
        {
            InitializeComponent();
            _seguridadServ = new SeguridadService();
            _validadorEmail = new ValidadorEmail();
        }

        private void EviarClaveCorreo(string claveTemporal)
        {
                  // Configuración para Gmail
            var correo = new SmtpMailService(
                smtpServidor: ConfigurationManager.AppSettings["SmtpServidor"],
                smtpPuerto: int.Parse(ConfigurationManager.AppSettings["Puerto"]),
                usuario: ConfigurationManager.AppSettings["Usuario"],
                contrasena: ConfigurationManager.AppSettings["Contrasena"],
                usarSsl: bool.Parse(ConfigurationManager.AppSettings["UsarSsl"])
            );

            bool enviado = correo.Enviar(
                destinatario: "vcordero@iiconcepcion.edu.ar",
                asunto: "Clave Temporal",
                cuerpo: "Estimado usuario,\n\nLe enviamos su clave temporal. La misma es: " + claveTemporal +"\n\nSaludos."
            );

            if (enviado)
                MessageBox.Show("✅ Correo enviado correctamente.");
            else
                MessageBox.Show("❌ Falló el envío.");
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Validaciones

            var resultadoEmail = _validadorEmail.Validar(TxtCorreo.Text);
            if (resultadoEmail.EsValido == false)
            {
                MessageBox.Show(resultadoEmail.Mensaje,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            string ClaveTemporal = _seguridadServ.GenerarClaveTemporal();
            //Validar campos
            var NuevoUsuario = new Entidades.Usuario
            {
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                Correo = TxtCorreo.Text,
                Clave = ClaveTemporal,
                CambiarClave = 1
            };

            //Guardar en la base de datos
            var ResultAlta = _seguridadServ.AltaUsuario(NuevoUsuario);

            if (ResultAlta != null)
            {
                MessageBox.Show(ResultAlta,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                TxtCorreo.Focus();
            }
            else
            {
                //Mientras que implementamos el envio de correo, mostramos la clave en un mensaje
                //MessageBox.Show($"Anote su clave temporal");
                //TxtTemporal.Text = ClaveTemporal;
                EviarClaveCorreo(ClaveTemporal);

            }
        }
    }
}
