namespace Foodie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        FoodID = c.Int(nullable: false, identity: true),
                        FoodName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false),
                        ImagePath = c.String(),
                        UnitPrice = c.Double(),
                        CategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.FoodID)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ContactNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        CartId = c.String(nullable: false, maxLength: 128),
                        ItemId = c.String(),
                        Quantity = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        FoodId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CartId)
                .ForeignKey("dbo.Foods", t => t.FoodId, cascadeDelete: true)
                .Index(t => t.FoodId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 50),
                        ConfirmPassword = c.String(),
                        FullName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartItems", "FoodId", "dbo.Foods");
            DropForeignKey("dbo.Foods", "CategoryID", "dbo.Categories");
            DropIndex("dbo.CartItems", new[] { "FoodId" });
            DropIndex("dbo.Foods", new[] { "CategoryID" });
            DropTable("dbo.Users");
            DropTable("dbo.CartItems");
            DropTable("dbo.Contacts");
            DropTable("dbo.Foods");
            DropTable("dbo.Categories");
        }
    }
}
