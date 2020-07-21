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
            usrActual = new UsuarioLogic().getOneNombre(txtNombre.Text);
            if (usrActual.Clave != txtContra.Text)
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
            else {
                this.DialogResult = DialogResult.OK;
            }






        }
    }
}
