using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class usrCtrlFecha : System.Web.UI.UserControl
    {
        public string getAnio()
        {
            return ddlAnio.SelectedValue;
        }
        public string getMes()
        {
            return ddlMes.SelectedValue;
        }
        public string getDia()
        {
            return ddlDia.SelectedValue;
        }
        public void setAnio(string a)
        {
            ddlAnio.SelectedValue= a;
        }
        public void setMes(string a)
        {
            ddlMes.SelectedValue = a;
        }
        public void setDia(string a)
        {
            ddlDia.SelectedValue = a;
        }
        public void setAnio(bool a)
        {
            ddlAnio.Enabled= a;
        }
        public void setMes(bool a)
        {
            ddlAnio.Enabled = a;
        }
        public void setDia(bool a)
        {
            ddlAnio.Enabled = a;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            FillDays();
        }
        public void cargarDiasCalendario()
        {
            if (Page.IsPostBack == false)
            {
                {
                    //Fill Years
                    for (int i = 1960; i <= 2020; i++)
                    {
                        ddlAnio.Items.Add(i.ToString());
                    }
                    ddlAnio.Items.FindByValue(System.DateTime.Now.Year.ToString()).Selected = true;  //set current year as selected

                    //Fill Months
                    for (int i = 1; i <= 12; i++)
                    {
                        ddlMes.Items.Add(i.ToString());
                    }
                    ddlMes.Items.FindByValue(System.DateTime.Now.Month.ToString()).Selected = true; // Set current month as selected

                    //Fill days
                    FillDays();
                }
            }

        }
        public void FillDays()
        {
            ddlDia.Items.Clear();
            //getting numbner of days in selected month & year
            int noofdays = DateTime.DaysInMonth(Convert.ToInt32(ddlAnio.SelectedValue), Convert.ToInt32(ddlMes.SelectedValue));

            //Fill days
            for (int i = 1; i <= noofdays; i++)
            {
                ddlDia.Items.Add(i.ToString());
            }
            ddlDia.Items.FindByValue(System.DateTime.Now.Day.ToString()).Selected = true;// Set current date as selected
        }
        protected void añoNacDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDays();
        }
        protected void mesNacDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDays();
        }
    }
}