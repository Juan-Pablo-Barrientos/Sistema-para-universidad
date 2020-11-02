using Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class FormMain : Form
    {
        public object EspecialidadMenu { get; private set; }

        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMainLoad(object sender, EventArgs e)
        {
            
        }

        private void FormMain_Click(object sender, EventArgs e)
        {
           
        }


        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();        
        }

        
        private void materialistadomenu_Click(object sender, EventArgs e)
        {
            Materias formMateria = new Materias();
            formMateria.ShowDialog();
        }

        private void materiaAltaMenu_Click(object sender, EventArgs e)
        {
            MateriaDesktop formMateria = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            formMateria.ShowDialog();
        }

        private void usuarioListadoMenu_Click(object sender, EventArgs e)
        {
            Usuarios formUsuario = new Usuarios();
            formUsuario.ShowDialog();
        }

        private void usuariosAltaMenu_Click(object sender, EventArgs e)
        {
            UsuarioDesktop formUsuario = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
            formUsuario.ShowDialog();
        }

        private void especialidadaltaMenuStrip_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop formEspecializacion = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            formEspecializacion.ShowDialog();
            
        }

        private void especialidadlistadoMenuStrip_Click(object sender, EventArgs e)
        {
            Especialidades formEspecializaciones = new Especialidades();
            formEspecializaciones.ShowDialog();
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            
        }
        private void FormMain_Shown(object sender, EventArgs e)
        {
            FormLogin appLogin = new FormLogin();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
            else
            {               
               Usuario UsuarioLogeado = FormLogin.GetUsuarioLogueado(); // Obtiene el usuario logeado de FormLogin
               if (UsuarioLogeado != null) 
                { 
                    txtUsuarioLogeado.Text = UsuarioLogeado.NombreUsuario;

                    switch (UsuarioLogeado.TiposUsuario.ToString())
                    {
                        case "Docente":
                            MateriasMenu.Visible = false;
                            PlanesMenu.Visible = false;
                            ComisionMenu.Visible = false;
                            UsuariosMenu.Visible = false;
                            EspecialidadesMenu.Visible = false;
                            ModulosMenu.Visible = false;
                            MisCursosAlumnoMenu.Visible = false;
                            InscribirseMenu.Visible = false;
                            InscribirUsuarioMenu.Visible = false;
                            CursosAltastrip.Visible = false;
                            break;

                        case "Alumno":
                            MateriasMenu.Visible = false;
                            PlanesMenu.Visible = false;
                            ComisionMenu.Visible = false;
                            UsuariosMenu.Visible = false;
                            EspecialidadesMenu.Visible = false;
                            ModulosMenu.Visible = false;
                            MisCursosDocenteMenu.Visible = false;
                            InscribirUsuarioMenu.Visible = false;
                            CursosAltastrip.Visible = false;

                            break;

                        case "Admin":
                            MisCursosAlumnoMenu.Visible = false;
                            MisCursosDocenteMenu.Visible = false;
                            InscribirseMenu.Visible = false;

                            break;

                    }
                }  
               else
                    txtUsuarioLogeado.Text = "SuperAdmin";
                              
            }
        }

        private void altaModulo_Click(object sender, EventArgs e)
        {
            ModuloDesktop formModulo = new ModuloDesktop(ApplicationForm.ModoForm.Alta);
            formModulo.ShowDialog();
        }

        private void listadoModulo_Click(object sender, EventArgs e)
        {
            Modulos formModulos = new Modulos();
            formModulos.ShowDialog();
        }

        private void listadoPlanes_Click(object sender, EventArgs e)
        {
            Planes formPlanes = new Planes();
            formPlanes.ShowDialog();
        }

        private void altaPlanes_Click(object sender, EventArgs e)
        {
            PlanDesktop formPlan = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            formPlan.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comisiones formComisiones = new Comisiones();
            formComisiones.ShowDialog();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComisionDesktop formComision = new ComisionDesktop(ApplicationForm.ModoForm.Alta);
            formComision.ShowDialog();

        }

        private void MisCursosAlumnoMenu_Click(object sender, EventArgs e)
        {
            AlumnosInscripcion formAlumnosInscripcion = new AlumnosInscripcion();
            formAlumnosInscripcion.ShowDialog();
        }

        private void InscribirseMenu_Click(object sender, EventArgs e)
        {
            AlumnosInscripcionDesktop formAlumnoInscrpcion = new AlumnosInscripcionDesktop(ApplicationForm.ModoForm.Alta);
            formAlumnoInscrpcion.ShowDialog();
        }

        private void MisCursosDocenteMenu_Click(object sender, EventArgs e)
        {
            DocentesCursos DocentesCursos= new DocentesCursos();
            DocentesCursos.ShowDialog();
        }

        private void altaDocenteCurso_Click(object sender, EventArgs e)
        {
            DocCurDesktop formDocCur = new DocCurDesktop(ApplicationForm.ModoForm.Alta);
            formDocCur.ShowDialog();
        }

        private void listadoDocenteCurso_Click(object sender, EventArgs e)
        {
            DocentesCursos DocentesCursos = new DocentesCursos();
            DocentesCursos.ShowDialog();
        }

        private void altaAlumnoInscripcion_Click(object sender, EventArgs e)
        {
            AlumnosInscripcionDesktop formAlumnoInscrpcion = new AlumnosInscripcionDesktop(ApplicationForm.ModoForm.Alta);
            formAlumnoInscrpcion.ShowDialog();

        }

        private void listadoAlumnoInscripcion_Click(object sender, EventArgs e)
        {
            AlumnosInscripcion formAlumnosInscripcion = new AlumnosInscripcion();
            formAlumnosInscripcion.ShowDialog();
        }

        private void CursosAltastrip_Click(object sender, EventArgs e)
        {
            CursoDesktop formCurso = new CursoDesktop(ApplicationForm.ModoForm.Alta);
            formCurso.ShowDialog();
        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursos formCursos = new Cursos();
            formCursos.ShowDialog();
        }
    }
}
