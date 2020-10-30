using Business.Entities;
using Data.Database;
using System.Collections.Generic;

namespace Business.Logic
{

    public class ComisionLogic : BusinessLogic
    {
        private Data.Database.ComisionAdapter _ComisionData;
        public ComisionAdapter ComisionData { get => _ComisionData; set => _ComisionData = value; }


        //Metodos
        public ComisionLogic()
        {
            ComisionData = new Data.Database.ComisionAdapter();
        }

        public List<Comision> GetAll()
        {
            return ComisionData.GetAll();
        }
        public Business.Entities.Comision getOne(int ID)
        {
            return ComisionData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            ComisionData.Delete(ID);
        }
        public void Save(Business.Entities.Comision Comision)
        {
            ComisionData.Save(Comision);
        }

        public static bool isDeleteValid(int idComisionActual)
        {
            List<Curso> Cursos = new CursosLogic().GetAll();
            foreach (var c in Cursos)
            {
                if (c.IDComision == idComisionActual) return false;
            }
            return true;
        }


    }

}
