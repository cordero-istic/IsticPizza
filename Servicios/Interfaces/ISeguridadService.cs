using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    public interface ISeguridadService
    {
        string GenerarClaveTemporal();
        bool ValidarUsuario(string usuario, string clave);
        void CambiarClave(string usuario, string claveActual, string nuevaClave);
        bool ValidarCorreo(string correo);
        void AltaUsuario(Usuario usuario);
    }
}
