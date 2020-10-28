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
    public partial class AlumnosInscripciones : System.Web.UI.Page
    {
        #region Propiedades
        AlumInsLogic _logic;
        private AlumInsLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new AlumInsLogic { };
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

        private AlumnosIncripcion Entity
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
            LoadGrid();
            if (!IsPostBack)
            {
                List<Usuario> Usuarios = new UsuarioLogic().GetAll();
                List<Curso> Cursos = new CursosLogic().GetAll();
                LoadGrid();
                this.FormMode = FormModes.Baja;
                this.IDtxt.Enabled = false;        
                foreach (var u in Usuarios)
                {
                    if (u.TiposUsuario.ToString() == "Alumno")
                        Alumnoddl.Items.Add(u.NombreUsuario);
                }
                foreach (var c in Cursos)
                {
                    Cursoddl.Items.Add(c.Descripcion);
                }

            }
        }

        private void LoadGrid()
        {
            this.GridView1.DataSource = this.Logic.GetAll();
            this.GridView1.DataBind();
            List<AlumnosIncripcion> cur = new AlumInsLogic().GetAll();
            for (int i = 0; i < cur.Count; i++)
            {
                var mat = new UsuarioLogic().getOne(Convert.ToInt32(this.GridView1.Rows[i].Cells[1].Text));
                this.GridView1.Rows[i].Cells[5].Text = mat.NombreUsuario;
            }
            for (int i = 0; i < cur.Count; i++)
            {
                var com = new CursosLogic().getOne(Convert.ToInt32(this.GridView1.Rows[i].Cells[2].Text));
                this.GridView1.Rows[i].Cells[6].Text = com.Descripcion;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.GridView1.SelectedValue;
            if (this.FormMode == FormModes.Modificacion)
                if (this.IsEntitySelected)
                {
                    this.FormPanel.Visible = true;
                    this.FormMode = FormModes.Modificacion;
                    this.LoadForm(this.SelectedID);
                    this.EnableForm(true);
                }
            if (this.FormMode == FormModes.Baja)
            {
                if (this.IsEntitySelected)
                {

                    this.FormPanel.Visible = true;
                    this.FormMode = FormModes.Baja;
                    this.EnableForm(false);
                    this.LoadForm(this.SelectedID);
                }
            }
            if (this.FormMode == FormModes.Alta)
            {
                if (this.IsEntitySelected)
                {
                    this.FormPanel.Visible = true;
                    this.FormMode = FormModes.Modificacion;
                    this.LoadForm(this.SelectedID);
                    this.EnableForm(true);
                }
            }
        }

        private void LoadForm(int id)
        {
            List<Usuario> Usuarios = new UsuarioLogic().GetAll();
            List<Curso> Cursos = new CursosLogic().GetAll();
            this.Entity = this.Logic.getOne(id);
            this.IDtxt.Text = this.Entity.ID.ToString();
            this.Condicionddl.SelectedValue = this.Entity.Condicion.ToString();
            this.Notatxt.Text = this.Entity.Nota.ToString();

            foreach (var u in Usuarios.Where(u => u.ID == this.Entity.IDAlumno))
            {
                this.Alumnoddl.Text = u.NombreUsuario;
            }

            foreach (var c in Cursos.Where(c => c.ID == this.Entity.IDCurso))
            {
                this.Cursoddl.Text = c.Descripcion;
            }
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.FormPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
                this.EnableForm(true);
            }
        }
        private void LoadEntity(AlumnosIncripcion AlumnoInscripcion)
        {
         
            List<Usuario> Usuarios = new UsuarioLogic().GetAll();
            List<Curso> Cursos = new CursosLogic().GetAll();
            AlumnoInscripcion.Nota =Convert.ToInt32(this.Notatxt.Text);
            if (Condicionddl.Text == "Inscripto")
            AlumnoInscripcion.Condicion = AlumnosIncripcion.Cond.Inscripto;
            if (Condicionddl.Text == "Regular")
                AlumnoInscripcion.Condicion = AlumnosIncripcion.Cond.Regular;
            if (Condicionddl.Text == "Aprobado")
                AlumnoInscripcion.Condicion = AlumnosIncripcion.Cond.Aprobado;
            if (Condicionddl.Text == "Libre")
                AlumnoInscripcion.Condicion = AlumnosIncripcion.Cond.Libre;

            foreach (var p in Usuarios.Where(p => p.NombreUsuario == Alumnoddl.Text))
            {
                AlumnoInscripcion.IDAlumno = p.ID;
            }
            foreach (var p in Cursos.Where(p => p.Descripcion == Cursoddl.Text))
            {
                AlumnoInscripcion.IDCurso = p.ID;
            }


        }
        private void SaveEntity(AlumnosIncripcion AlumnoInscripcion)
        {
            this.Logic.Save(AlumnoInscripcion);
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
                    this.Entity = new AlumnosIncripcion();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    this.FormPanel.Visible = false;
                    break;
                case FormModes.Alta:
                    this.Entity = new AlumnosIncripcion();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                default:
                    break;
            }
            this.FormPanel.Visible = false;
        }
        private void EnableForm(bool check)
        {
            this.IDtxt.Enabled = check;
            this.Condicionddl.Enabled = check;
            this.Cursoddl.Enabled = check;
            this.Alumnoddl.Enabled = check;
            this.Notatxt.Enabled = check;
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {

                this.FormPanel.Visible = true;
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
            this.FormPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }
        private void ClearForm()
        {
            this.IDtxt.Text = string.Empty;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.LoadGrid();
            this.FormPanel.Visible = false;
        }
    }
}