using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

namespace UI.Web
{
    public partial class DocentesCursos : System.Web.UI.Page
    {
        #region Propiedades
        DocCurLogic _logic;
        Usuario UsuarioLogueado;
        private DocCurLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new DocCurLogic { };
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


        private DocenteCurso Entity
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

            UsuarioLogueado = new UsuarioLogic().getOneNombre(Session["user"].ToString());
            if (UsuarioLogueado.ID != 0 && UsuarioLogueado.TiposUsuario.ToString() == "Docente")
            {
                this.GridView1.Columns[6].HeaderText = "Ver Alumnos";
                this.editarLinkButton.Visible = false;
                this.eliminarLinkButton.Visible = false;
                this.nuevoLinkButton.Visible = false;
            }
            if (!IsPostBack)
            {
                List<Usuario> Usuarios = new UsuarioLogic().GetAll();
                List<Curso> Cursos = new CursosLogic().GetAll();
                LoadGrid();
                this.FormMode = FormModes.Baja;
                this.txtID.Enabled = false;

                foreach (var u in Usuarios)
                {
                    if (u.TiposUsuario.ToString() == "Docente")
                        ddlDocente.Items.Add(u.NombreUsuario);
                }
                foreach (var c in Cursos)
                {
                    ddlCurso.Items.Add(c.Descripcion);
                }

            }
        }

        private void LoadGrid()
        {
            List<DocenteCurso> cur;
            if (UsuarioLogueado.ID != 0 && UsuarioLogueado.TiposUsuario.ToString() == "Docente")
            {
                this.GridView1.DataSource = this.Logic.GetMisCursos(UsuarioLogueado.ID);
                cur = new DocCurLogic().GetMisCursos(UsuarioLogueado.ID);
            }
            else
            {
                this.GridView1.DataSource = this.Logic.GetAll();
                cur = new DocCurLogic().GetAll();
            }
            this.GridView1.DataBind();
            for (int i = 0; i < cur.Count; i++)
            {
                var mat = new UsuarioLogic().getOne(Convert.ToInt32(this.GridView1.Rows[i].Cells[2].Text));
                this.GridView1.Rows[i].Cells[5].Text = mat.NombreUsuario;
            }
            for (int i = 0; i < cur.Count; i++)
            {
                var com = new CursosLogic().getOne(Convert.ToInt32(this.GridView1.Rows[i].Cells[1].Text));
                this.GridView1.Rows[i].Cells[4].Text = com.Descripcion;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.GridView1.SelectedValue;
            if (UsuarioLogueado.ID != 0 && UsuarioLogueado.TiposUsuario.ToString() == "Docente")
            {
                var docCur = new DocCurLogic().getOne(this.SelectedID);
                Session["idcurso"] = docCur.IDCurso;
                Response.Redirect("~/AlumnosInscripciones.aspx");
            }
            else
            {

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
        }

        private void LoadForm(int id)
        {
            List<Usuario> Usuarios = new UsuarioLogic().GetAll();
            List<Curso> Cursos = new CursosLogic().GetAll();
            this.Entity = this.Logic.getOne(id);
            this.txtID.Text = this.Entity.ID.ToString();
            this.ddlCargo.SelectedValue = this.Entity.Cargo.ToString();

            foreach (var u in Usuarios.Where(u => u.ID == this.Entity.IDDocente))
            {
                this.ddlDocente.Text = u.NombreUsuario;
            }

            foreach (var c in Cursos.Where(c => c.ID == this.Entity.IDCurso))
            {
                this.ddlCurso.Text = c.Descripcion;
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
        private void LoadEntity(DocenteCurso DocenteCurso)
        {
            List<Usuario> Usuarios = new UsuarioLogic().GetAll();
            List<Curso> Cursos = new CursosLogic().GetAll();
            if (ddlCargo.Text == "Docente")
                DocenteCurso.Cargo = DocenteCurso.TiposCargos.Docente;
            if (ddlCargo.Text == "Auxiliar")
                DocenteCurso.Cargo = DocenteCurso.TiposCargos.Auxiliar;
            if (ddlCargo.Text == "Jefecatedra")
                DocenteCurso.Cargo = DocenteCurso.TiposCargos.Jefecatedra;

            foreach (var p in Usuarios.Where(p => p.NombreUsuario == ddlDocente.Text))
            {
                DocenteCurso.IDDocente = p.ID;
            }
            foreach (var p in Cursos.Where(p => p.Descripcion == ddlCurso.Text))
            {
                DocenteCurso.IDCurso = p.ID;
            }


        }
        private void SaveEntity(DocenteCurso DocenteCurso)
        {
            this.Logic.Save(DocenteCurso);
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
                    if (DocCurLogic.isInscripcionValid(ddlDocente.Text, ddlCurso.Text))
                    {
                        this.Entity = new DocenteCurso();
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = BusinessEntity.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                        this.formPanel.Visible = false;
                    }
                    else
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "No se pudo anotar", "alert('Este usuario ya está anotado')", true);
                    break;
                case FormModes.Alta:
                    if (DocCurLogic.isInscripcionValid(ddlDocente.Text, ddlCurso.Text))
                    {
                        this.Entity = new DocenteCurso();
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();
                    }
                    else
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "No se pudo anotar", "alert('Este usuario ya está anotado')", true);
                    break;

                default:
                    break;
            }
            this.formPanel.Visible = false;
        }
        private void EnableForm(bool check)
        {
            this.txtID.Enabled = check;
            this.ddlCargo.Enabled = check;
            this.ddlCurso.Enabled = check;
            this.ddlDocente.Enabled = check;
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
            this.txtID.Text = string.Empty;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.LoadGrid();
            this.formPanel.Visible = false;
        }
    }
}