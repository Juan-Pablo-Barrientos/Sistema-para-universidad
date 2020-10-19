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
    public partial class Cursos : System.Web.UI.Page
    {
        #region Propiedades
        CursosLogic _logic;
        private CursosLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new CursosLogic { };
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


        private Curso Entity
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
                List<Materia> materias = new MateriaLogic().GetAll();
                List<Comision> comisiones = new ComisionLogic().GetAll();
                LoadGrid();
                this.FormMode = FormModes.Baja;
                this.IdTextBox.Enabled = false;

                foreach (var m in materias)
                {
                    idMateriaDdl.Items.Add(m.Descripcion);
                }
                foreach (var c in comisiones)
                {
                    idComisionDdl.Items.Add(c.Descripcion);
                }
                int anio2 = (DateTime.Now).Year;

                for (int anio = 1900; anio <= anio2; anio++)
                {
                    AnioDdl.Items.Add(anio.ToString());
                }
            }
        }

        private void LoadGrid()
        {
            this.GridView1.DataSource = this.Logic.GetAll();
            this.GridView1.DataBind();
            List<Curso> cur = new CursosLogic().GetAll();
            for (int i = 0; i < cur.Count; i++)
            {
                var mat = new MateriaLogic().getOne(Convert.ToInt32(this.GridView1.Rows[i].Cells[6].Text));
                this.GridView1.Rows[i].Cells[7].Text = mat.Descripcion;
            }
            for (int i = 0; i < cur.Count; i++)
            {
                var com = new ComisionLogic().getOne(Convert.ToInt32(this.GridView1.Rows[i].Cells[4].Text));
                this.GridView1.Rows[i].Cells[5].Text = com.Descripcion;
            }
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
            List<Materia> mat = new MateriaLogic().GetAll();
            List<Comision> com = new ComisionLogic().GetAll();
            this.Entity = this.Logic.getOne(id);
            this.IdTextBox.Text = this.Entity.ID.ToString();
            this.DescripcionTextBox.Text = this.Entity.Descripcion;
            this.CupoTextBox.Text = this.Entity.Cupo.ToString();
            this.AnioDdl.SelectedValue = this.Entity.AnioCalendario.ToString();
            foreach (var c in com.Where(c => c.ID == this.Entity.IDComision))
            {
                this.idComisionDdl.Text = c.Descripcion;
            }
            foreach (var m in mat.Where(m => m.ID == this.Entity.IDMateria))
            {
                this.idMateriaDdl.Text = m.Descripcion;
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
        private void LoadEntity(Curso curso)
        {
            List<Comision> com = new ComisionLogic().GetAll();
            List<Materia> mat = new MateriaLogic().GetAll();
            curso.Descripcion = this.DescripcionTextBox.Text;
            curso.AnioCalendario = Convert.ToInt32(this.AnioDdl.SelectedValue);
            curso.Cupo = Convert.ToInt32(this.CupoTextBox.Text);
            foreach (var m in mat.Where(m => m.Descripcion == idMateriaDdl.Text))
            {
                curso.IDMateria = m.ID;
            }
            foreach (var c in com.Where(c => c.Descripcion == idComisionDdl.Text))
            {
                curso.IDComision = c.ID;
            }


        }
        private void SaveEntity(Curso curso)
        {
            this.Logic.Save(curso);
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
                    this.Entity = new Curso();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Alta:
                    this.Entity = new Curso();
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
            this.CupoTextBox.Enabled = check;
            this.DescripcionTextBox.Enabled = check;
            this.idComisionDdl.Enabled = check;
            this.idMateriaDdl.Enabled = check;
            this.AnioDdl.Enabled = check;
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
            this.IdTextBox.Text = string.Empty;
            this.DescripcionTextBox.Text = string.Empty;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.LoadGrid();
            this.formPanel.Visible = false;
        }
    }
}