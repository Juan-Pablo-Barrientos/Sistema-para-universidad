using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Data.Database
{
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            //return new List<Usuario>(Usuarios);
            //instanciamos el objeto lista a retornar
            List<Comision> comisiones = new List<Comision>();
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

                SqlCommand cmdComisiones = new SqlCommand("select * from comisiones", sqlConn);

                /*
                 * instanciamos un objeto DataReader que sera
                 * el que recuperara los datos de la BD
                 */
                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();

                /*
                 * Read() lee una fila de las devueltas por el comando sql
                 * carga los datos en drUsuarios para poder accederlos,
                 * devuelve verdadero mientras haya podido leer datos y 
                 * avanza a la fila siguiente para el proximo read
                 */
                while (drComisiones.Read())
                {
                    /*creamos un objeto Usuario de la capa de entidades para 
                     * copiar los datos de la fila del DataReader al objeto de
                     * entidades
                     */

                    Comision Com = new Comision();

                    //ahora copiamos los datos de la fila al objeto
                    Com.ID = (int)drComisiones["id_comision"];
                    Com.Descripcion = (string)drComisiones["desc_comision"];
                    Com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    Com.IDPlan = (int)drComisiones["id_plan"];
                    //agregamos el objeto con datos a la lista que devolveremos
                    comisiones.Add(Com);
                }

                //cerramos el DataReader y la conexion a la BD
                drComisiones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de comsiones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            //devolvemos el objeto
            return comisiones;
        }
        public Business.Entities.Comision GetOne(int ID)
        {
            Comision Com = new Comision();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComisions = new SqlCommand("select * from comisiones where id_comision=@id", sqlConn);
                cmdComisions.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drComisiones = cmdComisions.ExecuteReader();
                if (drComisiones.Read())
                {
                    Com.ID = (int)drComisiones["id_comision"];
                    Com.Descripcion = (string)drComisiones["desc_comision"];
                    Com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    Com.IDPlan = (int)drComisiones["id_plan"];

                }
                drComisiones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar comision", Ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }
            return Com;


        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                //creamos la sentencia sql y asignamos un valor al parametro
                SqlCommand cmdDelete =
                    new SqlCommand("delete comisiones where id_comision=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                //ejecutamos la sentencia sql
                cmdDelete.ExecuteNonQuery();
            }


            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar comision", Ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Update(Comision comision)

        {

            try
            {

                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "UPDATE comisiones SET desc_comision = @desc_comision, anio_especialidad = @anio_especialidad, " +
                "id_plan=@id_plan " +
                "WHERE id_comision = @id", sqlConn);


                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = comision.ID;
                cmdSave.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = comision.Descripcion;
                cmdSave.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = comision.IDPlan;

                cmdSave.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {

                Exception ExcepcionManejada =
                    new Exception("Error al modificar datos de la comision", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Comision comision)
        {
            //   try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "insert into comisiones(desc_comision,anio_especialidad,id_plan)" +
                "values(@desc_comision,@anio_especialidad,@id_plan) " +
                "select @@identity", //esta linea es para recuperar el ID que asigno el sql automaticamente 
                sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = comision.ID;
                cmdSave.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = comision.Descripcion;
                cmdSave.Parameters.Add("@anio_especialidad", SqlDbType.Int, 50).Value = comision.AnioEspecialidad;                
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int, 50).Value = comision.IDPlan;
                comision.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
                //asi se obtiene el ID que asigno al BD automaticamente
            }
            /*
                            catch (Exception Ex)
                            {

                                Exception ExcepcionManejada =
                                    new Exception("Error al crear la comision", Ex);
                                throw ExcepcionManejada;
                            }

                            finally
                            {
                                this.CloseConnection();
                            }
                            */
        }

        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.New)
            {

                this.Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Deleted)
            {
                this.Delete(comision.ID);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                this.Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }
    }
}
