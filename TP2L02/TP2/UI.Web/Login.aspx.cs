using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class Login : System.Web.UI.Page
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
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (contraseñaTextBox.Text == "" && contraseñaTextBox.Text == "") { Response.Redirect("~/Default.aspx"); } //Super ADMIN
            else
            {
                usuarioLogueado = new UsuarioLogic().getOneNombre(usuarioTextBox.Text);
                if (usuarioLogueado.Clave != contraseñaTextBox.Text)
                {
                    Page.Response.Write("Usuario y/o contraseña incorrectos");
                }
                if ((!usuarioLogueado.Habilitado) && (usuarioLogueado.Clave == contraseñaTextBox.Text))
                {
                    Page.Response.Write("Usuario no esta habilitado");
                }
                if ((usuarioLogueado.Habilitado) && (usuarioLogueado.Clave == contraseñaTextBox.Text))
                {
                    Response.Redirect("~/Default.aspx");
                }


            }
        }
    }
}