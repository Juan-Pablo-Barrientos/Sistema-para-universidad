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
    public partial class Materia : Form
    {
        public Materia()
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

        //NUEVO Y EDITAR PENDIENTE



    }
}
