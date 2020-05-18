using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{

    public class UsuarioLogic : BusinessLogic
    {
        private Data.Database.UsuarioAdapter _UsuarioData;
        public UsuarioAdapter UsuarioData { get => _UsuarioData; set => _UsuarioData = value; }
        
        
        //Metodos
        public UsuarioLogic()
        {
            this.UsuarioData=null;

        }

        public List<Usuario> GetAll()
        {
         return UsuarioData.GetAll();
        }
        public Business.Entities.Usuario getOne(int ID)
        { 
            return UsuarioData.GetOne(ID); 
        }

        public void Delete(int ID)
        {
            UsuarioData.Delete(ID);
        }
        public void Save(Business.Entities.Usuario Usuario)
        {
            UsuarioData.Save(Usuario);
        }
    }
}
