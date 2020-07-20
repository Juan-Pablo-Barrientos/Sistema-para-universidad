using Business.Entities;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Util.entities;

namespace Business.Logic
{
    public class ValidarUsuario
    {
        //Exprecion regular
       private const string EmailRegex = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
       //Esta clase recibe un Usuario y se encarga de validar si los datos ingresados son validos para guardarlo.
       static public Validador Validar(Usuario UsuarioActual,string confirmar)
        {
            var validador = new Validador();
            if (!EsMailValido(UsuarioActual.EMail)) validador.AgregarError("Email invalido");
            if (!EsContraseñaValida(UsuarioActual.Clave, confirmar)) validador.AgregarError("Contraseña invalida");
            if (!SonCamposValidos(UsuarioActual)) validador.AgregarError("No todos los campos estan completos");
            return validador;
        }

        static private bool SonCamposValidos(Usuario UsuarioActual)
        {
            return (
            UsuarioActual.Nombre != String.Empty &
            UsuarioActual.Apellido != String.Empty &
            UsuarioActual.NombreUsuario != String.Empty &
            UsuarioActual.Clave != String.Empty
            );
        }

        static private bool EsContraseñaValida(string contraseña, string confirmar)
        {
            return (contraseña.Length > 8) && (contraseña == confirmar);
        }

        static private bool EsMailValido(string Email)
        {
            return Regex.IsMatch(Email, EmailRegex);
        }

    }
}
