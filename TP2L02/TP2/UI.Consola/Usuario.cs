using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using Business.Entities;

namespace UI.Consola
{
    public class Usuario
    {
        private Business.Logic.UsuarioLogic _UsuarioNegocio;
        public UsuarioLogic UsuarioNegocio { get => _UsuarioNegocio; set => _UsuarioNegocio = value; }
        public Usuario()
        {
            this.UsuarioNegocio = null;
        }
        public void Menu()
        {
            int op = 0;
            while (op != 6)
            {
                Console.WriteLine("1– Listado General");
                Console.WriteLine("2– Consulta");
                Console.WriteLine("3– Agregar");
                Console.WriteLine("4 - Modificar");
                Console.WriteLine("5 - Eliminar");
                Console.WriteLine("6 - Salir");
            
            
            }




        }
    
    
    }
}
