using COMP231_Group_Project.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP231_Group_Project
{
    public partial class GoMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userType"] != null)
            {
                lnkLogin.Text = "Logout";
                if (!Session["userType"].Equals("admin"))
                {
                    lnkAdmin.Visible = false;
                }
                else
                {
                    lnkAdmin.Visible = true;
                }
            }
        }
        protected void lnkLogin_Click(object sender, EventArgs e)
        {
            if (!lnkLogin.Text.Equals("Logout"))
            {
                if (Session["userType"] != null)
                {
                    lnkLogin.Text = "Logout";
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                FormsAuthentication.SignOut();
                Session["userType"] = null;
                Session.Clear();
                Session.Abandon();
                Response.Redirect("Login.aspx");
            }
        }
    }
}