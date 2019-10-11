using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Foodie.Models;

namespace Foodie
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var userName = txtUserName.Text.Trim();
            var password = txtpwd.Text.Trim();
            var context = new FoodContext();
            var myUser = context.Users.FirstOrDefault(u => u.UserName == userName && u.Password==password);
            ViewState["UserName"] = userName;
            if (myUser != null)
            {
                txtUserName.Text =" ";
                txtpwd.Text = " ";
            }
            else if (userName == "Admin" && password == "Admin@123")
            {
                Response.Redirect("AdminPage.aspx");
            }
            else
            {
                loggedUser.Text = "Invalid username/password";
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}