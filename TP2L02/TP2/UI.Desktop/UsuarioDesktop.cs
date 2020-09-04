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
using Util.entities;
using System.Globalization;

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

            //---- Bloque en testeo
            this.txtLegajo.Text = this.UsuarioActual.legajo;
            this.txtDireccion.Text = this.UsuarioActual.direccion;         
            DateTime dt = DateTime.ParseExact(this.UsuarioActual.fecha_nac, "yyyy/mm/dd", CultureInfo.InvariantCulture);
            this.txtFec.Text = dt.ToString();
            this.txtTelefono.Text = this.UsuarioActual.telefono;
            this.cBTipoDeUsuario.Text = this.UsuarioActual.TiposUsuario.ToString();

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
                UsuarioActual.fecha_nac = txtFec.Text;
                UsuarioActual.direccion = txtDireccion.Text;
                UsuarioActual.telefono = txtTelefono.Text;
                UsuarioActual.legajo = txtLegajo.Text;                
                if (cBTipoDeUsuario.Text == "Alumno" )
                UsuarioActual.TiposUsuario = Usuario.TipoUsuario.Alumno;
                if (cBTipoDeUsuario.Text == "Docente")
                UsuarioActual.TiposUsuario = Usuario.TipoUsuario.Docente;

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
            MapearADatos();  
            new UsuarioLogic().Save(UsuarioActual);
        }
        public override bool Validar()
        {          
            var validador = new Validador();
            List<string> Campos = (this.container.Controls.OfType<TextBox>().Where(txt => txt.ReadOnly == false).Select(txt => txt.Text)).ToList();
            if (!BusinessLogic.EsMailValido(txtEmail.Text)) validador.AgregarError("Email invalido");
            if (!Business.Logic.UsuarioLogic.EsContraseñaValida(txtClave.Text, txtConfirmarClave.Text)) validador.AgregarError("Contraseña invalida");
            if (!BusinessLogic.SonCamposValidos(Campos)) validador.AgregarError("No todos los campos estan completos");           
            if(!validador.EsValido()) BusinessLogic.Notificar("Usuario",validador.Errores, MessageBoxButtons.OK, MessageBoxIcon.Error);//Si no es valido, mustra el erro
            return validador.EsValido();       
        }

        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
          //  if (Validar())
            {
                GuardarCambios();               
                Close();
            }        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labellegajo_Click(object sender, EventArgs e)
        {

        }
    }
}
