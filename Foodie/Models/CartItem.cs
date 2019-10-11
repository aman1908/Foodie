using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Foodie.Models
{
    public class CartItem
    {
        public string ItemId { get; set; }
        [Key]
        public string CartId { get; set; }

        public int Quantity { get; set; }

        public DateTime CreatedDate { get; set; }

        public int FoodId { get; set; }

        public virtual Food Food { get; set; }

    }
}