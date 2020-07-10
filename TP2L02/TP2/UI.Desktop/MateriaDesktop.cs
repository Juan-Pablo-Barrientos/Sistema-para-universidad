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
    public partial class MateriaDesktop : ApplicationForm
    {
        public Materia MateriaActual;

        #region constructores
        public MateriaDesktop()
        {
            InitializeComponent();
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public MateriaDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public MateriaDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            MateriaActual = new MateriaLogic().getOne(ID);
            MapearDeDatos();

        }
        #endregion



        public override void MapearDeDatos()
        {
            this.txtIdmateria.Text = this.MateriaActual.ID.ToString();      
            this.txtIdplan.Text = this.MateriaActual.IDPlan.ToString();
            this.txtDescripcion.Text = this.MateriaActual.Descripcion;
            this.txtHssemanales.Text = this.MateriaActual.HSSemanales.ToString();
            this.txtHstotales.Text = this.MateriaActual.HSTotales.ToString();
            

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
                MateriaActual = new Materia();
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                MateriaActual.Descripcion = txtDescripcion.Text;
                MateriaActual.HSSemanales =Convert.ToInt32( txtHssemanales.Text);
                MateriaActual.HSTotales =Convert.ToInt32( txtHstotales.Text);
                                       
                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            MateriaActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            MateriaActual.State = BusinessEntity.States.Modified;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            MateriaActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            MateriaActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                }
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            new MateriaLogic().Save(MateriaActual);
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

            //Validar el interior de los campos 

       /*     if (txtClave.Text != txtConfirmarClave.Text)
            {
                Notificar("La clave ingresada no coincide con la clave de confirmación. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }
            else if (txtClave.Text.Length < 8)
            {
                Notificar("La clave ingresada debe ser al menos de 8 carateres de longitud.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }

            if (Business.Logic.Validar.EsMailValido(txtEmail.Text.Trim()))
            {
                Notificar("El email ingresado no es válido. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }
                */
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

        private void MateriaDesktop_Load(object sender, EventArgs e)
        {
            
        }
    }
}
