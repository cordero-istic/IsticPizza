using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementaciones
{
    public class SmtpMailService : IMailService
    {
        private readonly string _smtpServidor;
        private readonly int _smtpPuerto;
        private readonly string _usuario;
        private readonly string _contrasena;
        private readonly bool _usarSsl;

        public SmtpMailService(string smtpServidor, int smtpPuerto,
                               string usuario, string contrasena, bool usarSsl = true)
        {
            _smtpServidor = smtpServidor;
            _smtpPuerto = smtpPuerto;
            _usuario = usuario;
            _contrasena = contrasena;
            _usarSsl = usarSsl;
        }

        public bool Enviar(string destinatario, string asunto, string cuerpo)
        {
            try
            {
                using (var mensaje = new MailMessage())
                {
                    mensaje.From = new MailAddress(_usuario);
                    mensaje.To.Add(destinatario);
                    mensaje.Subject = asunto;
                    mensaje.Body = cuerpo;
                    mensaje.IsBodyHtml = false; // Cambia a true si usas HTML

                    using (var clienteSmtp = new SmtpClient(_smtpServidor, _smtpPuerto))
                    {
                        clienteSmtp.EnableSsl = _usarSsl;
                        clienteSmtp.Credentials = new NetworkCredential(_usuario, _contrasena);
                        clienteSmtp.Send(mensaje);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error al enviar correo: {ex.Message}");
                return false;
            }
        }
    }
}
