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
    public partial class DocentesCursos : Form
    {
                            
        Usuario UsuarioActual = FormLogin.GetUsuarioLogueado();
        private static int _cursoElejido;
        public static int CursoElejido { get => _cursoElejido; set => _cursoElejido = value; }
        public static int GetCursoElejido()
        {
            return CursoElejido;
        }
        public DocentesCursos()
        {
            InitializeComponent();
            this.dgvDocCur.AutoGenerateColumns = false;
            if (UsuarioActual != null && UsuarioActual.TiposUsuario.ToString() == "Docente")
            {
                btnNuevo.Visible = false;
                btnEliminar.Visible = false;
                btnEditar.Text = "Ver alumnos que cursan";            
            }
        }

        void Listar()
        {
            List<DocenteCurso> Ma;
            if (UsuarioActual != null && UsuarioActual.TiposUsuario.ToString() == "Docente")
            {
                DocCurLogic ul = new DocCurLogic();
                this.dgvDocCur.DataSource = ul.GetMisCursos(UsuarioActual.ID);
                Ma = ul.GetMisCursos(UsuarioActual.ID);
            }
            else
            {                
                DocCurLogic ul = new DocCurLogic();
                this.dgvDocCur.DataSource = ul.GetAll();
                Ma = ul.GetAll();
            }

            for (int i = 0; i < Ma.Count; i++)
            {
                var esp = new UsuarioLogic().getOne(Convert.ToInt32(this.dgvDocCur.Rows[i].Cells[2].Value));
                this.dgvDocCur.Rows[i].Cells[4].Value = esp.NombreUsuario;
            }
            for (int i = 0; i < Ma.Count; i++)
            {
                var esp = new CursosLogic().getOne(Convert.ToInt32(this.dgvDocCur.Rows[i].Cells[1].Value));
                this.dgvDocCur.Rows[i].Cells[3].Value = esp.Descripcion;
            }
        }

        private void DocCur_Load(object sender, EventArgs e)
        {
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

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

            DocCurDesktop formAlumIns = new DocCurDesktop(ApplicationForm.ModoForm.Alta);
            formAlumIns.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (UsuarioActual != null && UsuarioActual.TiposUsuario.ToString() == "Docente")
            {
                CursoElejido =Convert.ToInt32(this.dgvDocCur.SelectedRows[0].Cells[1].Value );
                AlumnosInscripcion formAlumnosInscripcion = new AlumnosInscripcion();
                formAlumnosInscripcion.ShowDialog();
            }
            else 
            { 
            int ID = ((Business.Entities.DocenteCurso)this.dgvDocCur.SelectedRows[0].DataBoundItem).ID;
            DocCurDesktop formAlumIns = new DocCurDesktop(ID, DocCurDesktop.ModoForm.Modificacion);
            formAlumIns.ShowDialog();
            this.Listar();
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.DocenteCurso)this.dgvDocCur.SelectedRows[0].DataBoundItem).ID;
            new DocCurLogic().Delete(ID);
            this.Listar();
        }
    }
}
