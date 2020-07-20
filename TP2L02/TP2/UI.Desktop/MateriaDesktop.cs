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
                MateriaActual.HSSemanales = Convert.ToInt32(txtHssemanales.Text);
                MateriaActual.HSTotales = Convert.ToInt32(txtHstotales.Text);
                
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
            new MateriaLogic().Save(MateriaActual);
        }
        public override bool Validar()
        {
            // Los dos IF convierten el .Text en 0 si esta vacio. .Text devolvera un string vacio si es null, pero Conver.ToInt32(String.empty) dara error.
            if (txtHssemanales.Text == "") txtHssemanales.Text ="0";
            if (txtHstotales.Text == "") txtHstotales.Text ="0";
            MapearADatos();
            var validador = Business.Logic.ValidarMateria.Validar(MateriaActual);
            if (!validador.EsValido()) Notificar(validador.Errores, MessageBoxButtons.OK, MessageBoxIcon.Error);//Si no es valido, mustra el error
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

        private void MateriaDesktop_Load(object sender, EventArgs e)
        {
            
        }

        //Este metodo esta linkeado con el evento KeyPress, no permite que se ingrese otro caracter que no sea numerico
        //Lo TextBox para la hora lo usan
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') )       
            {
                e.Handled = true;
            }          
        }     
    }
}
