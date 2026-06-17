using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Servicios.Validators;
public class ValidadorContrasena
{
    // Contraseñas más comunes (en producción usa una lista de miles o una API)
    private static readonly HashSet<string> ContrasenasComunes = new(StringComparer.OrdinalIgnoreCase)
    {
        "123456", "password", "12345678", "qwerty", "123456789", "12345", "1234",
        "111111", "1234567", "dragon", "123123", "baseball", "abc123", "football",
        "monkey", "letmein", "shadow", "master", "666666", "qwertyuiop", "123321",
        "mustang", "1234567890", "michael", "654321", "superman", "1qaz2wsx",
        "7777777", "121212", "000000", "qazwsx", "123qwe", "killer", "trustno1",
        "jordan", "jennifer", "zxcvbnm", "asdfgh", "hunter", "buster", "soccer",
        "harley", "batman", "andrew", "tigger", "sunshine", "iloveyou", "2000",
        "charlie", "robert", "thomas", "hockey", "ranger", "daniel", "starwars",
        "klaster", "112233", "george", "computer", "michelle", "jessica", "pepper",
        "1111", "zxcvbn", "555555", "11111111", "131313", "freedom", "777777",
        "pass", "maggie", "159753", "aaaaaa", "ginger", "princess", "joshua",
        "cheese", "amanda", "summer", "love", "ashley", "nicole", "chelsea",
        "biteme", "matthew", "access", "yankees", "987654321", "dallas", "austin",
        "thunder", "taylor", "matrix"
    };

    // Patrones de teclado (filas adyacentes)
    private static readonly string[] PatronesTeclado = {
        "qwerty", "qwertz", "azerty", "asdf", "zxcv", "qwer", "asdfgh",
        "zxcvbn", "1qaz", "2wsx", "3edc", "4rfv", "5tgb", "6yhn", "7ujm",
        "1q2w", "1q2w3e", "qazwsx", "wasd", "!@#$", "!@#$%"
    };

    // Configuración de políticas (ajústalas según tus necesidades)
    public int LongitudMinima { get; set; } = 12;
    public int LongitudMaxima { get; set; } = 128;
    public bool RequiereMayuscula { get; set; } = true;
    public bool RequiereMinuscula { get; set; } = true;
    public bool RequiereNumero { get; set; } = true;
    public bool RequiereEspecial { get; set; } = true;
    public int MaxCaracteresRepetidos { get; set; } = 3; // Ej: "aaa" no permitido

    public (bool EsValida, List<string> Errores) Validar(string contrasena, string nombreUsuario = null)
    {
        var errores = new List<string>();

        // PASO 1: ¿Está vacía?
        if (string.IsNullOrEmpty(contrasena))
        {
            errores.Add("La contraseña es obligatoria");
            return (false, errores);
        }

        // PASO 2: Longitud
        if (contrasena.Length < LongitudMinima)
            errores.Add($"Debe tener al menos {LongitudMinima} caracteres (actual: {contrasena.Length})");

        if (contrasena.Length > LongitudMaxima)
            errores.Add($"No puede superar {LongitudMaxima} caracteres");

        // PASO 3: Complejidad (solo si la longitud es válida)
        if (contrasena.Length >= LongitudMinima)
        {
            if (RequiereMayuscula && !Regex.IsMatch(contrasena, "[A-Z]"))
                errores.Add("Debe contener al menos una letra mayúscula");

            if (RequiereMinuscula && !Regex.IsMatch(contrasena, "[a-z]"))
                errores.Add("Debe contener al menos una letra minúscula");

            if (RequiereNumero && !Regex.IsMatch(contrasena, "[0-9]"))
                errores.Add("Debe contener al menos un número");

            if (RequiereEspecial && !Regex.IsMatch(contrasena, "[^A-Za-z0-9]"))
                errores.Add("Debe contener al menos un carácter especial (!@#$%^&*...)");
        }

        // PASO 4: ¿Está en la lista de contraseñas comunes?
        if (ContrasenasComunes.Contains(contrasena))
            errores.Add("Esta contraseña es demasiado común y fácil de adivinar");

        // PASO 5: ¿Contiene el nombre de usuario?
        if (!string.IsNullOrWhiteSpace(nombreUsuario))
        {
            var usuario = nombreUsuario.ToLower().Trim();
            var pass = contrasena.ToLower();

            if (usuario.Length >= 3 && pass.Contains(usuario))
                errores.Add("La contraseña no puede contener tu nombre de usuario");
        }

        // PASO 6: ¿Tiene patrones de teclado? (qwerty, asdf, etc.)
        var passLower = contrasena.ToLower();
        foreach (var patron in PatronesTeclado)
        {
            if (passLower.Contains(patron))
            {
                errores.Add($"Contiene un patrón de teclado común ({patron})");
                break;
            }
        }

        // PASO 7: ¿Tiene secuencias numéricas o alfabéticas? (1234, abcd)
        if (TieneSecuencia(contrasena, 4))
            errores.Add("Contiene secuencias obvias (1234, abcd, etc.)");

        // PASO 8: ¿Tiene muchos caracteres repetidos? (aaa, 111)
        if (TieneCaracteresRepetidos(contrasena, MaxCaracteresRepetidos))
            errores.Add($"Tiene {MaxCaracteresRepetidos} o más caracteres iguales consecutivos");

        // PASO 9: ¿Tiene espacios al inicio o final?
        if (contrasena != contrasena.Trim())
            errores.Add("No debe tener espacios al inicio o final");

        // PASO 10: ¿Es solo un carácter repetido? (aaaaaaaa)
        if (contrasena.Distinct().Count() == 1)
            errores.Add("No puede ser un solo carácter repetido");

        return (!errores.Any(), errores);
    }

    // Detecta secuencias como "abcd", "1234", "dcba", "4321"
    private bool TieneSecuencia(string texto, int longitudMinima)
    {
        for (int i = 0; i <= texto.Length - longitudMinima; i++)
        {
            bool ascendente = true;
            bool descendente = true;

            for (int j = 1; j < longitudMinima; j++)
            {
                if (texto[i + j] != texto[i + j - 1] + 1)
                    ascendente = false;
                if (texto[i + j] != texto[i + j - 1] - 1)
                    descendente = false;
            }

            if (ascendente || descendente)
                return true;
        }
        return false;
    }

    // Detecta caracteres repetidos consecutivamente
    private bool TieneCaracteresRepetidos(string texto, int maximo)
    {
        int contador = 1;
        for (int i = 1; i < texto.Length; i++)
        {
            if (texto[i] == texto[i - 1])
            {
                contador++;
                if (contador >= maximo)
                    return true;
            }
            else
            {
                contador = 1;
            }
        }
        return false;
    }
}