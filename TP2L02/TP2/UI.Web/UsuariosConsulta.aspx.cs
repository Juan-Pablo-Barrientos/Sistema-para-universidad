using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class UsuariosConsulta : System.Web.UI.Page
    {
        #region Propiedades
        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new UsuarioLogic { };
                }
                return _logic;
            }
        }
        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }
        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }


        private Usuario Entity
        {
            get;
            set;

        }

        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }

        }
        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }



        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                this.EnableForm(false);
            }
        }
        private void EnableForm(bool check)
        {
            this.Label223.Visible = check;
            this.label2222.Visible = check;
            this.Label23233.Visible = check;
            this.Label23234.Visible = check;
            this.habilitadoCheck.Visible = check;
            this.Label4.Visible = check;
            this.Label5.Visible = check;
            this.Label6.Visible = check;
            this.Label8.Visible = check;
            this.Label7.Visible = check;
            this.Label9.Visible = check;
            this.Label10.Visible = check;
        }

        private void LoadForm(int id)
        {
            this.idLabel.Text = this.Entity.ID.ToString();
            this.nombreLabel.Text = this.Entity.Nombre;
            this.apellidoLabel.Text = this.Entity.Apellido;
            this.emailLabel.Text = this.Entity.EMail;
            this.habilitadoCheck.Checked = this.Entity.Habilitado;
            this.nombreUsuarioLabel.Text = this.Entity.NombreUsuario;
            this.tipoUsrLabel.Text = this.Entity.TiposUsuario.ToString();
            this.legajoLabel.Text = this.Entity.legajo;
            this.fechaNacLabel.Text = this.Entity.fecha_nac.ToString().Truncate(10);
            this.telefonoLabel.Text = this.Entity.telefono;
            this.direccionLabel.Text = this.Entity.direccion;
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            UsuarioLogic ul = new UsuarioLogic();
            this.Entity = ul.getOneNombre(nombreUsuarioTextBox.Text);

            if (this.Entity.NombreUsuario != null)
            {
                this.LoadForm(this.Entity.ID);
                this.EnableForm(true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Esta especialidad no puede ser eliminada", "alert('Este usuario no existe')", true);
            }
        }
    }
}