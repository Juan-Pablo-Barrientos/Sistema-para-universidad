using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using Util.entities;

namespace UI.Desktop
{
    public partial class PlanDesktop : ApplicationForm
    {

        public Plan PlanActual;

        #region constructores
        public PlanDesktop()
        {
            InitializeComponent();
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public PlanDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            PlanActual = new PlanLogic().getOne(ID);
            MapearDeDatos();

        }
        #endregion
        

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PlanActual.ID.ToString();
            this.txtDescripcion.Text = this.PlanActual.Descripcion;

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
            }
            else if (Modo == ModoForm.Baja)
            {
                this.btnAceptar.Text = "Eliminar";
            }
            else if (Modo == ModoForm.Consulta)
            {
                this.btnAceptar.Text = "Aceptar";
            }

        }
        public override void MapearADatos()
        {

            if (Modo == ModoForm.Alta)
            {
                PlanActual = new Plan();
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                PlanActual.Descripcion = txtDescripcion.Text;

                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            PlanActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            PlanActual.State = BusinessEntity.States.Modified;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            PlanActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            PlanActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                }
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            new PlanLogic().Save(PlanActual);
        }
        public override bool Validar()
        {
            var validador = new Validador();
            List<string> Campos = (this.container.Controls.OfType<TextBox>().Where(txt => txt.ReadOnly == false).Select(txt => txt.Text)).ToList();
            if (!BusinessLogic.SonCamposValidos(Campos)) validador.AgregarError("No todos los campos estan completos");
            if (!validador.EsValido()) BusinessLogic.Notificar("Plan", validador.Errores, MessageBoxButtons.OK, MessageBoxIcon.Error);//Si no es valido, mustra el error
            return validador.EsValido();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();

                Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PlanDesktop_Load(object sender, EventArgs e)
        {

        }

        private void PlanDesktop_Load_1(object sender, EventArgs e)
        {

        }
    }
}
