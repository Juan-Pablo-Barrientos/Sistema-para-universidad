using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.entities;

namespace Business.Logic
{
    public class ValidarEspecialidad
    {
        static public Validador Validar(Especialidad EspecialidadActual)
        {
            Validador validador = new Validador();
            if (!SonCamposValidos(EspecialidadActual)) validador.AgregarError("No todos los campos estan completos");
            return validador;
        }
        static private bool SonCamposValidos(Especialidad EspecialidadActual)
        {
            return (EspecialidadActual.Descripcion != String.Empty);
        }
    }
}
