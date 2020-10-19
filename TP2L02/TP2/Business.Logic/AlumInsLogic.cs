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

        public List<AlumnosIncripcion> GetMisCursos(int id)
        {
            return AlumInData.GetMisCursos(id);
        }
        public List<AlumnosIncripcion> GetAlumnosPorCurso(int id)
        {
            return AlumInData.GetAlumnosPorCurso(id);
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

        public static bool isInscripcionValid(string stringusario, string stringcurso)
        {
            List<AlumnosIncripcion> Inscripciones = new AlumInsLogic().GetAll();
            List<Usuario> Usuarios = new UsuarioLogic().GetAll();
            List<Curso> Cursos = new CursosLogic().GetAll();
            foreach (var u in Usuarios.Where(u => u.NombreUsuario == stringusario))
            {
                foreach (var c in Cursos.Where(c => c.Descripcion == stringcurso))
                {
                    foreach (var i in Inscripciones.Where(i => i.IDAlumno == u.ID))
                    {
                        if (i.IDCurso == c.ID) return false;
                    }
                }
            }
            return true;           
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
