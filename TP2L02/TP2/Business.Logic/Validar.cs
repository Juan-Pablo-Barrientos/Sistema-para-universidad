using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
   public class Validar
    {
        static public bool  EsMailValido(string mail)
        {
            //Buscar reg expresion  ( validacion de texto)
            if (!((mail.Contains("@")) && (mail.Contains(".com"))))
            {              
                return false;
            }
            return true;
        }

    }
}
