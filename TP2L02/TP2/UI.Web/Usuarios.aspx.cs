using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;
namespace UI.Web
{
    public partial class Usuarios : System.Web.UI.Page
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
                LoadGrid();
                this.usrCtrlFecha1.cargarDiasCalendario();
                this.FormMode = FormModes.Modificacion;
            }
        }

        private void LoadGrid()
        {
            this.GridView1.DataSource = this.Logic.GetAll();
            this.GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.GridView1.SelectedValue;
            if (this.FormMode == FormModes.Modificacion)
                if (this.IsEntitySelected)
                {
                    this.formPanel.Visible = true;
                    this.FormMode = FormModes.Modificacion;
                    this.LoadForm(this.SelectedID);
                    this.EnableForm(true);
                }
            if (this.FormMode == FormModes.Baja)
            {
                if (this.IsEntitySelected)
                {

                    this.formPanel.Visible = true;
                    this.FormMode = FormModes.Baja;
                    this.EnableForm(false);
                    this.LoadForm(this.SelectedID);
                }
            }
            if (this.FormMode == FormModes.Alta)
            {
                if (this.IsEntitySelected)
                {
                    this.formPanel.Visible = true;
                    this.FormMode = FormModes.Modificacion;
                    this.LoadForm(this.SelectedID);
                    this.EnableForm(true);
                }
            }
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.getOne(id);
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.emailTextBox.Text = this.Entity.EMail;
            this.habilitadoCheckBox.Checked = this.Entity.Habilitado;
            this.nombreUsuarioTextBox.Text = this.Entity.NombreUsuario;
            this.tipoUsuarioDdl.SelectedValue = this.Entity.TiposUsuario.ToString();
            this.legajoTextBox.Text = this.Entity.legajo;
            this.claveTextBox.Text = this.Entity.Clave;
            this.repetirClaveTextBox.Text = this.Entity.Clave;
            DateTime dt = this.Entity.fecha_nac;
            this.usrCtrlFecha1.setAnio(dt.Year.ToString());
            this.usrCtrlFecha1.setMes(dt.Month.ToString());
            this.usrCtrlFecha1.FillDays();
            this.usrCtrlFecha1.setDia(dt.Day.ToString()); 
            this.telefonoTextBox.Text = this.Entity.telefono;
            this.direccionTextBox.Text = this.Entity.direccion;
            if (this.Entity.pregunta != "falta")
            {
                this.preguntaContraDdl.SelectedValue = this.Entity.pregunta;
                this.respuestaContraTextBox.Text = this.Entity.respuesta;
            }
        }
        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
                this.EnableForm(true);
            }
        }
        private void LoadEntity(Usuario usuario)
        {
            usuario.Nombre = this.nombreTextBox.Text;
            usuario.Apellido = this.apellidoTextBox.Text;
            usuario.EMail = this.emailTextBox.Text;
            usuario.NombreUsuario = this.nombreUsuarioTextBox.Text;
            usuario.Clave = this.claveTextBox.Text;
            usuario.Habilitado = this.habilitadoCheckBox.Checked;
            if (this.tipoUsuarioDdl.SelectedValue == "Alumno")
                usuario.TiposUsuario = Usuario.TipoUsuario.Alumno;
            if (this.tipoUsuarioDdl.SelectedValue == "Docente")
                usuario.TiposUsuario = Usuario.TipoUsuario.Docente;
            if (this.tipoUsuarioDdl.SelectedValue == "Admin")
                usuario.TiposUsuario = Usuario.TipoUsuario.Admin;
            usuario.legajo = this.legajoTextBox.Text;
            string fecha = String.Concat(this.usrCtrlFecha1.getDia(), "/", this.usrCtrlFecha1.getMes(), "/", this.usrCtrlFecha1.getAnio());
            DateTime dt = DateTime.Parse(fecha);
            usuario.fecha_nac = dt;
            usuario.telefono = this.telefonoTextBox.Text;
            usuario.direccion = this.direccionTextBox.Text;
            usuario.pregunta = this.preguntaContraDdl.SelectedValue;
            usuario.respuesta = this.respuestaContraTextBox.Text;
        }
        private void SaveEntity(Usuario usuario)
        {
            this.Logic.Save(usuario);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            
                switch (this.FormMode)
                {
                    case FormModes.Baja:
                        if (Business.Logic.PlanLogic.isDeleteValid(this.SelectedID))
                        {
                            this.Logic.BorrarInscripciones(this.SelectedID);
                            this.DeleteEntity(this.SelectedID);
                            this.LoadGrid();
                            this.formPanel.Visible = false;
                        }
                        else
                        {
                            this.DeleteEntity(this.SelectedID);
                        }
                        break;
                    case FormModes.Modificacion:
                    if (Page.IsValid)
                    {
                        this.Entity = new Usuario();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = BusinessEntity.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        this.formPanel.Visible = false;
                    }
                        break;
                    
                    case FormModes.Alta:
                    if (Page.IsValid)
                    {
                        this.Entity = new Usuario();
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        this.formPanel.Visible = false;
                    }
                        break;
                    
                    default:
                        break;
                }
            }
        
        private void EnableForm(bool check)
        {
            this.nombreTextBox.Enabled = check;
            this.apellidoTextBox.Enabled = check;
            this.emailTextBox.Enabled = check;
            this.habilitadoCheckBox.Enabled = check;
            this.nombreUsuarioTextBox.Enabled = check;
            this.claveTextBox.Enabled = check;
            this.claveLabel.Enabled = check;
            this.repetirClaveTextBox.Enabled = check;
            this.repetirClaveLabel.Enabled = check;
            this.tipoUsuarioDdl.Enabled = check;
            this.legajoTextBox.Enabled = check;
            this.usrCtrlFecha1.setAnio(check);
            this.usrCtrlFecha1.setDia(check);
            this.usrCtrlFecha1.setMes(check);
            this.telefonoTextBox.Enabled = check;
            this.direccionTextBox.Enabled = check;
            this.respuestaContraTextBox.Enabled = check;
            this.preguntaContraDdl.Enabled = check;
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {

                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }
        }
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }
        private void ClearForm()
        {
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.habilitadoCheckBox.Checked = false;
            this.nombreUsuarioTextBox.Text = string.Empty;
            this.tipoUsuarioDdl.SelectedValue = "Alumno";
            this.legajoTextBox.Text = string.Empty;
            this.claveTextBox.Text = string.Empty;
            this.repetirClaveTextBox.Text = string.Empty;
            this.usrCtrlFecha1.setDia("1");
            this.usrCtrlFecha1.setMes("1");
            this.usrCtrlFecha1.setAnio("2000");
            this.telefonoTextBox.Text = string.Empty;
            this.direccionTextBox.Text = string.Empty;
            this.respuestaContraTextBox.Text = string.Empty;
            this.preguntaContraDdl.SelectedValue = "Apodo de su infancia";
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.LoadGrid();
            this.formPanel.Visible = false;
        }
    }
}