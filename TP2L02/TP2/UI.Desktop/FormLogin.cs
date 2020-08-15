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
        public Usuario usrActual;
        
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

            if (txtContra.Text == "" && txtNombre.Text == "") { this.DialogResult = DialogResult.OK; } //ADMIN
            else
            {
                usrActual = new UsuarioLogic().getOneNombre(txtNombre.Text);              
                if (String.IsNullOrEmpty(usrActual.NombreUsuario)) 
                BusinessLogic.Notificar("Error", "El usuario no existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else              
                if (usrActual.Clave != txtContra.Text)  
                 BusinessLogic.Notificar("Error", "La contraseña no es correcta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                if (!usrActual.Habilitado)
                BusinessLogic.Notificar("Error", "El usuario no esta habilitado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else this.DialogResult = DialogResult.OK;
             
            }
        }
    }
}
