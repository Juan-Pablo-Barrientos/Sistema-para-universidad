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
    public partial class AlumnosInscripcion : Form       
    {
        Usuario UsuarioActual = FormLogin.GetUsuarioLogueado();
        public AlumnosInscripcion()
        {
            InitializeComponent();
            this.dgvAlumIns.AutoGenerateColumns = false;
            if (UsuarioActual != null && UsuarioActual.TiposUsuario.ToString() == "Alumno")
            {
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
                btnNuevo.Visible = false;
                id_curso.Visible = false;
                id_alumno.Visible = false;
            }
            else if (UsuarioActual != null && UsuarioActual.TiposUsuario.ToString() == "Docente")
            {
                btnNuevo.Visible = false;
                btnEliminar.Visible = false;
                btnEditar.Text ="Revisar Nota/Condicion";
                id_curso.Visible = false;
                id_alumno.Visible = false;
            }
            else
            {

            }
        }

        void Listar()
        {
            List<AlumnosIncripcion> Ma;

            if (UsuarioActual != null && UsuarioActual.TiposUsuario.ToString() == "Alumno")
            {
                 AlumInsLogic ul = new AlumInsLogic();
                 this.dgvAlumIns.DataSource = ul.GetMisCursos(UsuarioActual.ID);
                 Ma = new AlumInsLogic().GetMisCursos(UsuarioActual.ID);
            }
            else if (UsuarioActual != null && UsuarioActual.TiposUsuario.ToString() == "Docente")
            {
                AlumInsLogic ul = new AlumInsLogic();
                this.dgvAlumIns.DataSource = ul.GetAlumnosPorCurso(DocentesCursos.GetCursoElejido());
                 Ma = new AlumInsLogic().GetAlumnosPorCurso(DocentesCursos.GetCursoElejido());
            }
            else 
            { 
            AlumInsLogic ul = new AlumInsLogic();
            this.dgvAlumIns.DataSource = ul.GetAll();
            Ma = new AlumInsLogic().GetAll();
            }
            
            for (int i = 0; i < Ma.Count; i++)
            {
                var esp = new UsuarioLogic().getOne(Convert.ToInt32(this.dgvAlumIns.Rows[i].Cells[1].Value));
                this.dgvAlumIns.Rows[i].Cells[3].Value = esp.NombreUsuario;
            }
            for (int i = 0; i < Ma.Count; i++)
            {
                var esp = new CursosLogic().getOne(Convert.ToInt32(this.dgvAlumIns.Rows[i].Cells[2].Value));
                this.dgvAlumIns.Rows[i].Cells[4].Value = esp.Descripcion;
            }
        }

        private void AlumIns_Load(object sender, EventArgs e)
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
            AlumnosInscripcionDesktop formAlumIns = new AlumnosInscripcionDesktop(ApplicationForm.ModoForm.Alta);
            formAlumIns.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.AlumnosIncripcion)this.dgvAlumIns.SelectedRows[0].DataBoundItem).ID;
            AlumnosInscripcionDesktop formAlumIns = new AlumnosInscripcionDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formAlumIns.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.AlumnosIncripcion)this.dgvAlumIns.SelectedRows[0].DataBoundItem).ID;
            new AlumInsLogic().Delete(ID);
            this.Listar();
        }
    }
}
