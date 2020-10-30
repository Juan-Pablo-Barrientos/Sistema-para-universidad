using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                this.OpenConnection();



                SqlCommand cmdMaterias = new SqlCommand("select * from materias", sqlConn);


                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();


                while (drMaterias.Read())
                {


                    Materia Mat = new Materia();

                    Mat.ID = (int)drMaterias["id_materia"];
                    Mat.Descripcion = (string)drMaterias["desc_materia"];
                    Mat.HSSemanales = (int)drMaterias["hs_semanales"];
                    Mat.HSTotales = (int)drMaterias["hs_totales"];
                    Mat.IDPlan = (int)drMaterias["id_plan"];
                    materias.Add(Mat);
                }

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
                SqlCommand cmdDelete =
new SqlCommand("delete materias where id_materia=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
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
                "hs_totales= @hs_totales, id_plan=@id_plan " +
                "WHERE id_materia = @id", sqlConn);


                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = materia.ID;
                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                cmdSave.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = materia.HSSemanales;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int).Value = materia.HSTotales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IDPlan;

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
                "insert into materias(desc_materia,hs_semanales,hs_totales,id_plan)" +
                "values(@desc_materia,@hs_semanales,@hs_totales,@id_plan) " +
                "select @@identity", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = materia.ID;
                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                cmdSave.Parameters.Add("@hs_semanales", SqlDbType.Int, 50).Value = materia.HSSemanales;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int, 50).Value = materia.HSTotales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int, 50).Value = materia.IDPlan;
                materia.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
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
