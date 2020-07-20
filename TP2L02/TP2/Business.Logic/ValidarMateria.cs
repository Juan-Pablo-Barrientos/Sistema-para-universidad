using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util.entities;

namespace Business.Logic
{
    public class ValidarMateria
  {
    static public Validador Validar(Materia MateriaActual)
    {
         Validador validador = new Validador();
         if (!SonCamposValidos(MateriaActual)) validador.AgregarError("No todos los campos estan completos");
         return validador;
    }
    static private bool SonCamposValidos(Materia MateriaActual)
    {
        return (
        MateriaActual.HSSemanales != 0 &
        MateriaActual.HSTotales != 0 &
        MateriaActual.Descripcion != String.Empty       
        );   
    }
  }
}



