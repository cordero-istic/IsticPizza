using Entidades;
using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Servicios.Implementaciones
{
    public class SeguridadService : ISeguridadService
    {
        public Usuario ValidarUsuario(string usuario)
        {
            using (var context = new IsticPizzaContext())
            {
                return context.Usuarios.FirstOrDefault(u => u.Correo == usuario);
            }
        }

        public void CambiarClave(string usuario, string claveActual, string nuevaClave)
        {
            using (var context = new IsticPizzaContext())
            {
                string claveActualEncriptada = EncriptarClave(claveActual);
                var user = context.Usuarios.FirstOrDefault(u => u.Correo == usuario && u.Clave == claveActualEncriptada);
                if (user != null)
                {
                    user.Clave = EncriptarClave(nuevaClave);
                    user.CambiarClave = 0;
                    context.SaveChanges();
                }
            }
        }

        public bool ValidarCorreo(string correo)
        {
            // Implementación del método
            return true;
        }

        public void AltaUsuario(Usuario usuario)
        {
            try
            {
                using (var context = new IsticPizzaContext())
                {
                    usuario.Clave = EncriptarClave(usuario.Clave);
                    context.Usuarios.Add(usuario);
                    context.SaveChanges();
                }
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException?.Message.Contains("UNIQUE") == true)
                {
                    throw new Exception("El correo ya está registrado");
                }
                throw;
            }
        }

        public string GenerarClaveTemporal()
        {
            string ClaveTemporal = Guid.NewGuid().ToString().Substring(0, 8);
            return ClaveTemporal;
        }

        public string EncriptarClave(string clave)
        {
            byte[] key = Encoding.UTF8.GetBytes("IsticPizza123456");
            byte[] iv = new byte[16];
            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                byte[] encrypted = encryptor.TransformFinalBlock(Encoding.UTF8.GetBytes(clave), 0, clave.Length);
                return Convert.ToBase64String(encrypted);
            }
        }

        public string DesencriptarClave(string claveEncriptada)
        {
            byte[] key = Encoding.UTF8.GetBytes("IsticPizza123456");
            byte[] iv = new byte[16];
            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                byte[] buffer = Convert.FromBase64String(claveEncriptada);
                byte[] decrypted = decryptor.TransformFinalBlock(buffer, 0, buffer.Length);
                return Encoding.UTF8.GetString(decrypted);
            }
        }

    }
}