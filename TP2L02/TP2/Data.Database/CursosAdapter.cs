﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Data.Database
{
    public class CursosAdapter : Adapter
    {
        // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
        private static List<Curso> _Cursos;


        public List<Curso> GetAll()
        {
            //return new List<Especialidad>(Usuarios);

            //instanciamos el objeto lista a retornar
            List<Curso> cursos = new List<Curso>();
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

                SqlCommand cmdCursos = new SqlCommand("select * from cursos", sqlConn);

                /*
                 * instanciamos un objeto DataReader que sera
                 * el que recuperara los datos de la BD
                 */
                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                /*
                 * Read() lee una fila de las devueltas por el comando sql
                 * carga los datos en drUsuarios para poder accederlos,
                 * devuelve verdadero mientras haya podido leer datos y 
                 * avanza a la fila siguiente para el proximo read
                 */
                while (drCursos.Read())
                {
                    /*creamos un objeto Usuario de la capa de entidades para 
                     * copiar los datos de la fila del DataReader al objeto de
                     * entidades
                     */

                    Curso cur = new Curso();

                    //ahora copiamos los datos de la fila al objeto
                    cur.ID = (int)drCursos["id_curso"];
                    cur.IDMateria = (int)drCursos["id_materia"];
                    cur.IDComision = (int)drCursos["id_comision"];
                    cur.AnioCalendario = (int)drCursos["anio_calendario"];
                    cur.Cupo = (int)drCursos["cupo"];
                    cur.Descripcion =(string)drCursos["desc_curso"];
                    //agregamos el objeto con datos a la lista que devolveremos
                    cursos.Add(cur);
                }

                //cerramos el DataReader y la conexion a la BD
                drCursos.Close();
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
            return cursos;

        }



        public Business.Entities.Curso GetOne(int ID)
        {
            Curso cur = new Curso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("select * from cursos where id_curso=@id", sqlConn);
                cmdCursos.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                if (drCursos.Read())
                {
                    cur.ID = (int)drCursos["id_curso"];
                    cur.IDMateria = (int)drCursos["id_materia"];
                    cur.IDComision = (int)drCursos["id_comision"];
                    cur.AnioCalendario = (int)drCursos["anio_calendario"];
                    cur.Cupo = (int)drCursos["cupo"];
                    cur.Descripcion = (string)drCursos["desc_curso"];
                }
                drCursos.Close();
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
            return cur;



        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                //creamos la sentencia sql y asignamos un valor al parametro
                SqlCommand cmdDelete =
                    new SqlCommand("delete cursos where id_curso=@id", sqlConn);
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
        protected void Update(Curso cur)

        {

            //try
            //{

            this.OpenConnection();
            SqlCommand cmdSave = new SqlCommand(
            "UPDATE cursos SET id_materia = @id_materia, " +
            "id_comision = @id_comision, anio_calendario = @anio_calendario, " +
            "cupo = @cupo, desc_curso = @dec_curso " +
            "WHERE id_especialidad = @id", sqlConn);


            cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = cur.ID;
            cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = cur.IDComision;
            cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = cur.IDMateria;
            cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = cur.Cupo;
            cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = cur.AnioCalendario;
            cmdSave.Parameters.Add("@desc_curso", SqlDbType.VarChar, 50);

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


        protected void Insert(Curso cur)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "INSERT into cursos(id_comision,id_materia,cupo,anio_calendario,desc_curso)" +
                "values(@id_comision,@id_materia,@cupo,@anio_calendario,@desc_curso) " +
                "select @@identity", //esta linea es para recuperar el ID que asigno el sql automaticamente
                sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = cur.ID;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = cur.IDComision;
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = cur.IDMateria;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = cur.Cupo;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = cur.AnioCalendario;
                cmdSave.Parameters.Add("@desc_curso", SqlDbType.VarChar, 50).Value=cur.Descripcion;

                cur.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
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

        public void Save(Curso curso)
        {
            if (curso.State == BusinessEntity.States.New)
            {

                this.Insert(curso);
            }
            else if (curso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(curso.ID);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                this.Update(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;
        }
    }
}
