using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;


namespace Business.Logic
{

    public class CursosLogic : BusinessLogic
    {
        private Data.Database.CursosAdapter _CursosData;
        public CursosAdapter CursosData { get => _CursosData; set => _CursosData = value; }


        //Metodos
        public CursosLogic()
        {
            CursosData = new Data.Database.CursosAdapter();
        }

        public List<Curso> GetAll()
        {
            return CursosData.GetAll();
        }
        public Business.Entities.Curso getOne(int ID)
        {
            return CursosData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            CursosData.Delete(ID);
        }
        public void Save(Business.Entities.Curso curso)
        {
            CursosData.Save(curso);
        }
        public static bool isDeleteValid(int idEspecialidadActual)
        {
            List<Plan> Planes = new PlanLogic().GetAll();
            foreach (var p in Planes)
            {
                return p.IDEspecialidad != idEspecialidadActual;
            }
            return true;
        }

    }
}
