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
    public partial class ModuloDesktop : ApplicationForm
    {
        public Modulo ModuloActual;

        #region constructores
        public ModuloDesktop()
        {
            InitializeComponent();
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public ModuloDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public ModuloDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            ModuloActual = new ModuloLogic().getOne(ID);
            MapearDeDatos();

        }
        #endregion



        public override void MapearDeDatos()
        {
            this.txtIdModulo.Text = this.ModuloActual.ID.ToString();
            this.txtDescripcion.Text = this.ModuloActual.Descripcion;

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
                ModuloActual = new Modulo();
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                ModuloActual.Descripcion = txtDescripcion.Text;


                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            ModuloActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            ModuloActual.State = BusinessEntity.States.Modified;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            ModuloActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            ModuloActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                }
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            new ModuloLogic().Save(ModuloActual);
        }
        public override bool Validar()
        {         
            var validador = new Validador();
            List<string> Campos = (this.container.Controls.OfType<TextBox>().Where(txt => txt.ReadOnly == false).Select(txt => txt.Text)).ToList();
            if (!BusinessLogic.SonCamposValidos(Campos)) validador.AgregarError("No todos los campos estan completos");
            if (!validador.EsValido()) BusinessLogic.Notificar("Especialidad", validador.Errores, MessageBoxButtons.OK, MessageBoxIcon.Error);//Si no es valido, mustra el error
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

        private void ModuloDesktop_Load(object sender, EventArgs e)
        {

        }

    }
}