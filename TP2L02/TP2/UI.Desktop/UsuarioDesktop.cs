using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;


namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public Usuario UsuarioActual;

        #region constructores
        public UsuarioDesktop()
        {
            InitializeComponent();
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
      
        public UsuarioDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            UsuarioActual = new UsuarioLogic().getOne(ID);
            MapearDeDatos();

        }
        #endregion

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtEmail.Text = this.UsuarioActual.EMail;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;

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
                UsuarioActual = new Usuario();
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                UsuarioActual.Nombre = txtNombre.Text;
                UsuarioActual.Apellido = txtApellido.Text;
                UsuarioActual.EMail = txtEmail.Text;
                UsuarioActual.NombreUsuario = txtUsuario.Text;
                UsuarioActual.Clave = txtClave.Text;           
                UsuarioActual.Habilitado = chkHabilitado.Checked;

                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            UsuarioActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            UsuarioActual.State = BusinessEntity.States.Modified;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            UsuarioActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            UsuarioActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                }
            }
        }
        public override void GuardarCambios()
        {           
            new UsuarioLogic().Save(UsuarioActual);
        }
        public override bool Validar()
        {
            //Para validar se usa UsuarioActual y se lo envia a ValidarUsuario. ValidarUsuario devuelve validador, que indentificara los errores de haberlos
            MapearADatos();
            var validador = Business.Logic.ValidarUsuario.Validar(UsuarioActual,txtConfirmarClave.Text);  
            if(!validador.EsValido()) Notificar(validador.Errores, MessageBoxButtons.OK, MessageBoxIcon.Error);//Si no es valido, mustra el error
            return validador.EsValido();         
        }

        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {

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
    }
}
