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
    public partial class ComisionDesktop : ApplicationForm
    {
        public Comision ComisionActual;
        List<Plan> Planes = new PlanLogic().GetAll();
        #region constructores
        public ComisionDesktop()
        {
            InitializeComponent();
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // Mostrar listado de Planes.                 
            foreach (var p in Planes)
            {
                cBIdPlan.Items.Add(p.Descripcion);
            }
        }

        public ComisionDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public ComisionDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
        //    ComisionActual = new ComisionLogic().getOne(ID);
            MapearDeDatos();
        }
        #endregion



        public override void MapearDeDatos()
        {
            this.txtIdComision.Text = this.ComisionActual.ID.ToString();
            this.txtDescripcion.Text = this.ComisionActual.Descripcion;
            this.txtAnio.Text = this.ComisionActual.AnioEspecialidad.ToString();          
            foreach (var p in Planes.Where(p => p.ID == ComisionActual.IDPlan))
            {
                this.cBIdPlan.Text = p.Descripcion;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
            }
            if (Modo == ModoForm.Baja)
            {
                this.btnAceptar.Text = "Eliminar";
            }
            if (Modo == ModoForm.Consulta)
            {
                this.btnAceptar.Text = "Aceptar";
            }

        }
        public override void MapearADatos()
        {

            if (Modo == ModoForm.Alta)
            {
                ComisionActual = new Comision();
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                ComisionActual.Descripcion = txtDescripcion.Text;
                ComisionActual.AnioEspecialidad = Convert.ToInt32(txtAnio.Text);               
                foreach (var p in Planes.Where(p => p.Descripcion == cBIdPlan.Text))
                {
                    ComisionActual.IDPlan = p.ID;
                }

                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            ComisionActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            ComisionActual.State = BusinessEntity.States.Modified;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            ComisionActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            ComisionActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                }
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
           // new ComisionLogic().Save(ComisionActual);
        }
        public override bool Validar()
        {
            var validador = new Validador();
            List<string> Campos = (this.container.Controls.OfType<TextBox>().Where(txt => txt.ReadOnly == false).Select(txt => txt.Text)).ToList();
            if (!BusinessLogic.SonCamposValidos(Campos)) validador.AgregarError("No todos los campos estan completos");
            if (cBIdPlan.SelectedItem == null) validador.AgregarError("Elija una especialidad");
            if (!validador.EsValido()) BusinessLogic.Notificar("Comision", validador.Errores, MessageBoxButtons.OK, MessageBoxIcon.Error);//Si no es valido, mustra el error
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

        private void ComisionDesktop_Load(object sender, EventArgs e)
        {

        }

        //Este metodo esta linkeado con el evento KeyPress, no permite que se ingrese otro caracter que no sea numerico
        //Lo TextBox para la hora lo usan.
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
        }
    }
}
