using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class UsuarioAdapter:Adapter
    {
        #region DatosEnMemoria
        // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
        private static List<Usuario> _Usuarios;

        private static List<Usuario> Usuarios
        {
            get
            {
                if (_Usuarios == null)
                {
                    _Usuarios = new List<Business.Entities.Usuario>();
                    Business.Entities.Usuario usr;
                    usr = new Business.Entities.Usuario();
                    usr.ID = 1;
                    usr.State = Business.Entities.BusinessEntity.States.Unmodified;
                    usr.Nombre = "Casimiro";
                    usr.Apellido = "Cegado";
                    usr.NombreUsuario = "casicegado";
                    usr.Clave = "miroooooo";
                    usr.EMail = "casimirocegado@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                    usr = new Business.Entities.Usuario();
                    usr.ID = 2;
                    usr.State = Business.Entities.BusinessEntity.States.Unmodified;
                    usr.Nombre = "Armando Esteban";
                    usr.Apellido = "Quito";
                    usr.NombreUsuario = "aequito";
                    usr.Clave = "carpintero";
                    usr.EMail = "armandoquito@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                    usr = new Business.Entities.Usuario();
                    usr.ID = 3;
                    usr.State = Business.Entities.BusinessEntity.States.Unmodified;
                    usr.Nombre = "Alan";
                    usr.Apellido = "Brado";
                    usr.NombreUsuario = "alanbrado";
                    usr.Clave = "abrete sesamo";
                    usr.EMail = "alanbrado@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                }
                return _Usuarios;
            }
        }
        #endregion

        public List<Usuario> GetAll()
        {
            //return new List<Usuario>(Usuarios);

            //instanciamos el objeto lista a retornar
            List<Usuario> usuarios = new List<Usuario>();

            //abrimos la conexion a la base de datos con el metodo que creamos antes
            this.OpenConnection();

            /*
             * creamos un objeto SqlCommand que sera la sentencia Sql
             * que vamos a ejecutar contra la base de datos
             * (los datos de la BD usuario, contraseña, servidor, etc.
             * estan en el connection strin)
             */

            SqlCommand cmdUsuarios = new SqlCommand("select * from usuarios", sqlConn);

            /*
             * instanciamos un objeto DataReader que sera
             * el que recuperara los datos de la BD
             */
            SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

            /*
             * Read() lee una fila de las devueltas por el comando sql
             * carga los datos en drUsuarios para poder accederlos,
             * devuelve verdadero mientras haya podido leer datos y 
             * avanza a la fila siguiente para el proximo read
             */
            while (drUsuarios.Read())
            {
                /*creamos un objeto Usuario de la capa de entidades para 
                 * copiar los datos de la fila del DataReader al objeto de
                 * entidades
                 */

                Usuario usr = new Usuario();

                //ahora copiamos los datos de la fila al objeto
                usr.ID = (int) drUsuarios["id_usuario"];
                usr.NombreUsuario = (string) drUsuarios["nombre_usuario"];
                usr.Clave = (string) drUsuarios["clave"];
                usr.Habilitado = (bool) drUsuarios["habilitado"];
                usr.Nombre = (string) drUsuarios["nombre"];
                usr.Apellido = (string) drUsuarios["Apellido"];
                usr.EMail = (string) drUsuarios["email"];
                //agregamos el objeto con datos a la lista que devolveremos
                usuarios.Add(usr);
            }

            //cerramos el DataReader y la conexion a la BD
            drUsuarios.Close();
            this.CloseConnection();

            //devolvemos el objeto
            return usuarios;

        }
              
            
            
        
        
        
     

        public Business.Entities.Usuario GetOne(int ID)
        {
            return Usuarios.Find(delegate(Usuario u) { return u.ID == ID; });
        }

        public void Delete(int ID)
        {
            Usuarios.Remove(this.GetOne(ID));
        }

        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.States.New)
            {
                int NextID = 0;
                foreach (Usuario usr in Usuarios)
                {
                    if (usr.ID > NextID)
                    {
                        NextID = usr.ID;
                    }
                }
                usuario.ID = NextID + 1;
                Usuarios.Add(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Deleted)
            {
                this.Delete(usuario.ID);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                Usuarios[Usuarios.FindIndex(delegate(Usuario u) { return u.ID == usuario.ID; })]=usuario;
            }
            usuario.State = BusinessEntity.States.Unmodified;            
        }
    }
}
