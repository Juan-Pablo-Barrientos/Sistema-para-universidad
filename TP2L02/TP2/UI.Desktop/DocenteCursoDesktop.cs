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
using Util.entities;

namespace UI.Desktop
{
    public partial class DocCurDesktop : ApplicationForm
    {
        public DocenteCurso DocCurActual;
        List<Usuario> Usuarios = new UsuarioLogic().GetAll();
        List<Curso> Cursos = new CursosLogic().GetAll();

        #region constructores
        public DocCurDesktop()
        {
            InitializeComponent();
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            foreach (var u in Usuarios)
            {
                if (u.TiposUsuario.ToString() == "Docente")
                    cBDocente.Items.Add(u.NombreUsuario);
            }
            foreach (var c in Cursos)
            {
                cBCurso.Items.Add(c.Descripcion);
            }

        }

        public DocCurDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public DocCurDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            DocCurActual = new DocCurLogic().getOne(ID);
            MapearDeDatos();
        }
        #endregion



        public override void MapearDeDatos()
        {
            this.txtIdDocenteCurso.Text = this.DocCurActual.ID.ToString();
            this.cBCargo.Text = this.DocCurActual.Cargo.ToString();


            foreach (var u in Usuarios.Where(u => u.ID == DocCurActual.IDDocente))
            {
                this.cBDocente.Text = u.NombreUsuario;
            }

            foreach (var c in Cursos.Where(c => c.ID == DocCurActual.IDCurso))
            {
                this.cBCurso.Text = c.Descripcion;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
            }
            if (Modo == ModoForm.Baja)
            {
                this.btnAceptar.Text = "Eliminar";
            }
            if (Modo == ModoForm.Consulta)
            {
                this.btnAceptar.Text = "Aceptar";
            }

        }
        public override void MapearADatos()
        {

            if (Modo == ModoForm.Alta)
            {
                DocCurActual = new DocenteCurso();
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {

                if (cBCargo.Text == "Docente")
                    DocCurActual.Cargo = DocenteCurso.TiposCargos.Docente;
                if (cBCargo.Text == "Auxiliar")
                    DocCurActual.Cargo = DocenteCurso.TiposCargos.Auxiliar;
                if (cBCargo.Text == "Jefecatedra")
                    DocCurActual.Cargo = DocenteCurso.TiposCargos.Jefecatedra;

                foreach (var p in Usuarios.Where(p => p.NombreUsuario == cBDocente.Text))
                {
                    DocCurActual.IDDocente = p.ID;
                }
                foreach (var p in Cursos.Where(p => p.Descripcion == cBCurso.Text))
                {
                    DocCurActual.IDCurso = p.ID;
                }

                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            DocCurActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            DocCurActual.State = BusinessEntity.States.Modified;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            DocCurActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            DocCurActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                }
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            new DocCurLogic().Save(DocCurActual);
        }
        public override bool Validar()
        {        
            var validador = new Validador();           
            if (!DocCurLogic.isInscripcionValid(cBDocente.Text,cBCurso.Text))
                validador.AgregarError("El docente ya esta inscripto en ese curso");
            if (cBCargo.SelectedItem == null) validador.AgregarError("Elija un cargo");
            if (cBDocente.SelectedItem == null) validador.AgregarError("Elija un Docente");
            if (cBCurso.SelectedItem == null) validador.AgregarError("Elija un curso");
            if (!validador.EsValido()) BusinessLogic.Notificar("DocenteCurso", validador.Errores, MessageBoxButtons.OK, MessageBoxIcon.Error);//Si no es valido, mustra el error
            return validador.EsValido();
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();

                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DocCurDesktop_Load(object sender, EventArgs e)
        {

        }

        //Este metodo esta linkeado con el evento KeyPress, no permite que se ingrese otro caracter que no sea numerico
        //Lo TextBox para la hora lo usan.
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
        }
    }
}
