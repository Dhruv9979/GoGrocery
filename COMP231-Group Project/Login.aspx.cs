using MongoDB.Driver;
using System;
using COMP231_Group_Project.App_Code;
using System.Web.Security;
using MongoDB.Driver.Builders;
using MongoDB.Bson;
using System.Linq;

namespace COMP231_Group_Project
{
    public partial class Login : System.Web.UI.Page
    {
        DAL getMongo = new DAL();
        MongoCollection<User> users = DAL.myDB.GetCollection<User>("users");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userType"] != null)
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void LoginUser(object sender, EventArgs e)
        {
            var query = Query.And(Query<User>.EQ(u => u.Username, txtUsername.Text), Query<User>.EQ(u => u.Password, txtPassword.Text));
            MongoCursor<User> cursor = users.Find(query);
            var list = cursor.ToList();
            if(list.Count != 0)
            {
                Session["userType"] = list[0].Type;
                FormsAuthentication.RedirectFromLoginPage(txtUsername.Text, false);
            }
            else
            {
                Response.Write("<script language = javascript> alert('Login Unsuccessful');</script >");
            }
            //foreach (User item in cursor.)
            //{
            //    if (txtUsername.Text == item.Username && txtPassword.Text == item.Password)
            //    {
                    
                   
            //    }
            //}
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }
    }
}