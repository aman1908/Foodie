namespace Foodie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Foods", "CategoryID", c => c.Int());
            AlterColumn("dbo.CartItems", "FoodId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CartItems", "FoodId", c => c.Int(nullable: false));
            AlterColumn("dbo.Foods", "CategoryID", c => c.Int());
        }
    }
}
