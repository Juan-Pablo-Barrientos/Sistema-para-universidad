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
    public partial class CursoDesktop : ApplicationForm
    {
        public Curso CursoActual;
        List<Comision> Comisiones = new ComisionLogic().GetAll();
        List<Materia> Materias = new MateriaLogic().GetAll();
        #region constructores
        public CursoDesktop()
        {
            InitializeComponent();
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // Mostrar listado de Comisiones.                 
            foreach (var c in Comisiones)
            {
                cBComision.Items.Add(c.Descripcion);
            }
            foreach (var c in Materias)
            {
                cBMateria.Items.Add(c.Descripcion);
            }
        }

        public CursoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public CursoDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            CursoActual = new CursosLogic().getOne(ID);
            MapearDeDatos();
        }
        #endregion



        public override void MapearDeDatos()
        {
            this.txtIDCurso.Text = this.CursoActual.ID.ToString();
            this.txtAnio.Text = this.CursoActual.AnioCalendario.ToString();
            this.txtCupo.Text = this.CursoActual.Cupo.ToString();
            this.txtDescripcion.Text = this.CursoActual.Descripcion;
            
            foreach (var p in Comisiones.Where(p => p.ID == CursoActual.IDComision))
            {
                this.cBComision.Text = p.Descripcion;
            }
            foreach (var p in Materias.Where(p => p.ID == CursoActual.IDMateria))
            {
                this.cBMateria.Text = p.Descripcion;
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
                CursoActual = new Curso();
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                CursoActual.Descripcion = txtDescripcion.Text;
                CursoActual.AnioCalendario = Convert.ToInt32(txtAnio.Text);
                CursoActual.Cupo = Convert.ToInt32(txtCupo.Text);
                foreach (var p in Materias.Where(p => p.Descripcion == cBMateria.Text))
                {
                    CursoActual.IDMateria = p.ID;
                }
                foreach (var p in Comisiones.Where(p => p.Descripcion == cBComision.Text))
                {
                    CursoActual.IDComision = p.ID;
                }

                switch (Modo)
                {
                    case ModoForm.Alta:
                        {
                            CursoActual.State = BusinessEntity.States.New;
                            break;
                        }
                    case ModoForm.Modificacion:
                        {
                            CursoActual.State = BusinessEntity.States.Modified;
                            break;
                        }
                    case ModoForm.Consulta:
                        {
                            CursoActual.State = BusinessEntity.States.Unmodified;
                            break;
                        }
                    case ModoForm.Baja:
                        {
                            CursoActual.State = BusinessEntity.States.Deleted;
                            break;
                        }
                }
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            new CursosLogic().Save(CursoActual);
        }
        public override bool Validar()
        {
            var validador = new Validador();
            List<string> Campos = (this.container.Controls.OfType<TextBox>().Where(txt => txt.ReadOnly == false).Select(txt => txt.Text)).ToList();
            if (!BusinessLogic.SonCamposValidos(Campos)) validador.AgregarError("No todos los campos estan completos");
            if (cBComision.SelectedItem == null) validador.AgregarError("Elija una comision");
            if (cBMateria.SelectedItem == null) validador.AgregarError("Elija una materia");
            if (!validador.EsValido()) BusinessLogic.Notificar("Curso", validador.Errores, MessageBoxButtons.OK, MessageBoxIcon.Error);//Si no es valido, mustra el error
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

        private void CursoDesktop_Load(object sender, EventArgs e)
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
