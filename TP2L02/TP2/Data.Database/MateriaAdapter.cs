using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Data.Database
{
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            //return new List<Usuario>(Usuarios);

            //instanciamos el objeto lista a retornar
            List<Materia> materias = new List<Materia>();
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

                SqlCommand cmdMaterias = new SqlCommand("select * from materias", sqlConn);

                /*
                 * instanciamos un objeto DataReader que sera
                 * el que recuperara los datos de la BD
                 */
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();

                /*
                 * Read() lee una fila de las devueltas por el comando sql
                 * carga los datos en drUsuarios para poder accederlos,
                 * devuelve verdadero mientras haya podido leer datos y 
                 * avanza a la fila siguiente para el proximo read
                 */
                while (drMaterias.Read())
                {
                    /*creamos un objeto Usuario de la capa de entidades para 
                     * copiar los datos de la fila del DataReader al objeto de
                     * entidades
                     */

                    Materia Mat = new Materia();

                    //ahora copiamos los datos de la fila al objeto
                    Mat.ID = (int)drMaterias["id_materia"];
                    Mat.Descripcion = (string)drMaterias["desc_materia"];
                    Mat.HSSemanales = (int)drMaterias["hs_semanales"];
                    Mat.HSTotales = (int)drMaterias["hs_totales"];
                    //agregamos el objeto con datos a la lista que devolveremos
                    materias.Add(Mat);
                }

                //cerramos el DataReader y la conexion a la BD
                drMaterias.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de materias", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            //devolvemos el objeto
            return materias;
        }
            public Business.Entities.Materia GetOne(int ID)
            {
                Materia Mat = new Materia();
                try
                {
                    this.OpenConnection();
                    SqlCommand cmdMaterias = new SqlCommand("select * from materias where id_materia=@id", sqlConn);
                    cmdMaterias.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                    SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
                    if (drMaterias.Read())
                    {
                        Mat.ID = (int)drMaterias["id_materia"];
                        Mat.Descripcion = (string)drMaterias["desc_materia"];
                        Mat.HSTotales = (int)drMaterias["hs_semanales"];
                        Mat.HSSemanales = (int)drMaterias["hs_totales"];
                        Mat.IDPlan = (int)drMaterias["id_plan"];

                    }
                    drMaterias.Close();
                }
                   catch (Exception Ex)
                      {
                          Exception ExcepcionManejada =
                          new Exception("Error al recuperar materia", Ex);
                          throw ExcepcionManejada;

                      }
                finally
                {
                    this.CloseConnection();
                }
                return Mat;


            }

            public void Delete(int ID)
            {
                try
                {
                    this.OpenConnection();
                    //creamos la sentencia sql y asignamos un valor al parametro
                    SqlCommand cmdDelete =
                        new SqlCommand("delete materias where id_materia=@id", sqlConn);
                    cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                    //ejecutamos la sentencia sql
                    cmdDelete.ExecuteNonQuery();
                }
                

                   catch (Exception Ex)
                      {
                          Exception ExcepcionManejada =
                          new Exception("Error al recuperar materia", Ex);
                          throw ExcepcionManejada;

                      }
                finally
                {
                    this.CloseConnection();
                }
            }
            protected void Update(Materia materia)

            {

                try
                {

                    this.OpenConnection();
                    SqlCommand cmdSave = new SqlCommand(
                    "UPDATE materias SET desc_materia = @desc_materia, hs_semanales = @hs_semanales, " +
                    "hs_totales = @hs_totales, id_plan = @id_plan," +
                    "WHERE id_materia = @ id", sqlConn);


                    cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = materia.ID;
                    cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                    cmdSave.Parameters.Add("@hs_semanales", SqlDbType.Int, 50).Value = materia.HSSemanales;
                    cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int, 50).Value = materia.HSTotales;
                    //cmdSave.Parameters.Add("@id_plan", SqlDbType.VarChar, 50).Value = materia.IDPlan;
                    cmdSave.ExecuteNonQuery();
                }

                catch (Exception Ex)
                {

                    Exception ExcepcionManejada =
                        new Exception("Error al modificar datos de la materia", Ex);
                    throw ExcepcionManejada;
                }

                finally
                {
                    this.CloseConnection();
                }
            }


            protected void Insert(Materia materia)
            {
                try
                {
                    this.OpenConnection();
                    SqlCommand cmdSave = new SqlCommand(
                    "insert into materias(id_materia,desc_materia,hs_semanales,hs_totales,id_plan)" +
                    "values(@id_materia,@desc_materia,@hs_semanales,@hs_totales,@id_plan) " +
                    "select @@identity", //esta linea es para recuperar el ID que asigno el sql automaticamente 
                    sqlConn);

                    cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = materia.ID;
                    cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                    cmdSave.Parameters.Add("@hs_semanales", SqlDbType.Int, 50).Value = materia.HSSemanales;
                    cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int, 50).Value = materia.HSTotales;
                    cmdSave.Parameters.Add("@id_plan", SqlDbType.Int, 50).Value = materia.IDPlan;
                    materia.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
                    //asi se obtiene el ID que asigno al BD automaticamente
                }

                catch (Exception Ex)
                {

                    Exception ExcepcionManejada =
                        new Exception("Error al crear la materia", Ex);
                    throw ExcepcionManejada;
                }

                finally
                {
                    this.CloseConnection();
                }
            }

            public void Save(Materia materia)
            {
                if (materia.State == BusinessEntity.States.New)
                {

                    this.Insert(materia);
                }
                else if (materia.State == BusinessEntity.States.Deleted)
                {
                    this.Delete(materia.ID);
                }
                else if (materia.State == BusinessEntity.States.Modified)
                {
                    this.Update(materia);
                }
                materia.State = BusinessEntity.States.Unmodified;
            }
        }
    }
