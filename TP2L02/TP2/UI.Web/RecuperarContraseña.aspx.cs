using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class RecuperarContraseña : System.Web.UI.Page
    {
        private Usuario Entity
        {
            get;
            set;

        }
        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new UsuarioLogic { };
                }
                return _logic;
            }
        }
        private static Usuario _usuario;

        public static Usuario usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public static Usuario GetUsuario()
        {
            return usuario;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Entity = new UsuarioLogic().getOneNombre(Session["user"].ToString());
            usuariolbl.Text = Session["user"].ToString();
            preguntalbl2.Text = this.Entity.pregunta;
        }

        protected void regresarBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void IngresarBtn_Click(object sender, EventArgs e)
        {
            if (this.Entity.respuesta == RespuestaTextBox.Text)
            {
                Preguntalbl.Visible = false;
                preguntalbl2.Visible = false;
                Respuestalbl.Visible = false;
                RespuestaTextBox.Visible = false;
                IngresarBtn.Visible = false;
                nuevaContraseñalbl.Visible = true;
                nuevaContraseñaTextBox.Visible = true;
                ingresarNuevaContraseñaBtn.Visible = true;
                confirmarContraseñalbl.Visible = true;
                confirmarContraseñaTextBox.Visible = true;
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Respuesta incorrecta" + "');", true);

            }
        }

        protected void ingresarNuevaContraseñaBtn_Click(object sender, EventArgs e)
        {
            if (nuevaContraseñaTextBox.Text == confirmarContraseñaTextBox.Text)
            {
                this.Entity = new UsuarioLogic().getOneNombre(Session["user"].ToString());
                this.Entity.Clave = nuevaContraseñaTextBox.Text;
                this.Entity.State = BusinessEntity.States.Modified;
                this.Logic.Save(this.Entity);
                Response.Redirect("~/login.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "contraseña no coincide" + "');", true);
            }
        }
    }
}