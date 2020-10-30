using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
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
            List<Plan> Pl = new PlanLogic().GetAll();
            for (int i = 0; i < Pl.Count; i++)
            {
                var esp = new EspecialidadesLogic().getOne(Convert.ToInt32(this.dgvPlanes.Rows[i].Cells[2].Value));
                this.dgvPlanes.Rows[i].Cells[3].Value = esp.Descripcion;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            PlanDesktop formPlan = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            formPlan.ShowDialog();
            this.Listar();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop formPlan = new PlanDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formPlan.ShowDialog();                                  
            this.Listar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {   
            if (PlanLogic.isDeleteValid(Convert.ToInt32(this.dgvPlanes.SelectedRows[0].Cells[0].Value))) 
            {             
            int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            new PlanLogic().Delete(ID);
            this.Listar();
            }
            else BusinessLogic.Notificar("Plan", "Este plan esta vinculado con una materia o una comision", MessageBoxButtons.OK, MessageBoxIcon.Error);
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