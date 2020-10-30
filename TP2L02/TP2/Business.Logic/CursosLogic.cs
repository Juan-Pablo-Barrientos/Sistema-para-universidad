using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;
using System.Windows.Forms.VisualStyles;
using System.Runtime.CompilerServices;

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

        public static bool isDeleteValid(int idCursoActual)
        {
            List<DocenteCurso> Doc = new DocCurLogic().GetAll();
            List<AlumnosIncripcion> Alm = new AlumInsLogic().GetAll();
            foreach (var a in Alm)
            {
                foreach (var c in Doc)
                {
                    if (a.IDCurso == idCursoActual || c.IDCurso == idCursoActual) return false;
                }
            }
            return true;
        }

        public static bool IsCursoFull(string stringcurso)
        {         
            List<Curso> Cursos = new CursosLogic().GetAll();
            foreach (var c in Cursos.Where(c => c.Descripcion == stringcurso))
            {                                                
            Curso Cur = new CursosLogic().getOne(c.ID);
            List<AlumnosIncripcion> Inscripciones = new AlumInsLogic().GetAlumnosPorCurso(c.ID);
            return Cur.Cupo == Inscripciones.Count;
            }
            return false;
        }
    }
}
