using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class AlumInAdapter : Adapter
    {
        private static List<AlumnosIncripcion> _AlumIns;


        public List<AlumnosIncripcion> GetAll()
        {

            List<AlumnosIncripcion> alumIns = new List<AlumnosIncripcion>();
            try
            {
                this.OpenConnection();



                SqlCommand cmdAlumIns = new SqlCommand("select * from alumnos_inscripciones", sqlConn);


                SqlDataReader drAlumIns = cmdAlumIns.ExecuteReader();


                while (drAlumIns.Read())
                {


                    AlumnosIncripcion alumIn = new AlumnosIncripcion();

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
                    alumIns.Add(alumIn);
                }

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
            return alumIns;

        }

        public List<AlumnosIncripcion> GetMisCursos(int id)
        {

            List<AlumnosIncripcion> alumIns = new List<AlumnosIncripcion>();
            try
            {

                this.OpenConnection();

                SqlCommand cmdAlumIns = new SqlCommand("select * from alumnos_inscripciones where id_alumno=@id", sqlConn);
                cmdAlumIns.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drAlumIns = cmdAlumIns.ExecuteReader();

                while (drAlumIns.Read())
                {


                    AlumnosIncripcion alumIn = new AlumnosIncripcion();

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

                    alumIns.Add(alumIn);
                }


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

            return alumIns;

        }

        public List<AlumnosIncripcion> GetAlumnosPorCurso(int id)
        {

            List<AlumnosIncripcion> alumIns = new List<AlumnosIncripcion>();
            try
            {

                this.OpenConnection();
                SqlCommand cmdAlumIns = new SqlCommand("select * from alumnos_inscripciones where id_curso=@id", sqlConn);
                cmdAlumIns.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drAlumIns = cmdAlumIns.ExecuteReader();

                while (drAlumIns.Read())
                {


                    AlumnosIncripcion alumIn = new AlumnosIncripcion();

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

                    alumIns.Add(alumIn);
                }


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
                SqlCommand cmdDelete =
                new SqlCommand("delete alumnos_inscripciones where id_inscripcion=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
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
        public void DeleteAll(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete =
                new SqlCommand("delete alumnos_inscripciones where id_alumno=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
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

            try
            {

                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "UPDATE alumnos_inscripciones SET id_alumno = @id_alumno, " +
                "id_curso=@id_curso,condicion=@condicion,nota=@nota " +
                "WHERE id_inscripcion = @id", sqlConn);


                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = alumIn.ID;
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alumIn.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = alumIn.IDCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = alumIn.Condicion.ToString();
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = alumIn.Nota;

                cmdSave.ExecuteNonQuery();
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


        protected void Insert(AlumnosIncripcion alumIn)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "insert into alumnos_inscripciones(id_alumno,id_curso,condicion,nota)" +
                "values(@id_alumno,@id_curso,@condicion,@nota) " +
                "select @@identity", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = alumIn.ID;
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alumIn.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = alumIn.IDCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = alumIn.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = alumIn.Nota;
                alumIn.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
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
