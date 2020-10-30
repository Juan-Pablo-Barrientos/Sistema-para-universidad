using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{

    public class MateriaLogic : BusinessLogic
    {
        private Data.Database.MateriaAdapter _MateriaData;
        public MateriaAdapter MateriaData { get => _MateriaData; set => _MateriaData = value; }


        //Metodos
        public MateriaLogic()
        {
            MateriaData = new Data.Database.MateriaAdapter();
        }

        public List<Materia> GetAll()
        {
            return MateriaData.GetAll();
        }
        public Business.Entities.Materia getOne(int ID)
        {
            return MateriaData.GetOne(ID);
        }

        public void Delete(int ID)
        {
            MateriaData.Delete(ID);
        }
        public void Save(Business.Entities.Materia Materia)
        {
            MateriaData.Save(Materia);
        }
        public static bool isDeleteValid(int idMateriaActual)
        {           
            List<Curso> Cursos = new CursosLogic().GetAll();
            foreach (var c in Cursos)
            {                
              if (c.IDMateria == idMateriaActual) return false;         
            }
            return true;
        }

    }
}

