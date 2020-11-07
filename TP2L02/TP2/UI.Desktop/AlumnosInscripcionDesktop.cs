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
    public partial class AlumnosInscripcionDesktop : ApplicationForm
    {
        public AlumnosIncripcion AlumnosInscripcionActual;
        List<Curso> Cursos = new CursosLogic().GetAll();
        List<Usuario> Usuarios = new UsuarioLogic().GetAll();

        Usuario UsuarioActual = FormLogin.GetUsuarioLogueado();
        
        #region constructores
        public AlumnosInscripcionDesktop()
        {
            InitializeComponent();
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;                      
            foreach (var p in Usuarios)
            {
                if (p.TiposUsuario.ToString() == "Alumno")
                    cBAlumno.Items.Add(p.NombreUsuario);
            }
            foreach (var p in Cursos)
            {
                cBCurso.Items.Add(p.Descripcion);
            }

            if (UsuarioActual!=null && UsuarioActual.TiposUsuario.ToString() == "Alumno")
            {
                cBAlumno.Visible = false;
                cBCondicion.Visible = false;
                txtNota.Visible = false;
                labelAlumno.Visible = false;
                labelCondicion.Visible = false;
                labelNota.Visible = false;
            }
            else if (UsuarioActual != null && UsuarioActual.TiposUsuario.ToString() == "Docente")
            {
                cBAlumno.Enabled = false;
                cBCurso.Enabled = false;              
            }
        }

        public AlumnosInscripcionDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public AlumnosInscripcionDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            AlumnosInscripcionActual = new AlumInsLogic().getOne(ID);
            MapearDeDatos();
        }
        #endregion



        public override void MapearDeDatos()
        {
            this.txtInscripcion.Text = this.AlumnosInscripcionActual.ID.ToString();
            this.txtNota.Text = this.AlumnosInscripcionActual.Nota.ToString();
            this.cBCondicion.Text = this.AlumnosInscripcionActual.Condicion.ToString();                
            foreach (var p in Cursos.Where(p => p.ID == AlumnosInscripcionActual.IDCurso))
            {
                this.cBCurso.Text = p.Descripcion;
            }
            foreach (var p in Usuarios.Where(p => p.ID == AlumnosInscripcionActual.IDAlumno))
            {
                this.cBAlumno.Text = p.NombreUsuario;
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
                AlumnosInscripcionActual = new AlumnosIncripcion();
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                if (UsuarioActual != null && UsuarioActual.TiposUsuario.ToString() == "Alumno")
                {
                    AlumnosInscripcionActual.Condicion = AlumnosIncripcion.Cond.Inscripto;

                    foreach (var p in Cursos.Where(p => p.Descripcion == cBCurso.Text))
                    {
                        AlumnosInscripcionActual.IDCurso = p.ID;
                    }
                    AlumnosInscripcionActual.IDAlumno = UsuarioActual.ID;
                }

                else { 
                if (!String.IsNullOrEmpty(txtNota.Text))
                        AlumnosInscripcionActual.Nota = Convert.ToInt32(txtNota.Text);

                    if (cBCondicion.Text == "Inscripto")
                        AlumnosInscripcionActual.Condicion = AlumnosIncripcion.Cond.Inscripto;
                    if (cBCondicion.Text == "Regular")
                        AlumnosInscripcionActual.Condicion = AlumnosIncripcion.Cond.Regular;
                    if (cBCondicion.Text == "Aprobado")
                        AlumnosInscripcionActual.Condicion = AlumnosIncripcion.Cond.Aprobado;
                    if (cBCondicion.Text == "Libre")
                        AlumnosInscripcionActual.Condicion = AlumnosIncripcion.Cond.Libre;

                    foreach (var p in Cursos.Where(p => p.Descripcion == cBCurso.Text))
                    {
                        AlumnosInscripcionActual.IDCurso = p.ID;
                    }
                    foreach (var p in Usuarios.Where(p => p.NombreUsuario == cBAlumno.Text))
                    {
                        AlumnosInscripcionActual.IDAlumno = p.ID;
                    }
                }

                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            AlumnosInscripcionActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            AlumnosInscripcionActual.State = BusinessEntity.States.Modified;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            AlumnosInscripcionActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            AlumnosInscripcionActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                }
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            new AlumInsLogic().Save(AlumnosInscripcionActual);
        }
        public override bool Validar()
        {
            var validador = new Validador();
             
             if (UsuarioActual != null && UsuarioActual.TiposUsuario.ToString() == "Alumno")
             {
             if (!AlumInsLogic.isInscripcionValid(UsuarioActual.NombreUsuario, cBCurso.Text))
                   validador.AgregarError("Usted ya está inscripto en este curso");
             if (cBCurso.SelectedItem == null) validador.AgregarError("Elija un curso ");
             if (CursosLogic.IsCursoFull(cBCurso.Text))  validador.AgregarError("El curso esta lleno");
             }
             else if (UsuarioActual != null && UsuarioActual.TiposUsuario.ToString() == "Docente")
             {
            
             }
            else 
            {
            if (cBCurso.SelectedItem == null) validador.AgregarError("Elija un curso");
            if (cBCondicion.SelectedItem == null) validador.AgregarError("Elija una condicion");            
            if (cBAlumno.SelectedItem == null) validador.AgregarError("Elija un Alumno");
            if ((!AlumInsLogic.isInscripcionValid(cBAlumno.Text, cBCurso.Text)) & (Modo != ModoForm.Modificacion))
                    validador.AgregarError("El Alumno ya esta inscripto en ese curso");
            }           
            if (!validador.EsValido()) BusinessLogic.Notificar("AlumnosInscripcion", validador.Errores, MessageBoxButtons.OK, MessageBoxIcon.Error);//Si no es valido, mustra el error
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

        private void AlumnosInscripcionDesktop_Load(object sender, EventArgs e)
        {

        }

        private void cBCondicion_TextChanged(object sender, EventArgs e)
        {
            
           txtNota.Items.Clear();
           if(cBCondicion.Text == "Regular" || cBCondicion.Text == "Aprobado")
           {
                txtNota.Items.Add("6");
                txtNota.Items.Add("7");
                txtNota.Items.Add("8");
                txtNota.Items.Add("9");
                txtNota.Items.Add("10");
           }        
           if (cBCondicion.Text == "Libre")
           {
                txtNota.Items.Add("5");
                txtNota.Items.Add("4");
                txtNota.Items.Add("3");
                txtNota.Items.Add("2");
                txtNota.Items.Add("1");
                txtNota.Items.Add("0");
            }
           if (cBCondicion.Text == "Inscripto")
           {
           }
        }
    }
}
