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
                cargarDiasCalendario();
                this.FormMode = FormModes.Baja;
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
            DateTime dt = this.Entity.fecha_nac;
            this.añoNacDdl.SelectedValue = dt.Year.ToString();
            this.mesNacDdl.SelectedValue = dt.Month.ToString();
            FillDays();
            this.diaNacDdl.SelectedValue = dt.Day.ToString();
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
            string fecha = String.Concat(this.diaNacDdl.SelectedValue, "/", this.mesNacDdl.SelectedValue, "/", this.añoNacDdl.SelectedValue);
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
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Usuario();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Alta:
                    this.Entity = new Usuario();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                default:
                    break;
            }
            this.formPanel.Visible = false;
        }
        private void EnableForm(bool check)
        {
            this.nombreTextBox.Enabled = check;
            this.apellidoTextBox.Enabled = check;
            this.emailTextBox.Enabled = check;
            this.nombreUsuarioTextBox.Enabled = check;
            this.claveTextBox.Visible = check;
            this.claveLabel.Visible = check;
            this.repetirClaveTextBox.Visible = check;
            this.repetirClaveLabel.Visible = check;
            this.tipoUsuarioDdl.Enabled = check;
            this.legajoTextBox.Enabled = check;
            this.diaNacDdl.Enabled = check;
            this.mesNacDdl.Enabled = check;
            this.añoNacDdl.Enabled = check;
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
            this.diaNacDdl.SelectedValue = "1";
            this.mesNacDdl.SelectedValue = "1";
            this.añoNacDdl.SelectedValue = "2000";
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
        private void cargarDiasCalendario()
        {
            if (Page.IsPostBack == false)
            {
                {
                    //Fill Years
                    for (int i = 1960; i <= 2020; i++)
                    {
                        añoNacDdl.Items.Add(i.ToString());
                    }
                    añoNacDdl.Items.FindByValue(System.DateTime.Now.Year.ToString()).Selected = true;  //set current year as selected

                    //Fill Months
                    for (int i = 1; i <= 12; i++)
                    {
                        mesNacDdl.Items.Add(i.ToString());
                    }
                    mesNacDdl.Items.FindByValue(System.DateTime.Now.Month.ToString()).Selected = true; // Set current month as selected

                    //Fill days
                    FillDays();
                }
            }

        }
        public void FillDays()
        {
            diaNacDdl.Items.Clear();
            //getting numbner of days in selected month & year
            int noofdays = DateTime.DaysInMonth(Convert.ToInt32(añoNacDdl.SelectedValue), Convert.ToInt32(mesNacDdl.SelectedValue));

            //Fill days
            for (int i = 1; i <= noofdays; i++)
            {
                diaNacDdl.Items.Add(i.ToString());
            }
            diaNacDdl.Items.FindByValue(System.DateTime.Now.Day.ToString()).Selected = true;// Set current date as selected
        }
        protected void añoNacDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDays();
        }
        protected void mesNacDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDays();
        }
    }
}