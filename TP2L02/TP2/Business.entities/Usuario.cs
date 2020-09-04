using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {

        private string _NombreUsuario;
        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }
        private string _Clave;
        public string Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Apellido;
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        private string _EMail;
        public string EMail
        {
            get { return _EMail; }
            set { _EMail = value; }
        }
        private bool _Habilitado;
        public bool Habilitado
        {
            get { return _Habilitado; }
            set { _Habilitado = value; }
        }

        public enum TipoUsuario
        {
            Alumno,
            Docente

        }

        private TipoUsuario _TiposUsuario;
        public TipoUsuario TiposUsuario
        {
            get { return _TiposUsuario; }
            set { _TiposUsuario = value; }
        }

        private string _legajo;
        public string legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

        private DateTime _fecha_nac;
        public DateTime fecha_nac
        {
            get { return _fecha_nac; }
            set { _fecha_nac = value; }
        }

        private string _telefono;
        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private string _direccion;
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

    }
}
