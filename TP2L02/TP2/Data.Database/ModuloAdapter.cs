using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ModuloAdapter : Adapter
    {
        public List<Modulo> GetAll()
        {
            //return new List<Usuario>(Usuarios);

            //instanciamos el objeto lista a retornar
            List<Modulo> modulos = new List<Modulo>();
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

                SqlCommand cmdModulos = new SqlCommand("select * from modulos", sqlConn);

                /*
                 * instanciamos un objeto DataReader que sera
                 * el que recuperara los datos de la BD
                 */
                SqlDataReader drModulos = cmdModulos.ExecuteReader();

                /*
                 * Read() lee una fila de las devueltas por el comando sql
                 * carga los datos en drUsuarios para poder accederlos,
                 * devuelve verdadero mientras haya podido leer datos y 
                 * avanza a la fila siguiente para el proximo read
                 */
                while (drModulos.Read())
                {
                    /*creamos un objeto Usuario de la capa de entidades para 
                     * copiar los datos de la fila del DataReader al objeto de
                     * entidades
                     */

                    Modulo Mod = new Modulo();

                    //ahora copiamos los datos de la fila al objeto
                    Mod.ID = (int)drModulos["id_modulo"];
                    Mod.Descripcion = (string)drModulos["desc_modulo"];
                    //agregamos el objeto con datos a la lista que devolveremos
                    modulos.Add(Mod);
                }

                //cerramos el DataReader y la conexion a la BD
                drModulos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de modulos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            //devolvemos el objeto
            return modulos;
        }
        public Business.Entities.Modulo GetOne(int ID)
        {
            Modulo Mod = new Modulo();
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulos = new SqlCommand("select * from modulos where id_modulo=@id", sqlConn);
                cmdModulos.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drModulos = cmdModulos.ExecuteReader();
                if (drModulos.Read())
                {
                    Mod.ID = (int)drModulos["id_modulo"];
                    Mod.Descripcion = (string)drModulos["desc_modulo"];
                }
                drModulos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar modulo", Ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }
            return Mod;


        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                //creamos la sentencia sql y asignamos un valor al parametro
                SqlCommand cmdDelete =
                    new SqlCommand("delete modulos where id_modulo=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                //ejecutamos la sentencia sql
                cmdDelete.ExecuteNonQuery();
            }


            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar modulo", Ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Update(Modulo modulo)

        {

            //try
           // {

                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "UPDATE modulos SET desc_modulo = @desc_modulo " +
                "WHERE id_modulo = @id", sqlConn);


                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = modulo.ID;
                cmdSave.Parameters.Add("@desc_modulo", SqlDbType.VarChar, 50).Value = modulo.Descripcion;
                cmdSave.ExecuteNonQuery();
           // }

            //catch (Exception Ex)
            //{

            //    Exception ExcepcionManejada =
            //        new Exception("Error al modificar datos del modulo", Ex);
            //    throw ExcepcionManejada;
            //}

            //finally
            //{
            //    this.CloseConnection();
            //}
        }


        protected void Insert(Modulo modulo)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "insert into modulos(desc_modulo)" +
                "values(@desc_modulo) " +
                "select @@identity", //esta linea es para recuperar el ID que asigno el sql automaticamente 
                sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = modulo.ID;
                cmdSave.Parameters.Add("@desc_modulo", SqlDbType.VarChar, 50).Value = modulo.Descripcion;
                modulo.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
                //asi se obtiene el ID que asigno al BD automaticamente
            }

                   catch (Exception Ex)
                   {

                       Exception ExcepcionManejada =
                           new Exception("Error al crear el modulo", Ex);
                       throw ExcepcionManejada;
                   }
                   
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Modulo modulo)
        {
            if (modulo.State == BusinessEntity.States.New)
            {

                this.Insert(modulo);
            }
            else if (modulo.State == BusinessEntity.States.Deleted)
            {
                this.Delete(modulo.ID);
            }
            else if (modulo.State == BusinessEntity.States.Modified)
            {
                this.Update(modulo);
            }
            modulo.State = BusinessEntity.States.Unmodified;
        }
    }
}
