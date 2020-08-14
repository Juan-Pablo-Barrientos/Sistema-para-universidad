using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class AlumnosIncripcion : BusinessEntity
    {
        
        public enum Condicion
        {
            Inscripto,
            Regular,
            Libre,
            Aprobado
        }
        private int _IDAlumno;
        public int IDAlumno
        {
            get { return _IDAlumno; }
            set { _IDAlumno = value; }
        }
        private int _IDCurso;
        public int IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }
        private int _Nota;
        public int Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }

        private Condicion _Cond;
        public Condicion Cond
        {
            get { return _Cond; }
            set { _Cond = value; }
        }







    }
}
