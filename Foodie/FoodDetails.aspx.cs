using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Foodie.Models;
using System.Web.ModelBinding;

namespace Foodie
{
    public partial class FoodDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Food> GetFood([QueryString("foodID")] int? foodId)
        {
            var _db = new Foodie.Models.FoodContext();
            IQueryable<Food> query = _db.Foods;
            if (foodId.HasValue && foodId > 0)
            {
                query = query.Where(f => f.FoodID == foodId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}