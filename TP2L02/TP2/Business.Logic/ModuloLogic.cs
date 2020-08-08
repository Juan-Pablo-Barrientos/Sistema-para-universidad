using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{

    public class ModuloLogic : BusinessLogic
    {
        private Data.Database.ModuloAdapter _ModuloData;
        public ModuloAdapter ModuloData { get => _ModuloData; set => _ModuloData = value; }


        //Metodos
        public ModuloLogic()
        {
            ModuloData = new Data.Database.ModuloAdapter();
        }

        public List<Modulo> GetAll()
        {
            return ModuloData.GetAll();
        }
        public Business.Entities.Modulo getOne(int ID)
        {
            return ModuloData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            ModuloData.Delete(ID);
        }
        public void Save(Business.Entities.Modulo Modulo)
        {
            ModuloData.Save(Modulo);
        }

    }
}

