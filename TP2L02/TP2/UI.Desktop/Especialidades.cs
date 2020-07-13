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
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
            this.dgvEspecialidades.AutoGenerateColumns = false;
        }
        void Listar()
        {
            EspecialidadesLogic el = new EspecialidadesLogic();
            this.dgvEspecialidades.DataSource = el.GetAll();
        }


        private void tsNuevo_Click(object sender, EventArgs e)
        {
            //EspecialidadDesktop formEspecialidades = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            //formEspecialidad.ShowDialog();
            //this.Listar();
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            /*int ID = ((Business.Entities.Especialidad)this.dgvEspecialidad.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Alta);

            if (formEspecialidad.ShowDialog() == DialogResult.OK)
            {
                new EspecialidadLogic().Delete(ID);
            }
            this.Listar();*/
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {

        }
        

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
