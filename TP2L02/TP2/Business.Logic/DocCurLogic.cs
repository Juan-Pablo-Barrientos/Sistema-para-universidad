using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;


namespace Business.Logic
{

    public class DocCursLogic : BusinessLogic
    {
        private Data.Database.DocCurAdapter _DocCurData;
        public DocCurAdapter DocCurData { get => _DocCurData; set => _DocCurData = value; }


        //Metodos
        public DocCursLogic()
        {
            DocCurData = new Data.Database.DocCurAdapter();
        }

        public List<DocenteCurso> GetAll()
        {
            return DocCurData.GetAll();
        }
        public Business.Entities.DocenteCurso getOne(int ID)
        {
            return DocCurData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            DocCurData.Delete(ID);
        }
        public void Save(Business.Entities.DocenteCurso docCur)
        {
            DocCurData.Save(docCur);
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
