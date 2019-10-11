using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Foodie.Models;

namespace Foodie
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
           
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var context = new FoodContext();
            var food = new Food();
            if (txtFoodName.Text.Trim().Length> 0 && txtDescription.Text.Trim().Length>0 && txtImagePath.Text.Trim().Length>0)
            {
                food.FoodName = txtFoodName.Text.Trim();
                food.Description = txtDescription.Text.Trim();
                food.ImagePath = txtImagePath.Text.Trim();
                food.UnitPrice = Convert.ToDouble(txtUnitPrice.Text.Trim());
                food.CategoryID = Convert.ToInt32(txtCategoryID.Text.Trim());
                context.Foods.Add(food);
                int result = context.SaveChanges();
                if (result > 0)
                {
                    reset();
                }
            }
            
        }
        private void reset()
        {
            txtFoodName.Text = " ";
            txtDescription.Text = " ";
            txtImagePath.Text = " ";
            txtUnitPrice.Text = " ";
            txtCategoryID.Text = " ";
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}