using Entidades;
using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementaciones
{
    public class SeguridadService : ISeguridadService
    {
        private readonly IsticPizzaContext _context;

        public SeguridadService()
        {
            _context = new IsticPizzaContext();
        }

        public bool ValidarUsuario(string usuario, string clave)
        {
            var UserValido = _context.Usuarios.FirstOrDefault(u => u.Correo == usuario && u.Clave == clave);
            return UserValido != null;
        }

        public void CambiarClave(string usuario, string claveActual, string nuevaClave)
        {
            // Implementación del método
        }

        public bool ValidarCorreo(string correo)
        {
            // Implementación del método
            return true;
        }

        public void AltaUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public string GenerarClaveTemporal()
        {
            string ClaveTemporal = Guid.NewGuid().ToString().Substring(0, 8);
            return ClaveTemporal;
        }
    }
}