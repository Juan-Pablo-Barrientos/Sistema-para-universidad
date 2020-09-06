using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;


namespace Business.Logic
{

    public class AlumInsLogic : BusinessLogic
    {
        private Data.Database.AlumInAdapter _AlumInData;
        public AlumInAdapter AlumInData { get => _AlumInData; set => _AlumInData = value; }


        //Metodos
        public AlumInsLogic()
        {
            AlumInData = new Data.Database.AlumInAdapter();
        }

        public List<AlumnosIncripcion> GetAll()
        {
            return AlumInData.GetAll();
        }
        public Business.Entities.AlumnosIncripcion getOne(int ID)
        {
            return AlumInData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            AlumInData.Delete(ID);
        }
        public void Save(Business.Entities.AlumnosIncripcion alumIn)
        {
            AlumInData.Save(alumIn);
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
