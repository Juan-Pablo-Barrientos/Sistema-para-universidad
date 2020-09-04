using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business.Logic
{
    public class BusinessLogic
    {
        private const string EmailRegex = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";//Regular expression, Email
        static public void  Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)      
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        static public bool SonCamposValidos(List<string> c)
        {
            foreach (string item in c)
            {
                if (String.IsNullOrEmpty(item)) return false;            
            }
            return true;
        }
        static public bool EsMailValido(string Email)
        {
             return Regex.IsMatch(Email, EmailRegex);
        }
        
    }
    public static class StringExt
    {
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
    }
}
