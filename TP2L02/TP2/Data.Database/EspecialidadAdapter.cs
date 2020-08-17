using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Data.Database
{
    public class EspecialidadAdapter : Adapter
    {
        // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
        private static List<Especialidad> _Especialidades;


        public List<Especialidad> GetAll()
        {
            //return new List<Especialidad>(Usuarios);

            //instanciamos el objeto lista a retornar
            List<Especialidad> especialidades = new List<Especialidad>();
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

                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades", sqlConn);

                /*
                 * instanciamos un objeto DataReader que sera
                 * el que recuperara los datos de la BD
                 */
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();

                /*
                 * Read() lee una fila de las devueltas por el comando sql
                 * carga los datos en drUsuarios para poder accederlos,
                 * devuelve verdadero mientras haya podido leer datos y 
                 * avanza a la fila siguiente para el proximo read
                 */
                while (drEspecialidades.Read())
                {
                    /*creamos un objeto Usuario de la capa de entidades para 
                     * copiar los datos de la fila del DataReader al objeto de
                     * entidades
                     */

                    Especialidad esp = new Especialidad();

                    //ahora copiamos los datos de la fila al objeto
                    esp.ID = (int)drEspecialidades["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidades["desc_especialidad"];
                    //agregamos el objeto con datos a la lista que devolveremos
                    especialidades.Add(esp);
                }

                //cerramos el DataReader y la conexion a la BD
                drEspecialidades.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            //devolvemos el objeto
            return especialidades;

        }



        public Business.Entities.Especialidad GetOne(int ID)
        {
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("select * from especialidades where id_especialidad=@id", sqlConn);
                cmdEspecialidad.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drEspecialidades = cmdEspecialidad.ExecuteReader();
                if (drEspecialidades.Read())
                {
                    esp.ID = (int)drEspecialidades["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidades["desc_especialidad"];

                }
                drEspecialidades.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar especialidad", Ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }
            return esp;



        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                //creamos la sentencia sql y asignamos un valor al parametro
                SqlCommand cmdDelete =
                    new SqlCommand("delete especialidades where id_especialidad=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                //ejecutamos la sentencia sql
                cmdDelete.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar especialidad", Ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Update(Especialidad especialidad)

        {

            //try
            //{

                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "UPDATE especialidades SET desc_especialidad = @desc_especialidad " +
                "WHERE id_especialidad = @id", sqlConn);


                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = especialidad.ID;
                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = especialidad.Descripcion;
               
                cmdSave.ExecuteNonQuery();
            //}

            //catch (Exception Ex)
            //{

            //    Exception ExcepcionManejada =
            //        new Exception("Error al modificar datos de la especialidad", Ex);
            //    throw ExcepcionManejada;
            //}

            //finally
            //{
            //    this.CloseConnection();
            //}
        }


        protected void Insert(Especialidad especialidad)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "insert into especialidades(desc_especialidad)" +
                "values(@desc_especialidad) " +
                "select @@identity", //esta linea es para recuperar el ID que asigno el sql automaticamente
                sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = especialidad.ID;
                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = especialidad.Descripcion;
                especialidad.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
                //asi se obtiene el ID que asigno al BD automaticamente
            }

            catch (Exception Ex)
            {

                Exception ExcepcionManejada =
                    new Exception("Error al modificar datos de la especialidad", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.New)
            {

                this.Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Deleted)
            {
                this.Delete(especialidad.ID);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                this.Update(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }
    }
}
