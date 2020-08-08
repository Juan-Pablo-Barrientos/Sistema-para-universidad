using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.entities;

namespace Business.Logic
{
   public class ValidarModulo
    {
        static public Validador Validar(Modulo ModuloActual)
        {
            Validador validador = new Validador();
            if (!SonCamposValidos(ModuloActual)) validador.AgregarError("No todos los campos estan completos");
            return validador;
        }
        static private bool SonCamposValidos(Modulo ModuloActual)
        {
            return (ModuloActual.Descripcion != String.Empty);
        }
    }
}
