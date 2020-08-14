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

namespace UI.Desktop
{
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
            this.dgvPlanes.AutoGenerateColumns = false;
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        void Listar()
        {
            PlanLogic ml = new PlanLogic();
            this.dgvPlanes.DataSource = ml.GetAll();

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //PlanDesktop formPlan = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            //formPlan.ShowDialog();
            //this.Listar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //int ID = ((Business.Entities.Plan)this.dgvPlan.SelectedRows[0].DataBoundItem).ID;
            //PlanDesktop formMateria = new PlanDesktop(ID, ApplicationForm.ModoForm.Alta);

            //if (formPlan.ShowDialog() == DialogResult.OK)
            //{
            //    new PlanLogic().Delete(ID);
            //}
            //this.Listar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            new PlanLogic().Delete(ID);
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
