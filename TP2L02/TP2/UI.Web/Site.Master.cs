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
    public partial class Site : System.Web.UI.MasterPage
    {
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
        private Usuario Entity
        {
            get;
            set;

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            NombreUsr.Text = Session["user"].ToString();
            
            if (NombreUsr.Text != "SuperAdmin")
            {
                Entity = Logic.getOneNombre(Session["user"].ToString());
                TipoUsr.Text = this.Entity.TiposUsuario.ToString();
            }
            else
            {
                TipoUsr.Text = "SuperAdmin";
            }
        }
        protected void Menu1_MenuItemDataBound(object sender, MenuEventArgs e)
        {
            System.Web.UI.WebControls.Menu menu = (System.Web.UI.WebControls.Menu)sender;
            SiteMapNode mapNode = (SiteMapNode)e.Item.DataItem;
            

            System.Web.UI.WebControls.MenuItem itemToRemove = menu.FindItem(mapNode.Title);
            if (NombreUsr.Text != "SuperAdmin")
            {
                if (this.Entity.TiposUsuario.ToString() == "Alumno")
                {
                    if (mapNode.Title == "Usuarios")
                    {
                        System.Web.UI.WebControls.MenuItem parent = e.Item.Parent;
                        if (parent != null)
                        {
                            parent.ChildItems.Remove(e.Item);
                        }
                    }
                    if (mapNode.Title == "Especialidades")
                    {
                        System.Web.UI.WebControls.MenuItem parent = e.Item.Parent;
                        if (parent != null)
                        {
                            parent.ChildItems.Remove(e.Item);
                        }
                    }
                    if (mapNode.Title == "Planes")
                    {
                        System.Web.UI.WebControls.MenuItem parent = e.Item.Parent;
                        if (parent != null)
                        {
                            parent.ChildItems.Remove(e.Item);
                        }
                    }
                }
            }
        }
    }
}