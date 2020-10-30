using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            List<Comision> comisiones = new List<Comision>();
            try
            {
                this.OpenConnection();



                SqlCommand cmdComisiones = new SqlCommand("select * from comisiones", sqlConn);


                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();


                while (drComisiones.Read())
                {


                    Comision Com = new Comision();

                    Com.ID = (int)drComisiones["id_comision"];
                    Com.Descripcion = (string)drComisiones["desc_comision"];
                    Com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    Com.IDPlan = (int)drComisiones["id_plan"];
                    comisiones.Add(Com);
                }

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
                SqlCommand cmdDelete =
    new SqlCommand("delete comisiones where id_comision=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
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
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                "insert into comisiones(desc_comision,anio_especialidad,id_plan)" +
                "values(@desc_comision,@anio_especialidad,@id_plan) " +
                "select @@identity", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = comision.ID;
                cmdSave.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = comision.Descripcion;
                cmdSave.Parameters.Add("@anio_especialidad", SqlDbType.Int, 50).Value = comision.AnioEspecialidad;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int, 50).Value = comision.IDPlan;
                comision.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }

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
