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

namespace UI.Desktop
{
    public partial class EspecialidadDesktop : ApplicationForm
    {
   
        public Especialidad EspecialidadActual;

        #region constructores
        public EspecialidadDesktop()
        {
            InitializeComponent();
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public EspecialidadDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public EspecialidadDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            EspecialidadActual = new EspecialidadesLogic().getOne(ID);
            MapearDeDatos();

        }
        #endregion


        public override void MapearDeDatos()
        {
            this.txtIdespecialidades.Text = this.EspecialidadActual.ID.ToString();        
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;
        
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
                EspecialidadActual = new Especialidad();
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                EspecialidadActual.Descripcion = txtDescripcion.Text;
                          
                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            EspecialidadActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            EspecialidadActual.State = BusinessEntity.States.Modified;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            EspecialidadActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            EspecialidadActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                }
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            new EspecialidadesLogic().Save(EspecialidadActual);
        }
        public override bool Validar()
        {

            // Validar que los campos no esten vacios 

            foreach (Control oControls in this.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio.
                {
                    Notificar("Hay al menos un campo vacío. Por favor, completelo/s. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false);
                }
            }

            //validar el interior de los campos 

            //if (txtclave.text != txtconfirmarclave.text)
            //{
            //    notificar("la clave ingresada no coincide con la clave de confirmación. ", messageboxbuttons.ok, messageboxicon.error);
            //    return (false);
            //}
            //else if (txtclave.text.length < 8)
            //{
            //    notificar("la clave ingresada debe ser al menos de 8 carateres de longitud.", messageboxbuttons.ok, messageboxicon.error);
            //    return (false);
            //}

            //if (business.logic.validar.esmailvalido(txtemail.text.trim()))
            //{
            //    notificar("el email ingresado no es válido. ", messageboxbuttons.ok, messageboxicon.error);
            //    return (false);
            //}

            return (true);

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

        private void EspecialidadDesktop_Load(object sender, EventArgs e)
        {

        }
    }
}
