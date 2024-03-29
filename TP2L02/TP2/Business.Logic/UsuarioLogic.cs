﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;


namespace Business.Logic
{

    public class UsuarioLogic : BusinessLogic
    {
        private Data.Database.UsuarioAdapter _UsuarioData;
        public UsuarioAdapter UsuarioData { get => _UsuarioData; set => _UsuarioData = value; }


        //Metodos
        public UsuarioLogic()
        {
            UsuarioData = new Data.Database.UsuarioAdapter();
        }

        public List<Usuario> GetAll()
        {
         return UsuarioData.GetAll();
        }
        public Business.Entities.Usuario getOne(int ID)
        { 
            return UsuarioData.GetOne(ID); 
        }
        public Business.Entities.Usuario getOneNombre(string nombreusr)
        {
            return UsuarioData.GetOneNombre(nombreusr);
        }

        public void Delete(int ID)
        {
            UsuarioData.Delete(ID);
        }
        public void Save(Business.Entities.Usuario Usuario)
        {
            UsuarioData.Save(Usuario);
        }
        static public bool EsContraseñaValida(string contraseña, string confirmar)
        {
            return (contraseña.Length > 8) && (contraseña == confirmar);
        }
        public static bool isDeleteValid(int idUsuarioActual)
        {
            List<DocenteCurso> Doc = new DocCurLogic().GetAll();
            List<AlumnosIncripcion> Alm = new AlumInsLogic().GetAll();
            foreach (var a in Alm)
            {
                foreach (var c in Doc)
                {
                    if (a.IDAlumno == idUsuarioActual || c.IDDocente == idUsuarioActual) return false;
                }
            }
            return true;
        }
        public void BorrarInscripciones(int ID)
        {
            Usuario us = this.getOne(ID);
            if (us.TiposUsuario.ToString() == "Docente")
            {          
            DocCurLogic dcl = new DocCurLogic();
            dcl.DeleteAll(ID); 
            }
            if (us.TiposUsuario.ToString() == "Alumno")
            {
                AlumInsLogic ail = new AlumInsLogic();
                ail.DeleteAll(ID);
            }
        }
    }
}
