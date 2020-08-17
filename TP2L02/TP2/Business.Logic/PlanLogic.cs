using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Business.Logic
{

    public class PlanLogic : BusinessLogic
    {
        private Data.Database.PlanAdapter _PlanData;
        public PlanAdapter PlanData { get => _PlanData; set => _PlanData = value; }


        //Metodos
        public PlanLogic()
        {
            PlanData = new Data.Database.PlanAdapter();
        }

        public List<Plan> GetAll()
        {
            return PlanData.GetAll();
        }
        public Business.Entities.Plan getOne(int ID)
        {
            return PlanData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            PlanData.Delete(ID);
        }
        public void Save(Business.Entities.Plan Plan)
        {
            PlanData.Save(Plan);
        }

        public static bool isDeleteValid(int idPlanActual)
        {
            List<Materia> Materias = new MateriaLogic().GetAll();
            foreach (var m in Materias)
            {
              return m.IDPlan != idPlanActual;
            }
            return true;
        }
     
    }
}