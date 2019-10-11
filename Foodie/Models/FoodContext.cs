using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Foodie.Models
{
    public class FoodContext : DbContext
    {
        public FoodContext() : base("Foodie")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}