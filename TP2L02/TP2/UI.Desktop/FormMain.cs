using Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Click(object sender, EventArgs e)
        {
           
        }


        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void FormMainLoad(object sender, EventArgs e)
        {
            

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
        }

        private void altaModulo_Click(object sender, EventArgs e)
        {
            ModuloDesktop formModulo = new ModuloDesktop(ApplicationForm.ModoForm.Alta);
            formModulo.ShowDialog();
        }

        private void listadoModuloBtn_Click(object sender, EventArgs e)
        {
            Modulos formModulos = new Modulos();
            formModulos.ShowDialog();
        }

        private void listadoPlanesBtn_Click(object sender, EventArgs e)
        {
            Planes formPlanes = new Planes();
            formPlanes.ShowDialog();
        }

        private void altaPlanesBtn_Click(object sender, EventArgs e)
        {
            //Modulos formModulos = new Modulos();
            //formModulos.ShowDialog();
        }
    }
}
