using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Data.Database
{
    public class AlumInAdapter : Adapter
    {
        // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
        private static List<AlumnosIncripcion> _AlumIns;


        public List<AlumnosIncripcion> GetAll()
        {
            //return new List<Especialidad>(Usuarios);

            //instanciamos el objeto lista a retornar
            List<AlumnosIncripcion> alumIns = new List<AlumnosIncripcion>();
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

                SqlCommand cmdAlumIns = new SqlCommand("select * from alumnos_inscripciones", sqlConn);

                /*
                 * instanciamos un objeto DataReader que sera
                 * el que recuperara los datos de la BD
                 */
                SqlDataReader drAlumIns = cmdAlumIns.ExecuteReader();

                /*
                 * Read() lee una fila de las devueltas por el comando sql
                 * carga los datos en drUsuarios para poder accederlos,
                 * devuelve verdadero mientras haya podido leer datos y 
                 * avanza a la fila siguiente para el proximo read
                 */
                while (drAlumIns.Read())
                {
                    /*creamos un objeto Usuario de la capa de entidades para 
                     * copiar los datos de la fila del DataReader al objeto de
                     * entidades
                     */

                    AlumnosIncripcion alumIn = new AlumnosIncripcion();

                    //ahora copiamos los datos de la fila al objeto
                    alumIn.ID = (int)drAlumIns["id_inscripcion"];
                    alumIn.IDAlumno = (int)drAlumIns["id_alumno"];
                    alumIn.IDCurso = (int)drAlumIns["id_curso"];
                    alumIn.Nota = (int)drAlumIns["nota"];
                    if ((string)drAlumIns["condicion"] == "Aprobado")
                        alumIn.Condicion = AlumnosIncripcion.Cond.Aprobado;
                    if ((string)drAlumIns["condicion"] == "Inscripto")
                        alumIn.Condicion = AlumnosIncripcion.Cond.Inscripto;
                    if ((string)drAlumIns["condicion"] == "Libre")
                        alumIn.Condicion = AlumnosIncripcion.Cond.Libre;
                    if ((string)drAlumIns["condicion"] == "Regular")
                        alumIn.Condicion = AlumnosIncripcion.Cond.Regular;
                    //agregamos el objeto con datos a la lista que devolveremos
                    alumIns.Add(alumIn);
                }

                //cerramos el DataReader y la conexion a la BD
                drAlumIns.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de alumnos inscriptos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            //devolvemos el objeto
            return alumIns;

        }



        public Business.Entities.AlumnosIncripcion GetOne(int ID)
        {
            AlumnosIncripcion alumIn = new AlumnosIncripcion();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumIn = new SqlCommand("select * from alumnos_inscripciones where id_inscripcion=@id", sqlConn);
                cmdAlumIn.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drAlumIns = cmdAlumIn.ExecuteReader();
                if (drAlumIns.Read())
                {
                    alumIn.ID = (int)drAlumIns["id_inscripcion"];
                    alumIn.IDAlumno = (int)drAlumIns["id_alumno"];
                    alumIn.IDCurso = (int)drAlumIns["id_curso"];
                    alumIn.Nota = (int)drAlumIns["nota"];
                    if ((string)drAlumIns["condicion"] == "Aprobado")
                        alumIn.Condicion = AlumnosIncripcion.Cond.Aprobado;
                    if ((string)drAlumIns["condicion"] == "Inscripto")
                        alumIn.Condicion = AlumnosIncripcion.Cond.Inscripto;
                    if ((string)drAlumIns["condicion"] == "Libre")
                        alumIn.Condicion = AlumnosIncripcion.Cond.Libre;
                    if ((string)drAlumIns["condicion"] == "Regular")
                        alumIn.Condicion = AlumnosIncripcion.Cond.Regular;

                }
                drAlumIns.Close();
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
            return alumIn;

        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                //creamos la sentencia sql y asignamos un valor al parametro
                SqlCommand cmdDelete =
                    new SqlCommand("delete alumnos_inscripciones where id_inscripcion=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                //ejecutamos la sentencia sql
                cmdDelete.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar alumno inscripto", Ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Update(AlumnosIncripcion alumIn)

        {

            //try
            //{

            this.OpenConnection();
            SqlCommand cmdSave = new SqlCommand(
            "UPDATE alumnos_inscripciones SET id_alumno = @id_alumno, " +
            "id_curso=@id_curso,condicion=@condicion,nota=@nota " +
            "WHERE id_inscripciones = @id", sqlConn);


            cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = alumIn.ID;
            cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alumIn.IDAlumno;
            cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = alumIn.IDCurso;
            cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = alumIn.Condicion;
            cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = alumIn.Nota;

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


        protected void Insert(AlumnosIncripcion alumIn)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "insert into alumnos_inscripciones(id_alumno,id_curso,condicion,nota)" +
                "values(@id_alumno,@id_curso,@condicion,@nota) " +
                "select @@identity", //esta linea es para recuperar el ID que asigno el sql automaticamente
                sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = alumIn.ID;
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alumIn.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = alumIn.IDCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = alumIn.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = alumIn.Nota;
                alumIn.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
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

        public void Save(AlumnosIncripcion alumIn)
        {
            if (alumIn.State == BusinessEntity.States.New)
            {

                this.Insert(alumIn);
            }
            else if (alumIn.State == BusinessEntity.States.Deleted)
            {
                this.Delete(alumIn.ID);
            }
            else if (alumIn.State == BusinessEntity.States.Modified)
            {
                this.Update(alumIn);
            }
            alumIn.State = BusinessEntity.States.Unmodified;
        }
    }
}
