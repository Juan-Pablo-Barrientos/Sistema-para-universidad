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
    public partial class Modulos : Form
    {
        public Modulos()
        {
            InitializeComponent();
            this.dgvModulo.AutoGenerateColumns = false;
        }

        private void Modulos_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        void Listar()
        {
            ModuloLogic modl = new ModuloLogic();
            this.dgvModulo.DataSource = modl.GetAll();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ModuloDesktop formModulo = new ModuloDesktop(ApplicationForm.ModoForm.Alta);
            formModulo.ShowDialog();
            this.Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Modulo)this.dgvModulo.SelectedRows[0].DataBoundItem).ID;
            ModuloDesktop formModulo = new ModuloDesktop(ID, ApplicationForm.ModoForm.Alta);

            if (formModulo.ShowDialog() == DialogResult.OK)
            {
                new ModuloLogic().Delete(ID);
            }
            this.Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Modulo)this.dgvModulo.SelectedRows[0].DataBoundItem).ID;
            new ModuloLogic().Delete(ID);
            this.Listar();
        }
    }
}
