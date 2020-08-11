using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.entities
{
    //Esta clase se encarga de recopilar los errores que vayan surgiendo en una lista para dsp devolverlos.
     public  class Validador
    {
        private List<string> errores = new List<string>();
        public string Errores 
        {
            get
            {
                return string.Join("\n", errores);   // De esta manera se puede recibir el listado de errores de forma concatenada
            }
        }
        public bool EsValido()   
        {
            return !errores.Any();  // Any() devuelve true si hay algo dentro de errores, el return esta negado ya que sera valido si no hay error
        }
        public void AgregarError(string error) { errores.Add(error); }   //Este metodo agrega errores al listado conforme los recibe por parametro
    }
}
