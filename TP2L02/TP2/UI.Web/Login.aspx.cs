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

        protected void contraseniaRecup(object sender, EventArgs e)
        {
            usuarioLogueado = new UsuarioLogic().getOneNombre(usuarioTextBox.Text);
            if (usuarioTextBox.Text == usuarioLogueado.NombreUsuario)
            {
                Session["user"] = usuarioTextBox.Text;
                Response.Redirect("~/RecuperarContraseña.aspx");
            }
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Usuario no existe" + "');", true);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == "" && contraseñaTextBox.Text == "") 
            {
                Session["user"] = "SuperAdmin";
                Response.Redirect("~/Default.aspx");   
            } //Super ADMIN
            else
            {
                usuarioLogueado = new UsuarioLogic().getOneNombre(usuarioTextBox.Text);
                if (usuarioLogueado.Clave != contraseñaTextBox.Text)
                {
                    Page.Response.Write("Usuario y/o contraseña incorrectos");
                    contraseñaTextBox.Text = "";
                }
                if ((!usuarioLogueado.Habilitado) && (usuarioLogueado.Clave == contraseñaTextBox.Text))
                {
                    Page.Response.Write("Usuario no esta habilitado");
                    contraseñaTextBox.Text = "";
                }
                if ((usuarioLogueado.Habilitado) && (usuarioLogueado.Clave == contraseñaTextBox.Text))
                {
                    Session["user"] = usuarioTextBox.Text;
                    Response.Redirect("~/Default.aspx");
                }


            }
        }
    }
}