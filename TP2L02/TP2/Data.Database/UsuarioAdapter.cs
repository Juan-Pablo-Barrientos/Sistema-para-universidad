using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

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
            try
            {
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
                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.EMail = (string)drUsuarios["email"];
                    if ((string)drUsuarios["tipo_usuario"] == "Alumno")
                    {
                        usr.TiposUsuario = Usuario.TipoUsuario.Alumno;
                    }
                    else
                    {
                        usr.TiposUsuario = Usuario.TipoUsuario.Docente;
                    }
                    usr.legajo = (string)drUsuarios["legajo"];
                    usr.fecha_nac = (DateTime)drUsuarios["fecha_nac"];
                    usr.telefono = (string)drUsuarios["telefono"];
                    usr.direccion = (string)drUsuarios["direccion"];
                    
                        
                    //agregamos el objeto con datos a la lista que devolveremos
                    usuarios.Add(usr);
                }

                //cerramos el DataReader y la conexion a la BD
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de usuarios", Ex);
                throw ExcepcionManejada;
            }
            finally { 
            this.CloseConnection();
                    }
            //devolvemos el objeto
            return usuarios;

        }
              
            

        public Business.Entities.Usuario GetOne(int ID)
        {
            Usuario usr = new Usuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("select * from usuarios where id_usuario=@id", sqlConn);
                cmdUsuarios.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                if (drUsuarios.Read())
                {
                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.EMail = (string)drUsuarios["email"];
                    if ((string)drUsuarios["tipo_usuario"] == "Alumno")
                    {
                        usr.TiposUsuario = Usuario.TipoUsuario.Alumno;
                    }
                    else
                    {
                        usr.TiposUsuario = Usuario.TipoUsuario.Docente;
                    }
                    usr.legajo = (string)drUsuarios["legajo"];
                    usr.fecha_nac = (DateTime)drUsuarios["fecha_nac"];
                    usr.telefono = (string)drUsuarios["telefono"];
                    usr.direccion = (string)drUsuarios["direccion"];


                }
                drUsuarios.Close();
            }
         catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar usuario", Ex);
                throw ExcepcionManejada;
            
            }
            finally
            {
                this.CloseConnection();
            }
            return usr;

         

        }

        public Business.Entities.Usuario GetOneNombre(string nombreusr)
        {
            Usuario usr = new Usuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("select * from usuarios where nombre_usuario=@nombre_usuario", sqlConn);
                cmdUsuarios.Parameters.Add("@nombre_usuario", SqlDbType.VarChar).Value = nombreusr;
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                if (drUsuarios.Read())
                {
                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.EMail = (string)drUsuarios["email"];
                    if ((string)drUsuarios["tipo_usuario"] == "Alumno")
                    {
                        usr.TiposUsuario = Usuario.TipoUsuario.Alumno;
                    }
                    else
                    {
                        usr.TiposUsuario = Usuario.TipoUsuario.Docente;
                    }
                    usr.legajo = (string)drUsuarios["legajo"];
                    usr.fecha_nac = (DateTime)drUsuarios["fecha_nac"];
                    usr.telefono = (string)drUsuarios["telefono"];
                    usr.direccion = (string)drUsuarios["direccion"];

                }
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("No se pudo recuperar el usuario", Ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }
            return usr;



        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                //creamos la sentencia sql y asignamos un valor al parametro
                SqlCommand cmdDelete =
                    new SqlCommand("delete usuarios where id_usuario=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                //ejecutamos la sentencia sql
                cmdDelete.ExecuteNonQuery();
            }
      
         catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar usuario", Ex);
                throw ExcepcionManejada;
            
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Update(Usuario usuario)

        {

            try
            {

                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "UPDATE usuarios SET nombre_usuario = @nombre_usuario, clave = @clave, " +
                "habilitado = @habilitado, nombre = @nombre, apellido = @apellido, email = @email " +
                "tipo_usuario = @tipo_usuario, legajo = @legajo, fecha_nac = @fecha_nac, telefono = @telefono " +
                "direccion = @direccion " +
                "WHERE id_usuario = @id", sqlConn);
            

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = usuario.ID;
                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.VarChar, 50).Value = usuario.Habilitado;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.EMail;
                cmdSave.Parameters.Add("@tipo_usuario", SqlDbType.VarChar, 50).Value = (usuario.TiposUsuario).ToString();
                cmdSave.Parameters.Add("@legajo", SqlDbType.VarChar, 50).Value = usuario.legajo;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.VarChar, 50).Value = usuario.fecha_nac;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = usuario.telefono;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = usuario.direccion;
                cmdSave.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {

                Exception ExcepcionManejada =
                new Exception("Error al modificar datos del usuario", Ex);

                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }
        }


        protected void Insert(Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "INSERT into usuarios(nombre_usuario,clave,habilitado,nombre,apellido,email)" +
                "values(@nombre_usuario, @clave, @habilitado, @nombre, @apellido, @email) " +
                "tipo_usuario = @tipo_usuario, legajo = @legajo, fecha_nac = @fecha_nac, telefono = @telefono " +
                "direccion = @direccion " +
                "select @@identity", //esta linea es para recuperar el ID que asigno el sql automaticamente
                sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = usuario.ID;
                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.VarChar, 50).Value = usuario.Habilitado;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.EMail;
                cmdSave.Parameters.Add("@tipo_usuario", SqlDbType.VarChar, 50).Value = (usuario.TiposUsuario).ToString();
                cmdSave.Parameters.Add("@legajo", SqlDbType.VarChar, 50).Value = usuario.legajo;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.VarChar, 50).Value = usuario.fecha_nac;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = usuario.telefono;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = usuario.direccion;
                usuario.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
                //asi se obtiene el ID que asigno al BD automaticamente
            }

            catch (Exception Ex)
            {

                Exception ExcepcionManejada =
                    new Exception("Error al modificar datos del usuario", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.States.New)
            {

                this.Insert(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Deleted)
            {
                this.Delete(usuario.ID);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                this.Update(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified;            
        }
    }
}
