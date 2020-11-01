using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class DocCurAdapter : Adapter
    {

        private static List<DocenteCurso> _DocCurs;


        public List<DocenteCurso> GetAll()
        {

            List<DocenteCurso> DocCurs = new List<DocenteCurso>();
            try
            {
                this.OpenConnection();



                SqlCommand cmdDocCurs = new SqlCommand("select * from docentes_cursos", sqlConn);


                SqlDataReader drDocCurs = cmdDocCurs.ExecuteReader();


                while (drDocCurs.Read())
                {


                    DocenteCurso docCur = new DocenteCurso();

                    docCur.ID = (int)drDocCurs["id_dictado"];
                    docCur.IDCurso = (int)drDocCurs["id_curso"];
                    docCur.IDDocente = (int)drDocCurs["id_docente"];
                    if ((string)drDocCurs["cargo"] == "Docente")
                        docCur.Cargo = DocenteCurso.TiposCargos.Docente;
                    if ((string)drDocCurs["cargo"] == "Jefecatedra")
                        docCur.Cargo = DocenteCurso.TiposCargos.Jefecatedra;
                    if ((string)drDocCurs["cargo"] == "Auxiliar")
                        docCur.Cargo = DocenteCurso.TiposCargos.Auxiliar;
                    DocCurs.Add(docCur);
                }

                drDocCurs.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de docentes y cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return DocCurs;

        }
        public List<DocenteCurso> GetMisCursos(int id)
        {

            List<DocenteCurso> DocCurs = new List<DocenteCurso>();
            try
            {

                this.OpenConnection();

                SqlCommand cmdDocCurs = new SqlCommand("select * from docentes_cursos where id_docente=@id", sqlConn);
                cmdDocCurs.Parameters.Add("@id", SqlDbType.Int).Value = id;

                SqlDataReader drDocCurs = cmdDocCurs.ExecuteReader();


                while (drDocCurs.Read())
                {
                    DocenteCurso docCur = new DocenteCurso();
                    docCur.ID = (int)drDocCurs["id_dictado"];
                    docCur.IDCurso = (int)drDocCurs["id_curso"];
                    docCur.IDDocente = (int)drDocCurs["id_docente"];
                    if ((string)drDocCurs["cargo"] == "Docente")
                        docCur.Cargo = DocenteCurso.TiposCargos.Docente;
                    if ((string)drDocCurs["cargo"] == "Jefecatedra")
                        docCur.Cargo = DocenteCurso.TiposCargos.Jefecatedra;
                    if ((string)drDocCurs["cargo"] == "Auxiliar")
                        docCur.Cargo = DocenteCurso.TiposCargos.Auxiliar;

                    DocCurs.Add(docCur);
                }

                drDocCurs.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de docentes y cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return DocCurs;

        }


        public Business.Entities.DocenteCurso GetOne(int ID)
        {
            DocenteCurso docCur = new DocenteCurso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocCur = new SqlCommand("select * from docentes_cursos where id_dictado=@id", sqlConn);
                cmdDocCur.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drDocCurs = cmdDocCur.ExecuteReader();
                if (drDocCurs.Read())
                {
                    docCur.ID = (int)drDocCurs["id_dictado"];
                    docCur.IDCurso = (int)drDocCurs["id_curso"];
                    docCur.IDDocente = (int)drDocCurs["id_docente"];
                    if ((string)drDocCurs["cargo"] == "Docente")
                        docCur.Cargo = DocenteCurso.TiposCargos.Docente;
                    if ((string)drDocCurs["cargo"] == "Auxiliar")
                        docCur.Cargo = DocenteCurso.TiposCargos.Auxiliar;
                    if ((string)drDocCurs["cargo"] == "Jefecatedra")
                        docCur.Cargo = DocenteCurso.TiposCargos.Jefecatedra;

                }
                drDocCurs.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar docente curso", Ex);

            }
            finally
            {
                this.CloseConnection();
            }
            return docCur;



        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete =
                new SqlCommand("delete docentes_cursos where id_dictado=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar docente y curso", Ex);
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
                new SqlCommand("delete docentes_cursos where id_docente=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar docente y curso", Ex);
                throw ExcepcionManejada;

            }
            finally
            {
                this.CloseConnection();
            }
        }


        protected void Update(DocenteCurso docCur)

        {

            try
            {

                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "UPDATE docentes_cursos SET id_curso = @id_curso, " +
                "id_docente = @id_docente, cargo = @cargo " +
                "WHERE id_dictado = @id", sqlConn);


                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = docCur.ID;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = docCur.IDCurso;
                cmdSave.Parameters.Add("@id_docente", SqlDbType.Int).Value = docCur.IDDocente;
                cmdSave.Parameters.Add("@cargo", SqlDbType.VarChar, 50).Value = docCur.Cargo.ToString();

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


        protected void Insert(DocenteCurso docCur)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "INSERT into docentes_cursos(id_curso,id_docente,cargo)" +
                "values(@id_curso,@id_docente,@cargo) " +
                "select @@identity", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = docCur.ID;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = docCur.IDCurso;
                cmdSave.Parameters.Add("@id_docente", SqlDbType.Int).Value = docCur.IDDocente;
                cmdSave.Parameters.Add("@cargo", SqlDbType.VarChar, 50).Value = docCur.Cargo.ToString();
                docCur.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }

            catch (Exception Ex)
            {

                Exception ExcepcionManejada =
                    new Exception("Error al modificar datos de la docente cursos", Ex);
                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(DocenteCurso docCur)
        {
            if (docCur.State == BusinessEntity.States.New)
            {

                this.Insert(docCur);
            }
            else if (docCur.State == BusinessEntity.States.Deleted)
            {
                this.Delete(docCur.ID);
            }
            else if (docCur.State == BusinessEntity.States.Modified)
            {
                this.Update(docCur);
            }
            docCur.State = BusinessEntity.States.Unmodified;
        }
    }
}
