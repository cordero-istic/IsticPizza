using System;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DnsClient;

namespace Servicios.Validators;
public class ValidadorEmail
{
    // Dominios de correos desechables (temporales)
    private static readonly string[] DominiosDesechables = {
        "mailinator.com", "tempmail.com", "guerrillamail.com",
        "yopmail.com", "10minutemail.com", "throwaway.email"
    };

    // Correos de "rol" (no personales)
    private static readonly string[] CorreosRol = {
        "admin", "info", "support", "sales", "contact",
        "webmaster", "postmaster", "noreply"
    };

    public (bool EsValido, string Mensaje) Validar(string email)
    {
        // PASO 1: ¿Está vacío?
        if (string.IsNullOrWhiteSpace(email))
            return (false, "El correo es obligatorio");

        // Limpiar el email
        email = email.Trim().ToLower();

        // PASO 2: ¿Es muy largo?
        if (email.Length > 254)
            return (false, "El correo es demasiado largo");

        // PASO 3: ¿Tiene formato básico? (algo@algo.algo)
        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            return (false, "El formato no es válido");

        // PASO 4: Validar con la clase de .NET
        try
        {
            var mail = new MailAddress(email);
            if (mail.Address != email)
                return (false, "Formato inválido");
        }
        catch
        {
            return (false, "Formato inválido");
        }

        // PASO 5: Separar las partes
        var partes = email.Split('@');
        var usuario = partes[0];
        var dominio = partes[1];

        // PASO 6: Validar la parte del usuario
        if (usuario.Length > 64)
            return (false, "La parte del usuario es muy larga");

        if (usuario.StartsWith(".") || usuario.EndsWith(".") || usuario.Contains(".."))
            return (false, "Puntos inválidos en el correo");

        // PASO 7: ¿Es un correo desechable?
        if (DominiosDesechables.Contains(dominio))
            return (false, "No aceptamos correos temporales");

        // PASO 8: ¿Es un correo de rol?
        if (CorreosRol.Contains(usuario))
            return (false, "No aceptamos correos genéricos (admin, info, etc)");

        // PASO 9: ¿Existe el dominio? (Consulta DNS)
        try
        {
            var dns = new LookupClient();

            // Buscar registros MX (servidores de correo)
            var resultadoMX = dns.Query(dominio, QueryType.MX);

            // Si no tiene MX, buscar registros A (servidores normales)
            if (!resultadoMX.Answers.MxRecords().Any())
            {
                var resultadoA = dns.Query(dominio, QueryType.A);

                // Si tampoco tiene registros A, el dominio no existe
                if (!resultadoA.Answers.ARecords().Any())
                    return (false, "El dominio no existe");
            }
        }
        catch
        {
            return (false, "No se pudo verificar el dominio");
        }

        // ¡Todo está bien!
        return (true, "Correo válido");
    }
}