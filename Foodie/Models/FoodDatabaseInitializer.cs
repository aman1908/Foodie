using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Foodie.Models
{
    public class FoodDatabaseInitializer : DropCreateDatabaseIfModelChanges<FoodContext>
    {

        protected override void Seed(FoodContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetFoods().ForEach(f => context.Foods.Add(f));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "North Indian"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Fast Food"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Street Food"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Pizza"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Biryani"
                },
            };

            return categories;
        }

        private static List<Food> GetFoods()
        {
            var foods = new List<Food> {
                new Food
                {
                    FoodID = 1,
                    FoodName = "Awadhi Biryani",
                    Description = "Lucknawi or Awadhi Biryani is a feast in itself.The royal dish is best server hot with a simple+" +
                                   "raita (curd)",
                    ImagePath="north-indian-foods-1.jpg",
                    UnitPrice = 200,
                    CategoryID = 1
               },
                new Food
                {
                    FoodID = 2,
                    FoodName = "Litti Choka",
                    Description = "Litti is served with choka and chutney.The stuffing made of sattu, chillies and achari masala is+" +
                                  "put inside balls, made using wheat flour dough and sealed.",
                    ImagePath="north-indian-foods-5.jpg",
                    UnitPrice = 100,
                    CategoryID = 1
               },
                new Food
                {
                    FoodID = 3,
                    FoodName = "Baigan Bharta",
                    Description = "The simple dish from North India can be relished with a helping of rice or roti and is a favorite+" +
                                  "especialy during the chilly winters.",
                    ImagePath="north-indian-foods-6.jpg",
                    UnitPrice = 150,
                    CategoryID = 1
                },
                new Food
                {
                    FoodID = 4,
                    FoodName = "Tandoori Chicken/Tikka Masala",
                    Description = "Tandoori chicken which is a roasted chicken that is marinated in curd and basted with a melange of spices",
                    ImagePath="north-indian-foods-8.jpg",
                    UnitPrice = 240,
                    CategoryID = 1
                },
                new Food
                {
                    FoodID = 5,
                    FoodName = "Rogan Josh/Laal Maans",
                    Description = "Another option for the spice lovers is the Rajasthani Laal Maans.Mutton laced with flavors"+
                                   "of hot spices is cooked with a generous helping of curd to balance sharpness of chilies",
                    ImagePath="north-indian-foods-13.1.jpg",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Food
                {
                    FoodID = 6,
                    FoodName = "Chick-fil-A Chicken Sandwich",
                    Description = "Chick-fil-A may be politically polarizing, but people tend to have a unified stance on their+" +
                                  "original Chicken Sandwich",
                    ImagePath="chick-fil-a-fried-chicken-sandwich.jpg",
                    UnitPrice = 150,
                    CategoryID = 2
                },
                new Food
                {
                    FoodID = 7,
                    FoodName = "KFC Original Chicken",
                    Description = "This fun glider is made from real balsa wood. Some assembly required.",
                    ImagePath="kfc-original-chicken.jpg",
                    UnitPrice = 300,
                    CategoryID = 2
                },
                new Food
                {
                    FoodID = 8,
                    FoodName = "Five Guys Cheeseburger",
                    Description = "This paper plane is like no other paper plane. Some folding required.",
                    ImagePath="five-guys-burger-fries-drink-flickr.jpg",
                    UnitPrice = 200,
                    CategoryID = 2
                },
                new Food
                {
                    FoodID = 9,
                    FoodName = "McDonald's Happy Meal",
                    Description = "Rubber band powered plane features two wheels.",
                    ImagePath="mcdonalds-happy-meal.jpg",
                    UnitPrice = 150,
                    CategoryID = 2
                },
                new Food
                {
                    FoodID = 10,
                    FoodName = "McDonald's Egg McMuffin",
                    Description = "Baco,egg and cheese on muffin.The most iconic fasr-food breakfast option.",
                    ImagePath="mcdonalds-Egg-McMuffin-1.jpg",
                    UnitPrice = 120,
                    CategoryID = 2
                },
                new Food
                {
                    FoodID = 11,
                    FoodName = "Aloo Tikki",
                    Description = "Assorted with cutd,red and green chutney,namkeen and pomegranate seeds, aloo tikki is a must+" +
                                  "try. The explosion of flavours is a treat to your taste buds.",
                    ImagePath="2.jpg",
                    UnitPrice = 50,
                    CategoryID = 3
                },
                new Food
                {
                    FoodID = 12,
                    FoodName = "Vada Pav",
                    Description = "Vada placed between buns with spicy powder and chutney is the secret of the amazing taste",
                    ImagePath="3.jpg",
                    UnitPrice = 40,
                    CategoryID = 3
                },
  
                new Food
                {
                    FoodID = 13,
                    FoodName = "Dahi Puri",
                    Description = "The semi puffed pooris with the sweetness of curd and tangy chutney is the perfectway to+" +
                                    "treat yourself.",
                    ImagePath="4.jpg",
                    UnitPrice = 95.00,
                    CategoryID = 3
                },
                new Food
                {
                    FoodID = 14,
                    FoodName = "Pav Bhaji",
                    Description = "A mixture of veggies with a few drops of lime to go with the pav dipped in butter",
                    ImagePath="5.jpg",
                    UnitPrice = 100.00,
                    CategoryID = 3
                },
                new Food
                {
                    FoodID = 15,
                    FoodName = "Margherita Pizza",
                    Description = "This pizza has thin crust,fresh tomato sauce,fresh mozzarella cheese,and few leaves of basil",
                    ImagePath="margherita.jpeg",
                    UnitPrice = 180.00,
                    CategoryID = 4
                },
                new Food
                {
                    FoodID = 16,
                    FoodName = "Pepperoni Pizza",
                    Description = "Single layer of pepperoni on top of the sauce before adding cheese and another layer of pepperoni+" +
                                   "on top.",
                    ImagePath="pepperoni.jpeg",
                    UnitPrice = 200.00,
                    CategoryID = 4
                },
                new Food
                {
                    FoodID = 17,
                    FoodName = "BBQ Chicken Pizza",
                    Description = "Made with BBQ sauce,chicken,cliantro,red onions and fontina cheese",
                    ImagePath="bbqChicken.jpeg",
                    UnitPrice = 250.00,
                    CategoryID = 4
                },
                new Food
                {
                    FoodID = 18,
                    FoodName = "Hyderabadi Biryani",
                    Description = "Hyderabadi Biryani involves cooking of basmatic rice and meat separately and then layering+" +
                                  "them together",
                    ImagePath="biryani-hyderabad.jpg",
                    UnitPrice = 300.00,
                    CategoryID = 5
                },
                new Food
                {
                    FoodID = 19,
                    FoodName = "Thalassery Biryani",
                    Description = "Make use of Khyma or Jeerakasala rice instead of basmati rice.Other ingredients used in this+" +
                                  "biryani include Malabar spices,meat,fried onions,fennel seeds,sauteed cashews and raisins",
                    ImagePath="thalassery-biryani.jpg",
                    UnitPrice = 400.00,
                    CategoryID = 5
                },
                new Food
                {
                    FoodID = 20,
                    FoodName = "Calcutta Biryani",
                    Description = "Cooked with light yellow rice,which is layered with yogurt-based meat,soft boiled eggs and potatoes",
                    ImagePath="kolkata-biryani.jpg",
                    UnitPrice = 280.00,
                    CategoryID = 5
                }
            };

            return foods;
        }
    }
}