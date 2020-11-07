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
    public partial class FormLogin : Form
    {
        private static Usuario _usuarioLogueado;
             
        public static Usuario usuarioLogueado
        {
            get { return _usuarioLogueado; }
            set { _usuarioLogueado = value; }
        }
       
        public static Usuario GetUsuarioLogueado()
        {
            return usuarioLogueado;
        }

        public FormLogin()
        {
            InitializeComponent();
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (txtContra.Text == "admin" && txtNombre.Text == "admin") { this.DialogResult = DialogResult.OK; usuarioLogueado = null; } //Super ADMIN//
            else
            {
                usuarioLogueado = new UsuarioLogic().getOneNombre(txtNombre.Text);              
                if (String.IsNullOrEmpty(usuarioLogueado.NombreUsuario)) 
                BusinessLogic.Notificar("Error", "No se pudo ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else              
                if (usuarioLogueado.Clave != txtContra.Text)  
                 BusinessLogic.Notificar("Error", "No se pudo ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                if (!usuarioLogueado.Habilitado)
                BusinessLogic.Notificar("Error", "No se pudo ingresar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else this.DialogResult = DialogResult.OK;                                           
            }
        }
    }
}
