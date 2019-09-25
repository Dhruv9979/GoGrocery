using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using COMP231_Group_Project.App_Code;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading;

namespace COMP231_Group_Project
{
    public partial class Signup : System.Web.UI.Page
    {
        DAL getMongo = new DAL();
        MongoCollection<User> users = DAL.myDB.GetCollection<User>("users");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            if(!IsUserExists())
            {
                user.FullName = txtFullName.Text;
                user.Username = txtUserName.Text;
                user.Email = txtEmail.Text;
                user.Password = txtPassword.Text;
                user.Type = "customer";
                getMongo.InsertUser(user);
            }
        }

        private bool IsUserExists()
        {
            bool result = false;
            foreach (var item in users.FindAll())
            {
                if (item.Email == txtEmail.Text || item.Username == txtUserName.Text)
                {
                    Response.Write("<script> alert('This user already holds an account.') </script>");
                    //Thread.Sleep(5000);
                    //Response.Redirect("Signup.aspx");
                    result = true;
                }
            }
            return result;
        }
    }
}