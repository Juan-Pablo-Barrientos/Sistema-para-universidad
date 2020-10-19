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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
            this.dvgCursos.AutoGenerateColumns = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Listar()
        {
            CursosLogic cl = new CursosLogic();
            this.dvgCursos.DataSource = cl.GetAll();
            List<Curso> Co = new CursosLogic().GetAll();
            for (int i = 0; i < Co.Count; i++)
            {
                var esp = new MateriaLogic().getOne(Convert.ToInt32(this.dvgCursos.Rows[i].Cells[1].Value));
                this.dvgCursos.Rows[i].Cells[3].Value = esp.Descripcion;
            }
            for (int i = 0; i < Co.Count; i++)
            {
                var esp = new ComisionLogic().getOne(Convert.ToInt32(this.dvgCursos.Rows[i].Cells[2].Value));
                this.dvgCursos.Rows[i].Cells[4].Value = esp.Descripcion;
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Curso)this.dvgCursos.SelectedRows[0].DataBoundItem).ID;
            new CursosLogic().Delete(ID);
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            CursoDesktop formComision = new CursoDesktop(ApplicationForm.ModoForm.Alta);
            formComision.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Curso)this.dvgCursos.SelectedRows[0].DataBoundItem).ID;
            CursoDesktop formComision = new CursoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formComision.ShowDialog();
            this.Listar();
        }

        private void Curso_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
