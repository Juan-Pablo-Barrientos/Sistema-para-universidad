using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;


namespace Business.Logic
{

    public class EspecialidadesLogic : BusinessLogic
    {
        private Data.Database.EspecialidadAdapter _EspecialidadData;
        public EspecialidadAdapter EspecialidadData { get => _EspecialidadData; set => _EspecialidadData = value; }


        //Metodos
        public EspecialidadesLogic()
        {
            EspecialidadData = new Data.Database.EspecialidadAdapter();
        }

        public List<Especialidad> GetAll()
        {
            return EspecialidadData.GetAll();
        }
        public Business.Entities.Especialidad getOne(int ID)
        {
            return EspecialidadData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            EspecialidadData.Delete(ID);
        }
        public void Save(Business.Entities.Especialidad especialidad)
        {
            EspecialidadData.Save(especialidad);
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
