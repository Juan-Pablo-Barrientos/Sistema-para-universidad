using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class RecuperarContraseña2 : System.Web.UI.Page
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

        protected void nextBtn_Click(object sender, EventArgs e)
        {
            usuarioLogueado = new UsuarioLogic().getOneNombre(nombreUsuarioTextBox.Text);
            if (nombreUsuarioTextBox.Text == usuarioLogueado.NombreUsuario)
            {
                Session["user"] = usuarioLogueado.NombreUsuario;
                Response.Redirect("~/RecuperarContraseña.aspx");
            }
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Usuario no existe" + "');", true);
            }
        }

        protected void regresarBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}