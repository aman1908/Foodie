using System;
using System.Linq;
using System.Web.UI;
using Foodie.Models;

namespace Foodie
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(ViewState["UserName"]))
            {
                lblLoggedUser.Text = ViewState["UserName"].ToString();
            }
           
        }

        public IQueryable<Category> GetCategories()
        {
            var _db = new Foodie.Models.FoodContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }
    }
}