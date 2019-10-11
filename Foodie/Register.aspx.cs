using System;
using Foodie.Models;

namespace Foodie
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_click(object sender, EventArgs e)
        {
            var context = new FoodContext();
            User u = new User();
            u.UserName = UserName.Text;
            u.Password = Password.Text;
            u.ConfirmPassword = confirmPassword.Text;
            u.FullName = FullName.Text;
            context.Users.Add(u);
            int result = context.SaveChanges();
            if (result > 0)
            {
                UserName.Text = "";
                FullName.Text = "";
                insertedUser.Text="User"+u.FullName+"successfully inserted";
                Response.Redirect("login.aspx");
            }
            else
            {
                insertedUser.Text = "Try Again";
            }
        }
    }
}