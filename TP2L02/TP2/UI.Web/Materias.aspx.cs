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
    public partial class Materias : System.Web.UI.Page
    {
        #region Propiedades
        MateriaLogic _logic;
        private MateriaLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new MateriaLogic { };
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


        private Materia Entity
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
                List<Plan> planes = new PlanLogic().GetAll();
                LoadGrid();
                this.FormMode = FormModes.Baja;
                this.IdTextBox.Enabled = false;
                foreach (var p in planes)
                {
                    idPlanDdl.Items.Add(p.Descripcion);
                }

            }
        }

        private void LoadGrid()
        {
            this.GridView1.DataSource = this.Logic.GetAll();
            this.GridView1.DataBind();
            List<Materia> mat = new MateriaLogic().GetAll();
            for (int i = 0; i < mat.Count; i++)
            {
                var pl = new PlanLogic().getOne(Convert.ToInt32(this.GridView1.Rows[i].Cells[4].Text));
                this.GridView1.Rows[i].Cells[5].Text = pl.Descripcion;
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
            List<Plan> planes = new PlanLogic().GetAll();
            this.Entity = this.Logic.getOne(id);
            this.IdTextBox.Text = this.Entity.ID.ToString();
            this.DescripcionTextBox.Text = this.Entity.Descripcion;
            this.HSSemanalesTextBox.Text = this.Entity.HSSemanales.ToString();
            this.HSTotalesTextBox.Text = this.Entity.HSTotales.ToString();
            foreach (var p in planes.Where(p => p.ID == this.Entity.IDPlan))
            {
                this.idPlanDdl.Text = p.Descripcion;
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
        private void LoadEntity(Materia materia)
        {
            List<Plan> planes = new PlanLogic().GetAll();
            materia.Descripcion = this.DescripcionTextBox.Text;
            materia.HSSemanales = Convert.ToInt32(this.HSSemanalesTextBox.Text);
            materia.HSTotales = Convert.ToInt32(this.HSTotalesTextBox.Text);
            foreach (var p in planes.Where(p => p.Descripcion == idPlanDdl.Text))
            {
                materia.IDPlan = p.ID;
            }


        }
        private void SaveEntity(Materia materia)
        {
            this.Logic.Save(materia);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Baja:
                    if (Business.Logic.MateriaLogic.isDeleteValid(this.SelectedID))
                    {
                        this.DeleteEntity(this.SelectedID);
                        this.LoadGrid();
                        this.formPanel.Visible = false;
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Esta especialidad no puede ser eliminada", "alert('Esta materia no puede ser eliminada por que ya esta asignada a un curso')", true);
                    }
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Materia();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Alta:
                    this.Entity = new Materia();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    this.formPanel.Visible = false;
                    break;
                default:
                    break;
            }
        }
        private void EnableForm(bool check)
        {
            this.DescripcionTextBox.Enabled = check;
            this.idPlanDdl.Enabled = check;
            this.HSSemanalesTextBox.Enabled = check;
            this.HSTotalesTextBox.Enabled = check;
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
            this.HSSemanalesTextBox.Text = string.Empty;
            this.HSTotalesTextBox.Text = string.Empty;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.LoadGrid();
            this.formPanel.Visible = false;
        }
    }
}