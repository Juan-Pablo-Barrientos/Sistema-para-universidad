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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            this.dgvMaterias.AutoGenerateColumns = false;
        }

        private void MateriaForm_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Listar()
        {
            MateriaLogic ml = new MateriaLogic();
            this.dgvMaterias.DataSource = ml.GetAll();
            List<Materia> Ma = new MateriaLogic().GetAll();
            for (int i = 0; i < Ma.Count; i++)
            {
                var esp = new PlanLogic().getOne(Convert.ToInt32(this.dgvMaterias.Rows[i].Cells[4].Value));
                this.dgvMaterias.Rows[i].Cells[5].Value = esp.Descripcion;
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            new MateriaLogic().Delete(ID);
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            MateriaDesktop formMateria = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            formMateria.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
            MateriaDesktop formMateria = new MateriaDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formMateria.ShowDialog();
            this.Listar();
        }
    }
}